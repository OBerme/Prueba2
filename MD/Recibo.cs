using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD
{
    public class Recibo : Movimiento, IEquatable<Recibo>
    {
        private int codigo;
        private Cuenta cuentaDest;

        /// <summary>
        /// PRE: El codigo tiene que ser unico para este recibo
        /// POST: devuelve y establece el codigo del Recibo
        /// </summary>
        public int Codigo { get=> codigo; set => codigo = value; }

        /// <summary>
        /// PRE: La cuenta de destino tiene que ser diferente a la cuenta origen
        /// POST: devuelve la cuenta de destino del Recibo
        /// </summary>
        public Cuenta CuentaDestino { get => cuentaDest; }

        

        public Recibo(DateTime fechaRealizacion, double cantidad, Cuenta cuenta, int codigo, Cuenta cuentaDestino) : base(fechaRealizacion, cantidad, cuenta)
        {
            this.codigo = codigo;
            this.cuentaDest = cuentaDestino;
        }

        public bool Equals(Recibo other)
        {
            if (other == null) return false;
            return base.Equals(other) && codigo == other.Codigo && cuentaDest.Equals(other.CuentaDestino);
        }

        public override string ToString()
        {
            return $"Recibo: {base.ToString()}, Codigo: {codigo}, CuentaDestino: {cuentaDest}";
        }
    }
}
