using Microsoft.VisualBasic;

namespace OOPLR2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            MessageBox.Show(product.Info());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string name = Convert.ToString(Interaction.InputBox("¬вед≥ть назву продукта", "¬веденн€", " ава"));
                double price = Convert.ToDouble(Interaction.InputBox("¬вед≥ть ц≥ну продукта", "¬веденн€", "200"));
                int quantity = Convert.ToInt32(Interaction.InputBox("¬вед≥ть к≥льк≥сть продукта", "¬веденн€", "1"));
                Product product = new Product(name, price, quantity);
                MessageBox.Show(product.Info());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
          
           

        }
    }
}