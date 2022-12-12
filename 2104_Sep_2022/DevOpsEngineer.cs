
using System;
using System.Collections.Generic;
using System.Text;

namespace _2104_Sep_2022
{
    public class DevOpsEngineer : StandardEmployee
    {
        public DevOpsEngineer(string id, StandardEmployeeType employeeType, int startYear)
            : base(id, employeeType, startYear)
        {
            this.VacationDays = 15;
            this.SetSalary();
        }

        public override int GetVacationDays()
        {
            if (DateTime.Now.Year - this.startYear >= 5)
            {
                return this.VacationDays + 3;
            }

            return this.VacationDays;
        }

        // Override for the abstract function
        public override int StartYear => this.StartYear;
    }
}
