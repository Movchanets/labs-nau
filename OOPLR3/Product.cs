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

        public Product()
        {
            count++;
            nomer = count;
            Name = "Test";
            Price = 100;
            Quantity = 5;


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
            Quantity = quantity;
        }

        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

     
        public virtual string Info()
        {
          return   $"Об'єкт  #{nomer} Назва: {Name}, Ціна: {Price}";
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
    }



}
