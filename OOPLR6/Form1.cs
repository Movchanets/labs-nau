using Microsoft.VisualBasic;

namespace OOPLR3
{
    public partial class Form1 : Form
    {
        private Fruit fruit = null;
        private Vegetable vegetable = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnCreateFruit_Click(object sender, EventArgs e)
        {
            // Логіка створення об'єкта Fruit
            fruit = new Fruit();
            MessageBox.Show(fruit.Info());
        }
        private void btnCreateVegetable_Click(object sender, EventArgs e)
        {
            // Логіка створення об'єкта Vegetable
            vegetable = new Vegetable("Carrot", 1.5, 8, "Orange");
            MessageBox.Show(vegetable.Info());
        }
        private void btnVegetableQuantityUp_Click(object sender, EventArgs e)
        {
            if (!ReferenceEquals(vegetable, null))
            {

                vegetable++;
                MessageBox.Show(vegetable.Info());
            }
            else
            {
                MessageBox.Show("Спочатку створіть об'єкт овоча.");
            }
        }
        private void btnVegetableQuantityDown_Click(object sender, EventArgs e)
        {
            if (!ReferenceEquals(vegetable, null))
            {
                if (vegetable.Quantity == 0) { return; }
                vegetable--;
                MessageBox.Show(vegetable.Info());
            }
            else
            {
                MessageBox.Show("Спочатку створіть об'єкт овоча.");
            }
        }
        private void btnFruitQuantityUp_Click(object sender, EventArgs e)
        {
            if (!ReferenceEquals(fruit, null))
            {

                fruit++;
                MessageBox.Show(fruit.Info());
            }
            else
            {
                MessageBox.Show("Спочатку створіть об'єкт фрукта.");
            }
        }
        private void btnFruitQuantityDown_Click(object sender, EventArgs e)
        {
            
            if (!ReferenceEquals(fruit, null) )
            {
                if(fruit.Quantity == 0) { return; }
                fruit--;
                MessageBox.Show(fruit.Info());
            }
            else
            {
                MessageBox.Show("Спочатку створіть об'єкт фрукта.");
            }
        }
        private void btnEditFruit_Click(object sender, EventArgs e)
        {
            if (!ReferenceEquals(fruit, null))
            {
                string name = Convert.ToString(Interaction.InputBox("Введіть назву продукта", "Введення", fruit.Name));
                string flavor = Convert.ToString(Interaction.InputBox("Введіть смак продукта", "Введення", fruit.Flavor));
                double price = Convert.ToDouble(Interaction.InputBox("Введіть ціну продукта", "Введення", fruit.Price.ToString()));
                int quantity = Convert.ToInt32(Interaction.InputBox("Введіть кількість продукта", "Введення", fruit.Quantity.ToString()));
                fruit.Name = name;
                fruit.Price = price;
                fruit.Quantity = quantity;
                fruit.Flavor = flavor;

            }
            else
            {
                MessageBox.Show("Спочатку створіть об'єкт фрукту.");
            }
        }
        private void btnEditVegetable_Click(object sender, EventArgs e)
        {
            if (!ReferenceEquals(vegetable, null))
            {
                string name = Convert.ToString(Interaction.InputBox("Введіть назву продукта", "Введення", vegetable.Name));
                string color = Convert.ToString(Interaction.InputBox("Введіть Колір продукта", "Введення", vegetable.Color));
                double price = Convert.ToDouble(Interaction.InputBox("Введіть ціну продукта", "Введення", vegetable.Price.ToString()));
                int quantity = Convert.ToInt32(Interaction.InputBox("Введіть кількість продукта", "Введення", vegetable.Quantity.ToString()));
                vegetable.Name = name;
                vegetable.Price = price;
                vegetable.Quantity = quantity;
                vegetable.Color = color;
            }
            else
            {
                MessageBox.Show("Спочатку створіть об'єкт овоча.");
            }
        }
        private void btnDestroyFruit_Click(object sender, EventArgs e)
        {
            if (!ReferenceEquals(fruit, null))
            {
                // Логіка знищення об'єкта Fruit
                fruit = null;
                MessageBox.Show("Об'єкт фрукту був знищений.");
            }
            else
            {
                MessageBox.Show("Об'єкт фрукту відсутній.");
            }
        }
        private void btnDestroyVegetable_Click(object sender, EventArgs e)
        {
            if (!ReferenceEquals(vegetable, null))
            {
                // Логіка знищення об'єкта Vegetable
                vegetable = null;
                MessageBox.Show("Об'єкт овоча був знищений.");
            }
            else
            {
                MessageBox.Show("Об'єкт овоча відсутній.");
            }
        }
        private void btnInfoFruit_Click(object sender, EventArgs e)
        {
            if (!ReferenceEquals(fruit, null))
            {
                // Логіка виведення інформації про об'єкт Fruit
                MessageBox.Show(fruit.Info());
            }
            else
            {
                MessageBox.Show("Об'єкт фрукту відсутній.");
            }
        }
        private void btnInfoVegatable_Click(object sender, EventArgs e)
        {
            if (!ReferenceEquals(vegetable, null))
            {
                // Логіка виведення інформації про об'єкт Vegetable
                MessageBox.Show(vegetable.Info());
            }
            else
            {
                MessageBox.Show("Об'єкт овоча відсутній.");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Product.DisplayProducts();
        }

        private void btnBinaryOperators_Click(object sender, EventArgs e)
        {
         
            if (ReferenceEquals(fruit, null) || ReferenceEquals(vegetable, null)) {
                MessageBox.Show("Об'єкти відсутні.");
            }
            else
            {
               
                // Використання == 
                bool areEqual = (vegetable == fruit);
                // Виведення інформації
                MessageBox.Show($"Product1 і Product2 рівні: {areEqual}");
            }
        }

       
    }
}