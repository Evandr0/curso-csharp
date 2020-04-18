using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[4]; //Declara variave e instancia vetor.

            //atribuir valores aos vetores.
            vetor[0] = 7;
            vetor[1] = 3;
            vetor[2] = 5;
            vetor[3] = 1;
            //int valor = vetor[1]; //Declara variavel valor para acessar o vetor.(Neste caso não precisa isso para rodar este programa)
            System.Array.Sort(vetor); //ordena o valor do vetor por ordem crescente.

            for (int index = 0; index < 4; index++)
            {
                MessageBox.Show(vetor[index].ToString(), "Array");
            }
                
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string[] semana = new string[7];
            semana[0] = "Domingo";
            semana[1] = "Segunda-Feira";
            semana[2] = "Terça-Feira";
            semana[3] = "Quarta-Feira";
            semana[4] = "Quinta-Feira";
            semana[5] = "Sexta-Feira";
            semana[6] = "Sábado";

            string valor = semana[1];
            for (int index = 0; index <= 6; index++)
                MessageBox.Show(semana[index].ToString(), "Array");
        }
    }
}
