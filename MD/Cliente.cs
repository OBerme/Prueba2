
//ANA 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD
{
    public class Cliente : IEquatable<Cliente> 
    {
        private String nombre; //Nombre del cliente
        private String dni; //DNI del cliente

        //PRE: nombre y dni son cadenas de caracteres que representan el nombre y dni de un cliente.
        //POST: se crea un cliente con nombre y dni como atributos.
        public Cliente(String nombre, String dni)
        {
            this.nombre = nombre;
            this.dni = dni;
        }
        
        //PRE: ---
        //POST: propiedad que devuelve o modifica el nombre del cliente.
        public String Nommbre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }


        //PRE: --
        //POST: devuelve el DNI del cliente
        public String DNI
        {
            get
            {
                return this.dni;
            }
        }


        //PRE: ---
        //POST: devuelve una cadena de caracteres con el nombre y el dni del cliente.
        public override string ToString()
        {
            return ("dni" + this.dni + "\n nombre:" + this.nombre);
        }


        //PRE: other es un cliente que debe exisitir
        //POST: devuelve true si ambos cleitne coinciden en nombre y dni y falso en caso contrario.
        public bool Equals(Cliente other) 
        {
            if (other == null)
            {
                return false;
            }
            else
            {
                return this.nombre.Equals(other.nombre) && this.dni.Equals(other.dni);
            }
        
        }

    }

}
