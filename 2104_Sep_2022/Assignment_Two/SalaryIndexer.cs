using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2104_Sep_2022;

namespace _2104_Sep_2022.Assignment_Two
{
    public class SalaryIndexer<TKey, TSubKey, TValue> : Indexer<TKey, TSubKey, TValue> where TValue : Employee, ISalaryCalculator
    {
        TValue _currentValue;

        

        public double GetSalary()
        {
            return _currentValue.Calculate;
        }
        public void Add(TKey key, TSubKey subKey, TValue value)
        {
        }
        public TValue GetCurrent()
        {
            return this._currentValue;
        }
    }
}
