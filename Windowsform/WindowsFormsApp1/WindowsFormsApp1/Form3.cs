using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt1.Text.Length == 0)
            {

               MessageBox.Show("Lütfen sayı giriniz");
            }
            else if(Convert.ToInt32( txt1.Text) > 100) {
                MessageBox.Show("100 den küçük bir sayı giriniz");
            }
            else
            {
                int newOne = Convert.ToInt32(txt1.Text) + 1;
                txt1.Text = newOne.ToString();
            }
        }
        
    }
}
