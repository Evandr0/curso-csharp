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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int idadeJoao = 10, idademMaria = 25, idadeEvandro = 33, media;
            media = (idadeJoao + idademMaria + idadeEvandro) / 3;
            MessageBox.Show("A média de idade é:" + media);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            double pi = 3.14;
            int piQuebrado = (int)pi;
            MessageBox.Show("piQuebrado = " + piQuebrado);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            int a = 2, b = 3, c = 4;
            double delta, a1, a2, rdelta;
            delta = (b * b) - (4 * a * c);
            rdelta = Math.Sqrt(delta);
            a1 = (-b + rdelta) / (2 * a);
            a2 = (-b - rdelta) / (2 * a);
            uint a11 = (uint)a1;
            MessageBox.Show("teste" + a11);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            double saldo = 100.0;
            double valorSaque = 10.0;
            if (saldo >= valorSaque)
            {
                saldo -= valorSaque;
                MessageBox.Show("Saque realizado com sucesso. Seu saldo é de: R$" + saldo);
            }
            else
            {
                MessageBox.Show("Saldo Insuficiente");
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            int idade = 16;
            bool brasileira = true;
            if (idade >= 16 && brasileira)
            {
                MessageBox.Show("Você pode votar");
            }
            else
            {
                MessageBox.Show("Você não pode votar");
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            double valorInvestido = 1000.0;
            for (int i = 1; i <= 12; i += 1)
            {
                valorInvestido = valorInvestido * 1.01;
            }
            MessageBox.Show("Valor investido agora é " + valorInvestido);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            int i = 1;
            for (i = 1; i <=1000; i+=1)
            {
                i++;
                MessageBox.Show("soma é: i");
            }
        }
    }
}
