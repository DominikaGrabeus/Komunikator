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
    public partial class Form1 : Form
    {
        public static Socket _clientSocket;
        public byte[] _buffer;
        public static string nick;
        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                 _clientSocket.BeginConnect(new IPEndPoint(IPAddress.Parse("192.168.43.131"), 8001), new AsyncCallback(ConnectCallback), _clientSocket);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (IsEmptyTextBox(textBox1, textBox2) == true)
            {
                Thread.Sleep(15);
                byte[] buffer1 = Encoding.ASCII.GetBytes(textBox1.Text + " " + textBox2.Text + " " + "SprawdzamyLogowanieTeraz");
                _clientSocket.BeginSend(buffer1, 0, buffer1.Length, SocketFlags.None, new AsyncCallback(SendCallback), null);

                _buffer = new byte[256];
                _clientSocket.BeginReceive(_buffer, 0, _buffer.Length, 0, new AsyncCallback(ReceiveCallback), _clientSocket);
            }
             
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
                    _clientSocket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(EndReceive), _clientSocket);
                    string text = Encoding.ASCII.GetString(_buffer);
                    int i = text.IndexOf('\0');
                    if (i >= 0) text = text.Substring(0, i);
                    if ("PoprawneLogowanieSuper" == text)
                    {
                        nick = textBox1.Text;
                        this.Invoke(new Action(() => this.Hide()));
                        Form2 f = new Form2();
                        f.ShowDialog();
                    }
                    if ("NiepoprawneLogowanieSuper" == text)
                    {
                        MessageBox.Show("Nieprawidłowy Nick lub Hasło. ", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Invoke(new Action(() => textBox1.Text = String.Empty));
                        textBox2.Invoke(new Action(() => textBox2.Text = String.Empty));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EndReceive (IAsyncResult ar)
        {
            _clientSocket.EndReceive(ar);
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                _clientSocket.BeginConnect(new IPEndPoint(IPAddress.Parse("192.168.43.131"), 8001), new AsyncCallback(ConnectCallback), _clientSocket);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Hide();
            Form3 f = new Form3();
            f.ShowDialog();
        }
        private void ConnectCallback(IAsyncResult ar)
        {
            try { }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
         public bool IsEmptyTextBox(TextBox text1, TextBox text2)
        {
            if (text1.Text.Length == 0)
            {
                MessageBox.Show("Wprowadź Nick", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                   if (text2.Text.Length == 0)
            {
                MessageBox.Show("Wprowadź Hasło", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
   
}
