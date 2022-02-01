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
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    InventoryManagement.Inventorymanagement();
                    break;

                default:
                    Console.WriteLine("invalid option");
                    break;
            }
        }
    }
}
