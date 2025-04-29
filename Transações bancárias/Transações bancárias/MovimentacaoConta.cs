using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transações_bancárias
{
    public interface IMovimentacaoConta
    {
        void Depositar(double valor);
        void Sacar(double valor);
    }
}
