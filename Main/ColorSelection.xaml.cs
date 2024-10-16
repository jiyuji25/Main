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

namespace Main
{
    public partial class ColorSelection : Window
    {
        public ColorSelection()
        {
            InitializeComponent();
        }

        private void Colored_Click(object sender, RoutedEventArgs e)
        {
            // Handle colored option selected
            NavigateToPreview("Colored");
        }

        private void Greyscale_Click(object sender, RoutedEventArgs e)
        {
            // Handle greyscale option selected
            NavigateToPreview("Greyscale");
        }

        private void NavigateToPreview(string colorOption)
        {
            // Find the MainWindow
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;

            // Create an instance of the Previewxaml UserControl
            Previewxaml previewControl = new Previewxaml();
            // Optionally pass the color option to the Previewxaml (you may need to modify Previewxaml to accept this)
            // previewControl.SetColorOption(colorOption);

            // Set the MainContent of MainWindow to the Previewxaml UserControl
            mainWindow.MainContent.Content = previewControl;

            // Close the ColorSelection window
            Close();
        }
    }
}