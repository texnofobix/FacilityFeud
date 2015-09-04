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
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Threading;
using System.Net;
using System.Media;
using System.IO;

namespace FacultyFeudHost
{
    class ClientManager
    {
        bool dialedIn;
        SoundPlayer dial;

        UdpClient listener;
        Thread listenerThread;
        IPEndPoint listenerEP;
        List<IPEndPoint> clients;

        playManage p;
        
        
        //port 7471 used by host
        //port 7472 used by client

        public void listen(UdpClient l, IPEndPoint lEP)
        {
            while (listenerThread.ThreadState == ThreadState.Running)
            {
                byte[] buf = l.Receive(ref lEP);
                string v = Encoding.ASCII.GetString(buf);
                if (v == "c")
                {
                    //requesting connection ack packet
                    byte[] packet = Encoding.ASCII.GetBytes("v");
                    listener.Send(packet, packet.Length, new IPEndPoint(lEP.Address, 7472));
                    bool g = true;
                    foreach (IPEndPoint ep in clients)
                    {
                        if (ep.Address == lEP.Address)
                        {
                            g = false;
                            break;
                        }
                    }

                    if (g)
                        clients.Add(lEP);
                }
                else if (v.Contains('d'))
                {
                    if (dialedIn)
                        continue;

                    string[] vals = v.Split(',');

                    //dialing in
                    dial.Play();
                    dialedIn = true;
                    byte[] packet = Encoding.ASCII.GetBytes("di");
                    listener.Send(packet, packet.Length, new IPEndPoint(lEP.Address, 7472));

                    if (vals[1] == "0")
                    {
                        p.lftBox.BackColor = System.Drawing.Color.Green;
                        p.rtBox.BackColor = System.Drawing.Color.White;
                        //p.showWindow(true);
                        //p.bLeftControl_Click(null, null);
                    }
                    else if (vals[1] == "1")
                    {
                        p.rtBox.BackColor = System.Drawing.Color.Green;
                        p.lftBox.BackColor = System.Drawing.Color.White;
                        //p.showWindow(false);
                    }
                }
            }
        }
        public ClientManager(playManage p)
        {
            this.p = p;

            dialedIn = false;
            dial = new SoundPlayer(Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) + "\\sounds\\ff-ringin.wav");

            clients = new List<IPEndPoint>();
            try
            {
                listener = new UdpClient(7471);
                listenerEP = new IPEndPoint(IPAddress.Any, 7471);
                listenerThread = new Thread(new ThreadStart(delegate { this.listen(listener, listenerEP); }));
                listenerThread.Start();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Error Starting Client Manager");
                listener = null;
                listenerEP = null;
                listenerThread = null;
            }
        }

        public void clearDial()
        {
            dialedIn = false;
            byte[] packet = Encoding.ASCII.GetBytes("r");
            for (int i = 0; i < clients.Count; i++)
            {
                listener.Send(packet, packet.Length, clients[i]);
            }
        }

        public void terminate()
        {
            if (listener != null)
                listener.Close();
            if (listenerThread != null)
                listenerThread.Abort();
        }
    }
}
