using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Restoran
{
    internal class Restaurant
    {
        //public Food[] foods = new Food[0];
        //public Drink[] drinks = new Drink[0];

        //public void AddFood(string name, double price)
        //{
        //    Array.Resize(ref foods, foods.Length + 1);
        //    foods[foods.Length - 1] = new Food { Name = name, Price = price };
        //    Console.WriteLine($"{name} əlavə edildi.");
        //}

        //public void AddDrink(string name, double price, double alcoholpercentage)
        //{
        //    Array.Resize(ref drinks, drinks.Length + 1);
        //    drinks[drinks.Length - 1] = new Drink { Name = name, Price = price, AlcoholPercentage = alcoholpercentage };
        //    Console.WriteLine($"{name} əlavə edildi.");
        //}



        public List<Food> foods;
        public List<Drink> drinks;

        public Restaurant()
        {
            foods = new List<Food>();
            drinks = new List<Drink>();
        }

        //1)Qida əlavə et
        public void AddFood(string name, double price)
        {
            foods.Add(new Food(name, price)); 
            Console.WriteLine($"{name} adli qida menyu obyektine elave edildi.");
        }

        //2)İçki əlavə et
        public void AddDrink(string name, double price, double alcoholpercentage)
        {
            drinks.Add(new Drink(name, price, alcoholpercentage));
            Console.WriteLine($"{name} adli icki menyu obyektine elave edildi.");
        }

        //3)Bütün menyunu göstər
        public void ShowMenu()
        {
            Console.WriteLine("Qidalar:");
            foreach (var food in foods)
            {
                Console.WriteLine($"{food.Name} - {food.Price} AZN");
            }

            Console.WriteLine("\nİçkilər:");
            foreach (var drink in drinks)
            {
                Console.WriteLine($"{drink.Name} - {drink.Price} AZN - Alkol faizi: {drink.AlcoholPercentage}%");
            }
        }
    }
}
