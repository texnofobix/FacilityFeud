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
    partial class MainWindowForm
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
            this.bLoadGameManager = new System.Windows.Forms.Button();
            this.bQuestionManagement = new System.Windows.Forms.Button();
            this.bLoadAudienceWindow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bLoadGameManager
            // 
            this.bLoadGameManager.Enabled = false;
            this.bLoadGameManager.Location = new System.Drawing.Point(12, 12);
            this.bLoadGameManager.Name = "bLoadGameManager";
            this.bLoadGameManager.Size = new System.Drawing.Size(130, 66);
            this.bLoadGameManager.TabIndex = 0;
            this.bLoadGameManager.Text = "Game Manager";
            this.bLoadGameManager.UseVisualStyleBackColor = true;
            this.bLoadGameManager.Click += new System.EventHandler(this.button1_Click);
            // 
            // bQuestionManagement
            // 
            this.bQuestionManagement.Location = new System.Drawing.Point(284, 12);
            this.bQuestionManagement.Name = "bQuestionManagement";
            this.bQuestionManagement.Size = new System.Drawing.Size(130, 66);
            this.bQuestionManagement.TabIndex = 1;
            this.bQuestionManagement.Text = "Question Management";
            this.bQuestionManagement.UseVisualStyleBackColor = true;
            this.bQuestionManagement.Click += new System.EventHandler(this.button2_Click);
            // 
            // bLoadAudienceWindow
            // 
            this.bLoadAudienceWindow.Location = new System.Drawing.Point(148, 12);
            this.bLoadAudienceWindow.Name = "bLoadAudienceWindow";
            this.bLoadAudienceWindow.Size = new System.Drawing.Size(130, 66);
            this.bLoadAudienceWindow.TabIndex = 2;
            this.bLoadAudienceWindow.Text = "Toggle Audience Window";
            this.bLoadAudienceWindow.UseVisualStyleBackColor = true;
            this.bLoadAudienceWindow.Click += new System.EventHandler(this.button3_Click);
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 99);
            this.Controls.Add(this.bLoadAudienceWindow);
            this.Controls.Add(this.bQuestionManagement);
            this.Controls.Add(this.bLoadGameManager);
            this.Name = "MainWindowForm";
            this.Text = "FacultyFeud";
            this.Activated += new System.EventHandler(this.MainWindowForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bLoadGameManager;
        private System.Windows.Forms.Button bQuestionManagement;
        private System.Windows.Forms.Button bLoadAudienceWindow;
    }
}

