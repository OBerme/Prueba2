
//OSCAR


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD
{
    public class Movimiento : IEquatable<Movimiento>
    {
        protected DateTime fechaRealizacion;
        protected double cantidad;
        protected Cuenta cuenta;

        /// <summary>
        /// PRE: ----
        /// POST: devuelve y establece la fecha del movimiento
        /// </summary>
        public DateTime FechaRealizacion { get => fechaRealizacion; set => fechaRealizacion = value }

        /// <summary>
        /// PRE: La cuenta tiene que existir y tener un titular
        /// POST: devuelve la cuenta del movimiento
        /// </summary>
        public Cuenta Cuenta { get => cuenta; }

        /// <summary>
        /// PRE: Cantidad tiene que ser mayor que 0
        /// POST: devuelve y establece la cantidad del recibo
        /// </summary>
        public double Cantidad { get => cantidad; set => cantidad = value; }

        public Movimiento(DateTime fechaRealizacion, double cantidad, Cuenta cuenta)
        {
            this.fechaRealizacion = fechaRealizacion;
            this.cantidad = cantidad;
            this.cuenta = cuenta;
        }

        public bool Equals(Movimiento other)
        {
            if (other == null) return false;
            return fechaRealizacion == other.FechaRealizacion && cuenta.Equals(other.Cuenta);
        }

        public override string ToString()
        {
            return $"Fecha: {fechaRealizacion}, Cantidad: {cantidad}, Cuenta: {cuenta}";
        }
    }
}
