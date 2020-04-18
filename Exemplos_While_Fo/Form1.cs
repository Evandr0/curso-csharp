using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplos_While_Fo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int contador;
            for (contador = 2020; contador >= 1900; contador--)
            {
                cboAno.Items.Add(contador);
            }
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            Form2 novo = new Form2();
            novo.Show();
            this.Visible = false;
        }

        private void LblAno_Click(object sender, EventArgs e)
        {

        }

        private void CboAno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
