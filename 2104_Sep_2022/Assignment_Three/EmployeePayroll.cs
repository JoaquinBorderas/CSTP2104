using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2104_Sep_2022.Assignment_Three
{
    public class EmployeePayroll
    {
        public EmployeePayroll(string z, int x, double y) 
        {
            id = z;
            hours = x;
            rate = y;
           
        }
        public string id { get; set; }
        public int hours { get; set; }
        public double rate { get; set; }
       

    }
}
