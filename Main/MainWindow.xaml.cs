using System.Text;
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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Event handler to switch to QR code page
        private void GoToQRCodePage_Click(object sender, RoutedEventArgs e)
        {
            // Replace content of MainContent with Qrcode.xaml
            Qrcode qrPage = new Qrcode();
            MainContent.Content = qrPage; // This replaces the current content
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Flashdrive flashdrivePage = new Flashdrive();
            MainContent.Content = flashdrivePage; // This replaces the current content
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // Load the Uniquecode UserControl into the ContentControl
            Uniquecode uniquecodePage = new Uniquecode();
            MainContent.Content = uniquecodePage; // This replaces the current content
        }
    }
}