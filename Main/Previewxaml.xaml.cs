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
    public partial class Previewxaml : UserControl
    {
        public Previewxaml()
        {
            InitializeComponent();
        }

        // Method to set the color option
        public void SetColorOption(string colorOption)
        {
            // Use the colorOption to update UI elements, e.g., display the selected color
            // Example: ColorTextBlock.Text = $"Color: {colorOption}";
        }
    }
}