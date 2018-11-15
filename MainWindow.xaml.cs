using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace AmazingLauncher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string path = System.Environment.CurrentDirectory;

            Uri uri = new Uri(path + "\\APPEXE\\Amaze.exe");
            var proces =
            Process.Start(uri.ToString());
            this.WindowState = WindowState.Minimized;
            bool appworking = true;
            while (appworking)
            {
                if (proces.HasExited)
                {
                    appworking = false;
                    this.WindowState = WindowState.Normal;

                }
                else
                {
                    Thread.Sleep(1000);
                }
            }
        }

        private void Melement_Loaded(object sender, RoutedEventArgs e)
        {
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string path = System.Environment.CurrentDirectory;

            Uri uri = new Uri(path + "\\GFX\\Darude_-_Sandstorm.mid");
            Melement.Source = uri;
                Melement.Play();
        }
    }
}
