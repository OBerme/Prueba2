using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD
{
    public class Reintegro : Movimiento, IEquatable<Reintegro>
    {
        public Reintegro(DateTime fechaRealizacion, double cantidad, Cuenta cuenta) : base(fechaRealizacion, cantidad, cuenta)
        {
        }

        public bool Equals(Reintegro other)
        {
            if (other == null) return false;
            return base.Equals(other);
        }

        public override string ToString()
        {
            return $"Reintegro: {base.ToString()}";
        }
    }

}
