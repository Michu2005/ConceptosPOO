using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConceptos.Logica
{
    public class BaseComisionEmployes : ComisinEmployed
    {
        private decimal _salary;

        public decimal Salary
        {
            get => _salary;
            set => _salary = ValidateSalary(value);
        }

        public override decimal GetValueToPay()
        {
            var salary = base.GetValueToPay() + Salary;
            if (salary < 450)
            {
                return 450;
            }
            return salary;
        }

        public override string ToString()
        {
            return $"{Id}\t{FirsName} {LastName}\n\t" +
                   $"HireDate....................:{HireDate}\n\t" +
                   $"Comision............................:{ComisionPorcentaje, 20:P0}\n\t" +
                   $"Sales...............................:{Sales, 20:C2}\n\t" +
                   $"Base................................:{Salary, 20:C2}\n\t" +
                   $"Rol.................................:{GetValueToPay(), 20:C2}";
        }

        private decimal ValidateSalary(decimal value)
        {
            if (value < 200)
            {
                throw new ArgumentException("El salario no es valido");
            }
            return value;
        }

    }
}
