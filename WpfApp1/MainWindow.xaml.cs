using Microsoft.Win32;
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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string image = null;
        public MainWindow()
        {
            InitializeComponent();
       
        }

        private void Dashboardclick(object sender, RoutedEventArgs e)
        {
            // Handle the button click event here
            MessageBox.Show("Button clicked!");
        }
        private void PickImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.png; *.bmp)|*.jpg; *.png; *.bmp|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == true)
            {
                image = openFileDialog.FileName;
                // Do something with the selectedImagePath, like displaying it or processing the image
                
                openFileDialog.RestoreDirectory = true;

             
                    // string selectedFileName = dlg.FileName;
                    //   image.Content = selectedFileName;
                    BitmapImage bitmap = new BitmapImage();
                    bitmap.BeginInit();
                    bitmap.UriSource = new Uri(image);
                    bitmap.EndInit();
                    imgview.Source = bitmap;
            

            }
        }
       
    }
}
