using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2104_Sep_2022;

namespace _2104_Sep_2022.Assignment_Two
{
    public class Indexer<TKey, TSubKey, TValue> where TValue : Employee
    {
        TValue _currentValue;
        
        public void Indexr() 
        {
        }
        public void Add(TKey key, TSubKey subKey, TValue value) 
        {
        }
        public TValue GetCurrent() 
        {
            return this._currentValue;
        }
        //public double GetSalary(TKey key, TSubKey subkey) 
        
            //return _currentValue.Calculate();
        
    }
}
