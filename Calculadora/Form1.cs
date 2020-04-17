using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //declração de variaveis do tipo double, num1, num2, resultado.
            double num1, num2, resultado;
            //convertToDouble é necessário para que seja convertido o conteudo do textbox para número
            num1 = Convert.ToDouble(textNum1.Text);
            num2 = Convert.ToDouble(textNum2.Text);
            resultado = num1 * num2;

            //variavel resultado é convertido em texto novamente e colocada na textbox textResultado.
            textResultado.Text = resultado.ToString();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            textNum1.Text = "";
            textNum2.Text = "";
            textResultado.Text = "";
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSomar_Click(object sender, EventArgs e)
        {
            //declração de variaveis do tipo double, num1, num2, resultado.
            double num1, num2, resultado;
            //convertToDouble é necessário para que seja convertido o conteudo do textbox para número
            num1 = Convert.ToDouble(textNum1.Text);
            num2 = Convert.ToDouble(textNum2.Text);
            resultado = num1 + num2;

            //variavel resultado é convertido em texto novamente e colocada na textbox textResultado.
            textResultado.Text = resultado.ToString();

        }

        private void BtnSubtrair_Click(object sender, EventArgs e)
        {
            //declração de variaveis do tipo double, num1, num2, resultado.
            double num1, num2, resultado;
            //convertToDouble é necessário para que seja convertido o conteudo do textbox para número
            num1 = Convert.ToDouble(textNum1.Text);
            num2 = Convert.ToDouble(textNum2.Text);
            resultado = num1 - num2;

            //variavel resultado é convertido em texto novamente e colocada na textbox textResultado.
            textResultado.Text = resultado.ToString();
        }

        private void BtnDividir_Click(object sender, EventArgs e)
        {
            //declração de variaveis do tipo double, num1, num2, resultado.
            double num1, num2, resultado;
            //convertToDouble é necessário para que seja convertido o conteudo do textbox para número
            num1 = Convert.ToDouble(textNum1.Text);
            num2 = Convert.ToDouble(textNum2.Text);
            resultado = num1 / num2;

            //variavel resultado é convertido em texto novamente e colocada na textbox textResultado.
            textResultado.Text = resultado.ToString();
        }
    }
}
