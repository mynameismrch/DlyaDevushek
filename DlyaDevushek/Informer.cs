using System;

namespace StorePresentForWoman
{
    public class Informer
    {
        public void Buy(User user, Present present)
        {
            double price = present.GetDiscountPrice(user);
            user.ReduceBalance(price);
            Console.WriteLine();
            Console.WriteLine($"{user.Name} bought {present.Name} by {price}. Order sent to warehouse");
        }
    }
}
