using MD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LN
{
    public class LNRecibo : LNMovimiento
    {
        private Recibo recibo;
        private Cliente cliente;

        public LNRecibo(Recibo recibo, Cliente cliente)
        {
            this.recibo = recibo;
            this.cliente = cliente;
        }

        public override void realizarMovimiento()
        {
            throw new NotImplementedException();
        }
    }
}
