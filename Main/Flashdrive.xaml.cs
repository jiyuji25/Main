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

namespace Main
{
    /// <summary>
    /// Interaction logic for Flashdrive.xaml
    /// </summary>
    public partial class Flashdrive : UserControl
    {
        public Flashdrive()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ReturnButton_Click(object sender, RoutedEventArgs e)
        {
            // Switch to Unangpahina.xaml
            Unangpahina unangPahina = new Unangpahina(); // Create an instance of Unangpahina
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow; // Get MainWindow reference
            mainWindow.MainContent.Content = unangPahina; // Set the content of MainContent to Unangpahina
        }
    }
}
