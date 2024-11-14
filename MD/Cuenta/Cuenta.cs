
//CARMEN


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD
{
    public class Cuenta : ColeccionTitulares, IEquatable<Cuenta>
    {
        private string iban;
        private double saldo;
        private DateTime fechaApertura;
        private ColeccionTitulares titulares; //PREGUNTAR COMO PONER MÁXIMO 4 TITULARES

        //PRE: nombre y dni son cadenas de caracteres que representan el nombre y dni de un cliente.
        //POST: se crea un cliente con nombre y dni como atributos.

        /// <summary>
        /// PRE: iban es una cadena de caracteres que representa el iban de una cuenta, saldo es un número real que representa el saldo de una cuenta, fechaApertura es la fecha de apertura de una cuenta, titulares es la colección de titulares de una cuenta
        /// POST: crea una cuenta cuyo iban es IBAN, cuyo saldo es saldo, cuya fecha de apertura es fechaApertura y cuya colección de titulares es titulares
        /// </summary>
        /// <param name="iBAN"></param>
        /// <param name="saldo"></param>
        /// <param name="fechaApertura"></param>
        /// <param name="titulares"></param>
        public Cuenta (string IBAN, double saldo, DateTime fechaApertura, ColeccionTitulares titulares)
        {
            this.iban = IBAN;
            this.saldo = saldo;
            this.fechaApertura = fechaApertura;
            this.titulares = titulares;
        }

        /// <summary>
        /// PRE: ----
        /// POST: devuelve el iban de la cuenta
        /// </summary>
        public String Iban
        {
            get {return this.iban; }
        }

        /// <summary>
        /// PRE: ----
        /// POST: devuelve y establece el saldo de la cuenta
        /// </summary>
        public Double Saldo
        {
            get { return this.saldo; }
            set { this.saldo = value; }
        }

        /// <summary>
        /// PRE: ----
        /// POST: devuelve y establece la fecha de apertura
        /// </summary>
        public DateTime FechaApertura
        {
            get 
            {
                return this.fechaApertura;
            }
            set
            {
                this.fechaApertura = value;
            }
        }

        /// <summary>
        /// PRE: ----
        /// POST: devuelve y establece la colección de titulares
        /// </summary>
        public ColeccionTitulares Titulares
        {
            get
            {
                return this.Titulares;
            }
            set
            {
                this.Titulares = value;
            }
        }

        /// <summary>
        /// PRE: cliente es un Cliente que ha sido construido previamente y no figura como titular de la cuenta. La cuenta tiene un número de titulares menor que 4
        /// POST: añade el Cliente cliente a la colección de titulares de la cuenta
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public void anadirTitular(Cliente cliente)
        {
           this.titulares.Add(cliente);
        }

        /// <summary>
        /// PRE: cliente es un Cliente que ha sido previamente y figura como titular de la cuenta. El número de titulares de la cuenta es mayor que 1.
        /// POST: elimina el Cliente cliente de la colección de titulares de la cuenta
        /// </summary>
        /// <param name="cliente"></param>
        public void eliminarTitular(Cliente cliente)
        {
            this.titulares.Remove(cliente);
        }

        /// <summary>
        /// PRE: ----
        /// POST: devuelve una cadena de caracteres con el iban, el saldo, la fecha de apertura y la colección de titulares de la cuenta
        /// </summary>
        /// <returns></returns>
        public virtual string toString()
        {
            return ("IBAN" + this.iban + "\n Saldo" + this.saldo + "\n Fecha de apertura" + this.fechaApertura + "\n Titulares" + this.titulares);
        }

        /// <summary>
        /// PRE: cuenta es una Cuenta que debe existir
        /// POST: devuelve false si cuenta es nula; y en caso contrario devuelve true si cuenta y this coinciden en iban.
        /// </summary>
        /// <param name="cuenta"></param>
        /// <returns></returns>
        public virtual bool Equals(Cuenta cuenta)
        {
            if (cuenta == null)
            { 
                return false;
            }
            else
            {
                return (this.iban.Equals(cuenta.iban));
            }

        }
    }
}
