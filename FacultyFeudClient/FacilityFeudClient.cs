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
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace FacultyFeudClient
{
    public partial class FacilityFeudClient : Form
    {
        public FacilityFeudClient()
        {
            InitializeComponent();
        }
        Thread listenerThread;
        UdpClient listener;
        IPEndPoint listenerEP;
        System.Timers.Timer conStatTimer;
        System.Timers.Timer pingTimer;

        bool max;

        void listen()
        {
            while (listenerThread.ThreadState == ThreadState.Running)
            {
                byte[] buf;
                try
                {
                    buf = listener.Receive(ref listenerEP);
                    string data = Encoding.ASCII.GetString(buf);
                    if (data == "v")
                    {
                        pictureBox1.BackColor = Color.Green;
                        conStatTimer.Stop();
                        conStatTimer.Start();
                    }
                    else if (data == "di")
                    {
                        this.BackColor = Color.Green;
                    }
                    else if (data == "r")
                    {
                        this.BackColor = Color.White;
                    }
                }
                catch (Exception ex) { }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            conStatTimer = new System.Timers.Timer(5000);
            conStatTimer.Elapsed += new System.Timers.ElapsedEventHandler(timer1_Tick);

            pingTimer = new System.Timers.Timer(3000);
            pingTimer.Elapsed += new System.Timers.ElapsedEventHandler(ping);

            listenerEP = new IPEndPoint(IPAddress.Any, 7472);
            listener = new UdpClient(7472);
            listenerThread = new Thread(new ThreadStart(delegate { listen(); }));
            listenerThread.Start();

            max = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listenerEP.Address = IPAddress.Parse(tbHostIp.Text);
            byte[] packet = Encoding.ASCII.GetBytes("c");
            listener.Send(packet, packet.Length, new IPEndPoint(listenerEP.Address, 7471));
            conStatTimer.Start();
            pingTimer.Start();
        }

        private void ping(object sender, EventArgs e)
        {
            byte[] packet = Encoding.ASCII.GetBytes("c");
            listener.Send(packet, packet.Length, new IPEndPoint(listenerEP.Address, 7471));
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Red;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.Control && e.KeyCode == Keys.Enter)
            {
                max = !max;
                if (max)
                {
                    this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    this.WindowState = FormWindowState.Maximized;
                }
                else
                {
                    this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
                    this.WindowState = FormWindowState.Normal;
                }

                return;
            }
            else if (e.Alt && e.Control && e.KeyCode == Keys.L)
            {
                cbTeam.Enabled = !cbTeam.Enabled;
                cbTeam.Visible = !cbTeam.Visible;
                tbHostIp.Enabled = !tbHostIp.Enabled;
                tbHostIp.Visible = !tbHostIp.Visible;
                label1.Visible = !label1.Visible;
                label3.Visible = !label3.Visible;
                bConnect.Visible = !bConnect.Visible;
            }
            try
            {
                byte[] packet = Encoding.ASCII.GetBytes("d,"+cbTeam.SelectedIndex);
                listener.Send(packet, packet.Length, new IPEndPoint(listenerEP.Address, 7471));
            }
            catch (Exception ex) 
            { 
            
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            listener.Close();
            listenerThread.Abort();
        }
    }
}
