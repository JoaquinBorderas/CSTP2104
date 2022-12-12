using System;
using System.Collections.Generic;
using System.Text;

namespace _2104_Sep_2022
{
    public class ProjectManager : Employee
    {
        public int Hours { get; set; }
        public int HourlyRate { get; set; }

        public ProjectManager(string id) : base(id)
        {
        }
    }
}
