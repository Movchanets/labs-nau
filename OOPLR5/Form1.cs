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
            // Ћог≥ка створенн€ об'Їкта Fruit
            fruit = new Fruit();
            MessageBox.Show(fruit.Info());
        }
        private void btnCreateVegetable_Click(object sender, EventArgs e)
        {
            // Ћог≥ка створенн€ об'Їкта Vegetable
            vegetable = new Vegetable("Carrot", 1.5, 8, "Orange");
            MessageBox.Show(vegetable.Info());
        }
        private void btnEditFruit_Click(object sender, EventArgs e)
        {
            if (fruit != null)
            {
                string name = Convert.ToString(Interaction.InputBox("¬вед≥ть назву продукта", "¬веденн€", fruit.Name));
                string flavor = Convert.ToString(Interaction.InputBox("¬вед≥ть смак продукта", "¬веденн€", fruit.Flavor));
                double price = Convert.ToDouble(Interaction.InputBox("¬вед≥ть ц≥ну продукта", "¬веденн€", fruit.Price.ToString()));
                int quantity = Convert.ToInt32(Interaction.InputBox("¬вед≥ть к≥льк≥сть продукта", "¬веденн€", fruit.Quantity.ToString()));
                fruit.Name = name;
                fruit.Price = price;
                fruit.Quantity = quantity;
                fruit.Flavor = flavor;

            }
            else
            {
                MessageBox.Show("—початку створ≥ть об'Їкт фрукту.");
            }
        }
        private void btnEditVegetable_Click(object sender, EventArgs e)
        {
            if (vegetable != null)
            {
                string name = Convert.ToString(Interaction.InputBox("¬вед≥ть назву продукта", "¬веденн€", vegetable.Name));
                string color = Convert.ToString(Interaction.InputBox("¬вед≥ть  ол≥р продукта", "¬веденн€", vegetable.Color));
                double price = Convert.ToDouble(Interaction.InputBox("¬вед≥ть ц≥ну продукта", "¬веденн€", vegetable.Price.ToString()));
                int quantity = Convert.ToInt32(Interaction.InputBox("¬вед≥ть к≥льк≥сть продукта", "¬веденн€", vegetable.Quantity.ToString()));
                vegetable.Name = name;
                vegetable.Price = price;
                vegetable.Quantity = quantity;
                vegetable.Color = color;
            }
            else
            {
                MessageBox.Show("—початку створ≥ть об'Їкт овоча.");
            }
        }
        private void btnDestroyFruit_Click(object sender, EventArgs e)
        {
            if (fruit != null)
            {
                // Ћог≥ка знищенн€ об'Їкта Fruit
                fruit = null;
                MessageBox.Show("ќб'Їкт фрукту був знищений.");
            }
            else
            {
                MessageBox.Show("ќб'Їкт фрукту в≥дсутн≥й.");
            }
        }
        private void btnDestroyVegetable_Click(object sender, EventArgs e)
        {
            if (vegetable != null)
            {
                // Ћог≥ка знищенн€ об'Їкта Vegetable
                vegetable = null;
                MessageBox.Show("ќб'Їкт овоча був знищений.");
            }
            else
            {
                MessageBox.Show("ќб'Їкт овоча в≥дсутн≥й.");
            }
        }
        private void btnInfoFruit_Click(object sender, EventArgs e)
        {
            if (fruit != null)
            {
                // Ћог≥ка виведенн€ ≥нформац≥њ про об'Їкт Fruit
                MessageBox.Show(fruit.Info());
            }
            else
            {
                MessageBox.Show("ќб'Їкт фрукту в≥дсутн≥й.");
            }
        }
        private void btnInfoVegatable_Click(object sender, EventArgs e)
        {
            if (vegetable != null)
            {
                // Ћог≥ка виведенн€ ≥нформац≥њ про об'Їкт Vegetable
                MessageBox.Show(vegetable.Info());
            }
            else
            {
                MessageBox.Show("ќб'Їкт овоча в≥дсутн≥й.");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
           Product.DisplayProducts();
        }
    }
}