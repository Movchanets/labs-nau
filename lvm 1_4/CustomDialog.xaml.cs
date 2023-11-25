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
using System.Windows.Shapes;

namespace lvm_1_4
{
    /// <summary>
    /// Interaction logic for CustomDialog.xaml
    /// </summary>
    public partial class CustomDialog : Window
    {
        private readonly MainWindow _mainWindow;


        public string OptionIndex { get; private set; }
        public CustomDialog(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;

        }

        private void OkBtn_Click(object sender, RoutedEventArgs e)
        {
            _mainWindow.Button_WhichOption.IsEnabled = true;
            _mainWindow.DialogResult.Text = MessageEnter.Text;
            Hide();
        }

      
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton item)
            {
                OptionIndex = item.Uid;
            }
        }

        // Приховує вікно.
        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            Hide();
        }

    }
}
