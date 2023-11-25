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
    /// Interaction logic for AboutRetryIgnore.xaml
    /// </summary>
    
    public partial class AboutRetryIgnore : Window
    {
        public enum CustomDialogResult
        {
            Abort,
            Retry,
            Ignore
        }
        public CustomDialogResult DialogResult { get; private set; }

        public AboutRetryIgnore()
        {
            InitializeComponent();
        }

        private void Abort_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = CustomDialogResult.Abort;
            Close();
        }

        private void Retry_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = CustomDialogResult.Retry;
            Close();
        }

        private void Ignore_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = CustomDialogResult.Ignore;
            Close();
        }
    }
}
