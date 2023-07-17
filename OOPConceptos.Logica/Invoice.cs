using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConceptos.Logica
{
    public class Invoice : IPay
    {
        public int Id
        { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public float Quantity { get; set; }
        public Employes Employee { get; set; }

        
        public decimal GetValueToPay()
        {
            return (decimal)Quantity * Price;
        }

        public override string ToString()
        {
            return $"{Id}\t{Description}\n\t" +
                   $"Quantity............................:{Quantity, 20:N0}\n\t" +
                   $"Precie..............................:{Price, 20:C2}\n\t" +
                   $"Valor a Pagar.......................:{GetValueToPay(), 20:C2}";
        }
    }
}
