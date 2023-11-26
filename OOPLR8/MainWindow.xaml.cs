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

namespace OOPLR8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CloseBtn(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Func1Btn(object sender, RoutedEventArgs e)
        {
            string xStr = Convert.ToString(Interaction.InputBox("Введіть речення", "Введення", "додаток з інтерактивною формою"));
           
            StringBuilder sb = new StringBuilder();
            foreach (char c in xStr)
            {
                sb.Append(c);
                if (char.IsLetter(c)) { sb.Append('?'); }
              
            }

            MessageBox.Show($"Результат: {sb}, вхідний текст: {xStr}  ", "Результат");
        }

        private void Func2Btn(object sender, RoutedEventArgs e)
        {
            string xStr = Convert.ToString(Interaction.InputBox("Введіть речення", "Введення", "Ніколи не кажи ніколи"));
            string[] words = xStr.Split(' ');

            
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Replace("не", "");
            }

            string result = string.Join(" ", words);



            MessageBox.Show($"Результат: {result}, вхідний текст: {xStr}  ", "Результат");
        }
    }
}
