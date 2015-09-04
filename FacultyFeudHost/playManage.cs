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
        int roundScore = 0;
        static int maxAnswerTime = 10000;
        int answerTime = 0;
        int lastQindex;
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
            try
            {
                e.Cancel = true;
                this.Hide();
            }
            catch
            {
                //something
            }
            
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
            if (roundScore == 0)
            {
                Question q = QuestionManager.questions[qList.SelectedIndex];
                foreach (Control c in groupBox1.Controls)
                {
                    int t;
                    int.TryParse(c.Tag.ToString(), out t);
                    if (t > 0 && t <= q.n)
                    {
                        c.Text = q.a[t - 1];
                        c.Enabled = true;
                    }
                    else if (t > q.n)
                    {
                        c.Text = (t).ToString();
                        c.Enabled = false;
                    }
                }
                audience.audWnd.setNumAnswers(q.n);
                lastQindex = qList.SelectedIndex;
            }
            else
            {
                qList.SelectedIndex = lastQindex;
                System.Windows.MessageBox.Show("Unassigned points!");
            }
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
                //audience.audWnd.leftBox.Visibility = System.Windows.Visibility.Visible;
                //audience.audWnd.rightBox.Visibility = System.Windows.Visibility.Hidden;
            }
            else
            {
                //audience.audWnd.rtBox.Visibility = System.Windows.Visibility.Visible;
                //audience.audWnd.lftBox.Visibility = System.Windows.Visibility.Hidden;
            }
        }

        public void clearWindow()
        {
            FlipBack(ref audience.audWnd.rectangle0, ref audience.audWnd.a_1, ref audience.audWnd.b_1, ref audience.audWnd.p1);
            FlipBack(ref audience.audWnd.rectangle1, ref audience.audWnd.a_2, ref audience.audWnd.b_2, ref audience.audWnd.p2);
            FlipBack(ref audience.audWnd.rectangle2, ref audience.audWnd.a_3, ref audience.audWnd.b_3, ref audience.audWnd.p3);
            FlipBack(ref audience.audWnd.rectangle3, ref audience.audWnd.a_4, ref audience.audWnd.b_4, ref audience.audWnd.p4);
            FlipBack(ref audience.audWnd.rectangle4, ref audience.audWnd.a_5, ref audience.audWnd.b_5, ref audience.audWnd.p5);
            FlipBack(ref audience.audWnd.rectangle5, ref audience.audWnd.a_6, ref audience.audWnd.b_6, ref audience.audWnd.p6);
            FlipBack(ref audience.audWnd.rectangle6, ref audience.audWnd.a_7, ref audience.audWnd.b_7, ref audience.audWnd.p7);
            FlipBack(ref audience.audWnd.rectangle7, ref audience.audWnd.a_8, ref audience.audWnd.b_8, ref audience.audWnd.p8);
            
            rtBox.BackColor = System.Drawing.Color.White;
            lftBox.BackColor = System.Drawing.Color.White;

            //audience.audWnd.lftBox.Visibility = System.Windows.Visibility.Hidden;
            //audience.audWnd.rtBox.Visibility = System.Windows.Visibility.Hidden;
        }
        private void btn_Click(object sender, EventArgs e)
        {
            if (sender == back)
            {
                if (qList.SelectedIndex > 0 && (roundScore == 0))
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
                else if (roundScore > 0)
                    System.Windows.MessageBox.Show("Points unallocated from round, please ensure the correct team is selected and press End round first.");
            }
            else if (sender == next)
            {
                if ((qList.SelectedIndex + 1 < qList.Items.Count) && (roundScore == 0))
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
                else if (roundScore > 0)
                    System.Windows.MessageBox.Show("Points unallocated from round, please ensure the correct team is selected and press End round first.");
            }
            else if (sender == a_x)
            {
                timer1_Tick(new Object(), new EventArgs());
                numInv++;
                inv.Play();
                tmrBuzz.Start();
                switch (numInv)
                {
                    case 1:
                        audience.audWnd.x_1_1.Visibility = Visibility.Visible;
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
                if (numInv == 3 && rightInControl)
                { 
                    numInv = 0;
                    bLeftControl_Click(null, null); 
                }

                if (numInv == 3 && leftInControl)
                {
                    numInv = 0;
                    bRightControl_Click(null, null);
                }
            }
            else if (sender == b_x_s)
            {
                timer1_Tick(new Object(), new EventArgs());
                inv.Play();
                tmrBuzz.Start();
                audience.audWnd.x_1_1.Visibility = Visibility.Visible;
                if (rightInControl) { bLeftControl_Click(null, null); return; }
                if (leftInControl) { bRightControl_Click(null, null); return; }
            }
            else if (sender == bResetClients)
            {
                cMgr.clearDial();
                rtBox.BackColor = System.Drawing.Color.White;
                lftBox.BackColor = System.Drawing.Color.White;

                //audience.audWnd.lftBox.Visibility = Visibility.Hidden;
                //audience.audWnd.rtBox.Visibility = Visibility.Hidden;
                //audience.audWnd.leftWin.Visibility = Visibility.Hidden;
                //audience.audWnd.rightWin.Visibility = Visibility.Hidden;
            }

            updateScores();

            audience.audWnd.Question.Content = QuestionManager.questions[qList.SelectedIndex].q;
        }

        private int FlipAnswer(int ansIndex, ref System.Windows.Shapes.Rectangle blankBoardFlip, ref System.Windows.Controls.Label answerBox, ref System.Windows.Controls.Label blankBox, ref System.Windows.Controls.Label pointsBox)
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

            return (int)QuestionManager.questions[qList.SelectedIndex].p[ansIndex];
        }

        private void FlipBack(ref System.Windows.Shapes.Rectangle blankBoardFlip, ref System.Windows.Controls.Label answerBox, ref System.Windows.Controls.Label blankBox, ref System.Windows.Controls.Label pointBox)
        {
            blankBoardFlip.Fill = itemBg;
            answerBox.Visibility = Visibility.Hidden;
            blankBox.Visibility = Visibility.Visible;
            pointBox.Visibility = Visibility.Hidden;
        }

        private int FlipBack(int ansIndex, ref System.Windows.Shapes.Rectangle blankBoardFlip, ref System.Windows.Controls.Label answerBox, ref System.Windows.Controls.Label blankBox, ref System.Windows.Controls.Label pointBox)
        {
            blankBoardFlip.Fill = itemBg;
            answerBox.Visibility = Visibility.Hidden;
            blankBox.Visibility = Visibility.Visible;
            pointBox.Visibility = Visibility.Hidden;
            return (int)QuestionManager.questions[qList.SelectedIndex].p[ansIndex];
        }

        private void a_CheckedChanged(object sender, EventArgs e)
        {
            int pointsGained = 0;
            if (leftInControl == false && rightInControl == false) {
                System.Windows.MessageBox.Show("No team in control? Please select one.");
                return; //no team in control?
            }

            if (sender == a_1)
            {
                if (a_1.Checked)
                    pointsGained = FlipAnswer(0, ref audience.audWnd.rectangle0, ref audience.audWnd.a_1, ref audience.audWnd.b_1, ref audience.audWnd.p1);
                else
                    pointsGained = FlipBack(0, ref audience.audWnd.rectangle0, ref audience.audWnd.a_1, ref audience.audWnd.b_1, ref audience.audWnd.p1);
            }
            else if (sender == a_2)
            {
                if (a_2.Checked)
                    pointsGained = FlipAnswer(1, ref audience.audWnd.rectangle1, ref audience.audWnd.a_2, ref audience.audWnd.b_2, ref audience.audWnd.p2);
                else
                    pointsGained = FlipBack(1,ref audience.audWnd.rectangle1, ref audience.audWnd.a_2, ref audience.audWnd.b_2, ref audience.audWnd.p2);
            }
            else if (sender == a_3)
            {
                if (a_3.Checked)
                    pointsGained = FlipAnswer(2, ref audience.audWnd.rectangle2, ref audience.audWnd.a_3, ref audience.audWnd.b_3, ref audience.audWnd.p3);
                else
                    pointsGained = FlipBack(2,ref audience.audWnd.rectangle2, ref audience.audWnd.a_3, ref audience.audWnd.b_3, ref audience.audWnd.p3);

            }
            else if (sender == a_4)
            {
                if (a_4.Checked)
                    pointsGained = FlipAnswer(3, ref audience.audWnd.rectangle3, ref audience.audWnd.a_4, ref audience.audWnd.b_4, ref audience.audWnd.p4);
                else
                    pointsGained = FlipBack(3,ref audience.audWnd.rectangle3, ref audience.audWnd.a_4, ref audience.audWnd.b_4, ref audience.audWnd.p4);

            }
            else if (sender == a_5)
            {
                if (a_5.Checked)
                    pointsGained = FlipAnswer(4, ref audience.audWnd.rectangle4, ref audience.audWnd.a_5, ref audience.audWnd.b_5, ref audience.audWnd.p5);
                else
                    pointsGained = FlipBack(4,ref audience.audWnd.rectangle4, ref audience.audWnd.a_5, ref audience.audWnd.b_5, ref audience.audWnd.p5);
            }
            else if (sender == a_6)
            {
                if (a_6.Checked)
                    pointsGained = FlipAnswer(5, ref audience.audWnd.rectangle5, ref audience.audWnd.a_6, ref audience.audWnd.b_6, ref audience.audWnd.p6);
                else
                    pointsGained = FlipBack(5,ref audience.audWnd.rectangle5, ref audience.audWnd.a_6, ref audience.audWnd.b_6, ref audience.audWnd.p6);
            }
            else if (sender == a_7)
            {
                if (a_7.Checked)
                    pointsGained = FlipAnswer(6, ref audience.audWnd.rectangle6, ref audience.audWnd.a_7, ref audience.audWnd.b_7, ref audience.audWnd.p7);
                else
                    pointsGained = FlipBack(6,ref audience.audWnd.rectangle6, ref audience.audWnd.a_7, ref audience.audWnd.b_7, ref audience.audWnd.p7);

            }
            else if (sender == a_8)
            {
                if (a_8.Checked)
                    pointsGained = FlipAnswer(7, ref audience.audWnd.rectangle7, ref audience.audWnd.a_8, ref audience.audWnd.b_8, ref audience.audWnd.p8);
                else
                    pointsGained = FlipBack(7,ref audience.audWnd.rectangle7, ref audience.audWnd.a_8, ref audience.audWnd.b_8, ref audience.audWnd.p8);
            }

            if (cbPointsDoubled.Checked)
                pointsGained = pointsGained * 2;

            if (((CheckBox)sender).Checked)
            {
                cor.Play();
                roundScore += pointsGained;
            }

            if (!((CheckBox)sender).Checked)
            {
                roundScore -= pointsGained;
            }

            updateScores();

        }

        private void updateScores()
        {
            tLeftScore.Text = leftScore.ToString();
            tRightScore.Text = rightScore.ToString();
            tbRoundScore.Text = roundScore.ToString();

            audience.audWnd.leftScore.Content = leftScore.ToString();
            audience.audWnd.rightScore.Content = rightScore.ToString();
            audience.audWnd.roundScore.Content = roundScore.ToString();
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
            tmrBuzz.Stop();
            audience.audWnd.x_1_1.Visibility = Visibility.Hidden;

            audience.audWnd.x_2_1.Visibility = Visibility.Hidden;
            audience.audWnd.x_2_2.Visibility = Visibility.Hidden;

            audience.audWnd.x_3_1.Visibility = Visibility.Hidden;
            audience.audWnd.x_3_2.Visibility = Visibility.Hidden;
            audience.audWnd.x_3_3.Visibility = Visibility.Hidden;
        }

        public void terminate()
        {
            try {
                cMgr.terminate();
            }
            catch
            {
                //unclean terminate
            }
            
        }

        public void bLeftControl_Click(object sender, EventArgs e)
        {
            bRightControl.BackColor = System.Drawing.Color.Gray;
            bLeftControl.BackColor = System.Drawing.Color.Green;
            leftInControl = true;
            rightInControl = false;
            audience.audWnd.leftWin.Visibility = Visibility.Visible;
            audience.audWnd.rightWin.Visibility = Visibility.Hidden;
        }

        public void bRightControl_Click(object sender, EventArgs e)
        {
            bLeftControl.BackColor = System.Drawing.Color.Gray;
            bRightControl.BackColor = System.Drawing.Color.Green;
            leftInControl = false;
            rightInControl = true;
            audience.audWnd.rightWin.Visibility = Visibility.Visible;
            audience.audWnd.leftWin.Visibility = Visibility.Hidden;
        }

        private void lftBox_BackColorChanged(object sender, EventArgs e)
        {
            /*if (lftBox.BackColor == System.Drawing.Color.Green)
            {
                bLeftControl_Click(null, null);
            }*/
        }

        private void rtBox_BackColorChanged(object sender, EventArgs e)
        {
            /*if (rtBox.BackColor == System.Drawing.Color.Green)
            {
                bRightControl_Click(null, null);
            }*/
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

        private void bEndRound_Click(object sender, EventArgs e)
        {
            if (leftInControl && rightInControl)
            {
                System.Windows.MessageBox.Show("Unable to end round. No team is in control to assign points.");
                return;
            }

            if (leftInControl)
                leftScore += roundScore;
            if (rightInControl)
                rightScore += roundScore;

            roundScore = 0;
            updateScores();
        }

        private void bAnswerTimer_Click(object sender, EventArgs e)
        {
            //start or stop timer 
            answerTime = maxAnswerTime;
            tmrAnswer.Start();
            
        }

        private void tmrAnswer_Tick(object sender, EventArgs e)
        {
            //on non-out of time, update button remaining
            bAnswerTimer.Text = answerTime.ToString();
            answerTime -= tmrAnswer.Interval;
        }

        private void tbRoundScore_TextChanged(object sender, EventArgs e)
        {
            roundScore = Convert.ToInt32(tbRoundScore.Text);
        }


    }
}
