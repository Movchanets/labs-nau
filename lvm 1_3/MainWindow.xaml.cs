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

namespace lvm_1_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static RoutedCommand ExitCommand = new RoutedCommand();
        public static RoutedCommand MessageCommand = new RoutedCommand();
        public static RoutedCommand AboutCommand = new RoutedCommand();
        public static RoutedCommand CheckCommand = new RoutedCommand();
        public bool IsChecked { get; set; } = false;
        public MainWindow()
        {
            

            InitializeComponent();
            ExitCommand.InputGestures.Add(new KeyGesture(Key.E, ModifierKeys.Control));
            MessageCommand.InputGestures.Add(new KeyGesture(Key.M, ModifierKeys.Control));
            AboutCommand.InputGestures.Add(new KeyGesture(Key.A, ModifierKeys.Control));
            CheckCommand.InputGestures.Add(new KeyGesture(Key.K, ModifierKeys.Control));
        }


        private void Message_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This is a message.");
        }

        private void Check_Click(object sender, RoutedEventArgs e)
        {
            MenuItem checkMenuItem = (MenuItem)sender;
            checkMenuItem.IsChecked = !checkMenuItem.IsChecked;

            
            MenuItem messageMenuItem = (MenuItem)((MenuItem)checkMenuItem.Parent).Items[0];
            messageMenuItem.IsEnabled = !checkMenuItem.IsChecked;
        }
        private void Check_toolbar(object sender, RoutedEventArgs e)
        {
            toolbar_click.IsEnabled = false;
            
        }
        private void Uncheck_toolbar(object sender, RoutedEventArgs e)
        {
            toolbar_click.IsEnabled = true;

        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This is your application's About dialog.");
        }
        private void Cut_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("The Cut command was invoked.");
        }
        private void Copy_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("The Copy command was invoked.");
        }
        private void Paste_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("The Paste command was invoked.");
        }
        private void Exit_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void Message_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if(IsChecked == false) { 
            MessageBox.Show("This is a message.");
        }
        }
        private void About_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("This is your application's About dialog.");
        }
        private void Check_Executed(object sender, ExecutedRoutedEventArgs e)
        {   IsChecked = !IsChecked;

            check.IsChecked = IsChecked;
            check1.IsChecked = IsChecked;
            msg1.IsEnabled = !IsChecked;
            msg.IsEnabled = !IsChecked;
        }
    }
}
