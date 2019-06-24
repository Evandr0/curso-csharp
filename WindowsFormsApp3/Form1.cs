using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Conta conta1 = new Conta();
            Cliente cliente1 = new Cliente();
            cliente1.nome = "Evandro Pereira Dias";
            conta1.titular = cliente1;
            conta1.numero = 1;
            conta1.saldo = 1000;
            
            //conta1.titular.nome = "Evandro Pereira Dias";
            conta1.Saca(100);
            MessageBox.Show("Valor de Saldo de conta1 é: " + conta1.saldo  +"\nNumero de conta1 é: " + conta1.numero + "\nNome do titular da conta é: " + conta1.titular.nome);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Conta conta1 = new Conta();
            Cliente cliente1 = new Cliente();
            cliente1.nome = "Evandro";
            conta1.numero = 1;
            conta1.saldo = 1000;
            
            conta1.titular = cliente1;
            bool deuCerto = conta1.Saca(100.0);
           /*if(deuCerto)
                {
                    MessageBox.Show("Saque realizado com sucesso");
                }
                else
                {
                    MessageBox.Show("Saldo insuficiente");
                }*/
            //outra maneira de fazer
            if(conta1.Saca(100))
                {
                    MessageBox.Show("Saque realizado com sucesso");
                }
                else
                {
                    MessageBox.Show("Saldo insuficiente");
                }
           

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Conta conta1 = new Conta();
            conta1.Deposita(100);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Conta conta1 = new Conta();
            Cliente cliente1 = new Cliente();
            cliente1.nome = "Victor_nome";
            conta1.titular = cliente1;
            conta1.numero = 1;
            conta1.saldo = 100.0;
            conta1.Deposita(100);
            cliente1.rg = "062565739-00";
            MessageBox.Show("Saldo é: " + conta1.saldo + "\nNome do cliente " + conta1.titular.nome + "\nRG " + cliente1.rg);

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Conta conta2 = new Conta();
            Cliente cliente2 = new Cliente();
            conta2.numero = 2;
            cliente2.nome = "Evandro";
            conta2.titular = cliente2;
            cliente2.idade = 55;
            if (cliente2.EhMaiorDeIdade(cliente2.idade))
            {
                MessageBox.Show("Cliente é maior de idade");
            }
            else
            {
                MessageBox.Show("Cliente é menor de idade");
            }
        }
    }
}
