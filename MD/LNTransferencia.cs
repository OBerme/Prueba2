using MD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LN
{
    public class LNTransferencia : LNMovimiento
    {
        private Transferencia trans;
        private Cliente cliente;

        public LNTransferencia(Transferencia trans, Cliente cliente)
        {
            this.trans = trans;
            this.cliente = cliente;
        }

        public override void realizarMovimiento()
        {
            throw new NotImplementedException();
        }
    }
}
