using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD
{
    public class ColeccionTitulares : KeyedCollection<string, Cliente2>
    {
        protected override string GetKeyForItem(Cliente2 cliente)
        {
            return cliente.DNI;
        }
    }
}
