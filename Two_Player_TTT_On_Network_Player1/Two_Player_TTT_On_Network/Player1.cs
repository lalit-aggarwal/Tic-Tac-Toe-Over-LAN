using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace Two_Player_TTT_On_Network
{
    public partial class Player1 : Form
    {
        public Player1()
        {
            InitializeComponent();
        }

        private void Player1_Load(object sender, EventArgs e)
        {
            leetSocket1.ServerIpAsDNS = getIP();
            MessageBox.Show("YOU ARE 'X'");
        }

        private string getIP()
        {
            string strHostName = System.Net.Dns.GetHostName();
            IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(strHostName);
            IPAddress[] addr = ipEntry.AddressList;
            return addr[addr.Length - 1].ToString();

        }

        private void XWin()
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                MessageBox.Show("Player X Won");
                label5.Text = (Convert.ToInt32(label5.Text) + 1).ToString();
                leetSocket1.sendObject("TRUEX");
                restart();
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                MessageBox.Show("Player X Won");
                label5.Text = (Convert.ToInt32(label5.Text) + 1).ToString();
                leetSocket1.sendObject("TRUEX");
                restart();
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("Player X Won");
                label5.Text = (Convert.ToInt32(label5.Text) + 1).ToString();
                leetSocket1.sendObject("TRUEX");
                restart();
            }
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("Player X Won");
                label5.Text = (Convert.ToInt32(label5.Text) + 1).ToString();
                leetSocket1.sendObject("TRUEX");
                restart();
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                MessageBox.Show("Player X Won");
                label5.Text = (Convert.ToInt32(label5.Text) + 1).ToString();
                leetSocket1.sendObject("TRUEX");
                restart();
            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("Player X Won");
                label5.Text = (Convert.ToInt32(label5.Text) + 1).ToString();
                leetSocket1.sendObject("TRUEX");
                restart();
            }
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("Player X Won");
                label5.Text = (Convert.ToInt32(label5.Text) + 1).ToString();
                leetSocket1.sendObject("TRUEX");
                restart();
            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("Player X Won");
                label5.Text = (Convert.ToInt32(label5.Text) + 1).ToString();
                leetSocket1.sendObject("TRUEX");
                restart();
            }
            if (button1.Text != " " && button2.Text != " " && button3.Text != " " && button4.Text != " " && button5.Text != " " && button6.Text != " " && button7.Text != " " && button8.Text != " " && button9.Text != " ")
            {
                MessageBox.Show("MATCH DRAWN");
                leetSocket1.sendObject("DRAWN");
                restart();
            }
        }

        private void OWin()
        {
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                MessageBox.Show("Player O Won");
                label6.Text = (Convert.ToInt32(label6.Text) + 1).ToString();
                leetSocket1.sendObject("TRUEO");
                restart();
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                MessageBox.Show("Player O Won");
                label6.Text = (Convert.ToInt32(label6.Text) + 1).ToString();
                leetSocket1.sendObject("TRUEO");
                restart();
            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("Player O Won");
                label6.Text = (Convert.ToInt32(label6.Text) + 1).ToString();
                leetSocket1.sendObject("TRUEO");
                restart();
            }
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("Player O Won");
                label6.Text = (Convert.ToInt32(label6.Text) + 1).ToString();
                leetSocket1.sendObject("TRUEO");
                restart();
            }
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                MessageBox.Show("Player O Won");
                label6.Text = (Convert.ToInt32(label6.Text) + 1).ToString();
                leetSocket1.sendObject("TRUEO");
                restart();
            }
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("Player O Won");
                label6.Text = (Convert.ToInt32(label6.Text) + 1).ToString();
                leetSocket1.sendObject("TRUEO");
                restart();
            }
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("Player O Won");
                label6.Text = (Convert.ToInt32(label6.Text) + 1).ToString();
                leetSocket1.sendObject("TRUEO");
                restart();
            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("Player O Won");
                label6.Text = (Convert.ToInt32(label6.Text) + 1).ToString();
                leetSocket1.sendObject("TRUEO");
                restart();
            }
            if (button1.Text != " " && button2.Text != " " && button3.Text != " " && button4.Text != " " && button5.Text != " " && button6.Text != " " && button7.Text != " " && button8.Text != " " && button9.Text != " ")
            {
                MessageBox.Show("MATCH DRAWN");
                leetSocket1.sendObject("DRAWN");
                restart();
            }
        }

        private void restart()
        {
            button1.Text = " ";
            button1.Enabled = true;
            button2.Text = " ";
            button2.Enabled = true;
            button3.Text = " ";
            button3.Enabled = true;
            button4.Text = " ";
            button4.Enabled = true;
            button5.Text = " ";
            button5.Enabled = true;
            button6.Text = " ";
            button6.Enabled = true;
            button7.Text = " ";
            button7.Enabled = true;
            button8.Text = " ";
            button8.Enabled = true;
            button9.Text = " ";
            button9.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label4.Text == "X")
            {
                leetSocket1.sendObject("1X");
                label4.Text = "O";
                button1.Text = "X";
                button1.Enabled = false;
            }
            else
                MessageBox.Show("NOT YOUR TURN");
            XWin();
            OWin();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label4.Text == "X")
            {
                leetSocket1.sendObject("2X");
                label4.Text = "O";
                button2.Text = "X";
                button2.Enabled = false;
            }
            else
                MessageBox.Show("NOT YOUR TURN");
            XWin();
            OWin();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label4.Text == "X")
            {
                leetSocket1.sendObject("3X");
                label4.Text = "O";
                button3.Text = "X";
                button3.Enabled = false;
            }
            else
                MessageBox.Show("NOT YOUR TURN");
            XWin();
            OWin();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label4.Text == "X")
            {
                leetSocket1.sendObject("4X");
                label4.Text = "O";
                button4.Text = "X";
                button4.Enabled = false;
            }
            else
                MessageBox.Show("NOT YOUR TURN");
            XWin();
            OWin();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label4.Text == "X")
            {
                leetSocket1.sendObject("5X");
                label4.Text = "O";
                button5.Text = "X";
                button5.Enabled = false;
            }
            else
                MessageBox.Show("NOT YOUR TURN");
            XWin();
            OWin();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (label4.Text == "X")
            {
                leetSocket1.sendObject("6X");
                label4.Text = "O";
                button6.Text = "X";
                button6.Enabled = false;
            }
            else
                MessageBox.Show("NOT YOUR TURN");
            XWin();
            OWin();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (label4.Text == "X")
            {
                leetSocket1.sendObject("7X");
                label4.Text = "O";
                button7.Text = "X";
                button7.Enabled = false;
            }
            else
                MessageBox.Show("NOT YOUR TURN");
            XWin();
            OWin();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (label4.Text == "X")
            {
                leetSocket1.sendObject("8X");
                label4.Text = "O";
                button8.Text = "X";
                button8.Enabled = false;
            }
            else
                MessageBox.Show("NOT YOUR TURN");
            XWin();
            OWin();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (label4.Text == "X")
            {
                leetSocket1.sendObject("9X");
                label4.Text = "O";
                button9.Text = "X";
                button9.Enabled = false;
            }
            else
                MessageBox.Show("NOT YOUR TURN");
            XWin();
            OWin();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            restart();
            label4.Text = "X";
            leetSocket1.sendObject("RESTART");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            restart();
            label4.Text = "X";
            label5.Text = "0";
            label6.Text = "0";
            leetSocket1.sendObject("NEW GAME");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            leetSocket1.sendObject("EXIT");
            Application.Exit();
        }

        private void leetSocket1_OnReceiveCompletedDataEVENT(object value, byte[] bArray)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new MethodInvoker(delegate() { leetSocket1_OnReceiveCompletedDataEVENT(value, bArray); }));
                return;
            }
            string rec = (string)value;
            if (rec == "1O")
            {
                button1.Text = "O";
                button1.Enabled = false;
                label4.Text = "X";
            }
            if (rec == "2O")
            {
                button2.Text = "O";
                button2.Enabled = false;
                label4.Text = "X";
            }
            if (rec == "3O")
            {
                button3.Text = "O";
                button3.Enabled = false;
                label4.Text = "X";
            }
            if (rec == "4O")
            {
                button4.Text = "O";
                button4.Enabled = false;
                label4.Text = "X";
            }
            if (rec == "5O")
            {
                button5.Text = "O";
                button5.Enabled = false;
                label4.Text = "X";
            }
            if (rec == "6O")
            {
                button6.Text = "O";
                button6.Enabled = false;
                label4.Text = "X";
            }
            if (rec == "7O")
            {
                button7.Text = "O";
                button7.Enabled = false;
                label4.Text = "X";
            }
            if (rec == "8O")
            {
                button8.Text = "O";
                button8.Enabled = false;
                label4.Text = "X";
            }
            if (rec == "9O")
            {
                button9.Text = "O";
                button9.Enabled = false;
                label4.Text = "X";
            }
            if (rec == "TRUEX")
            {
                label5.Text = (Convert.ToInt32(label5.Text) + 1).ToString();
                restart();
            }
            if (rec == "TRUEO")
            {
                label6.Text = (Convert.ToInt32(label6.Text) + 1).ToString();
                restart();
            }
            if (rec == "RESTART")
            {
                restart();
                label4.Text = "X";
            }
            if (rec == "DRAWN")
            {
                restart();
            }
            if (rec == "NEW GAME")
            {
                restart();
                label4.Text = "X";
                label5.Text = "0";
                label6.Text = "0";
            }
            if (rec == "EXIT")
            {
                Application.Exit();
            }
        }
    }
}
