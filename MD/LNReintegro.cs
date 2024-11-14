using MD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LN
{
    public class LNReintegro : LNMovimiento
    {
        private Reintegro reintegro;
        private Cliente cliente;

        public LNReintegro(Cliente cliente, Reintegro reintegro)
        {
            this.reintegro = reintegro;
            this.cliente = cliente;
        }

        public override void realizarMovimiento()
        {
            // Lógica para realizar el reintegro
            throw new NotImplementedException();
        }
    }
}
