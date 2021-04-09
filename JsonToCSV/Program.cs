using System;

namespace JsonToCSV
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Query reccords form DataBase 
            var conDB = new QryDB();
            var ea = conDB.GetEAInfosTAM("27", "07", "02");
            // var ea = conDB.GetEAInfosAMP("27", "07");
            // var ea = conDB.GetEAInfosCWT("27");
            foreach (var item in ea)
            {
                try
                {
                    var reccords = conDB.Qry(item._id);
                    // Read Json form Text file and map to model
                    var read = new ReadJsonMapToModel();
                    var modelCommu = read.Community(reccords);
                    var modelBuilding = read.Building(reccords);
                    var modelHousehold = read.HouseHold(reccords);

                    // Write CSV file
                    var write = new WriteFile();
                    write.WriteFileCommu("C" + item._id, modelCommu);
                    write.WriteFileBuilding("B" + item._id, modelBuilding);
                    write.WriteFileUnit("U" + item._id, modelHousehold);
                }
                catch (System.Exception e)
                {
                    System.Console.WriteLine(e);
                }
            }
            System.Console.WriteLine("Done!!!");
        }
    }
}
