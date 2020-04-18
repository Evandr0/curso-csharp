using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabuada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            int numero, resultado, i;
            i = 1;
            numero = int.Parse(txtNumero.Text);
            while (i <= 10)
            {
                resultado = i * numero;
                lstTabuada.Items.Add(String.Concat(numero, "*", i, " = ", resultado));
                i = i + 1;
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            lstTabuada.Items.Clear();
            txtNumero.Clear();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
