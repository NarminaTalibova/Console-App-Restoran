﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Restoran
{
    internal class Food:Name_and_Price
    {
        public Food(string name,double price):base(name,price) { }
        public void ShowInfo()
        {
            Console.WriteLine($"Name:{Name}, Price:{Price}");
        }
    }
}
