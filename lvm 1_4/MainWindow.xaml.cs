using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace lvm_1_4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    
    public partial class MainWindow : Window
    {
        private readonly CustomDialog _customDialog;
        public MainWindow()
        {
            InitializeComponent();
            _customDialog = new CustomDialog(this);
        }
        private void YesNoCancel_Click(object sender, RoutedEventArgs e)
        {

            DialogResult.Text = MessageBox.Show("YesNoCancel кнопка натиснута",
                "YesNoCancel", MessageBoxButton.YesNoCancel, MessageBoxImage.Warning).ToString();

        }

        private void AbortRetryIgnore_Click(object sender, RoutedEventArgs e)
        {
            bool flag = false;
            do 
            {
                var aboutRetryIgnore = new AboutRetryIgnore();
                aboutRetryIgnore.ShowDialog();

                switch (aboutRetryIgnore.DialogResult)
                {
                    case AboutRetryIgnore.CustomDialogResult.Abort:
                        
                        DialogResult.Text = "Abort";
                        flag =false;
                        break;
                    case AboutRetryIgnore.CustomDialogResult.Retry:
                        
                        DialogResult.Text = "Retry";
                        flag = true;
                        break;
                    case AboutRetryIgnore.CustomDialogResult.Ignore:
                       DialogResult.Text = "Ignore";

                        
                        break;
                }
            } while (flag);
            
        }
    

    

        private void CustomDialog_Click(object sender, RoutedEventArgs e)
        {
            _customDialog.ShowDialog();
        }

        private void WhichOption_Click(object sender, RoutedEventArgs e)
        {
            DialogResult.Text = _customDialog.OptionIndex;
        }

        private void Button_Exit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {
           
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.DefaultExt = ".txt";
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            bool? result = openFileDialog.ShowDialog();

          
            if (result == true)
            {
               
                string filename = openFileDialog.FileName;
                DialogResult.Text = $"Selected File: {filename}";
            }
            else
            {
                DialogResult.Text = "No file selected";
            }
        }

        private void SaveAs_Click(object sender, RoutedEventArgs e)
        {
           
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = ".txt";
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|Lex files (*.lex)|*.lex|All files (*.*)|*.*";
            saveFileDialog.OverwritePrompt = true;
            bool? result = saveFileDialog.ShowDialog();         
            if (result == true)
            {
              
                string filename = saveFileDialog.FileName;
               
                DialogResult.Text = $"Saved As: {filename}";
                File.WriteAllText(filename, DialogResult.Text);
            }
            else
            {
                DialogResult.Text = "Save As canceled";
            }
        }
    }
}
