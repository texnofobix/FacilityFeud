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
using AudienceWPF;

namespace FacultyFeudHost
{
    public class audience
    {
        public static MainWindow audWnd = new MainWindow();
    }
    /*public partial class audience : Form
    {
        public static audience audWnd = new audience();

        public audience()
        {
            InitializeComponent();
        }

        private void audience_Load(object sender, EventArgs e)
        {

        }

        private void audience_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.L && e.Control && e.Alt)
                audWnd.ControlBox = !audWnd.ControlBox;
        }

        private void audience_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        public void setNumAnswers(int n)
        {
            switch (n)
            {
                case 1:
                    b_1.Visible = true;
                    b_2.Visible = false;
                    b_3.Visible = false;
                    b_4.Visible = false;
                    b_5.Visible = false;
                    b_6.Visible = false;
                    b_7.Visible = false;
                    b_8.Visible = false;
                    break;
                case 2:
                    b_1.Visible = true;
                    b_2.Visible = true;
                    b_3.Visible = false;
                    b_4.Visible = false;
                    b_5.Visible = false;
                    b_6.Visible = false;
                    b_7.Visible = false;
                    b_8.Visible = false;
                    break;
                case 3:
                    b_1.Visible = true;
                    b_2.Visible = true;
                    b_3.Visible = true;
                    b_4.Visible = false;
                    b_5.Visible = false;
                    b_6.Visible = false;
                    b_7.Visible = false;
                    b_8.Visible = false;
                    break;
                case 4:
                    b_1.Visible = true;
                    b_2.Visible = true;
                    b_3.Visible = true;
                    b_4.Visible = true;
                    b_5.Visible = false;
                    b_6.Visible = false;
                    b_7.Visible = false;
                    b_8.Visible = false;
                    break;
                case 5:
                    b_1.Visible = true;
                    b_2.Visible = true;
                    b_3.Visible = true;
                    b_4.Visible = true;
                    b_5.Visible = true;
                    b_6.Visible = false;
                    b_7.Visible = false;
                    b_8.Visible = false;
                    break;
                case 6:
                    b_1.Visible = true;
                    b_2.Visible = true;
                    b_3.Visible = true;
                    b_4.Visible = true;
                    b_5.Visible = true;
                    b_6.Visible = true;
                    b_7.Visible = false;
                    b_8.Visible = false;
                    break;
                case 7:
                    b_1.Visible = true;
                    b_2.Visible = true;
                    b_3.Visible = true;
                    b_4.Visible = true;
                    b_5.Visible = true;
                    b_6.Visible = true;
                    b_7.Visible = true;
                    b_8.Visible = false;
                    break;
                case 8:
                    b_1.Visible = true;
                    b_2.Visible = true;
                    b_3.Visible = true;
                    b_4.Visible = true;
                    b_5.Visible = true;
                    b_6.Visible = true;
                    b_7.Visible = true;
                    b_8.Visible = true;
                    break;
            }
        }

        private void audience_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }*/
}
