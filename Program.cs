using System.Globalization;

using Project_1.Entities;
using Project_1.Entities.Enums;

System.Console.WriteLine("Enter client data: ");
System.Console.Write("Name: ");
string Name = Console.ReadLine();
System.Console.Write("Email: ");
string Email = Console.ReadLine();
System.Console.Write("Birth date (DD/MM/YYYY): ");
DateTime BirthDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
System.Console.WriteLine("Enter order data: ");
System.Console.Write("Status: ");
OrderStatus Status = Enum.Parse<OrderStatus>(Console.ReadLine().ToUpper());
System.Console.Write("How many itens to this order: ");


int ItensIntoOrder = int.Parse(Console.ReadLine());
Client client = new Client(Name, Email, BirthDate);
Order order = new Order(DateTime.Now, Status, client);

for (int i = 0; i < ItensIntoOrder; i++)
{
    System.Console.WriteLine();
    System.Console.WriteLine($"Enter #{i+1} item data:");
    System.Console.Write("Product name: ");
    string productName = Console.ReadLine();
    System.Console.Write("Product price: ");
    double price = double.Parse(Console.ReadLine());
    System.Console.Write("Quantity: ");
    int quantity = int.Parse(Console.ReadLine());

    Product product = new Product(productName, price);
    
    OrderItem items = new OrderItem(quantity, price, product);
    order.AddItem(items);
}

System.Console.WriteLine();
System.Console.WriteLine("ORDEM SUMMARY:");
System.Console.WriteLine(order);


