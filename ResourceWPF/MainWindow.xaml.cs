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

namespace ResourceWPF
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

        private void Zmiana_Click(object sender, RoutedEventArgs e)
        {
            (this.Resources["valueContent"] as ValueContent).color = Brushes.RoyalBlue;
             //jezeli umiescimy zmiany dla calego projektu i umiescimy je w app.xaml to zamias "this.Resources" wpisujemy "Application.Current.Resources"
        }
    }
}
