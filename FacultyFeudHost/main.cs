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

using System.Windows;

namespace FacultyFeudHost
{
    public partial class Form1 : Form
    {    
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (questions.qForm.Visible)
                questions.qForm.Hide();
            else
                questions.qForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            audience.audWnd.toggleVisibility();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (playManage.mgr.Visible)
                playManage.mgr.Hide();
            else
                playManage.mgr.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            playManage.mgr.terminate();
        }
    }
}
