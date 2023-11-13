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
            // ����� ��������� ��'���� Fruit
            fruit = new Fruit();
            MessageBox.Show(fruit.Info());
        }
        private void btnCreateVegetable_Click(object sender, EventArgs e)
        {
            // ����� ��������� ��'���� Vegetable
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
                MessageBox.Show("�������� ������� ��'��� �����.");
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
                MessageBox.Show("�������� ������� ��'��� �����.");
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
                MessageBox.Show("�������� ������� ��'��� ������.");
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
                MessageBox.Show("�������� ������� ��'��� ������.");
            }
        }
        private void btnEditFruit_Click(object sender, EventArgs e)
        {
            if (!ReferenceEquals(fruit, null))
            {
                string name = Convert.ToString(Interaction.InputBox("������ ����� ��������", "��������", fruit.Name));
                string flavor = Convert.ToString(Interaction.InputBox("������ ���� ��������", "��������", fruit.Flavor));
                double price = Convert.ToDouble(Interaction.InputBox("������ ���� ��������", "��������", fruit.Price.ToString()));
                int quantity = Convert.ToInt32(Interaction.InputBox("������ ������� ��������", "��������", fruit.Quantity.ToString()));
                fruit.Name = name;
                fruit.Price = price;
                fruit.Quantity = quantity;
                fruit.Flavor = flavor;

            }
            else
            {
                MessageBox.Show("�������� ������� ��'��� ������.");
            }
        }
        private void btnEditVegetable_Click(object sender, EventArgs e)
        {
            if (!ReferenceEquals(vegetable, null))
            {
                string name = Convert.ToString(Interaction.InputBox("������ ����� ��������", "��������", vegetable.Name));
                string color = Convert.ToString(Interaction.InputBox("������ ���� ��������", "��������", vegetable.Color));
                double price = Convert.ToDouble(Interaction.InputBox("������ ���� ��������", "��������", vegetable.Price.ToString()));
                int quantity = Convert.ToInt32(Interaction.InputBox("������ ������� ��������", "��������", vegetable.Quantity.ToString()));
                vegetable.Name = name;
                vegetable.Price = price;
                vegetable.Quantity = quantity;
                vegetable.Color = color;
            }
            else
            {
                MessageBox.Show("�������� ������� ��'��� �����.");
            }
        }
        private void btnDestroyFruit_Click(object sender, EventArgs e)
        {
            if (!ReferenceEquals(fruit, null))
            {
                // ����� �������� ��'���� Fruit
                fruit = null;
                MessageBox.Show("��'��� ������ ��� ��������.");
            }
            else
            {
                MessageBox.Show("��'��� ������ �������.");
            }
        }
        private void btnDestroyVegetable_Click(object sender, EventArgs e)
        {
            if (!ReferenceEquals(vegetable, null))
            {
                // ����� �������� ��'���� Vegetable
                vegetable = null;
                MessageBox.Show("��'��� ����� ��� ��������.");
            }
            else
            {
                MessageBox.Show("��'��� ����� �������.");
            }
        }
        private void btnInfoFruit_Click(object sender, EventArgs e)
        {
            if (!ReferenceEquals(fruit, null))
            {
                // ����� ��������� ���������� ��� ��'��� Fruit
                MessageBox.Show(fruit.Info());
            }
            else
            {
                MessageBox.Show("��'��� ������ �������.");
            }
        }
        private void btnInfoVegatable_Click(object sender, EventArgs e)
        {
            if (!ReferenceEquals(vegetable, null))
            {
                // ����� ��������� ���������� ��� ��'��� Vegetable
                MessageBox.Show(vegetable.Info());
            }
            else
            {
                MessageBox.Show("��'��� ����� �������.");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Product.DisplayProducts();
        }

        private void btnBinaryOperators_Click(object sender, EventArgs e)
        {
         
            if (ReferenceEquals(fruit, null) || ReferenceEquals(vegetable, null)) {
                MessageBox.Show("��'���� ������.");
            }
            else
            {
               
                // ������������ == 
                bool areEqual = (vegetable == fruit);
                // ��������� ����������
                MessageBox.Show($"Product1 � Product2 ���: {areEqual}");
            }
        }

       
    }
}