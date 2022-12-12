using System;
using _2104_Sep_2022;
using _2104_Sep_2022.Assignment_One;
using _2104_Sep_2022.Assignment_Two;
using _2104_Sep_2022.Assignment_Three;
using _2104_Sep_2022.Assignment_Four;
class Program
{
    static void Main(string[] args)
    {
        //new Program().Assignment_One();
        //new Program().Assignment_Two();
        //new Program().Assignment_Three();
        new Program().Assignment_Four();

        //var appConfigReader = new AppConfigReader();
        //appConfigReader.ReadConnectionStrings();
        //var connString = appConfigReader.GetConnectionString("Project1");
        //Console.WriteLine("Connection String found: ");
        //Console.WriteLine(connString);

        //var examineCollection = new ExamineCollections();
        //examineCollection.TestIEnumerator();
        //var count = examineCollection.Count(new int[] { 1, 2, 3 });
        //Console.Write($"count={count}");

        //newlist.Add(new Person(10, 4, 6));
    }
    public void Assignment_One()
    {
        var _2021_Mercedes_Benz_E_Class = new Car("Mercedes-Benz", "E-Class", 2021, 4682, "Used", "AMG E 63 S: 20 AMG CROSS-SPOKE FORGED WHEELS, INTE", "Sedan", "8 Cylinder Engine", 8, "Automatic", "AWD", "V2154065V", "designo Hyacinth Red Metallic", 4, "Gas", "15.0L/100km", "10.1L/100km");
        var _2022_Audi_Q7 = new Car("Audi", "Q7", 2022, 3121, "Used", "55 3.0T Progressiv quattro 8sp Tiptronic X-DEMO", "SUV", "V6 Cylinder Engine 3.0L", 6, "Automatic", "AWD", "AD220249", "Mythos Black Metallic", 4, "Gas", "11.0L/100km", "9.4L/100km");
        var _2006_Cadillac_CTS = new Car("Cadillac", "CTS", 2006, 233933, "Used", "Automatic Leather Sunroof", "Sedan", "V6 Cylinder Engine", 6, "Automatic", "RWD", "60194965", "Green", 4, "Gas", "13.1L/100km", "8.2L/100km");
        var _2016_Ford_Focus = new Car("Ford", "Focus", 2016, 18000, "Used", "5dr HB RS", "Coupe", "V8 Cylinder Engine", 8, "Manual", "RWD", "N/A", "Grey", 5, "Gas", "15.1L/100km", "12.3L/100km");
        var _2023_Trail_King = new Trailer("Trail King", "TK50LP", 2023, "New", "NR059814", "Silver", 2);
        var _2022_Trail_King = new Trailer("Trail King", "TKT40LP", 2022, "New", "128746", "Black", 2);
        var _2020_Dimond_Van = new Trailer("DI-MOND", "Van", 2020, "Used", "13004", "Black", 2);
        var _2012_Utility_4000dx = new Trailer("Utility", "4000dx", 2012, "Used", "95356", "White", 2);
        var _1978_Bayliner_Bristol = new Boat("Bayliner", "Bristol", 1978, "Used", 333.0, "Power", "Mercruiser 7.4L", 2, 750, 35.6, "Inboard", "515903", "White", "Gas");
        var _1973_Houseboat_FloatingAccomodation = new Boat("Houseboat", "Floating Accomodation", 1973, "Used", 660.0, "Power", "Blackstone 8 Cylinderm", 1, 1150, 120, "Inboard", "468658", "White/Black", "Gas");
        var _1993_Broward_Tri_Deck = new Boat("Broward", "Tri-Deck", 1993, "Used", 2800.0, "Power", "Detroit 16V92", 2, 800, 123, "Inboard", "487235", "White/Black", "Diesel");

    }

    public void Assignment_Two()
    {
        var developer_one = new Developer("678", StandardEmployeeType.Fulltime, 1998);
        SalaryIndexer<string, string, Employee> salaryindex = new SalaryIndexer<string, string, Employee>();
    }
    public void Assignment_Three()
    {
        var del_ags = new Delegate_one();
        del_ags.Delegator();
    }
    public void Assignment_Four()
    {
        //part 1
        var examine_This = new MyIntegerList();
        examine_This.ExamineCollection();

        //part 2
        MyList list_ex = new MyList();
        foreach (list_x li_st in list_ex)
        {
            Console.WriteLine(li_st.name);
            Console.WriteLine(li_st.address);
            Console.WriteLine(li_st.city);
        }
    }
}


