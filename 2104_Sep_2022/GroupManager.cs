
using System;
using System.Collections.Generic;
using System.Text;

namespace _2104_Sep_2022
{
    public class GroupManager : StandardEmployee
    {
        public GroupManager(string id, int startYear) : base(id, StandardEmployeeType.Fulltime, startYear)
        {
            this.VacationDays = 20;
            this.SetSalary();
        }

        protected override void SetSalary()
        {
            this.Salary = SalaryConfiguration.DefaultFulltimeGroupManagerSalary;
        }

        // Override for the abstract function
        public override int StartYear => this.StartYear;
    }
}
