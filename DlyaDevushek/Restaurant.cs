using System;

namespace StorePresentForWoman
{
    class Restaurant : Present
    {
        public string Type { get; private set; }

        public Restaurant(string name, string type, int price)
        {
            Name = name;
            Type = type;
            Price = price;
        }
        public override double GetDiscountPrice(User user)
        {
            Name = Name.ToLower();
            if (user.DayOfTheWeek == "monday" && Name[0] == 'm')
            {
                return Price * 0.9;
            }
            return Price;
        }
        public override void GetWrite()
        {
            Console.WriteLine("Restaurant:");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Type: " + Type);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine();
        }
    }
}
