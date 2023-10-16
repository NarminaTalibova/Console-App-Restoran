using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Restoran
{
    internal class Drink:Name_and_Price
    {
        public double AlcoholPercentage { get; set; }

        public Drink(string name, double price,double alcoholpercentage) : base(name, price) 
        {
            AlcoholPercentage = alcoholpercentage;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Name:{Name},Price:{Price},AlcoholPercentage{AlcoholPercentage}");
        }
    }
}
