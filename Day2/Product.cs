using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class Product
    {
        private decimal _price;
        private int _stockQuantity;

        public string? Name { get; set; }
        public decimal Price
        {
            get => _price;
            set => _price = value >= 0 ? value : 0;

        }
        public int StockQuantity
        {
            get => _stockQuantity;
            set => _stockQuantity = value >= 0 ? value : 0;
        }
        public bool IsAvailable
        {
            get => StockQuantity > 0;
        }

        public void UpdateStock(int quantity)
        {
            if (quantity >= 0)
            {
                StockQuantity = quantity;
            }
            else
            {
                Console.WriteLine("Stock cannot be negative. No changes made.");
            }
        }
    }
}
