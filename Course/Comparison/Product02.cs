
using System.Globalization;

namespace Course.Comparison
{
    class Product02
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product02(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name
                + ", "
                + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
