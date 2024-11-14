using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD
{
    public class ColeccionTitulares : KeyedCollection<string, Cliente>
    {
        protected override string GetKeyForItem(Cliente cliente)
        {
            return cliente.DNI;
        }
    }
}
