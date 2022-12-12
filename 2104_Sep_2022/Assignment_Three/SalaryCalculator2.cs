using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2104_Sep_2022.Assignment_Three
{
    public class SalaryCalculator2
    {
        public double Calculate(string z, int x, double y)
        {
            var result = x * y;

            foreach (char s in z)
            {
                if (z.StartsWith("M"))
                {
                    result = result + 500;
                    return result;

                }

            }

            return result;
        }

        internal object Calculate(EmployeePayroll employee)
        {
            var result = employee.hours * employee.rate;

            foreach (char s in employee.id)
            {
                if (employee.id.StartsWith("M"))
                {
                    result = result + 500;
                    return result;

                }

            }

            return result;
        }
    }
  }

