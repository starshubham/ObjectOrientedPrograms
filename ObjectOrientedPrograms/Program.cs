using ObjectOrientedPrograms.InventoryMangementData;

using System;

namespace ObjectOrientedPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your choice ");
            Console.WriteLine("Press 1 : For JSON Inventory Data Management of Rice, Pulses and Wheats");
            Console.WriteLine("Press 2 : For Inventory Management Program to Add, Update or Delete the Items");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    InventoryManagement.Inventorymanagement();
                    break;

                case 2:
                    InventoryManager.ManageInventoryData();
                    break;

                default:
                    Console.WriteLine("invalid option");
                    break;
            }
        }
    }
}
