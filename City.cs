using System.Collections.Generic;
using System.Linq;

namespace _01.LinqIntro
{
    public class City
    {
        public string Name { get; set; }
        public List<Building> Buildings { get; set; } = new List<Building>();
    }
}