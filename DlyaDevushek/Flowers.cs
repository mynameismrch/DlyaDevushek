using System;

namespace StorePresentForWoman
{
    class Flowers : Present
    {
        public string Color { get; private set; }
        public int Count { get; private set; }

        public Flowers(string name, int price, string color, int count)
        {
            Name = name;
            Price = price;
            Color = color;
            Count = count;
        }

        public override double GetDiscountPrice(User user)
        {
            Name = Name.ToLower();
            Color = Color.ToLower();
            if (user.DateDay == 8 && Name[0] == 'r' && Color != "red")
            {
                return Price * 0.85;
            }
            if (user.DateDay == 8 && Color == "red")
            {
                return Price * 0.9;
            }
            return Price;
        }
        public override void GetWrite()
        {
            Console.WriteLine("Flowers: ");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Color: " + Color);
            Console.WriteLine("Count: " + Count);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine();
        }
    }
}
