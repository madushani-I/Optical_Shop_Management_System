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
    /// Interaction logic for remove_item.xaml
    /// </summary>
    public partial class remove_item : Window
    {
        public remove_item()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            removeFrame frame = new removeFrame();
            frame.Show();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            removeLens lens = new removeLens();
            lens.Show();
        }
    }
}
