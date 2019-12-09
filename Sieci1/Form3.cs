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
    public partial class Form3 : Form
    {
        public static string nickk;
        private Socket _clientSocket = Sieci1.Form1._clientSocket;
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        { }
        
        private void button1_Click(object sender, EventArgs e)
        {
           
            if (textBox4.Text == textBox5.Text)
            {
                nickk = textBox3.Text;
                if (Check(textBox3.Text) == true)
                {
                    byte[] buffer = Encoding.ASCII.GetBytes("NowyUczestnikKomunikatora " + Environment.NewLine + textBox3.Text + Environment.NewLine + textBox4.Text);
                    byte[] buffer1 = Encoding.ASCII.GetBytes("NowyUczestnikDane " + Environment.NewLine + textBox1.Text + textBox2.Text + Environment.NewLine + textBox3.Text);
                    
                    _clientSocket.BeginSend(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(SendCallback), _clientSocket);
                    Thread.Sleep(150);
                    _clientSocket.BeginSend(buffer1, 0, buffer1.Length, SocketFlags.None, new AsyncCallback(SendCallback), _clientSocket);
                    this.Hide();
                    Form2 f = new Form2();
                    f.ShowDialog();
                }
            }
            if (textBox4.Text != textBox5.Text)
            {
                MessageBox.Show("Wprowadzone hasło jest niepoprawne ", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = String.Empty;
                textBox2.Text = String.Empty;
                textBox3.Text = String.Empty;
                textBox4.Text = String.Empty;
                textBox5.Text = String.Empty;
            }
        }

        private bool Check(string word)
        { 
            return true;
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
        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
    
}
