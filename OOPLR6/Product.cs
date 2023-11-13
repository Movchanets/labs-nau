using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLR3
{
    using System;

    class Product
    {
        private static int count = 0;
        protected int nomer;
        public static List<Product> products = new List<Product>();
        public Product()
        {
            count++;
            nomer = count;
            Name = "Test";
            Price = 100;
            Quantity = 5;
            products.Add(this);

            Info();
        }
        public static int  Count => count;
        public Product(string name, double price, int quantity)
        {
            count++;
            nomer = count;
            Name = name;
            Price = price;
            Info();
            products.Add(this);
            Quantity = quantity;
        }
       
        public static bool operator==(Product p1, Product p2)
        {
            // Порівнюємо продукти за ім'ям, ціною і кількістю
            return p1.Name == p2.Name && p1.Price == p2.Price && p1.Quantity == p2.Quantity;
        }
        public static bool operator !=(Product p1, Product p2)
        {
            // Обернене порівняння для оператора ==
            return !(p1 == p2);
        }
        public Product this[int index]
        {
            get
            {
                if (index >= 0 && index < products.Count)
                {
                    return products[index];
                }
                else
                {
                    throw new IndexOutOfRangeException("Invalid index");
                }
            }
            set
            {
                if (index >= 0 && index < products.Count)
                {
                    products[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Invalid index");
                }
            }
        }
        public static void DisplayProducts()
        {
          
            for (int i = 0; i < products.Count; i++)
            {
                MessageBox.Show($"Product #{i + 1}: {products[i].Info()}");
            }
        }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

     
        public virtual string Info()
        {
          return   $"Об'єкт  #{nomer} Назва: {Name}, Ціна: {Price}, Кількість: {Quantity}";
        }

        ~Product()
        {
            Console.WriteLine($"Об'єкт Product #{nomer} був знищений.");
          // count--;
        }
    }

    class Vegetable : Product
    {
        public Vegetable(string name, double price,int quantity, string color)
            : base(name, price, quantity)
        {
            Color = color;
        }
        public Vegetable():base("Test Vegetable", 10, 5)
        {
            Color = "test";
        }
        public string Color { get; set; }
        public override string Info()
        {
            return "Овоч " + base.Info() + $", Колір {Color}";
        }
        public static Vegetable operator ++(Vegetable vegetable)
        {
            vegetable.Quantity++;
            return vegetable;
        }
        public static Vegetable operator --(Vegetable vegetable)
        {
            vegetable.Quantity--;
            return vegetable;
        }
    }

    class Fruit : Product
    {
        public Fruit(string name, double price,  int quantity, string flavor)
            : base(name, price, quantity)
        {
            Flavor = flavor;
        }
        public Fruit():base("Test Fruit", 20, 3) 
        {
            Flavor = "test";
        }
        public string Flavor { get; set; }

        public override string Info()
        {
            return "Фрукт " + base.Info() + $", Смак {Flavor}";
        }
        public static Fruit operator ++(Fruit fruit)
        {
            fruit.Quantity++;
            return fruit;
        }
        public static Fruit operator --(Fruit fruit)
        {
            fruit.Quantity--;
            return fruit;
        }
    }



}
