﻿using System;
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
            Conta c1 = new Conta();
            c1.numero = 1;
            c1.saldo = 1000;
            c1.titular = "Evandro Pereira Dias";
            c1.Saca(100);
            MessageBox.Show("Valor de Saldo de c1 é: " + c1.saldo  +"\nNumero de c1 é: " + c1.numero +"\nTitular de c1 é: " + c1.titular);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Conta c1 = new Conta();
            c1.numero = 1;
            c1.saldo = 1000;
            c1.titular = "Evandro Pereira Dias";
            bool deuCerto = c1.Saca(100.0);
           /*if(deuCerto)
                {
                    MessageBox.Show("Saque realizado com sucesso");
                }
                else
                {
                    MessageBox.Show("Saldo insuficiente");
                }*/
            //outra maneira de fazer
            if(c1.Saca(100))
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
            Conta c1 = new Conta();
            c1.Deposita(100);
        }
    }
}