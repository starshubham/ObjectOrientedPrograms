using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPrograms.InventoryMangementData
{
    class Inventory
    {
        public List<Rice> Rice { get; set; }
        public List<Wheats> Wheats { get; set; }
        public List<Pulses> Pulses { get; set; }
    }
    public class Rice
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Price { get; set; }
    }
    public class Wheats
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Price { get; set; }
    }
    public class Pulses
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Price { get; set; }
    }
}
