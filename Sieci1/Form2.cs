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
    public partial class Form2 : Form
    {
        public byte[] _buffer = new byte[256];
        private Socket _clientSocket = Sieci1.Form1._clientSocket;
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        { }
        

        private void wyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string k = Sieci1.Form3.nickk;
            byte[] buffer2= Encoding.ASCII.GetBytes("TylkoNick" +" " + k);
            Thread.Sleep(150);
            _clientSocket.BeginSend(buffer2, 0, buffer2.Length, SocketFlags.None, new AsyncCallback(SendCallback), _clientSocket);
            this.Hide();
            Form4 f = new Form4();
            f.ShowDialog();
        }

        private void wylogujSięToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Close();
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

        private void dodajZnajomegoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
             byte[] buffer1 = Encoding.ASCII.GetBytes(toolStripTextBox2.Text + toolStripTextBox4.Text + " " + "DodajNowegoZnajomegoProsze");
                Thread.Sleep(15);
                _clientSocket.BeginSend(buffer1, 0, buffer1.Length, SocketFlags.None, new AsyncCallback(SendCallback), _clientSocket);
                Thread.Sleep(15);
                _clientSocket.BeginReceive(_buffer, 0, _buffer.Length, 0, new AsyncCallback(ReceiveCallback), _clientSocket);
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
                {  _clientSocket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), _clientSocket);
                    string text = Encoding.ASCII.GetString(_buffer);
                    int i = text.IndexOf('\0');
                    if (i >= 0) text = text.Substring(0, i);
                    var a = "Blad";
                     if (a == text)
                    {
                        MessageBox.Show("Nie istnieje konto o podanym Imieniu i Nazwisku. ", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                     else
                     richTextBox1.Invoke(new Action(() => richTextBox1.Text = richTextBox1.Text + Environment.NewLine + text));
                     Array.Clear(_buffer, 0, _buffer.Length);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        
    }

}
