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
            Product product = new Product();
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
                string name = Convert.ToString(Interaction.InputBox("������ ����� ��������", "��������", "�����"));
                string color = Convert.ToString(Interaction.InputBox("������ ���� ��������", "��������", "�������"));
                double price = Convert.ToDouble(Interaction.InputBox("������ ���� ��������", "��������", "20"));
                int quantity = Convert.ToInt32(Interaction.InputBox("������ ������� ��������", "��������", "2"));
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
                string name = Convert.ToString(Interaction.InputBox("������ ����� ��������", "��������", "��������"));
                string flavor = Convert.ToString(Interaction.InputBox("������ ���� ��������", "��������", "��������"));
                double price = Convert.ToDouble(Interaction.InputBox("������ ���� ��������", "��������", "60"));
                int quantity = Convert.ToInt32(Interaction.InputBox("������ ������� ��������", "��������", "2"));
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
            MessageBox.Show($"ʳ������ ��'���� {Product.Count}");
        }

      
    }
}