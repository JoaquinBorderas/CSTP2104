using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2104_Sep_2022.Assignment_Four
{
    public class MyIntegerList
    {
        public void ExamineCollection() 
        {
            
            ICollection<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.Add(9);
            list.Add(10);
            
            foreach(int i in list) 
            {
                Console.WriteLine(i);
            }

            IEnumerator iterator = list.GetEnumerator();

            while (iterator.MoveNext())
            {
                int c = (int)iterator.Current;
                Console.Write($"{c} - ");
            }
        }
    }
}
