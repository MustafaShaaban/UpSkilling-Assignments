namespace Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("01300009879614");

            #region Problem 1
            Console.WriteLine("==================\n Problem 1: \n==================");
            account.AccountHolderName = "John Doe";
            account.Deposit(100);
            account.Withdraw(500);
            account.Withdraw(50);

            Console.WriteLine($"{account.Balance}");
            Console.WriteLine("");
            #endregion

            #region Problem 2
            Console.WriteLine("==================\n Problem 2: \n==================");
            Product product = new Product();
            product.Name = "Laptop";
            product.Price = 1500;
            product.StockQuantity = 10;
            product.UpdateStock(5);
            Console.WriteLine($"{product.Name} - Price: {product.Price}, Stock: {product.StockQuantity}, Available: {product.IsAvailable}");
            Console.WriteLine("");
            #endregion

            #region Problem 3
            Console.WriteLine("==================\n Problem 3: \n==================");
            Car car = new Car();
            car.Make = "Toyota";
            car.Model = "Crolla";
            car.Year = 2012;
            car.Drive(100);
            car.Drive(44);

            Console.WriteLine($"{car.Make} {car.Model}");
            Console.WriteLine($"Year: {car.Year}, Age: {car.Age} years");
            Console.WriteLine($"Mileage: {car.Mileage} km");
            Console.WriteLine("");
            #endregion
        }
    }
}
