using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Conta
    {
     //	numero,	titular	e	saldo	são	atributos	do	objeto
     public int numero;
     public string titular;
     public double saldo = 100; //100 é o valor inicial do saldo da conta.
     public bool Saca(double valor)
        {
            if (this.saldo >= valor)
            {
                this.saldo -= valor;
                return true; //Isso só é possível pois método Saca devolve um valor bool antes do método.
            }
             return false;
        }
    public void Deposita(double valor)
        {
            this.saldo += valor;
        }
    public void Transfere(double valor, Conta destino)
        {
            /*if(this.saldo >= valor)
            {
                this.saldo -= valor;
                destino.saldo += valor;
            }*/
            //outra maneira de fazer, jeito certo
            if (this.Saca(valor))
            {
                destino.Deposita(valor);
            }

        }
       
    }
}
