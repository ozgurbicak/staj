using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2(User _user)
        {
            InitializeComponent();
            user = _user;
        }
        User user;
        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = $"Hoş geldiniz {user.userName}";
        }
    }
}
