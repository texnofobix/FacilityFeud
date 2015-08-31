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
using System.Drawing;
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
            audience.audWnd.rectangle0.Fill = itemBg;
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

                audience.audWnd.lftBox.Visibility = Visibility.Hidden;
                audience.audWnd.rtBox.Visibility = Visibility.Hidden;
            }

            tLeftScore.Text = leftScore.ToString();
            tRightScore.Text = rightScore.ToString();

            audience.audWnd.leftScore.Content = leftScore.ToString();
            audience.audWnd.rightScore.Content = rightScore.ToString();

            audience.audWnd.Question.Content = QuestionManager.questions[qList.SelectedIndex].q;
        }

        private void FlipAnswer(int ansIndex, ref System.Windows.Shapes.Rectangle blankBoardFlip, ref System.Windows.Controls.Label answerBox, ref System.Windows.Controls.Label blankBox, ref System.Windows.Controls.Label pointsBox)
        {
            //TODO: change function to return int of points
            string answerText = QuestionManager.questions[qList.SelectedIndex].a[ansIndex];
            blankBoardFlip.Fill = itemAnsBg;

            answerBox.Content = answerText;
            answerBox.FontSize = calcFontSize(answerText, 294);
            answerBox.Visibility = Visibility.Visible;
            
            blankBox.Visibility = Visibility.Hidden;

            pointsBox.Content = QuestionManager.questions[qList.SelectedIndex].p[ansIndex].ToString();
            pointsBox.Visibility = Visibility.Visible;
            
            //pointMade = true;

        }

        private void FlipBack(ref System.Windows.Shapes.Rectangle blankBoardFlip, ref System.Windows.Controls.Label answerBox, ref System.Windows.Controls.Label blankBox, ref System.Windows.Controls.Label pointBox)
        {
            blankBoardFlip.Fill = itemBg;
            answerBox.Visibility = Visibility.Hidden;
            blankBox.Visibility = Visibility.Visible;
            pointBox.Visibility = Visibility.Hidden;
        }
        private void a_CheckedChanged(object sender, EventArgs e)
        {
            if (leftInControl == false && rightInControl == false)
                return; //no team in control?
            
            string q;
            int ansIndex = 0;
            bool pointMade = false;

            if (sender == a_1)
            {

                if (a_1.Checked)
                {
                    ansIndex = 0;
                    FlipAnswer(ansIndex, ref audience.audWnd.rectangle0, ref audience.audWnd.a_1, ref audience.audWnd.b_1, ref audience.audWnd.p1);
                    pointMade = true;
                }
                else
                    FlipBack(ref audience.audWnd.rectangle0, ref audience.audWnd.a_1, ref audience.audWnd.b_1, ref audience.audWnd.p1);
            }
            else if (sender == a_2)
            {
                if (a_2.Checked)
                {
                    ansIndex = 1;
                    FlipAnswer(ansIndex, ref audience.audWnd.rectangle1, ref audience.audWnd.a_2, ref audience.audWnd.b_2, ref audience.audWnd.p2);
                    pointMade = true;
                }
                else
                    FlipBack(ref audience.audWnd.rectangle1, ref audience.audWnd.a_2, ref audience.audWnd.b_2, ref audience.audWnd.p2);
                
            }
            else if (sender == a_3)
            {
                if (a_3.Checked)
                {
                    ansIndex = 2;
                    FlipAnswer(ansIndex, ref audience.audWnd.rectangle2, ref audience.audWnd.a_3, ref audience.audWnd.b_3, ref audience.audWnd.p3);
                    pointMade = true;
                }
                else
                    FlipBack(ref audience.audWnd.rectangle2, ref audience.audWnd.a_3, ref audience.audWnd.b_3, ref audience.audWnd.p3);
                    
            }
            else if (sender == a_4)
            {
                if (a_4.Checked)
                {
                    ansIndex = 3;
                    FlipAnswer(ansIndex, ref audience.audWnd.rectangle3, ref audience.audWnd.a_4, ref audience.audWnd.b_4, ref audience.audWnd.p4);
                    pointMade = true;
                }
                else
                    FlipBack(ref audience.audWnd.rectangle3, ref audience.audWnd.a_4, ref audience.audWnd.b_4, ref audience.audWnd.p4);
                 
            }
            else if (sender == a_5)
            {
                if (a_5.Checked)
                {
                    ansIndex = 4;
                    FlipAnswer(ansIndex, ref audience.audWnd.rectangle4, ref audience.audWnd.a_5, ref audience.audWnd.b_5, ref audience.audWnd.p5);
                    pointMade = true;
                }
                else
                    FlipBack(ref audience.audWnd.rectangle4, ref audience.audWnd.a_5, ref audience.audWnd.b_5, ref audience.audWnd.p5);
            }
            else if (sender == a_6)
            {
                if (a_6.Checked)
                {
                    ansIndex = 5;
                    FlipAnswer(ansIndex, ref audience.audWnd.rectangle5, ref audience.audWnd.a_6, ref audience.audWnd.b_6, ref audience.audWnd.p6);
                    pointMade = true;
                }
                else
                    FlipBack(ref audience.audWnd.rectangle5, ref audience.audWnd.a_6, ref audience.audWnd.b_6, ref audience.audWnd.p6);
            }
            else if (sender == a_7)
            {
                if (a_7.Checked)
                {
                    ansIndex = 6;
                    FlipAnswer(ansIndex, ref audience.audWnd.rectangle6, ref audience.audWnd.a_7, ref audience.audWnd.b_7, ref audience.audWnd.p7);
                    pointMade = true;
                }
                else
                    FlipBack(ref audience.audWnd.rectangle6, ref audience.audWnd.a_7, ref audience.audWnd.b_7, ref audience.audWnd.p7);
                 
            }
            else if (sender == a_8)
            {
                if (a_8.Checked)
                {
                    ansIndex = 7;
                    FlipAnswer(ansIndex, ref audience.audWnd.rectangle7, ref audience.audWnd.a_8, ref audience.audWnd.b_8, ref audience.audWnd.p8);
                    pointMade = true;
                }
                else
                    FlipBack(ref audience.audWnd.rectangle7, ref audience.audWnd.a_8, ref audience.audWnd.b_8, ref audience.audWnd.p8);
            }

            if (((CheckBox)sender).Checked && pointMade)
            {
                cor.Play();
                int pointsGained = (int)QuestionManager.questions[qList.SelectedIndex].p[ansIndex];
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
