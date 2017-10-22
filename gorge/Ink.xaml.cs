using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace gorge
{
    /// <summary>
    /// Interaction logic for Ink.xaml
    /// </summary>
    public partial class Ink : Window
    {
        private CheckBoxTester checkBoxTester = new CheckBoxTester();

        public Ink()
        {
            InitializeComponent();
            this.DataContext = checkBoxTester;
        }
        private void SetTrue_Click(object sender, RoutedEventArgs e)
        {
            checkBoxTester.TestChecked = true;
        }
        private void SetFalse_Click(object sender, RoutedEventArgs e)
        {
            checkBoxTester.TestChecked = false;
        }
    }
}
    