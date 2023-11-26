using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ResultGrid.ItemsSource = results;
           
        }
        private List<ResultItem> results = new List<ResultItem>();
        private bool TryParseDouble(string input, out double result)
        {
            return double.TryParse(input, out result);
        }

         private bool TryParseInt(string input, out int result)
        {
            return int.TryParse(input, out result);
        }
        private void CalculateExpBtn(object sender, RoutedEventArgs e)
        {
        double x = 3.49, y = 0.456, z = 0.0059;

            string xStr = Convert.ToString(Interaction.InputBox("Введіть змінну X", "Введення", x.ToString()));
            string yStr = Convert.ToString(Interaction.InputBox("Введіть змінну Y", "Введення", y.ToString()));
            string zStr = Convert.ToString(Interaction.InputBox("Введіть змінну Z", "Введення", z.ToString()));
            if (TryParseDouble(xStr, out double newX))
                x = newX;

            if (TryParseDouble(yStr, out double newY))
                y = newY;

            if (TryParseDouble(zStr, out double newZ))
                z = newZ;
            if ((14 * x + y * z) ==0)
            {
                MessageBox.Show("Знаменник не може дорівнювати 0", "Помилка");
                return;
            }
            // Обчислення виразу
            double result = (z - y) / (14 * x + y * z);

            // Виведення результатів у діалогове вікно
            MessageBox.Show($"Результат обчислень  (z - y) / (14 * x + y * z), при x ={x} ,y ={y} ,z ={z} ,: {result}", "Результат");
        }

        private void CalculateFuncBtn(object sender, RoutedEventArgs e)
        {
            double x = 3.49;

            string xStr = Convert.ToString(Interaction.InputBox("Введіть змінну X", "Введення", x.ToString()));
                if (TryParseDouble(xStr, out double newX))
                x = newX;


            // Обчислення виразу
            switch (x)
            {
                case >= 1 or < 0:
                    {
                        double result = Math.Acos(x / 4);
                        MessageBox.Show($"Результат обчислень arccos(x/4), при x ={x} : {result}", "Результат");
                        return;
                    }
                case >= 0 and < 0.25:
                    {
                        double result = Math.Log(Math.Abs(Math.PI / 15 - x));
                        MessageBox.Show($"Результат обчислень  ln|pi/15 - x|, при x ={x} : {result}", "Результат");
                        return;
                    }
                case >= 0.25 and < 1:
                    {
                        double result = Math.Pow(Math.Pow(x,2)+2.04,-3.14);
                        MessageBox.Show($"Результат обчислень (x^2 +2.04)^-3,14, при x ={x} : {result}", "Результат");
                        return;
                    }
              
            }
                       
         

        }
        public class ResultItem
        {
            public ResultItem(double x, double result)
            {
                X = x;
                Result = result;
            }
            public double X { get; set; }
           
            public double Result { get; set; }
        }
        private void CalculateFuncPointsBtn(object sender, RoutedEventArgs e)
        {
            double x = 0.6, delta = 1.5; int n = 6;
            results.Clear();
            string xStr = Convert.ToString(Interaction.InputBox("Введіть змінну X", "Введення", x.ToString()));
            if (TryParseDouble(xStr, out double newX))
                x = newX;
            if(x <0.6) 
            {
                MessageBox.Show("Змінна X не може бути меншою за 0.6", "Помилка");
                return;
            }
            for (int i = 0; i < n; i++) 
            {

                double result = (x + Math.Sin(2*x*Math.Pow(Math.E,2*x) - 8))/(x+2) ;
                MessageBox.Show($"Результат обчислень (x+sin2xe^2x - 8)/(x+2), при x ={x} : {result}", "Результат");
                results.Add(new ResultItem(x,result));
                x += delta;
            }
        }

        private void CloseBtn(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
