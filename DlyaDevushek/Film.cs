using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorePresentForWoman
{
    class Film : Present
    {
        public string TypeFilm { get; private set; }
        public string Genre { get; private set; }

        public Film(string typefilm, string name, string genre, int price)
        {
            TypeFilm = typefilm;
            Name = name;
            Genre = genre;
            Price = price;
        }
        public override double GetDiscountPrice(User user)
        {
            TypeFilm = TypeFilm.ToLower();
            if (user.DayOfTheWeek == "Wednesday" && TypeFilm == "cartoon")
            {
                return Price * 0.5;
            }
            if (user.DateDay == 8 && TypeFilm == "film")
            {
                return Price * 0.9;
            }
            return Price;
        }
        public override void GetWrite()
        {
            Console.WriteLine("Film:");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("TypeFilm: " + TypeFilm);
            Console.WriteLine("Genre: " + Genre);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine();
        }
    }
}
