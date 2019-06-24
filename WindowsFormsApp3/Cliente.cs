using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Cliente
    {
        public string nome;
        public string cpf;
        public string rg;
        public string endereco;
        public int idade;
        public int maioridade = 18;
        public bool EhMaiorDeIdade(int valor)
        {
            if (valor >= maioridade)
            {
                return true; //Isso só é possível pois método EhMaiorDeIdade devolve um valor bool antes do método.
            }
            return false;

        }
        
    }
}
