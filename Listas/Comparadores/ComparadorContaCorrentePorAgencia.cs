using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Listas.Comparadores
{
    class ComparadorContaCorrentePorAgencia : IComparer<ContaCorrente>
    {
        public int Compare([AllowNull] ContaCorrente x, [AllowNull] ContaCorrente y)
        {
            //if (x == y)
            //{
            //    return 1;
            //}
            //if (x == null)
            //{
            //    return 1;
            //}
            //if(y == null)
            //{
            //    return -1;
            //}
            //if(x.Agencia < y.Agencia)
            //{
            //    return -1;
            //}
            //if(x.Agencia > y.Agencia)
            //{
            //    return 0;
            //}
            //else
            //{
            //    return 1;
            //}
            return x.Agencia.CompareTo(y.Agencia);
            //nossas comparações de numeros inteiros é equivalente ao que ja existe no tipo Int
        }
    }
}
