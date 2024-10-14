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
            DialogResult = true; // Indicate the dialog was accepted
            Close();
        }

        private void Greyscale_Click(object sender, RoutedEventArgs e)
        {
            // Handle greyscale option selected
            DialogResult = false; // Indicate the dialog was canceled
            Close();
        }
    }
}