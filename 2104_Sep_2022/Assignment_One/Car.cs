using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2104_Sep_2022.Assignment_One
{
    public class Car
    {
        public Car(string make, string model, int year, int km, string status, string trim, string bodyType, string engine, int cylinder, string transmission, string drivetrain, string stockNumber, string exteriorColour, int door, string fuelType, string cityFuel, string hwyFuel)
        {
            Make = make;
            Model = model;
            Year = year;
            Km = km;
            Status = status;
            Trim = trim;
            BodyType = bodyType;
            Engine = engine;
            Cylinder = cylinder;
            Transmission = transmission;
            Drivetrain = drivetrain;
            StockNumber = stockNumber;
            ExteriorColour = exteriorColour;
            Door = door;
            FuelType = fuelType;
            CityFuel = cityFuel;
            HwyFuel = hwyFuel;
        }

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

