/*
    This file is part of Faculty Feud.

    Faculty Feud is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    Faculty Feud is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with Faculty Feud.  If not, see <http://www.gnu.org/licenses/>.
 */ 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace FacultyFeudHost
{
    public partial class questions : Form
    {
        public static questions qForm = new questions();
        public questions()
        {
            InitializeComponent();
        }
        Question actQ;
        private void numA_ValueChanged(object sender, EventArgs e)
        {
                foreach (Control o in groupBox1.Controls)
                {
                    int t;
                    try
                    {
                        int.TryParse(o.Tag.ToString(), out t);
                    }
                    catch (Exception ex)
                    {
                        continue;
                    }
                    if (t == 0)
                        continue;
                    if (t < 100)
                    {
                        if (t > numA.Value)
                            o.Visible = false;
                        else
                            o.Visible = true;
                    }
                    else if (t > 100)
                    {
                        if (t - 100 > numA.Value)
                            o.Visible = false;
                        else
                            o.Visible = true;
                    }
                }
        }

        private void q_TextChanged(object sender, EventArgs e)
        {
            bool a = true;
            foreach (Control o in groupBox1.Controls)
            {
                int t;
                try
                {
                    int.TryParse(o.Tag.ToString(), out t);
                }
                catch (Exception ex)
                {
                    continue;
                }
                if (t <= numA.Value && t < 100)
                {
                    if (o.Text.Length <= 0)
                    {
                        a = false;
                        break;
                    }
                }
            }
            if (a && q.Text.Length > 0)
                updateB.Enabled = true;
            else
                updateB.Enabled = false;
        }

        private void a_TextChanged(object sender, EventArgs e)
        {
            bool a = true;
            foreach (Control o in groupBox1.Controls)
            {
                int t;
                try
                {
                    int.TryParse(o.Tag.ToString(), out t);
                }
                catch (Exception ex)
                {
                    continue;
                }
                if (t <= numA.Value && t < 100)
                {
                    if (o.Text.Length <= 0)
                    {
                        a = false;
                        break;
                    }
                }
            }
            if (a && q.Text.Length > 0)
                updateB.Enabled = true;
            else
                updateB.Enabled = false;
        }

        private void updateB_Click(object sender, EventArgs e)
        {
            Question newQ;
            newQ.q = q.Text;
            newQ.n = (int)numA.Value;
            newQ.a = new List<string>();
            newQ.p = new List<int>();
            for (int i = 0; i < newQ.n; i++)
            {
                newQ.a.Add("");
                newQ.p.Add(0);
            }
            foreach (Control o in groupBox1.Controls)
            {
                int t;
                int.TryParse(o.Tag.ToString(), out t);
                string ad = "";
                try
                {
                    ad = o.AccessibleDescription;
                }
                catch (Exception ex) { }
                if ((t - 1 >= 0 && t <= newQ.n) && ad == "a")
                {
                    //answers
                    newQ.a[t - 1] = o.Text;
                }
                else if ((t - 1 >= 0 && t <= newQ.n) && ad == "p")
                {
                    //answers
                    newQ.p[t - 1] = (int)((NumericUpDown)o).Value;
                }
            }

            if (updateB.Text == "Add")
            {    
                if (QuestionManager.questions == null)
                    QuestionManager.questions = new List<Question>();

                QuestionManager.questions.Add(newQ);
                qList.Items.Add(newQ.q);
                qList.SelectedIndex = qList.Items.Count - 1;
            }
            else if (updateB.Text == "Update")
            {
                QuestionManager.questions[qList.SelectedIndex] = newQ;
                qList.Items[qList.SelectedIndex] = newQ.q;
            }
            playManage.mgr.playManage_Shown(new Object(), new EventArgs());
        }

        private void qList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (qList.SelectedIndex < 0)
            {
                updateB.Text = "Add";
                return;
            }

            updateB.Text = "Update";
            Question cq = QuestionManager.questions[qList.SelectedIndex];
            q.Text = cq.q;
            numA.Value = cq.n;

            foreach (Control o in groupBox1.Controls)
            {
                int t;
                int.TryParse(o.Tag.ToString(), out t);
                string ad = "";
                try
                {
                    ad = o.AccessibleDescription;
                }
                catch (Exception ex) { }
                if (t - 1 >= 0 && t <= cq.n && ad == "a")
                {
                    o.Text = cq.a[t - 1];
                }
                else if (t - 1 >= 0 && t <= cq.n && ad == "p")
                {
                    ((NumericUpDown)o).Value = cq.p[t - 1];
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog();
            s.Filter = "XML File (*.xml)|*.xml";
            if (s.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;
            XmlWriterSettings sets = new XmlWriterSettings();
            sets.Indent = true;
            sets.NewLineHandling = new NewLineHandling();
            using (XmlWriter writer = XmlWriter.Create(s.FileName, sets))
            {
                writer.WriteStartDocument();
                    writer.WriteStartElement("Questions");
                        foreach (Question q in QuestionManager.questions)
                        {
                            writer.WriteStartElement("Entry");
                                writer.WriteElementString("Question", q.q);
                                writer.WriteElementString("NumAnswers", q.n.ToString());
                                    writer.WriteStartElement("Answers");
                                        int j=0;
                                        foreach (string a in q.a)
                                        {
                                            writer.WriteStartElement("Answer");
                                                writer.WriteAttributeString("Points", q.p[j].ToString());
                                                writer.WriteAttributeString("Value", a);
                                                writer.WriteEndElement();
                                            j++;


                                            //writer.WriteElementString("Answer", a);
                                        }
                                    writer.WriteEndElement();
                            writer.WriteEndElement();
                        }
                    writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "XML Save (*.xml)|*.xml";
            if (o.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;
            bool num = false;
            bool question = false;

            if (QuestionManager.questions != null)
                QuestionManager.questions.Clear();
            using (XmlTextReader reader = new XmlTextReader(o.FileName))
            {
                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element:
                            if (reader.Name == "Questions")
                                QuestionManager.questions = new List<Question>();
                            else if (reader.Name == "Entry")
                            {
                                Question newQ = new Question();
                                newQ.a = new List<string>();
                                newQ.p = new List<int>();
                                QuestionManager.questions.Add(newQ);
                                this.actQ = newQ;
                            }
                            else if (reader.Name == "Answer")
                            {
                                int pt = 0;
                                int.TryParse(reader.GetAttribute("Points"), out pt);
                                string ans = reader.GetAttribute("Value");

                                QuestionManager.questions[QuestionManager.questions.Count - 1].a.Add(ans);
                                QuestionManager.questions[QuestionManager.questions.Count-1].p.Add(pt);
                            }
                            else if (reader.Name == "Question")
                                question = true;
                            else if (reader.Name == "NumAnswers")
                                num = true;
 
                            break;
                        case XmlNodeType.EndElement:
                            if (reader.Name == "Question")
                                question = false;
                            else if (reader.Name == "NumAnswers")
                                num = false;
                            break;
                        case XmlNodeType.Text:
                            /*if (answer)
                            {
                               // QuestionManager.questions[QuestionManager.questions.Count-1].a.Add(reader.Value);
                                //QuestionManager.questions[QuestionManager.questions.Count-1].p.Add(0);
                            }
                            else*/ if (question)
                            {
                                Question q = QuestionManager.questions[QuestionManager.questions.Count - 1];
                                q.q = reader.Value;
                                QuestionManager.questions[QuestionManager.questions.Count - 1] = q;
                            }
                            else if (num)
                            {
                                Question q = QuestionManager.questions[QuestionManager.questions.Count - 1];
                                q.n = int.Parse(reader.Value);
                                QuestionManager.questions[QuestionManager.questions.Count - 1] = q;
                            }
                            break;
                    }
                }
            }
            qList.Items.Clear();
            foreach (Question q in QuestionManager.questions)
            {
                qList.Items.Add(q.q);
            }

            playManage.mgr.playManage_Shown(new Object(), new EventArgs());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            q.Text = "";
            a1.Text = "";
            a2.Text = "";
            a3.Text = "";
            a4.Text = "";
            a5.Text = "";
            a6.Text = "";
            a7.Text = "";
            a8.Text = "";
            updateB.Text = "Add";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (QuestionManager.questions.Count > 0)
            {
                QuestionManager.questions.RemoveAt(qList.SelectedIndex);
                qList.Items.Remove(qList.SelectedItem);
                q.Text = "";
                a1.Text = "";
                a2.Text = "";
                a3.Text = "";
                a4.Text = "";
                a5.Text = "";
                a6.Text = "";
                a7.Text = "";
                a8.Text = "";
                updateB.Text = "Add";
            }
        }

        private void questions_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
