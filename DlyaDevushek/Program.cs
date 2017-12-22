using System;

namespace StorePresentForWoman
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User(
                "Ali Jan",
                "Sultanov street, 1337 home",
                8,
                "Monday",
                5000,
                1000
                );

            Console.WriteLine("List products: ");
            Console.WriteLine();

            Flowers roses = new Flowers(
                "Rose",
                600,
                "Yelow",
                4
                );
            Flowers tulip = new Flowers(
                "Tylip",
                600,
                "Red",
                6
                );
            Flowers chrysanthemum = new Flowers(
                "Сhrysanthemum",
                600,
                "Orange",
                3
                );

            roses.GetWrite();
            tulip.GetWrite();
            chrysanthemum.GetWrite();

            Film starWars = new Film(
                "Film",
                "StarWars",
                "fantastic",
                500
                );
            Film zootopia = new Film(
                "cartoon",
                "Zootopia",
                "comedy",
                300
                );
            Film peakyBlinders = new Film(
                "serial",
                "PeakyBlinders",
                "drama",
                5000
                );

            starWars.GetWrite();
            zootopia.GetWrite();
            peakyBlinders.GetWrite();

            Clothes adijeans = new Clothes(
                "Adidas Jeans",
                3500,
                "Black",
                "Adidas"
                );
            Clothes zarashirt = new Clothes(
                "Zara Shirt",
                3000,
                "White",
                "Zara"
                );
            Clothes hmjacket = new Clothes(
                "H&M Jacket",
                2500,
                "Black",
                "H&M"
                );

            adijeans.GetWrite();
            zarashirt.GetWrite();
            hmjacket.GetWrite();

            Restaurant cafeseven = new Restaurant(
                "Cafe Seven",
                "Cafe",
                2000
                );
            Restaurant kfc = new Restaurant(
                "KFC",
                "fast food",
                600
                );
            Restaurant shashlikoff = new Restaurant(
                "SHASHLIKOFF",
                "Grill & Bar",
                1000
                );

            cafeseven.GetWrite();
            kfc.GetWrite();
            shashlikoff.GetWrite();

            Toys mishka = new Toys(
                "MISHKA",
                1500,
                "Plush"
                );
            Toys rubikscube = new Toys(
                "Rubik's Cube",
                400,
                "Plastic"
                );
            Toys barbie = new Toys(
                "Barbie",
                1000,
                "Plastic"
                );

            mishka.GetWrite();
            rubikscube.GetWrite();
            barbie.GetWrite();

            Present[] presents = new Present[]
            {
                roses, tulip, chrysanthemum,
                starWars, zootopia, peakyBlinders,
                adijeans, zarashirt, hmjacket,
                cafeseven, kfc, shashlikoff,
                mishka, rubikscube, barbie
            };

            Informer informer = new Informer();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine($"Hello {user.Name} your balance {user.Balance}");
                Console.WriteLine();

                for (int i = 0; i < presents.Length; i++)
                {
                    Console.WriteLine($"Present {i} {presents[i].Name} to price {presents[i].Price}");
                }
                Console.Write("\nSelect the item and press Enter:  ");

                string str = Console.ReadLine();
                int productNumber = Convert.ToInt32(str);
                if (productNumber >= 0 && productNumber < presents.Length)
                {
                    if (presents[productNumber].Price < user.Balance)
                    {
                        informer.Buy(user, presents[productNumber]);
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("You have incufficient funds");
                    }
                }
                else
                {
                    Console.WriteLine("This present is no longer");
                }
            }
        }
    }
}
