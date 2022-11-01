using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteCalculadora
{
    public class Calculos
    {
        public int numero1, numero2, numeroAtivo;
        public string calculoAtiv;
        public int resultado = 0;
        
        public int soma(int numero1,int numero2)
        {
            numero1 = this.numero1;
            numero2 = this.numero2;
            return resultado = numero1 + numero2;
        }

        public int subtracao(int numero1, int numero2)
        {
            numero1 = this.numero1;
            numero2 = this.numero2;
            return resultado = numero1 - numero2;
        }

        public int divisao(int numero1, int numero2)
        {
            numero1 = this.numero1;
            numero2 = this.numero2;
            return resultado = numero1 / numero2;
        }

        public int multiplicacao(int numero1, int numero2)
        {
            numero1 = this.numero1;
            numero2 = this.numero2;
            return resultado = numero1 * numero2;
        }

        public string checarResultado()
        {
            switch (calculoAtiv)
            {
                case "soma":
                    soma(numero1, numero2);
                    return resultado.ToString();
                    break;

                case "subtracao":
                    subtracao(numero1, numero2);
                    return resultado.ToString();
                    break;

                case "divisao":
                    divisao(numero1, numero2);
                    return resultado.ToString();
                    break;

                case "multiplicacao":
                    multiplicacao(numero1, numero2);
                    return resultado.ToString();
                    break;

                default:
                    return "indefinido";
                    break;
            }
        }

        public void rodarConta()
        {
            checarResultado();
        }

    }
}
