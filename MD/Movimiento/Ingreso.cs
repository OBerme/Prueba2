using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD
{
    public class Ingreso : Movimiento, IEquatable<Ingreso>
    {

        public Ingreso(DateTime fechaRealizacion, double cantidad, Cuenta cuenta) : base(fechaRealizacion, cantidad, cuenta)
        {

        }

        public bool Equals(Ingreso other)
        {
            if (other == null) return false;
            return base.Equals(other);
        }

        public override string ToString()
        {
            return $"Ingreso: {base.ToString()}";
        }
    }
}
