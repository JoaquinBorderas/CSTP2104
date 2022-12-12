using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace _2104_Sep_2022
{
    public class ExamineCollections
    {
        public void TestIEnumerator() 
        {
            string s = "Hello String";
            IEnumerator iterator = s.GetEnumerator();

            while (iterator.MoveNext()) 
            {
                char c = (char) iterator.Current;
                Console.Write($"{c} - ");   
            }
        }
        public int Count(IEnumerable elements) 
        {
            int count = 0;
            foreach (object number in elements) 
            {
                count++;
            }

            return count;
        }
    }
}
