using System;

namespace StorePresentForWoman
{
    public class Present
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public string Manufacture { get; set; }

        public virtual double GetDiscountPrice(User user)
        {
            return Price;
        }
        public virtual void GetWrite()
        {
            Console.WriteLine("Product");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Manufacture: " + Manufacture);
        }
    }
}
