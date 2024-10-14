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
    public partial class FDfileselector : UserControl
    {
        public FDfileselector()
        {
            InitializeComponent();
            LoadFileList();
        }

        private void LoadFileList()
        {
            // Example file names - you can replace these with your actual file names
            List<string> files = new List<string>
            {
                "capstone.pdf",
                "sample1.pdf",
                "sample2.pdf",
                "sample3.pdf",
                "sample4.pdf"
            };

            // Set the ItemsSource for the ListBox
            FileList.ItemsSource = files;
        }
    }
}