using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPrograms
{
    public class InventoryManager
    {
        public static void ManageInventoryData()
        {
            InventoryFactory inventoryData = new InventoryFactory();
            Console.WriteLine("Enter the choice :");
            Console.WriteLine("=======================");
            Console.WriteLine("Press 1.GetInventoryDetails:");
            Console.WriteLine("Press 2.AddItem:");
            Console.WriteLine("Press 3.Update Item:");
            Console.WriteLine("Press 4.Delete Item:");

            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    inventoryData.GetUserDetails();
                    break;
                case 2:
                    inventoryData.AddItem();
                    break;
                case 3:
                    inventoryData.UpdateFile();
                    break;
                case 4:
                    inventoryData.DeleteItem();
                    break;

                default:
                    Console.WriteLine("enter the valid option");
                    break;


            }
        }
    }
}
