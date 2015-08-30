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
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows;
using System.Media;

namespace FacultyFeudHost
{
    public partial class playManage : Form
    {
        public static playManage mgr = new playManage();
        static ClientManager cMgr;
        ImageBrush itemBg, itemAnsBg;
        SoundPlayer cor;
        SoundPlayer inv;
        int numInv;
        int leftScore = 0;
        int rightScore = 0;
        bool leftInControl = false;
        bool rightInControl = false;

        public playManage()
        {
            InitializeComponent();
        }

        private void playManage_Load(object sender, EventArgs e)
        {
            itemBg = new ImageBrush();
            itemAnsBg = new ImageBrush();
            cMgr = new ClientManager(this);

            cor = new SoundPlayer(FacultyFeudHost.Properties.Resources.ff_clang);
            inv = new SoundPlayer(FacultyFeudHost.Properties.Resources.ff_strike);

            itemAnsBg.ImageSource = new BitmapImage(new Uri("pack://application:,,,/AudienceWPF;Component/Resources/item ans bg.png"));
            itemBg.ImageSource = new BitmapImage(new Uri("pack://application:,,,/AudienceWPF;Component/Resources/item bg.png"));
            numInv = 0;
        }

        private void playManage_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        public void playManage_Shown(object sender, EventArgs e)
        {
            qList.Items.Clear();
            if (QuestionManager.questions == null)
                return;

            foreach (Question q in QuestionManager.questions)
            {
                qList.Items.Add(q.q);
            }

            qList.SelectedIndex = 0;
        }

        private void qList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Question q = QuestionManager.questions[qList.SelectedIndex];
            foreach (Control c in groupBox1.Controls)
            {
                int t;
                int.TryParse(c.Tag.ToString(), out t);
                if (t > 0 && t <= q.n)
                {
                    c.Text = q.a[t-1];
                    c.Enabled = true;
                }
                else if (t > q.n)
                {
                    c.Text = (t).ToString();
                    c.Enabled = false;
                }
            }
            audience.audWnd.setNumAnswers(q.n);
        }

        public delegate void ShowWindowDelegate(bool lft);
        public void showWindow(bool lft)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new ShowWindowDelegate(showWindow), new object[] {lft});
                return;
            }
            if (lft)
            {
                audience.audWnd.lftBox.Visibility = System.Windows.Visibility.Visible;
                audience.audWnd.rtBox.Visibility = System.Windows.Visibility.Hidden;
            }
            else
            {
                audience.audWnd.rtBox.Visibility = System.Windows.Visibility.Visible;
                audience.audWnd.lftBox.Visibility = System.Windows.Visibility.Hidden;
            }
        }

        public void clearWindow()
        {
            audience.audWnd.panel1.Fill = itemBg;
            audience.audWnd.a_1.Visibility = Visibility.Hidden;
            audience.audWnd.b_1.Visibility = Visibility.Visible;
            audience.audWnd.p1.Visibility = Visibility.Hidden;

            audience.audWnd.rectangle1.Fill = itemBg;
            audience.audWnd.a_2.Visibility = Visibility.Hidden;
            audience.audWnd.b_2.Visibility = Visibility.Visible;
            audience.audWnd.p2.Visibility = Visibility.Hidden;

            audience.audWnd.rectangle2.Fill = itemBg;
            audience.audWnd.a_3.Visibility = Visibility.Hidden;
            audience.audWnd.b_3.Visibility = Visibility.Visible;
            audience.audWnd.p3.Visibility = Visibility.Hidden;

            audience.audWnd.rectangle3.Fill = itemBg;
            audience.audWnd.a_4.Visibility = Visibility.Hidden;
            audience.audWnd.b_4.Visibility = Visibility.Visible;
            audience.audWnd.p4.Visibility = Visibility.Hidden;

            audience.audWnd.rectangle4.Fill = itemBg;
            audience.audWnd.a_5.Visibility = Visibility.Hidden;
            audience.audWnd.b_5.Visibility = Visibility.Visible;
            audience.audWnd.p5.Visibility = Visibility.Hidden;

            audience.audWnd.rectangle5.Fill = itemBg;
            audience.audWnd.a_6.Visibility = Visibility.Hidden;
            audience.audWnd.b_6.Visibility = Visibility.Visible;
            audience.audWnd.p6.Visibility = Visibility.Hidden;

            audience.audWnd.rectangle6.Fill = itemBg;
            audience.audWnd.a_7.Visibility = Visibility.Hidden;
            audience.audWnd.b_7.Visibility = Visibility.Visible;
            audience.audWnd.p7.Visibility = Visibility.Hidden;

            audience.audWnd.rectangle7.Fill = itemBg;
            audience.audWnd.a_8.Visibility = Visibility.Hidden;
            audience.audWnd.b_8.Visibility = Visibility.Visible;
            audience.audWnd.p8.Visibility = Visibility.Hidden;

            rtBox.BackColor = System.Drawing.Color.White;
            lftBox.BackColor = System.Drawing.Color.White;

            audience.audWnd.lftBox.Visibility = System.Windows.Visibility.Hidden;
            audience.audWnd.rtBox.Visibility = System.Windows.Visibility.Hidden;
        }
        private void btn_Click(object sender, EventArgs e)
        {
            if (sender == back)
            {
                if (qList.SelectedIndex > 0)
                {
                    a_1.Checked = false;
                    a_2.Checked = false;
                    a_3.Checked = false;
                    a_4.Checked = false;
                    a_5.Checked = false;
                    a_6.Checked = false;
                    a_7.Checked = false;
                    a_8.Checked = false;
                    numInv = 0;
                    a_x.Text = "X: 0";
                    clearWindow();
                    qList.SelectedIndex--;
                    cMgr.clearDial();
                    cbShowQuestion.Checked = false;
                }
            }
            else if (sender == next)
            {
                if (qList.SelectedIndex + 1 < qList.Items.Count)
                {
                    a_1.Checked = false;
                    a_2.Checked = false;
                    a_3.Checked = false;
                    a_4.Checked = false;
                    a_5.Checked = false;
                    a_6.Checked = false;
                    a_7.Checked = false;
                    a_8.Checked = false;
                    numInv = 0;
                    a_x.Text = "X: 0";
                    clearWindow();
                    qList.SelectedIndex++;
                    cMgr.clearDial();
                    cbShowQuestion.Checked = false;
                }
            }
            else if (sender == a_x)
            {
                timer1_Tick(new Object(), new EventArgs());
                numInv++;
                inv.Play();
                timer1.Start();
                switch (numInv)
                {
                    case 1:
                        audience.audWnd.rectangle8.Visibility = Visibility.Visible;
                        break;
                    case 2:
                        audience.audWnd.x_2_1.Visibility = Visibility.Visible;
                        audience.audWnd.x_2_2.Visibility = Visibility.Visible;
                        break;
                    case 3:
                        audience.audWnd.x_3_1.Visibility = Visibility.Visible;
                        audience.audWnd.x_3_2.Visibility = Visibility.Visible;
                        audience.audWnd.x_3_3.Visibility = Visibility.Visible;
                        break;
                }
                a_x.Text = "X: " + numInv.ToString();
                if (numInv == 3)
                    numInv = 0;
            }
            else if (sender == b_x_s)
            {
                timer1_Tick(new Object(), new EventArgs());
                inv.Play();
                timer1.Start();
                audience.audWnd.rectangle8.Visibility = Visibility.Visible;
            }
            else if (sender == button1)
            {
                cMgr.clearDial();
                rtBox.BackColor = System.Drawing.Color.White;
                lftBox.BackColor = System.Drawing.Color.White;

                audience.audWnd.lftBox.Visibility = System.Windows.Visibility.Hidden;
                audience.audWnd.rtBox.Visibility = System.Windows.Visibility.Hidden;
            }

            tLeftScore.Text = leftScore.ToString();
            tRightScore.Text = rightScore.ToString();

            audience.audWnd.leftScore.Content = leftScore.ToString();
            audience.audWnd.rightScore.Content = rightScore.ToString();

            audience.audWnd.Question.Content = QuestionManager.questions[qList.SelectedIndex].q;
        }

        private void a_CheckedChanged(object sender, EventArgs e)
        {
            if (leftInControl == false && rightInControl == false)
                return; //no team in control?
            
            string q;
            int qindex = 0;
            bool pointMade = false;
            if (sender == a_1)
            {
                if (a_1.Checked)
                {
                    qindex = 0;
                    q = QuestionManager.questions[qList.SelectedIndex].a[qindex];
                    audience.audWnd.panel1.Fill = itemAnsBg;
                    audience.audWnd.a_1.Content = q;
                    audience.audWnd.a_1.FontSize = calcFontSize(q, 294);
                    audience.audWnd.a_1.Visibility = Visibility.Visible;
                    audience.audWnd.b_1.Visibility = Visibility.Hidden;
                    audience.audWnd.p1.Content = QuestionManager.questions[qList.SelectedIndex].p[qindex].ToString();
                    audience.audWnd.p1.Visibility = Visibility.Visible;
                    pointMade = true;
                }
                else
                {
                    audience.audWnd.panel1.Fill = itemBg;
                    audience.audWnd.a_1.Visibility = Visibility.Hidden;
                    audience.audWnd.b_1.Visibility = Visibility.Visible;
                    audience.audWnd.p1.Visibility = Visibility.Hidden;
                }
            }
            else if (sender == a_2)
            {
                if (a_2.Checked)
                {
                    qindex = 1;
                    q = QuestionManager.questions[qList.SelectedIndex].a[qindex];
                    audience.audWnd.rectangle1.Fill = itemAnsBg;
                    audience.audWnd.a_2.Content = q;
                    audience.audWnd.a_2.FontSize = calcFontSize(q, 294);
                    audience.audWnd.a_2.Visibility = Visibility.Visible;
                    audience.audWnd.b_2.Visibility = Visibility.Hidden;
                    audience.audWnd.p2.Content = QuestionManager.questions[qList.SelectedIndex].p[qindex].ToString();
                    audience.audWnd.p2.Visibility = Visibility.Visible;
                    pointMade = true;
                }
                else
                {
                    audience.audWnd.rectangle1.Fill = itemBg;
                    audience.audWnd.a_2.Visibility = Visibility.Hidden;
                    audience.audWnd.b_2.Visibility = Visibility.Visible;
                    audience.audWnd.p2.Visibility = Visibility.Hidden;
                }
            }
            else if (sender == a_3)
            {
                if (a_3.Checked)
                {
                    qindex = 2;
                    q = QuestionManager.questions[qList.SelectedIndex].a[qindex];
                    audience.audWnd.rectangle2.Fill = itemAnsBg;
                    audience.audWnd.a_3.Content = q;
                    audience.audWnd.a_3.FontSize = calcFontSize(q, 294);
                    audience.audWnd.a_3.Visibility = Visibility.Visible;
                    audience.audWnd.b_3.Visibility = Visibility.Hidden;
                    audience.audWnd.p3.Content = QuestionManager.questions[qList.SelectedIndex].p[qindex].ToString();
                    audience.audWnd.p3.Visibility = Visibility.Visible;
                    pointMade = true;
                }
                else
                {
                    audience.audWnd.rectangle2.Fill = itemBg;
                    audience.audWnd.a_3.Visibility = Visibility.Hidden;
                    audience.audWnd.b_3.Visibility = Visibility.Visible;
                    audience.audWnd.p3.Visibility = Visibility.Hidden;
                }
            }
            else if (sender == a_4)
            {
                if (a_4.Checked)
                {
                    qindex = 3;
                    q = QuestionManager.questions[qList.SelectedIndex].a[qindex];
                    audience.audWnd.rectangle3.Fill = itemAnsBg;
                    audience.audWnd.a_4.Content = q;
                    audience.audWnd.a_4.FontSize = calcFontSize(q, 294);
                    audience.audWnd.a_4.Visibility = Visibility.Visible;
                    audience.audWnd.b_4.Visibility = Visibility.Hidden;
                    audience.audWnd.p4.Content = QuestionManager.questions[qList.SelectedIndex].p[qindex].ToString();
                    audience.audWnd.p4.Visibility = Visibility.Visible;
                    pointMade = true;
                }
                else
                {
                    audience.audWnd.rectangle3.Fill = itemBg;
                    audience.audWnd.a_4.Visibility = Visibility.Hidden;
                    audience.audWnd.b_4.Visibility = Visibility.Visible;
                    audience.audWnd.p4.Visibility = Visibility.Hidden;
                }
            }
            else if (sender == a_5)
            {
                if (a_5.Checked)
                {
                    qindex = 4;
                    q = QuestionManager.questions[qList.SelectedIndex].a[qindex];
                    audience.audWnd.rectangle4.Fill = itemAnsBg;
                    audience.audWnd.a_5.Content = q;
                    audience.audWnd.a_5.FontSize = calcFontSize(q, 294);
                    audience.audWnd.a_5.Visibility = Visibility.Visible;
                    audience.audWnd.b_5.Visibility = Visibility.Hidden;
                    audience.audWnd.p5.Content = QuestionManager.questions[qList.SelectedIndex].p[qindex].ToString();
                    audience.audWnd.p5.Visibility = Visibility.Visible;
                    pointMade = true;
                }
                else
                {
                    audience.audWnd.rectangle4.Fill = itemBg;
                    audience.audWnd.a_5.Visibility = Visibility.Hidden;
                    audience.audWnd.b_5.Visibility = Visibility.Visible;
                    audience.audWnd.p5.Visibility = Visibility.Hidden;
                }
            }
            else if (sender == a_6)
            {
                if (a_6.Checked)
                {
                    qindex = 5;
                    q = QuestionManager.questions[qList.SelectedIndex].a[qindex];
                    audience.audWnd.rectangle5.Fill = itemAnsBg;
                    audience.audWnd.a_6.Content = q;
                    audience.audWnd.a_6.FontSize = calcFontSize(q, 294);
                    audience.audWnd.a_6.Visibility = Visibility.Visible;
                    audience.audWnd.b_6.Visibility = Visibility.Hidden;
                    audience.audWnd.p6.Content = QuestionManager.questions[qList.SelectedIndex].p[qindex].ToString();
                    audience.audWnd.p6.Visibility = Visibility.Visible;
                    pointMade = true;
                }
                else
                {
                    audience.audWnd.rectangle5.Fill = itemBg;
                    audience.audWnd.a_6.Visibility = Visibility.Hidden;
                    audience.audWnd.b_6.Visibility = Visibility.Visible;
                    audience.audWnd.p6.Visibility = Visibility.Hidden;
                }
            }
            else if (sender == a_7)
            {
                if (a_7.Checked)
                {
                    qindex = 6;
                    q = QuestionManager.questions[qList.SelectedIndex].a[qindex];
                    audience.audWnd.rectangle6.Fill = itemAnsBg;
                    audience.audWnd.a_7.Content = q;
                    audience.audWnd.a_7.FontSize = calcFontSize(q, 294);
                    audience.audWnd.a_7.Visibility = Visibility.Visible;
                    audience.audWnd.b_7.Visibility = Visibility.Hidden;
                    audience.audWnd.p7.Content = QuestionManager.questions[qList.SelectedIndex].p[qindex].ToString();
                    audience.audWnd.p7.Visibility = Visibility.Visible;
                    pointMade = true;
                }
                else
                {
                    audience.audWnd.rectangle6.Fill = itemBg;
                    audience.audWnd.a_7.Visibility = Visibility.Hidden;
                    audience.audWnd.b_7.Visibility = Visibility.Visible;
                    audience.audWnd.p7.Visibility = Visibility.Hidden;
                }
            }
            else if (sender == a_8)
            {
                if (a_8.Checked)
                {
                    qindex = 7;
                    q = QuestionManager.questions[qList.SelectedIndex].a[qindex];
                    audience.audWnd.rectangle7.Fill = itemAnsBg;
                    audience.audWnd.a_8.Content = q;
                    audience.audWnd.a_8.FontSize = calcFontSize(q, 294);
                    audience.audWnd.a_8.Visibility = Visibility.Visible;
                    audience.audWnd.b_8.Visibility = Visibility.Hidden;
                    audience.audWnd.p8.Content = QuestionManager.questions[qList.SelectedIndex].p[qindex].ToString();
                    audience.audWnd.p8.Visibility = Visibility.Visible;
                    pointMade = true;
                }
                else
                {
                    audience.audWnd.rectangle7.Fill = itemBg;
                    audience.audWnd.a_8.Visibility = Visibility.Hidden;
                    audience.audWnd.b_8.Visibility = Visibility.Visible;
                    audience.audWnd.p8.Visibility = Visibility.Hidden;
                }
            }

            if (((CheckBox)sender).Checked && pointMade)
            {
                cor.Play();
                int pointsGained = (int)QuestionManager.questions[qList.SelectedIndex].p[qindex];
                if (cbPointsDoubled.Checked)
                    pointsGained = pointsGained * 2;

                if (leftInControl && pointMade)
                    leftScore += pointsGained;


                if (rightInControl && pointMade)
                    rightScore += pointsGained;
            }
                

            tLeftScore.Text = leftScore.ToString();
            tRightScore.Text = rightScore.ToString();

            audience.audWnd.leftScore.Content = leftScore.ToString();
            audience.audWnd.rightScore.Content = rightScore.ToString();

        }

        public int calcFontSize(string s, int targetW)
        {
            Graphics g = Graphics.FromImage(new Bitmap(1,1));
            SizeF sz =  g.MeasureString(s, new Font("Segoe UI", 40, System.Drawing.FontStyle.Regular, GraphicsUnit.Pixel));
            int fsz = 40;
            while ((g.MeasureString(s, new Font("Segoe UI", fsz, System.Drawing.FontStyle.Regular, GraphicsUnit.Pixel)).Width > targetW) && fsz > 1)
            {
                fsz--;
            }

            return fsz;
        }

        private void a_8_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            audience.audWnd.rectangle8.Visibility = Visibility.Hidden;

            audience.audWnd.x_2_1.Visibility = Visibility.Hidden;
            audience.audWnd.x_2_2.Visibility = Visibility.Hidden;

            audience.audWnd.x_3_1.Visibility = Visibility.Hidden;
            audience.audWnd.x_3_2.Visibility = Visibility.Hidden;
            audience.audWnd.x_3_3.Visibility = Visibility.Hidden;
        }

        public void terminate()
        {
            cMgr.terminate();
        }

        private void bLeftControl_Click(object sender, EventArgs e)
        {
            bRightControl.BackColor = System.Drawing.Color.Gray;
            bLeftControl.BackColor = System.Drawing.Color.Green;
            leftInControl = true;
            rightInControl = false;
        }

        private void tRightScore_TextChanged(object sender, EventArgs e)
        {
            rightScore = Convert.ToInt32(tRightScore.Text);
        }

        private void tLeftScore_TextChanged(object sender, EventArgs e)
        {
            leftScore = Convert.ToInt32(tLeftScore.Text);
        }

        private void cbShowQuestion_CheckedChanged(object sender, EventArgs e)
        {
            //audience.audWnd;
            if (cbShowQuestion.Checked)
            {
                audience.audWnd.Question.Visibility = Visibility.Visible;
                audience.audWnd.Question.Content = QuestionManager.questions[qList.SelectedIndex].q;
            }
            else
                audience.audWnd.Question.Visibility = Visibility.Hidden;

        }

        private void bRightControl_Click(object sender, EventArgs e)
        {
            bLeftControl.BackColor = System.Drawing.Color.Gray;
            bRightControl.BackColor = System.Drawing.Color.Green;
            leftInControl = false;
            rightInControl = true;
        }
    }
}
