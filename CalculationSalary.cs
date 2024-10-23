using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIEmployesSalary.Model;
using WebAPIEmployesSalary.Services.Interfaces;

namespace WebAPIEmployesSalary.Bussiness
{

    public class CalculationSalary
    {
        private readonly ICalculatorSalaryStrategy _strategy;

        public CalculationSalary(ICalculatorSalaryStrategy strategy)
        {
            _strategy = strategy;
        }

        public decimal CalcularSalarioAnual(EmployeeAnnualSalary empleado)
        {
            return _strategy.OperationCalculatorAnnualSalary(empleado);
        }
    }

}
