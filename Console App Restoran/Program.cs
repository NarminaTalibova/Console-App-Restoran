namespace Console_App_Restoran
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Restaurant restaurant = new Restaurant();
            bool exit = false;
            while (!exit) // Proqramdan cixilana qeder dongu davam edir
            {
                Console.WriteLine("Proqram bizə menu seçimi göstərir aşağıdakı kimi:");
                Console.WriteLine("1. Qida əlavə et");
                Console.WriteLine("2. İçki əlavə et");
                Console.WriteLine("3. Bütün menyunu göstər");
                //Console.WriteLine("4. Qiymətə görə menyu axtar");
                //Console.WriteLine("5. Alkol faizlərinə görə içkiləri axtar");
                Console.WriteLine("0. Proqramı bitir");

                int choice = int.Parse(Console.ReadLine()); // Istifadeciden secimini daxil etmesini isteyir

                switch (choice) // Secime gore fesiller yaradir
                {
                    case 1:
                        Console.WriteLine("Qidanin adini daxil edin:");
                        string foodName = Console.ReadLine();
                        Console.WriteLine("Qidanin qiymetini daxil edin:");
                        double foodPrice = double.Parse(Console.ReadLine()); // Qidanin qiymetini oxuyur
                        restaurant.AddFood(foodName, foodPrice);
                        break;
                    case 2:
                        Console.WriteLine("Ickinin adini daxil edin:");
                        string drinkName = Console.ReadLine();
                        Console.WriteLine("Ickinin qiymetini daxil edin:");
                        double drinkPrice = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ickinin alkol faizini daxil edin:");
                        double drinkAlcoholPercentage = double.Parse(Console.ReadLine()); // Ickinin alkol faizini oxuyur
                        restaurant.AddDrink(drinkName, drinkPrice, drinkAlcoholPercentage); // Restorana yeni icki elave edir
                        break;
                    case 3:
                        restaurant.ShowMenu(); // Restoranda olan butun qidalar ve ickiler siyahisini ekrana cap edir
                        break;
                    case 0: 
                        exit = true; // Proqramdan cixmaq ucun serti true edir
                        Console.WriteLine("Proqram bitdi.");
                        break;
                    default: 
                        Console.WriteLine("Duzgun secim etmediyiniz ucun proqram sonlandi.");
                        exit = true;
                        break;
                }
            }
        }
    }
}   
