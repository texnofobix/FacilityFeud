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

namespace FacultyFeudHost
{
    partial class playManage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.qList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.b_x_s = new System.Windows.Forms.Button();
            this.a_8 = new System.Windows.Forms.CheckBox();
            this.a_7 = new System.Windows.Forms.CheckBox();
            this.a_6 = new System.Windows.Forms.CheckBox();
            this.a_5 = new System.Windows.Forms.CheckBox();
            this.a_4 = new System.Windows.Forms.CheckBox();
            this.a_3 = new System.Windows.Forms.CheckBox();
            this.a_2 = new System.Windows.Forms.CheckBox();
            this.a_1 = new System.Windows.Forms.CheckBox();
            this.a_x = new System.Windows.Forms.Button();
            this.tmrBuzz = new System.Windows.Forms.Timer(this.components);
            this.bResetClients = new System.Windows.Forms.Button();
            this.lftBox = new System.Windows.Forms.PictureBox();
            this.rtBox = new System.Windows.Forms.PictureBox();
            this.back = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.tLeftScore = new System.Windows.Forms.TextBox();
            this.tRightScore = new System.Windows.Forms.TextBox();
            this.bLeftControl = new System.Windows.Forms.Button();
            this.bRightControl = new System.Windows.Forms.Button();
            this.cbShowQuestion = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPointsDoubled = new System.Windows.Forms.CheckBox();
            this.tbRoundScore = new System.Windows.Forms.TextBox();
            this.bEndRound = new System.Windows.Forms.Button();
            this.tmrAnswer = new System.Windows.Forms.Timer(this.components);
            this.bAnswerTimer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lftBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtBox)).BeginInit();
            this.SuspendLayout();
            // 
            // qList
            // 
            this.qList.FormattingEnabled = true;
            this.qList.Location = new System.Drawing.Point(12, 12);
            this.qList.Name = "qList";
            this.qList.Size = new System.Drawing.Size(423, 381);
            this.qList.TabIndex = 0;
            this.qList.SelectedIndexChanged += new System.EventHandler(this.qList_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.b_x_s);
            this.groupBox1.Controls.Add(this.a_8);
            this.groupBox1.Controls.Add(this.a_7);
            this.groupBox1.Controls.Add(this.a_6);
            this.groupBox1.Controls.Add(this.a_5);
            this.groupBox1.Controls.Add(this.a_4);
            this.groupBox1.Controls.Add(this.a_3);
            this.groupBox1.Controls.Add(this.a_2);
            this.groupBox1.Controls.Add(this.a_1);
            this.groupBox1.Controls.Add(this.a_x);
            this.groupBox1.Location = new System.Drawing.Point(463, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 258);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Answers";
            // 
            // b_x_s
            // 
            this.b_x_s.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.b_x_s.Location = new System.Drawing.Point(153, 200);
            this.b_x_s.Name = "b_x_s";
            this.b_x_s.Size = new System.Drawing.Size(121, 40);
            this.b_x_s.TabIndex = 17;
            this.b_x_s.Tag = "x";
            this.b_x_s.Text = "X";
            this.b_x_s.UseVisualStyleBackColor = true;
            this.b_x_s.Click += new System.EventHandler(this.btn_Click);
            // 
            // a_8
            // 
            this.a_8.Appearance = System.Windows.Forms.Appearance.Button;
            this.a_8.Enabled = false;
            this.a_8.Location = new System.Drawing.Point(153, 148);
            this.a_8.Name = "a_8";
            this.a_8.Size = new System.Drawing.Size(121, 37);
            this.a_8.TabIndex = 16;
            this.a_8.Tag = "8";
            this.a_8.Text = "8";
            this.a_8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.a_8.UseVisualStyleBackColor = true;
            this.a_8.CheckedChanged += new System.EventHandler(this.a_CheckedChanged);
            // 
            // a_7
            // 
            this.a_7.Appearance = System.Windows.Forms.Appearance.Button;
            this.a_7.Enabled = false;
            this.a_7.Location = new System.Drawing.Point(153, 105);
            this.a_7.Name = "a_7";
            this.a_7.Size = new System.Drawing.Size(121, 37);
            this.a_7.TabIndex = 15;
            this.a_7.Tag = "7";
            this.a_7.Text = "7";
            this.a_7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.a_7.UseVisualStyleBackColor = true;
            this.a_7.CheckedChanged += new System.EventHandler(this.a_CheckedChanged);
            // 
            // a_6
            // 
            this.a_6.Appearance = System.Windows.Forms.Appearance.Button;
            this.a_6.Enabled = false;
            this.a_6.Location = new System.Drawing.Point(153, 62);
            this.a_6.Name = "a_6";
            this.a_6.Size = new System.Drawing.Size(121, 37);
            this.a_6.TabIndex = 14;
            this.a_6.Tag = "6";
            this.a_6.Text = "6";
            this.a_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.a_6.UseVisualStyleBackColor = true;
            this.a_6.CheckedChanged += new System.EventHandler(this.a_CheckedChanged);
            // 
            // a_5
            // 
            this.a_5.Appearance = System.Windows.Forms.Appearance.Button;
            this.a_5.Enabled = false;
            this.a_5.Location = new System.Drawing.Point(153, 19);
            this.a_5.Name = "a_5";
            this.a_5.Size = new System.Drawing.Size(121, 37);
            this.a_5.TabIndex = 13;
            this.a_5.Tag = "5";
            this.a_5.Text = "5";
            this.a_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.a_5.UseVisualStyleBackColor = true;
            this.a_5.CheckedChanged += new System.EventHandler(this.a_CheckedChanged);
            // 
            // a_4
            // 
            this.a_4.Appearance = System.Windows.Forms.Appearance.Button;
            this.a_4.Enabled = false;
            this.a_4.Location = new System.Drawing.Point(26, 148);
            this.a_4.Name = "a_4";
            this.a_4.Size = new System.Drawing.Size(121, 37);
            this.a_4.TabIndex = 12;
            this.a_4.Tag = "4";
            this.a_4.Text = "4";
            this.a_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.a_4.UseVisualStyleBackColor = true;
            this.a_4.CheckedChanged += new System.EventHandler(this.a_CheckedChanged);
            // 
            // a_3
            // 
            this.a_3.Appearance = System.Windows.Forms.Appearance.Button;
            this.a_3.Enabled = false;
            this.a_3.Location = new System.Drawing.Point(26, 105);
            this.a_3.Name = "a_3";
            this.a_3.Size = new System.Drawing.Size(121, 37);
            this.a_3.TabIndex = 11;
            this.a_3.Tag = "3";
            this.a_3.Text = "3";
            this.a_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.a_3.UseVisualStyleBackColor = true;
            this.a_3.CheckedChanged += new System.EventHandler(this.a_CheckedChanged);
            // 
            // a_2
            // 
            this.a_2.Appearance = System.Windows.Forms.Appearance.Button;
            this.a_2.Enabled = false;
            this.a_2.Location = new System.Drawing.Point(26, 62);
            this.a_2.Name = "a_2";
            this.a_2.Size = new System.Drawing.Size(121, 37);
            this.a_2.TabIndex = 10;
            this.a_2.Tag = "2";
            this.a_2.Text = "&2";
            this.a_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.a_2.UseVisualStyleBackColor = true;
            this.a_2.CheckedChanged += new System.EventHandler(this.a_CheckedChanged);
            // 
            // a_1
            // 
            this.a_1.Appearance = System.Windows.Forms.Appearance.Button;
            this.a_1.Enabled = false;
            this.a_1.Location = new System.Drawing.Point(26, 19);
            this.a_1.Name = "a_1";
            this.a_1.Size = new System.Drawing.Size(121, 37);
            this.a_1.TabIndex = 9;
            this.a_1.Tag = "1";
            this.a_1.Text = "&1";
            this.a_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.a_1.UseVisualStyleBackColor = true;
            this.a_1.CheckedChanged += new System.EventHandler(this.a_CheckedChanged);
            // 
            // a_x
            // 
            this.a_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.a_x.Location = new System.Drawing.Point(26, 200);
            this.a_x.Name = "a_x";
            this.a_x.Size = new System.Drawing.Size(121, 40);
            this.a_x.TabIndex = 8;
            this.a_x.Tag = "x";
            this.a_x.Text = "X: 0";
            this.a_x.UseVisualStyleBackColor = true;
            this.a_x.Click += new System.EventHandler(this.btn_Click);
            // 
            // tmrBuzz
            // 
            this.tmrBuzz.Interval = 2000;
            this.tmrBuzz.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bResetClients
            // 
            this.bResetClients.Location = new System.Drawing.Point(705, 365);
            this.bResetClients.Name = "bResetClients";
            this.bResetClients.Size = new System.Drawing.Size(65, 130);
            this.bResetClients.TabIndex = 4;
            this.bResetClients.Text = "Reset Clients";
            this.bResetClients.UseVisualStyleBackColor = true;
            this.bResetClients.Click += new System.EventHandler(this.btn_Click);
            // 
            // lftBox
            // 
            this.lftBox.BackColor = System.Drawing.Color.White;
            this.lftBox.Location = new System.Drawing.Point(530, 403);
            this.lftBox.Name = "lftBox";
            this.lftBox.Size = new System.Drawing.Size(60, 50);
            this.lftBox.TabIndex = 6;
            this.lftBox.TabStop = false;
            this.lftBox.BackColorChanged += new System.EventHandler(this.lftBox_BackColorChanged);
            // 
            // rtBox
            // 
            this.rtBox.BackColor = System.Drawing.Color.White;
            this.rtBox.Location = new System.Drawing.Point(620, 403);
            this.rtBox.Name = "rtBox";
            this.rtBox.Size = new System.Drawing.Size(60, 50);
            this.rtBox.TabIndex = 5;
            this.rtBox.TabStop = false;
            this.rtBox.BackColorChanged += new System.EventHandler(this.rtBox_BackColorChanged);
            // 
            // back
            // 
            this.back.Image = global::FacultyFeudHost.Properties.Resources.arrow_back;
            this.back.Location = new System.Drawing.Point(12, 399);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(121, 117);
            this.back.TabIndex = 3;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.btn_Click);
            // 
            // next
            // 
            this.next.Image = global::FacultyFeudHost.Properties.Resources.arrow_next;
            this.next.Location = new System.Drawing.Point(139, 399);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(121, 117);
            this.next.TabIndex = 2;
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.btn_Click);
            // 
            // tLeftScore
            // 
            this.tLeftScore.Location = new System.Drawing.Point(530, 370);
            this.tLeftScore.Name = "tLeftScore";
            this.tLeftScore.Size = new System.Drawing.Size(59, 20);
            this.tLeftScore.TabIndex = 7;
            this.tLeftScore.Text = "0";
            this.tLeftScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tLeftScore.TextChanged += new System.EventHandler(this.tLeftScore_TextChanged);
            // 
            // tRightScore
            // 
            this.tRightScore.Location = new System.Drawing.Point(620, 370);
            this.tRightScore.Name = "tRightScore";
            this.tRightScore.Size = new System.Drawing.Size(60, 20);
            this.tRightScore.TabIndex = 8;
            this.tRightScore.Text = "0";
            this.tRightScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tRightScore.TextChanged += new System.EventHandler(this.tRightScore_TextChanged);
            // 
            // bLeftControl
            // 
            this.bLeftControl.Location = new System.Drawing.Point(531, 487);
            this.bLeftControl.Name = "bLeftControl";
            this.bLeftControl.Size = new System.Drawing.Size(59, 23);
            this.bLeftControl.TabIndex = 9;
            this.bLeftControl.Text = "Left";
            this.bLeftControl.UseVisualStyleBackColor = true;
            this.bLeftControl.Click += new System.EventHandler(this.bLeftControl_Click);
            // 
            // bRightControl
            // 
            this.bRightControl.Location = new System.Drawing.Point(620, 487);
            this.bRightControl.Name = "bRightControl";
            this.bRightControl.Size = new System.Drawing.Size(60, 23);
            this.bRightControl.TabIndex = 10;
            this.bRightControl.Text = "Right";
            this.bRightControl.UseVisualStyleBackColor = true;
            this.bRightControl.Click += new System.EventHandler(this.bRightControl_Click);
            // 
            // cbShowQuestion
            // 
            this.cbShowQuestion.AutoSize = true;
            this.cbShowQuestion.Location = new System.Drawing.Point(463, 276);
            this.cbShowQuestion.Name = "cbShowQuestion";
            this.cbShowQuestion.Size = new System.Drawing.Size(155, 17);
            this.cbShowQuestion.TabIndex = 11;
            this.cbShowQuestion.Text = "Show question to audience";
            this.cbShowQuestion.UseVisualStyleBackColor = true;
            this.cbShowQuestion.CheckedChanged += new System.EventHandler(this.cbShowQuestion_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(455, 492);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Team Control";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(457, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Buzz Winner";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(471, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Score";
            // 
            // cbPointsDoubled
            // 
            this.cbPointsDoubled.AutoSize = true;
            this.cbPointsDoubled.Location = new System.Drawing.Point(463, 299);
            this.cbPointsDoubled.Name = "cbPointsDoubled";
            this.cbPointsDoubled.Size = new System.Drawing.Size(91, 17);
            this.cbPointsDoubled.TabIndex = 15;
            this.cbPointsDoubled.Text = "Double points";
            this.cbPointsDoubled.UseVisualStyleBackColor = true;
            // 
            // tbRoundScore
            // 
            this.tbRoundScore.Location = new System.Drawing.Point(555, 328);
            this.tbRoundScore.Name = "tbRoundScore";
            this.tbRoundScore.Size = new System.Drawing.Size(100, 20);
            this.tbRoundScore.TabIndex = 16;
            this.tbRoundScore.Text = "0";
            this.tbRoundScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbRoundScore.TextChanged += new System.EventHandler(this.tbRoundScore_TextChanged);
            // 
            // bEndRound
            // 
            this.bEndRound.Location = new System.Drawing.Point(311, 464);
            this.bEndRound.Name = "bEndRound";
            this.bEndRound.Size = new System.Drawing.Size(97, 46);
            this.bEndRound.TabIndex = 17;
            this.bEndRound.Text = "End Round and assign points";
            this.bEndRound.UseVisualStyleBackColor = true;
            this.bEndRound.Click += new System.EventHandler(this.bEndRound_Click);
            // 
            // tmrAnswer
            // 
            this.tmrAnswer.Interval = 1000;
            this.tmrAnswer.Tick += new System.EventHandler(this.tmrAnswer_Tick);
            // 
            // bAnswerTimer
            // 
            this.bAnswerTimer.Location = new System.Drawing.Point(624, 293);
            this.bAnswerTimer.Name = "bAnswerTimer";
            this.bAnswerTimer.Size = new System.Drawing.Size(113, 23);
            this.bAnswerTimer.TabIndex = 18;
            this.bAnswerTimer.Text = "Answer Timer";
            this.bAnswerTimer.UseVisualStyleBackColor = true;
            this.bAnswerTimer.Click += new System.EventHandler(this.bAnswerTimer_Click);
            // 
            // playManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 521);
            this.Controls.Add(this.bAnswerTimer);
            this.Controls.Add(this.bEndRound);
            this.Controls.Add(this.tbRoundScore);
            this.Controls.Add(this.cbPointsDoubled);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbShowQuestion);
            this.Controls.Add(this.bRightControl);
            this.Controls.Add(this.bLeftControl);
            this.Controls.Add(this.tRightScore);
            this.Controls.Add(this.tLeftScore);
            this.Controls.Add(this.lftBox);
            this.Controls.Add(this.rtBox);
            this.Controls.Add(this.bResetClients);
            this.Controls.Add(this.back);
            this.Controls.Add(this.next);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.qList);
            this.Name = "playManage";
            this.Text = "FF Game Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.playManage_FormClosing);
            this.Load += new System.EventHandler(this.playManage_Load);
            this.Shown += new System.EventHandler(this.playManage_Shown);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lftBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox qList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button a_x;
        private System.Windows.Forms.CheckBox a_8;
        private System.Windows.Forms.CheckBox a_7;
        private System.Windows.Forms.CheckBox a_6;
        private System.Windows.Forms.CheckBox a_5;
        private System.Windows.Forms.CheckBox a_4;
        private System.Windows.Forms.CheckBox a_3;
        private System.Windows.Forms.CheckBox a_2;
        private System.Windows.Forms.CheckBox a_1;
        private System.Windows.Forms.Timer tmrBuzz;
        private System.Windows.Forms.Button bResetClients;
        private System.Windows.Forms.Button b_x_s;
        public System.Windows.Forms.PictureBox rtBox;
        public System.Windows.Forms.PictureBox lftBox;
        private System.Windows.Forms.TextBox tLeftScore;
        private System.Windows.Forms.TextBox tRightScore;
        private System.Windows.Forms.Button bLeftControl;
        private System.Windows.Forms.Button bRightControl;
        private System.Windows.Forms.CheckBox cbShowQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbPointsDoubled;
        private System.Windows.Forms.TextBox tbRoundScore;
        private System.Windows.Forms.Button bEndRound;
        private System.Windows.Forms.Timer tmrAnswer;
        private System.Windows.Forms.Button bAnswerTimer;
    }
}