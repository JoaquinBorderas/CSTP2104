using System;
using System.Collections.Generic;
using System.Text;

namespace _2104_Sep_2022
{
    public class ProductManager : StandardEmployee
    {
        public ProductManager(string id, StandardEmployeeType employeeType, int startYear) 
            : base(id, employeeType, startYear)
        {
            this.VacationDays = 12;
            this.SetSalary();
        }

        // Override for the abstract function
        public override int StartYear => this.StartYear;

    }
}
