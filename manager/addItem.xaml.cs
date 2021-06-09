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

namespace manager
{
    /// <summary>
    /// Interaction logic for addItem.xaml
    /// </summary>
    public partial class addItem : Window
    {
        public addItem()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            addFrame frame = new addFrame();
            frame.Show();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            addLens lens = new addLens();
            lens.Show();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            newStock stock = new newStock();
            stock.Show();
        }
    }
}
