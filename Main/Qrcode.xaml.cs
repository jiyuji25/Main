using QRCoder;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Main
{
    public partial class Qrcode : UserControl
    {
        public Qrcode()
        {
            InitializeComponent(); // Initializes the XAML components
            Loaded += Qrcode_Loaded; // Subscribe to the Loaded event
        }

        private void Qrcode_Loaded(object sender, RoutedEventArgs e)
        {
            LoadItems(); // Load items into the ListBox
            GenerateQrCode("Your data here"); // Replace with your data
        }

        private void LoadItems()
        {
            List<string> items = new List<string>
            {
                "SELECT YOUR UPLOADED FILE",  // Add your desired text here
                "File 1",
                "File 2",
                "File 3",
                "File 4"
            };

            FileListBox.ItemsSource = items; // Bind the list to the ListBox
        }

        private void GenerateQrCode(string data)
        {
            using (var qrGenerator = new QRCodeGenerator())
            {
                using (var qrCodeData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.Q))
                {
                    using (var qrCode = new QRCode(qrCodeData))
                    {
                        using (var bitmap = qrCode.GetGraphic(20)) // Adjust the size here
                        {
                            using (var memoryStream = new MemoryStream())
                            {
                                bitmap.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
                                memoryStream.Position = 0;

                                var bitmapImage = new BitmapImage();
                                bitmapImage.BeginInit();
                                bitmapImage.StreamSource = memoryStream;
                                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                                bitmapImage.EndInit();
                                bitmapImage.Freeze();

                                QrCodeImage.Source = bitmapImage; // Set the generated QR code to the Image control
                            }
                        }
                    }
                }
            }
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Handle selection changes if needed
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
