using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConceptos.Logica
{
    public class ComisinEmployed : Employes
    {
        private decimal _sales;
        private float _comisionPorcentaje; //0 - 1

        public decimal Sales
        {
            get => _sales;
            set => _sales = ValidateSales(value);
        }

        public float ComisionPorcentaje
        {
            get => _comisionPorcentaje;
            set => _comisionPorcentaje = ValidateComisionPorcentaje(value);
        }

        public override decimal GetValueToPay()
        {
            float iva = 0.88f;
            return Sales * (decimal)ComisionPorcentaje * (decimal)iva;
        }


        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                   $"ComisionPorcentaje..................:{ComisionPorcentaje,20:P0}\n\t" +
                   $"Sales...............................:{Sales,20:C2}\n\t" +
                   $"Rol.................................:{GetValueToPay(),20:C2}";
        }

        private decimal ValidateSales(decimal value)
        {
            if (value >= 0)
            {
                return value; 
            }
            throw new ArgumentException("E numero de ventas no es valido");
        }

        private float ValidateComisionPorcentaje(float value)
        {
            if (value > 0 && value <= 1)
            {
                return value; 
            }
            throw new ArgumentException("El porcentaje no es valido");
        }
    }
}
