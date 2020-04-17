using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_Media
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void TxtNota1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double nota1, nota2, nota3, media;
            nota1 = Convert.ToDouble(txtNota1.Text);
            nota2 = Convert.ToDouble(txtNota2.Text);
            nota3 = Convert.ToDouble(txtNota3.Text);
            media = (nota1 + nota2 + nota3) / 3;
            txtMedia.Text = media.ToString();

            if (media > 7)
            {
                MessageBox.Show("O Aluno está aprovado!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("A aluno está reprovado!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtNota1.Text = "";
            txtNota2.Text = "";
            txtNota3.Text = "";
            txtMedia.Text = "";

        }
    }
}
