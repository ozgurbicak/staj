using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wolfgame.Models;

namespace wolfgame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Account account = new Account();
        private void Seç_Click(object sender, EventArgs e)
        {
            account.userName = textBox1.Text;
            account.race = comboBox1.SelectedItem.ToString();
            account.branch = comboBox2.SelectedItem.ToString();
            account.weapon= textBox2.Text;
            changeState(false);
            changeVisible(true);
        }
        public void changeState(bool state)
        {
            textBox1.Enabled = state;
            textBox2.Enabled   =    state;  
            comboBox1 .Enabled = state; 
            comboBox2.Enabled = state;

        }
        public void changeVisible(bool isVisible)
        {
            pictureBox1.Visible = label5.Visible = button1.Visible = isVisible;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            account.Attack();
            label5.Width -= account.damage;
            MessageBox.Show($"Düşmana {account.damage} kadar hasar verdiniz.");
            if(label5.Width<= 0)
            {
                MessageBox.Show("Düşmanı Yendiniz");
                pictureBox1.Visible = false;
            }

        }
    }
}
