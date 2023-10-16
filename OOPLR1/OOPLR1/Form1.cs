namespace OOPLR1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Розпочинаємо вивчення основ ООП");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ненавиджу вінформи");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Можна хоча б WPF ");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("закінчилися ідеї для сповіщення ");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("добре що хоч .net core");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}