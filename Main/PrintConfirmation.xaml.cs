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
    public partial class PrintConfirmation : Window
    {
        public PrintConfirmation()
        {
            InitializeComponent();
        }

        private void Yes_Click(object sender, RoutedEventArgs e)
        {
            // Add logic for what happens when "Yes" is clicked.
            this.Close();  // Example: Close window after confirmation.
        }

        private void No_Click(object sender, RoutedEventArgs e)
        {
            // Add logic for what happens when "No" is clicked.
            this.Close();  // Example: Close window if "No" is selected.
        }
    }
}
