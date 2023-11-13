using Microsoft.VisualBasic;

namespace OOPLR3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vegetable vegetable = new Vegetable();
            Fruit fruit = new Fruit();
            Product product = vegetable;
            MessageBox.Show(product.Info());
            product = fruit;
            MessageBox.Show(product.Info());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vegetable product = new Vegetable();
            MessageBox.Show(product.Info());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Fruit product = new Fruit();
            MessageBox.Show(product.Info());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string name = Convert.ToString(Interaction.InputBox("¬вед≥ть назву продукта", "¬веденн€", "ќг≥рок"));
                string color = Convert.ToString(Interaction.InputBox("¬вед≥ть  ол≥р продукта", "¬веденн€", "«елений"));
                double price = Convert.ToDouble(Interaction.InputBox("¬вед≥ть ц≥ну продукта", "¬веденн€", "20"));
                int quantity = Convert.ToInt32(Interaction.InputBox("¬вед≥ть к≥льк≥сть продукта", "¬веденн€", "2"));
                Vegetable product = new Vegetable(name, price, quantity, color);
                MessageBox.Show(product.Info());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string name = Convert.ToString(Interaction.InputBox("¬вед≥ть назву продукта", "¬веденн€", "јпельсин"));
                string flavor = Convert.ToString(Interaction.InputBox("¬вед≥ть смак продукта", "¬веденн€", "—олодкий"));
                double price = Convert.ToDouble(Interaction.InputBox("¬вед≥ть ц≥ну продукта", "¬веденн€", "60"));
                int quantity = Convert.ToInt32(Interaction.InputBox("¬вед≥ть к≥льк≥сть продукта", "¬веденн€", "2"));
                Fruit product = new Fruit(name, price, quantity, flavor);
                MessageBox.Show(product.Info());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show($" ≥льк≥сть об'Їкт≥в {Product.Count}");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button a = new Button();
            Random rand = new Random();
            a.Location = new Point(rand.Next(0, 500), rand.Next(0, 500));
            a.Size = new Size(100, 50);
            a.Text = ((Button)sender).Text;
            a.Click += button8_Click;
            a.Parent = this;
            a.Show();

        }

        private void button9_Click(object sender, EventArgs e)
        {

            Random rand = new Random();
            foreach (Control control in Controls)
            {
                if (control is Button && control != sender)
                {
                    control.Location = new Point(rand.Next(0, 500), rand.Next(0, 500));
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {

            foreach (Control control in Controls)
            {
                if (control is Button && control != sender)
                {
                    control.Left -= 10;
                }
            }

        }
    }
}