using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projects
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        Random random = new Random();

        private void btnGuess_Click(object sender, EventArgs e)
        {
            string[] questions = { "Yes", "No" };
            string question = "";
            DialogResult result;
            do
            {
                int number = random.Next(0, 2);
                question = questions[number];
               result = MessageBox.Show("Yazı mı? Tura mı ?\n Yazı ise Yes\n Tura ise No seçeneğini seçiniz.", "Soru", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            } while (result.ToString() != question);
            MessageBox.Show("Kazandınız");
        }
       
    }
}
