using System;

namespace StorePresentForWoman
{
    class Toys : Present
    {
        public string Material { get; private set; }

        public Toys(string name, int price, string material)
        {
            Name = name;
            Price = price;
            Material = material;
        }
        public override double GetDiscountPrice(User user)
        {
            Material = Material.ToLower();
            if (user.DayOfTheWeek == "monday" && Material[0] == 'm')
            {
                return Price * 0.45;
            }
            if (Material[0] == 'c')
            {
                return Price * 0.8;
            }
            return Price;
        }
        public override void GetWrite()
        {
            Console.WriteLine("Toys:");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Material: " + Material);
            Console.WriteLine();
        }
    }
}
