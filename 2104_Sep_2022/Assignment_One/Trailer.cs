using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2104_Sep_2022.Assignment_One
{
    public class Trailer
    {
        public Trailer(string make, string model, int year, string status, string stockNumber, string exteriorColour, int door)
        {
            Make = make;
            Model = model;
            Year = year;

            Status = status;


            StockNumber = stockNumber;
            ExteriorColour = exteriorColour;
            Door = door;

        }

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public string Status { get; set; }



        public string StockNumber { get; set; }
        public string ExteriorColour { get; set; }
        public int Door { get; set; }

    }
}
