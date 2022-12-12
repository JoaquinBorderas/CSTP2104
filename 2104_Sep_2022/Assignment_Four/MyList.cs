using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2104_Sep_2022;

namespace _2104_Sep_2022.Assignment_Four
{
    public class MyList :IEnumerable<list_x>
    {

        
        public List<list_x> listx;
        public MyList() 
        {
            listx = new List<list_x>()
            {
                new list_x("Mike","Tyson","Toronto"),
                new list_x("Henrik","Sedin","Vancouver"),
                new list_x("Mickey","Mouse","Los Angeles")
            };
        }

        public IEnumerator<list_x> GetEnumerator()
        {
            return listx.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
