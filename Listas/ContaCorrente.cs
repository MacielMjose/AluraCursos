using System;
using System.Collections.Generic;
using System.Text;

namespace Listas
{
    public class ContaCorrente:IComparable
    {
        public ContaCorrente(int agencia,int numero)
        {
            this.Agencia = agencia;
            this.Numero = numero;
        }
        public int Agencia { get;private set; }
        public int Numero { get;private set; }

        public int CompareTo(object obj)
        {
            //retornar negativo quando a instancia precede o obj
            //retornar zero quando a instancia e obj forem equivalentes
            //retornar positivo diferente de zero quando obj precede a instancia

            var outraConta = obj as ContaCorrente;

            if(outraConta == null)
            {
                return -1;
            }
            if(Agencia < outraConta.Agencia)
            {
                return -1;
            }
            if(Agencia == outraConta.Agencia)
            {
                return 0;
            }
            else
            {
                return 1;
            }

        }
    }
}
