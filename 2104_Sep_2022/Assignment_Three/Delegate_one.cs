using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2104_Sep_2022;

namespace _2104_Sep_2022.Assignment_Three
{
    public class Delegate_one
    {
        double _currentValue;
        delegate double SalaryDelegate(string name, int num, double d_b);
        
        public void Delegator()
        {
            
            //Declare function
            SalaryDelegate calc_Fct = Calculator;
           
            //Declare var that interprets called class
            var calculate = new SalaryCalculator2();
            
            //Declare function in var
            calc_Fct = calculate.Calculate;
            
            //Setting and printing results for Part 1
            var result = calc_Fct("M100", 30, 2.0);
            Console.WriteLine($"result= {result}");
            result = calc_Fct("1003", 30, 2.0);
            Console.WriteLine($"result= {result}");
            result = calc_Fct("2000", 24, 1.2);
            Console.WriteLine($"result= {result}");
            result = calc_Fct("M200", 24, 1.2);
            Console.WriteLine($"result= {result}");

            //Part2
            List<EmployeePayroll> EmployeeList = new List<EmployeePayroll>();
            EmployeeList.Add(new EmployeePayroll("M001", 23, 50.0));
            EmployeeList.Add(new EmployeePayroll("S001", 40, 40.0));
            EmployeeList.Add(new EmployeePayroll("M002", 38, 52.50));
            EmployeeList.Add(new EmployeePayroll("S011", 42, 43.50));
            EmployeeList.Add(new EmployeePayroll("M023", 34, 42.0));

            foreach (var employee in EmployeeList)
            {
                var result_list = calculate.Calculate(employee);
                Console.WriteLine($"ID:{employee.id}");
                Console.WriteLine($"Hours:{employee.hours}");
                Console.WriteLine($"Rate:{employee.rate}");
                Console.WriteLine($"Pay: {result_list}"); 
            }
        }
        public double Calculator(string s, int m, double d) 
        {
            return this._currentValue;
        }
        

    }
}
