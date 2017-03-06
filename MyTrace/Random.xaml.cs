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

namespace MyTrace
{
    /// <summary>
    /// Interaction logic for Random.xaml
    /// </summary>
    public partial class Random : Page
    {
        public Random()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string textbox = textBox.Text;
            string textbox_2 = textBox_Copy.Text;
            string textbox_3 = textBox_Copy1.Text;

            NavigationService.Navigate(new AddAnewPerson());
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }
    }
}
