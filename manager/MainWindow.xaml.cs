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

namespace manager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Window LoginWindow { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow.Show();
          

            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            reg_employee regWindow = new reg_employee();
            regWindow.Show();
          
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            edit_employee edit_EMP_Window = new edit_employee();
            edit_EMP_Window .Show();
           
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            remove_emp re_emp = new remove_emp();
            re_emp.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            view_emp view = new view_emp();
            view.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            addItem add = new addItem();
            add.Show();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            remove_item item = new remove_item();
            item.Show();
        }

        private void button_Click_7(object sender, RoutedEventArgs e)
        {
            salesReport stock = new salesReport();
            stock.Show();
        }
    }
}
