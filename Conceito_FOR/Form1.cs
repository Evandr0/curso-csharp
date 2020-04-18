using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conceito_FOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnFor_Click(object sender, EventArgs e)
        {
            for (int contador = 0; contador < 5; contador++)
            {
                MessageBox.Show("O Valor de contado é: " + contador);
                //Console.WriteLine("O valor de contador é: " + contador); //executa o comando somente no console, para analise detalhada.
            }
        }
    }
}
