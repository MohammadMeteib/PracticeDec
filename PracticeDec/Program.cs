using PracticeDec.
    Models;
Product product = new Product();
Console.WriteLine("Enter product name:");
string name = Console.ReadLine();
Console.WriteLine(product.ProductInfo(name));
Console.WriteLine("Enter product price");
int price = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(product.ProductInfo(name, price));
Console.WriteLine("Enter product quantity");
int quantity = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(product.ProductInfo(name, price, quantity));
