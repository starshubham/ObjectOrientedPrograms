using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace ObjectOrientedPrograms.InventoryMangementData
{
    /* 
       1. JSON Inventory Data Management of Rice, Pulses and Wheats
          a. Desc -> Create a JSON file having Inventory Details for Rice, Pulses and Wheats with properties name, weight, price per kg.
          b. Use Library : Java JSON Library, For IOS JSON Library use NSJSONSerialization for parsing the JSON.
          c. I/P -> read in JSON File
          d. Logic -> Get JSON Object in Java or NSDictionary in iOS. Create Inventory Object from JSON. Calculate the value for every Inventory.
          e. O/P -> Create the JSON from Inventory Object and output the JSON String
     */
    class InventoryManagement
    {
        public List<Rice> Rice { set; get; }
        public List<Pulses> Pulses { set; get; }        
        public List<Wheats> Wheats { set; get; }
        public static void Inventorymanagement()
        {
            Inventory inventory = new Inventory();

            double totalriceprice = 0.0;
            double totalwheatprice = 0.0;
            double totalpulsesprice = 0.0;
            string json = @"C:\Users\My Laptop\Desktop\BrProjects\ObjectOrientedPrograms\ObjectOrientedPrograms\InventoryMangementData\Inventory.json";
            try
            {
                string jsonfile = File.ReadAllText(json);
                InventoryManagement inventoryManagement = (InventoryManagement)JsonConvert.DeserializeObject(jsonfile, typeof(InventoryManagement));
                foreach (Rice objrice in inventoryManagement.Rice)
                {
                    string name = objrice.Name;
                    double price = objrice.Price;
                    double weight = objrice.Weight;

                    totalriceprice = totalriceprice + price * weight;
                    Console.WriteLine("\nRice Name: " + name);
                    Console.WriteLine("Rice Price: " + price);
                    Console.WriteLine("Rice Weight: " + weight);
                    Console.WriteLine("Total Price of Rice: " + totalriceprice);
                }
                foreach (Pulses objpulses in inventoryManagement.Pulses)
                {
                    string name = objpulses.Name;
                    double price = objpulses.Price;
                    double weight = objpulses.Weight;

                    totalpulsesprice = totalpulsesprice + price * weight;
                    Console.WriteLine("\nPulse Name: " + name);
                    Console.WriteLine("Pulse Price: " + price);
                    Console.WriteLine("Pulse Weight: " + weight);
                    Console.WriteLine("Total Price of Pulses: " + totalpulsesprice);
                }
                foreach (Wheats objwheats in inventoryManagement.Wheats)
                {
                    string name = objwheats.Name;
                    double price = objwheats.Price;
                    double weight = objwheats.Weight;

                    totalwheatprice = totalwheatprice + price * weight;
                    Console.WriteLine("\nWheats Name: " + name);
                    Console.WriteLine("Wheats Price: " + price);
                    Console.WriteLine("Wheats Weight: " + weight);
                    Console.WriteLine("Total Price of Wheats: " + totalwheatprice);

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
