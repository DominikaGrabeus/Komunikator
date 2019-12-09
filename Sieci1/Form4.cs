using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace Sieci1
{
    public partial class Form4 : Form
    {
        public byte[] _buffer = new byte[256];
        private Socket _clientSocket = Sieci1.Form1._clientSocket;
        
        public Form4()
        {
            InitializeComponent();
            Thread t = new Thread(new ThreadStart(receiving));
               t.Start();
        }
        private void receiving()
        {
            _clientSocket.BeginReceive(_buffer, 0, _buffer.Length, 0, new AsyncCallback(ReceiveCallback), _clientSocket);
        }
       
        
        private void wyjścieZProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Close();
        }

        private void powróToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void wylogujSięToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
        }
        
        private void SendCallback(IAsyncResult ar)
        {
            try
            {
               _clientSocket.EndSend(ar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string g = Sieci1.Form1.nick;
            byte[] buffer = Encoding.ASCII.GetBytes("WysylamNickDoSerwera" + " " + textBox3.Text + " " + g + " " + "pisze: " + textBox1.Text);
            _clientSocket.BeginSend(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(SendCallback), _clientSocket);
            Thread.Sleep(15);
            _clientSocket.BeginReceive(_buffer, 0, _buffer.Length, 0, new AsyncCallback(ReceiveCallback), _clientSocket);
            textBox1.Invoke(new Action(() => textBox1.Clear()));
            
        }
       
        private void ReceiveCallback(IAsyncResult ar)
        {
            try
            {
                int bytesRead = _clientSocket.EndReceive(ar);
                if (bytesRead == 0)
                {
                    return;
                }
                else
                {
                    _clientSocket.BeginReceive(_buffer, 0, _buffer.Length, 0, new AsyncCallback(ReceiveCallback), _clientSocket);
                    string text = Encoding.ASCII.GetString(_buffer);
                    string[] w = text.Split(' ');
                    string first = w[0];
                    string second = w[1];
                    var a = "BladNieMaTakiegoNicku";
                    if (second == "pisze:")
                    {
                        textBox2.Invoke(new Action(() => textBox2.Text = textBox2.Text + Environment.NewLine + text));
                    }
                    if (a == first)
                    {
                        MessageBox.Show("Nieprawidłowy Nick. ", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                Array.Clear(_buffer, 0, _buffer.Length);
                _clientSocket.BeginReceive(_buffer, 0, _buffer.Length, 0, new AsyncCallback(ReceiveCallback), _clientSocket);
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
       
    }
}
