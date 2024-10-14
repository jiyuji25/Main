using System.Windows.Controls;
using System.Windows;

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
            // Handle TextBox text changed event if needed
        }

        private void ReturnButton_Click(object sender, RoutedEventArgs e)
        {
            // Switch to Unangpahina.xaml
            Unangpahina unangPahina = new Unangpahina(); // Create an instance of Unangpahina
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow; // Get MainWindow reference
            mainWindow.MainContent.Content = unangPahina; // Set the content of MainContent to Unangpahina
        }

        private void FlashdriveImage_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to FDfileselector.xaml
            FDfileselector fdfilesectorPage = new FDfileselector(); // Create an instance of FDfileselector
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow; // Get MainWindow reference
            mainWindow.MainContent.Content = fdfilesectorPage; // Set the content of MainContent to FDfileselector
        }
    }
}