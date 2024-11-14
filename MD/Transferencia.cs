using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD
{
    public class Transferencia : Movimiento, IEquatable<Transferencia>
    {
        private string concepto;
        private Cuenta cuentaDesti;
        /// <summary>
        /// PRE: ---
        /// POST: devuelve y establece el concepto de la transferencia
        /// </summary>
        public string Concepto { get => concepto; set => concepto =value; }
        
        /// <summary>
        /// PRE: La cuenta de destino tiene que ser diferente a la cuenta origen
        /// POST: devuelve la cuenta de destino del Transferencia
        /// </summary>
        public Cuenta CuentaDestino { get => cuentaDesti; }

        public Transferencia(DateTime fechaRealizacion, double cantidad, Cuenta cuenta, string concepto, Cuenta cuentaDestino) : base(fechaRealizacion, cantidad, cuenta)
        {
            this.concepto = concepto;
            this.cuentaDesti = cuentaDestino;
        }

        public bool Equals(Transferencia other)
        {
            if (other == null) return false;
            return base.Equals(other) && concepto == other.Concepto && cuentaDesti.Equals(other.CuentaDestino);
        }

        public override string ToString()
        {
            return $"Transferencia: {base.ToString()}, Concepto: {concepto}, CuentaDestino: {cuentaDesti}";
        }
    }
}

