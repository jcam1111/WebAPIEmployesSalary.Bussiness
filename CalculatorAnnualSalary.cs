using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIEmployesSalary.Model;
using WebAPIEmployesSalary.Services.Interfaces;

namespace WebAPIEmployesSalary.Bussiness
{    
    public class CalculatorAnnualSalary : ICalculatorSalaryStrategy
    {
        public decimal OperationCalculatorAnnualSalary(EmployeeAnnualSalary employee)
        {
            employee.AnnualSalary = employee.AnnualSalary * 12; 
            return (decimal)(employee.AnnualSalary * 12);
        }
    }
}
