using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLR2
{
    public class Product
    {
        private string name;
        private double price;
        private int quantity;

        // Конструктори класу
        public Product(string name ="basic", double price = 100, int quantity =5)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        public Product()
        {
            this.name = "test";
            this.price = 200;
            this.quantity = 5;
        }

        // Методи для виконання обчислень
        public double CalculateTotalValue()
        {
            return price * quantity;
        }

        public double CalculateDiscountedValue(double discount)
        {
            return price * quantity * (1 - discount / 100);
        }

        // Метод для виводу інформації про продукт
        public string Info()
        {
            return $"Назва: {name}\nЦіна: {price:C}\nКількість: {quantity}\nЗагальна вартість: {CalculateTotalValue():C}\n";
        }
    }



}
