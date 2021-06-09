using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// Interaction logic for addLens.xaml
    /// </summary>
    public partial class addLens : Window
    {
        public addLens()
        {
            InitializeComponent();
        }
        private void reg_Click(object sender, RoutedEventArgs e)
        {
            string type = lensType.Text;

            string price = lensPrice.Text;
            string colour = lensColour.Text;
            string lens_qty = lensQty.Text;

            Exception Exception = new Exception();
            SqlConnection connect = new SqlConnection(@"Data Source=THISITHA_KAVIND\SQLEXPRESS; Initial Catalog=login; Integrated Security=SSPI;");
            //SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-FLRVOGO\SQLEXPRESS; Initial Catalog=user; Integrated Security=SSPI;");
            //  SqlConnection connect = new SqlConnection(@"Data Source=THISITHA_KAVIND\SQLEXPRESS; Initial Catalog=login; Integrated Security=SSPI;");
            string query = "INSERT INTO lens_t(lens_type ,price, colour,l_qty) VALUES('" + type + "','" + price + "','" + colour + "','"+lens_qty+"')";

            SqlCommand cmd_2 = new SqlCommand(query, connect);
            connect.Open();
            cmd_2.ExecuteNonQuery();
            MessageBox.Show("All entries are added");


        }


    }
}