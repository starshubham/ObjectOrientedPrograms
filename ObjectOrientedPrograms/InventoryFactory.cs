using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Linq;

namespace ObjectOrientedPrograms
{
    class InventoryFactory
    {
        string jsonFile = @"C:\Users\My Laptop\Desktop\BrProjects\ObjectOrientedPrograms\ObjectOrientedPrograms\InventoryMangementData\Inventory.json";
        public void GetUserDetails()
        {
            var json = File.ReadAllText(jsonFile);    // File comes from System.IO
            try
            {

                var JsonObject = JObject.Parse(json);     // JObject or JSON files comes from Newtonsoft.Json.Linq library
                if (JsonObject != null)
                {
                    JArray riceArray = (JArray)JsonObject["Rice"];


                    if (riceArray != null)
                    {
                        foreach (var item in riceArray)
                        {
                            Console.WriteLine("\nRice Name:" + item["name"].ToString());
                            Console.WriteLine("Rice price:" + item["price"].ToString());
                            Console.WriteLine("Rice Weight :" + item["weight"].ToString());

                        }
                    }
                }
                if (JsonObject != null)
                {
                    JArray wheatsArray = (JArray)JsonObject["Wheats"];
                    if (wheatsArray != null)
                    {
                        foreach (var item in wheatsArray)
                        {
                            Console.WriteLine("\nWheats Name :" + item["name"].ToString());
                            Console.WriteLine("Wheats Price :" + item["price"].ToString());
                            Console.WriteLine("Wheats weight :" + item["weight"].ToString());

                        }
                    }
                }
                if (JsonObject != null)
                {
                    JArray pulsesArray = (JArray)JsonObject["Pulses"];
                    foreach (var item in pulsesArray)
                    {
                        Console.WriteLine("\nPulses Name :" + item["name"].ToString());
                        Console.WriteLine("Pulses price :" + item["price"].ToString());
                        Console.WriteLine("Pulses weight :" + item["weight"].ToString());

                    }
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void AddItem()
        {
            Console.WriteLine("Enter the Item Name ");
            var itemname = Console.ReadLine();
            Console.WriteLine("Enter the Type of Item Name");
            var itemtypename = Console.ReadLine();
            Console.WriteLine("Enter the Price of Item");
            var price = Console.ReadLine();
            Console.WriteLine("Enter the Weight of Item");
            var weight = Console.ReadLine();

            var newItem = "{ 'name': '" + itemtypename + "','price':" + price + ",'weight':" + weight + "}";
            var json = File.ReadAllText(this.jsonFile);
            var jsonObject = JObject.Parse(json);
            var itemArray = jsonObject.GetValue(itemname) as JArray;
            var newitemObject = JObject.Parse(newItem);
            Console.WriteLine("new item object" + newitemObject);
            itemArray.Add(newitemObject);
            Console.WriteLine("item array :" + itemArray);
            jsonObject[itemname] = itemArray;

            string newJsonResult = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);  // JsonConvert comes from Newtonsoft.Json;
            File.WriteAllText(this.jsonFile, newJsonResult);

        }
        public void UpdateFile()
        {
            string json = File.ReadAllText(this.jsonFile);
            try
            {
                var jsonObject = JObject.Parse(json);
                Console.WriteLine("Enter Item Name ");
                string itemNameToUpdate = Console.ReadLine();
                JArray riceArrary = (JArray)jsonObject[itemNameToUpdate];
                Console.Write("Enter Item Name to Update : ");
                var itemName = Console.ReadLine();
                Console.Write("Enter New Item name : ");
                var newItemName = Convert.ToString(Console.ReadLine());

                foreach (var item in riceArrary.Where(obj => obj["name"].Value<string>().Equals(itemName)))
                {
                    item["name"] = !string.IsNullOrEmpty(newItemName) ? newItemName : string.Empty;
                }

                jsonObject["name"] = riceArrary;
                string output = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
                File.WriteAllText(this.jsonFile, output);
                Console.WriteLine(newItemName + " is Updated on " + itemName);
            }

            catch (Exception exception)
            {
                Console.WriteLine("Update Error : " + exception.Message.ToString());
            }
        }
        public void DeleteItem()
        {
            string json = File.ReadAllText(this.jsonFile);

            try
            {
                var jsonObject = JObject.Parse(json);
                Console.WriteLine("Enter the item Name ");
                var itemname = Console.ReadLine();
                JArray itemArray = (JArray)jsonObject[itemname];
                Console.WriteLine("Enter the item type to be deleted");
                var itemtypetodelete = Console.ReadLine();

                var itemtoDeleted = itemArray.FirstOrDefault(obj => obj["name"].Value<string>().Equals(itemtypetodelete));

                itemArray.Remove(itemtypetodelete);
                string Resultoutput = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
                File.WriteAllText(jsonFile, Resultoutput);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
