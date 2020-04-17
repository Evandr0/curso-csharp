using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calclulo_imc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            double peso, altura, imc;
            peso = Convert.ToDouble(txtPeso.Text);
            altura = Convert.ToDouble(txtAltura.Text);
            imc = peso / (altura * altura);
            txtImc.Text = imc.ToString();
            if (imc < 18.5)
            {
                MessageBox.Show("Você está com o IMC abaixo do normal. Magro demais!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (imc > 18.5 && imc < 25)
            {
                MessageBox.Show("Você está com o IMC Normal. Parabéns!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else if(imc >=25 && imc < 29.9)
            {
                MessageBox.Show("Você está com o IMC acima do normal. Sobrepeso! Obesidade grau I", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if( imc >= 30 && imc < 39.9)
            {
                MessageBox.Show("Você está com o IMC acima do normal. Sobrepeso! Obesidade grau II", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                MessageBox.Show("Você está com o IMC acima do normal. Sobrepeso! Obesidade grau III", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            /*IMC	CLASSIFICAÇÃO	OBESIDADE (GRAU)
            MENOR QUE 18,5	MAGREZA	0
            ENTRE 18,5 E 24,9	NORMAL	0
            ENTRE 25,0 E 29,9	SOBREPESO	I
            ENTRE 30,0 E 39,9	OBESIDADE	II
            MAIOR QUE 40,0	OBESIDADE GRAVE	III*/
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Text = "";
            txtImc.Text = "";
            txtPeso.Text = "";

        }
    }
}
