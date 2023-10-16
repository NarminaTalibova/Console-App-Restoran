using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Console_App_Restoran
{
    internal class Name_and_Price
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Name_and_Price(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}