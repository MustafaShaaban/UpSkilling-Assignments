namespace Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("01300009879614");

            #region Assignment 1
            account.AccountHolderName = "John Doe";
            account.Deposit(100);
            account.Withdraw(500);
            account.Withdraw(50);

            Console.WriteLine($"{account.Balance}");
            #endregion

            #region Assignment 2
            Product product = new Product();
            product.Name = "Laptop";
            product.Price = 1500;
            product.StockQuantity = 10;
            product.UpdateStock(5);
            Console.WriteLine($"{product.Name} - Price: {product.Price}, Stock: {product.StockQuantity}, Available: {product.IsAvailable}");
            #endregion

            #region Assignment 3
            Car car = new Car();
            car.Make = "Toyota";
            car.Model = "Crolla";
            car.Year = 2012;
            car.Drive(100);
            car.Drive(44);

            Console.WriteLine($"{car.Make} {car.Model}");
            Console.WriteLine($"Year: {car.Year}, Age: {car.Age} years");
            Console.WriteLine($"Mileage: {car.Mileage} km");
            #endregion
        }
    }
}
