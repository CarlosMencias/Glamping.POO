using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Programa
{
    public class Precios : Clientes
    {
        public decimal _precio;

        public Precios()
        {
            _precio = 5;
        }
        public decimal Precio 
        { 
            get => _precio; 
            set => _precio = (value); 
        }

        public override decimal GetValueToPay()
        {
            return (decimal)Huespedes * Precio;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                   $"Precio por persona......:{Precio,20}\n" +
                   $"Total a pagar...........:{GetValueToPay(),20}\n";



        }
    }


}
