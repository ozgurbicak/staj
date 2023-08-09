using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        User user;
        private void Form1_Load(object sender, EventArgs e)
        {
            user = new User("abdullah", "123");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text;
            string password
            = textBox1.Text;    
            if(userName == user.userName && password == user.password)
            {
                Form2 login
                    = new Form2(user);

                login.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("error");
            }
        }
    }
}
