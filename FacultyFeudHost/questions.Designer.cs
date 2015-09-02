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
    partial class questions
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
            this.label1 = new System.Windows.Forms.Label();
            this.qList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.p8 = new System.Windows.Forms.NumericUpDown();
            this.p7 = new System.Windows.Forms.NumericUpDown();
            this.p6 = new System.Windows.Forms.NumericUpDown();
            this.p4 = new System.Windows.Forms.NumericUpDown();
            this.p3 = new System.Windows.Forms.NumericUpDown();
            this.p2 = new System.Windows.Forms.NumericUpDown();
            this.p1 = new System.Windows.Forms.NumericUpDown();
            this.p5 = new System.Windows.Forms.NumericUpDown();
            this.updateB = new System.Windows.Forms.Button();
            this.a8 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.a7 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.a6 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.a5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.a4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.a3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.a2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.a1 = new System.Windows.Forms.TextBox();
            this.numA = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.q = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bNewQuestion = new System.Windows.Forms.Button();
            this.bDeleteQuestion = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numA)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Question List";
            // 
            // qList
            // 
            this.qList.FormattingEnabled = true;
            this.qList.Location = new System.Drawing.Point(15, 56);
            this.qList.Name = "qList";
            this.qList.Size = new System.Drawing.Size(120, 329);
            this.qList.TabIndex = 1;
            this.qList.SelectedIndexChanged += new System.EventHandler(this.qList_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.p8);
            this.groupBox1.Controls.Add(this.p7);
            this.groupBox1.Controls.Add(this.p6);
            this.groupBox1.Controls.Add(this.p4);
            this.groupBox1.Controls.Add(this.p3);
            this.groupBox1.Controls.Add(this.p2);
            this.groupBox1.Controls.Add(this.p1);
            this.groupBox1.Controls.Add(this.p5);
            this.groupBox1.Controls.Add(this.updateB);
            this.groupBox1.Controls.Add(this.a8);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.a7);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.a6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.a5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.a4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.a3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.a2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.a1);
            this.groupBox1.Controls.Add(this.numA);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.q);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(141, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 329);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Question Settings";
            // 
            // p8
            // 
            this.p8.AccessibleDescription = "p";
            this.p8.Location = new System.Drawing.Point(405, 218);
            this.p8.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.p8.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.p8.Name = "p8";
            this.p8.Size = new System.Drawing.Size(49, 20);
            this.p8.TabIndex = 28;
            this.p8.Tag = "8";
            this.p8.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.p8.Visible = false;
            // 
            // p7
            // 
            this.p7.AccessibleDescription = "p";
            this.p7.Location = new System.Drawing.Point(405, 192);
            this.p7.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.p7.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.p7.Name = "p7";
            this.p7.Size = new System.Drawing.Size(49, 20);
            this.p7.TabIndex = 27;
            this.p7.Tag = "7";
            this.p7.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.p7.Visible = false;
            // 
            // p6
            // 
            this.p6.AccessibleDescription = "p";
            this.p6.Location = new System.Drawing.Point(405, 166);
            this.p6.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.p6.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.p6.Name = "p6";
            this.p6.Size = new System.Drawing.Size(49, 20);
            this.p6.TabIndex = 26;
            this.p6.Tag = "6";
            this.p6.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.p6.Visible = false;
            // 
            // p4
            // 
            this.p4.AccessibleDescription = "p";
            this.p4.Location = new System.Drawing.Point(169, 218);
            this.p4.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.p4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(49, 20);
            this.p4.TabIndex = 25;
            this.p4.Tag = "4";
            this.p4.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.p4.Visible = false;
            // 
            // p3
            // 
            this.p3.AccessibleDescription = "p";
            this.p3.Location = new System.Drawing.Point(169, 192);
            this.p3.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.p3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(49, 20);
            this.p3.TabIndex = 24;
            this.p3.Tag = "3";
            this.p3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.p3.Visible = false;
            // 
            // p2
            // 
            this.p2.AccessibleDescription = "p";
            this.p2.Location = new System.Drawing.Point(169, 166);
            this.p2.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.p2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(49, 20);
            this.p2.TabIndex = 23;
            this.p2.Tag = "2";
            this.p2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.p2.Visible = false;
            // 
            // p1
            // 
            this.p1.AccessibleDescription = "p";
            this.p1.Location = new System.Drawing.Point(169, 140);
            this.p1.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.p1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(49, 20);
            this.p1.TabIndex = 22;
            this.p1.Tag = "1";
            this.p1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // p5
            // 
            this.p5.AccessibleDescription = "p";
            this.p5.Location = new System.Drawing.Point(405, 140);
            this.p5.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.p5.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.p5.Name = "p5";
            this.p5.Size = new System.Drawing.Size(49, 20);
            this.p5.TabIndex = 21;
            this.p5.Tag = "5";
            this.p5.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.p5.Visible = false;
            // 
            // updateB
            // 
            this.updateB.Enabled = false;
            this.updateB.Location = new System.Drawing.Point(379, 300);
            this.updateB.Name = "updateB";
            this.updateB.Size = new System.Drawing.Size(75, 23);
            this.updateB.TabIndex = 20;
            this.updateB.Tag = "0";
            this.updateB.Text = "Add";
            this.updateB.UseVisualStyleBackColor = true;
            this.updateB.Click += new System.EventHandler(this.updateB_Click);
            // 
            // a8
            // 
            this.a8.AccessibleDescription = "a";
            this.a8.Location = new System.Drawing.Point(299, 218);
            this.a8.MaxLength = 50;
            this.a8.Name = "a8";
            this.a8.Size = new System.Drawing.Size(100, 20);
            this.a8.TabIndex = 19;
            this.a8.Tag = "8";
            this.a8.Visible = false;
            this.a8.TextChanged += new System.EventHandler(this.a_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(242, 221);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 18;
            this.label11.Tag = "108";
            this.label11.Text = "Answer 8";
            this.label11.Visible = false;
            // 
            // a7
            // 
            this.a7.AccessibleDescription = "a";
            this.a7.Location = new System.Drawing.Point(299, 192);
            this.a7.MaxLength = 50;
            this.a7.Name = "a7";
            this.a7.Size = new System.Drawing.Size(100, 20);
            this.a7.TabIndex = 17;
            this.a7.Tag = "7";
            this.a7.Visible = false;
            this.a7.TextChanged += new System.EventHandler(this.a_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(242, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 16;
            this.label10.Tag = "107";
            this.label10.Text = "Answer 7";
            this.label10.Visible = false;
            // 
            // a6
            // 
            this.a6.AccessibleDescription = "a";
            this.a6.Location = new System.Drawing.Point(299, 166);
            this.a6.MaxLength = 50;
            this.a6.Name = "a6";
            this.a6.Size = new System.Drawing.Size(100, 20);
            this.a6.TabIndex = 15;
            this.a6.Tag = "6";
            this.a6.Visible = false;
            this.a6.TextChanged += new System.EventHandler(this.a_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(242, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 14;
            this.label9.Tag = "106";
            this.label9.Text = "Answer 6";
            this.label9.Visible = false;
            // 
            // a5
            // 
            this.a5.AccessibleDescription = "a";
            this.a5.Location = new System.Drawing.Point(299, 140);
            this.a5.MaxLength = 50;
            this.a5.Name = "a5";
            this.a5.Size = new System.Drawing.Size(100, 20);
            this.a5.TabIndex = 13;
            this.a5.Tag = "5";
            this.a5.Visible = false;
            this.a5.TextChanged += new System.EventHandler(this.a_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(242, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 12;
            this.label8.Tag = "105";
            this.label8.Text = "Answer 5";
            this.label8.Visible = false;
            // 
            // a4
            // 
            this.a4.AccessibleDescription = "a";
            this.a4.Location = new System.Drawing.Point(63, 218);
            this.a4.MaxLength = 50;
            this.a4.Name = "a4";
            this.a4.Size = new System.Drawing.Size(100, 20);
            this.a4.TabIndex = 11;
            this.a4.Tag = "4";
            this.a4.Visible = false;
            this.a4.TextChanged += new System.EventHandler(this.a_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 10;
            this.label7.Tag = "104";
            this.label7.Text = "Answer 4";
            this.label7.Visible = false;
            // 
            // a3
            // 
            this.a3.AccessibleDescription = "a";
            this.a3.Location = new System.Drawing.Point(63, 192);
            this.a3.MaxLength = 50;
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(100, 20);
            this.a3.TabIndex = 9;
            this.a3.Tag = "3";
            this.a3.Visible = false;
            this.a3.TextChanged += new System.EventHandler(this.a_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 8;
            this.label6.Tag = "103";
            this.label6.Text = "Answer 3";
            this.label6.Visible = false;
            // 
            // a2
            // 
            this.a2.AccessibleDescription = "a";
            this.a2.Location = new System.Drawing.Point(63, 166);
            this.a2.MaxLength = 50;
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(100, 20);
            this.a2.TabIndex = 7;
            this.a2.Tag = "2";
            this.a2.Visible = false;
            this.a2.TextChanged += new System.EventHandler(this.a_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 6;
            this.label5.Tag = "102";
            this.label5.Text = "Answer 2";
            this.label5.Visible = false;
            // 
            // a1
            // 
            this.a1.AccessibleDescription = "a";
            this.a1.Location = new System.Drawing.Point(63, 140);
            this.a1.MaxLength = 50;
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(100, 20);
            this.a1.TabIndex = 5;
            this.a1.Tag = "1";
            this.a1.TextChanged += new System.EventHandler(this.a_TextChanged);
            // 
            // numA
            // 
            this.numA.Location = new System.Drawing.Point(114, 88);
            this.numA.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numA.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numA.Name = "numA";
            this.numA.Size = new System.Drawing.Size(32, 20);
            this.numA.TabIndex = 4;
            this.numA.Tag = "0";
            this.numA.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numA.ValueChanged += new System.EventHandler(this.numA_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 3;
            this.label4.Tag = "0";
            this.label4.Text = "Number of Answers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Tag = "101";
            this.label3.Text = "Answer 1";
            // 
            // q
            // 
            this.q.Location = new System.Drawing.Point(64, 27);
            this.q.Name = "q";
            this.q.Size = new System.Drawing.Size(390, 53);
            this.q.TabIndex = 1;
            this.q.Tag = "0";
            this.q.Text = "";
            this.q.TextChanged += new System.EventHandler(this.q_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Tag = "0";
            this.label2.Text = "Question:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(613, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // bNewQuestion
            // 
            this.bNewQuestion.Location = new System.Drawing.Point(15, 391);
            this.bNewQuestion.Name = "bNewQuestion";
            this.bNewQuestion.Size = new System.Drawing.Size(55, 23);
            this.bNewQuestion.TabIndex = 4;
            this.bNewQuestion.Text = "New";
            this.bNewQuestion.UseVisualStyleBackColor = true;
            this.bNewQuestion.Click += new System.EventHandler(this.button1_Click);
            // 
            // bDeleteQuestion
            // 
            this.bDeleteQuestion.Location = new System.Drawing.Point(80, 391);
            this.bDeleteQuestion.Name = "bDeleteQuestion";
            this.bDeleteQuestion.Size = new System.Drawing.Size(55, 23);
            this.bDeleteQuestion.TabIndex = 5;
            this.bDeleteQuestion.Text = "Delete";
            this.bDeleteQuestion.UseVisualStyleBackColor = true;
            this.bDeleteQuestion.Click += new System.EventHandler(this.button2_Click);
            // 
            // questions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 439);
            this.Controls.Add(this.bDeleteQuestion);
            this.Controls.Add(this.bNewQuestion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.qList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "questions";
            this.Text = "FF Question Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.questions_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numA)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox qList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button updateB;
        private System.Windows.Forms.TextBox a8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox a7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox a6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox a5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox a4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox a3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox a2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox a1;
        private System.Windows.Forms.NumericUpDown numA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox q;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.Button bNewQuestion;
        private System.Windows.Forms.Button bDeleteQuestion;
        private System.Windows.Forms.NumericUpDown p8;
        private System.Windows.Forms.NumericUpDown p7;
        private System.Windows.Forms.NumericUpDown p6;
        private System.Windows.Forms.NumericUpDown p4;
        private System.Windows.Forms.NumericUpDown p3;
        private System.Windows.Forms.NumericUpDown p2;
        private System.Windows.Forms.NumericUpDown p1;
        private System.Windows.Forms.NumericUpDown p5;
    }
}