using MD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LN
{
    public class LNIngreso : LNMovimiento
    {
        private Ingreso ingreso;
        private Cliente cliente;

        public LNIngreso(Cliente cliente, Ingreso ingreso)
        {
            this.ingreso = ingreso;
            this.cliente = cliente;
        }

        public override void realizarMovimiento()
        {
            // Lógica para realizar el ingreso
            throw new NotImplementedException();
        }
    }
}
