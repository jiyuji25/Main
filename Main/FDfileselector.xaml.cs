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
            // Example file names - replace these with your actual file names
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

        private void FileList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (FileList.SelectedItem != null)
            {
                // Get the selected file
                string selectedFile = FileList.SelectedItem.ToString();

                // Open the ColorSelection window as a dialog
                ColorSelection colorSelectionWindow = new ColorSelection();
                bool? result = colorSelectionWindow.ShowDialog();

                if (result == true)
                {
                    // User chose "Colored" option
                    MessageBox.Show("You selected to print '" + selectedFile + "' in colored.");
                }
                else if (result == false)
                {
                    // User chose "Greyscale" option
                    MessageBox.Show("You selected to print '" + selectedFile + "' in greyscale.");
                }
            }
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