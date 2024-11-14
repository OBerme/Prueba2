using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD
{
    public class CuentaBonificada : Cuenta
    {
        /// <summary>
        /// PRE: iban es una cadena de caracteres que representa el iban de una cuenta, saldo es un número real mayor o igual que -100 que representa el saldo de una cuenta, fechaApertura es la fecha de apertura de una cuenta, titulares es la colección de titulares de una cuenta joven
        /// POST: crea una cuenta bonificada cuyo iban es IBAN, cuyo saldo es saldo, cuya fecha de apertura es fechaApertura y cuya colección de titulares es titulares
        /// </summary>
        /// <param name="iban"></param>
        /// <param name="saldo"></param>
        /// <param name="fechaApertura"></param>
        /// <param name="titulares"></param>
        public CuentaBonificada(string IBAN, double saldo, DateTime fechaApertura, ColeccionTitulares titulares) : base(IBAN, saldo, fechaApertura, titulares)
        {

        }

        /// <summary>
        /// PRE: saldo es un número real mayor o igual que -100
        /// POST: devuelve y establece el saldo de la cuenta
        /// </summary>
        public double Saldo
        {
            get
            {
                return this.Saldo;
            }
            set
            {
                this.Saldo = value;
            }
        }

        /// <summary>
        /// PRE: cuenta es una Cuenta que debe existir
        /// POST: devuelve false si cuenta es nula; y en caso contrario devuelve true si cuenta y this coinciden en iban.
        /// </summary>
        /// <param name="cuenta"></param>
        /// <returns></returns>
        public override bool Equals(Cuenta cuenta)
        {
            if (cuenta == null)
            {
                return false;
            }
            else
            {
                return base.Iban.Equals(cuenta.Iban) && this.Iban.Equals(cuenta.Iban);
            }
        }

        /// <summary>
        /// PRE: ----
        /// POST: devuelve una cadena de caracteres con el iban, el saldo, la fecha de apertura y la colección de titulares de la cuenta bonificada
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString();
        }

      

    }
}
