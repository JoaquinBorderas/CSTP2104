using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2104_Sep_2022.Assignment_One
{
    public class Boat
    {
        public Boat(string make, string model, int year, string status, double hp, string type, string engine, int num_engine, int hours, double length, string drivetrain, string stockNumber, string exteriorColour, string fuelType)
        {
            Make = make;
            Model = model;
            Year = year;

            Status = status;
            Hp = hp;
            Type_boat = type;
            Engine = engine;
            NumberEngine = num_engine;

            Hours = hours;
            Length = length;
            Drivetrain = drivetrain;
            StockNumber = stockNumber;
            ExteriorColour = exteriorColour;

            FuelType = fuelType;

        }
        public string Type_boat { get; set; }
        public int NumberEngine { get; set; }
        public int Hours { get; set; }
        public double Hp { get; set; }
        public double Length { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Km { get; set; }
        public string Status { get; set; }
        public string Trim { get; set; }
        public string BodyType { get; set; }
        public string Engine { get; set; }
        public int Cylinder { get; set; }
        public string Transmission { get; set; }
        public string Drivetrain { get; set; }
        public string StockNumber { get; set; }
        public string ExteriorColour { get; set; }
        public int Door { get; set; }
        public string FuelType { get; set; }
        public string CityFuel { get; set; }
        public string HwyFuel { get; set; }


    }
}

