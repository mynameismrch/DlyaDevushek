using System;

namespace StorePresentForWoman
{
    class Clothes : Present
    {
        public string Color { get; private set; }
        public string Firma { get; private set; }

        public Clothes(string name, int price, string color, string firma)
        {
            Name = name;
            Price = price;
            Color = color;
            Firma = firma.ToLower();

        }

        public override double GetDiscountPrice(User user)
        {
            if (user.DateDay == 8 && Firma[0] == 'a')
            {
                return Price * 0.6;
            }
            return Price;
        }
        public override void GetWrite()
        {
            Console.WriteLine("Clothes:");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Color: " + Color);
            Console.WriteLine("Firma: " + Firma);
            Console.WriteLine();
        }
    }
}
