
namespace Project_1.Entities
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {
            
        }

        public Product(string name, double Price)
        {
            Name = name;
            Price = Price;
        }
    }
}