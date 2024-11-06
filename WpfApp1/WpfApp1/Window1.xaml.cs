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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            image.Visibility = Visibility.Hidden;
        }

        public class Images
        {
            public string[] images = {
                @"C:\Users\ZolotarevNI\source\repos\WpfApp1\WpfApp1\WpfApp1\lol.jpg",
                @"C:\Users\ZolotarevNI\source\repos\WpfApp1\WpfApp1\WpfApp1\stonks.jpg"
            };
        }

        public static BitmapImage GetImage(string imageUri)
        {
            var bitmapImage = new BitmapImage();

            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri(imageUri, UriKind.RelativeOrAbsolute);
            bitmapImage.EndInit();

            return bitmapImage;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            image.Visibility = (Visibility) (image.Visibility == 0 ? 1 : 0);
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Images images = new Images();
            image.Source = GetImage(images.images[1]);
        }
        private void NextWindow(object sender, RoutedEventArgs e)
        {
            Window2 window = new Window2();
            window.Show();
            this.Close();
        }
    }
}
