using Oop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.userName = textBox1.Text;
            user.password = textBox2.Text;
            string loginDate = DateTime.Now.ToString();
            user.Login(loginDate);
            User user2 = new User();
            user2.userName = textBox1.Text;
            user2.password = textBox2.Text;
            user2.Login(loginDate);

        }
    }
}
