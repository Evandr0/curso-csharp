using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Condição_if
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            int idade;
            idade = Convert.ToInt32(txtIdade.Text);
            if (idade >= 18)
            {
                MessageBox.Show("Você é maior de idade", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("Você é meno de idade", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
