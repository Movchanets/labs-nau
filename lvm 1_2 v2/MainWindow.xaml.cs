using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace lvm_1_2_v2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<string> ComboBoxItems { get; set; } = new List<string> { "notepad.exe", "calc.exe", "cmd.exe" };
        public MainWindow()
        {
            InitializeComponent();
            ComboBox.ItemsSource = ComboBoxItems;
        }

        private void Show_msg(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(MessageText.Text);
        }

        private void Default_msg(object sender, RoutedEventArgs e)
        {
            MessageText.Text = "Enter a message here.";
        }

        private void Clear_msg(object sender, RoutedEventArgs e)
        {
            MessageText.Text = "";
        }

        private void Run_program(object sender, RoutedEventArgs e)
        {
            if (ComboBox.SelectedItem != null)
            {
                Process.Start(ComboBox.SelectedItem.ToString());
            }
            else
            {
                try
                {
                    Process.Start(ComboBox.Text);
                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }


            }
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Msg_action_check(object sender, RoutedEventArgs e)
        {
            Show_button.IsEnabled = true;
        }
        private void Msg_action_uncheck(object sender, RoutedEventArgs e)
        {
        Show_button.IsEnabled = false;
        }
        private void Program_action_check(object sender, RoutedEventArgs e)
        {
            Run_button.IsEnabled = true;
        }
        private void Program_action_uncheck(object sender, RoutedEventArgs e)
        {
            Run_button.IsEnabled = false;
        }
        private void Msg_show_check(object sender, RoutedEventArgs e)
        {
            Show_button.Visibility = Visibility.Visible;
        }
        private void Msg_show_uncheck(object sender, RoutedEventArgs e)
        {
            Show_button.Visibility = Visibility.Hidden;
        }
        private void Program_show_check(object sender, RoutedEventArgs e)
        {
            Run_button.Visibility = Visibility.Visible;
        }
        private void Program_show_uncheck(object sender, RoutedEventArgs e)
        {
            Run_button.Visibility = Visibility.Hidden;
        }

        private void Get_text(object sender, RoutedEventArgs e)
        {
            string selectedText = ComboBox.SelectedItem as string;

            if (!string.IsNullOrEmpty(selectedText))
            {
                MessageBox.Show("Поточне значення поля із списком: " + selectedText);
            }
            else
            {
                MessageBox.Show("Поле із списком порожнє.");
            }
        }
    }
}