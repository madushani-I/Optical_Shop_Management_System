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
    /// Interaction logic for removeLens.xaml
    /// </summary>
    public partial class removeLens : Window
    {
        public removeLens()
        {
            InitializeComponent();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string lensid = lensId.Text;

            // MessageBox.Show(empid);
            SqlConnection conect = new SqlConnection(@"Data Source=THISITHA_KAVIND\SQLEXPRESS; Initial Catalog=login; Integrated Security=SSPI;");
            //SqlConnection conect = new SqlConnection(@"Data Source=DESKTOP-FLRVOGO\SQLEXPRESS; Initial Catalog=user; Integrated Security=SSPI;");
            // SqlConnection conect = new SqlConnection(@"Data Source=THISITHA_KAVIND\SQLEXPRESS;Initial Catalog=login;Integrated Security=SSPI;");
            string query = ("DELETE FROM lens_t WHERE l_id='" + lensid + "'");

            SqlCommand cmd_2 = new SqlCommand(query, conect);

            //cmd_2.ExecuteNonQuery();
            SqlDataReader myreader;
            try
            {
                conect.Open();
                myreader = cmd_2.ExecuteReader();
                MessageBox.Show("Entry Deleted Successfully");
                while (myreader.Read()) { }
            }
            catch (Exception io)
            {
                MessageBox.Show("Entry not deleted");
            }


            //string query = "from emp_reg in emp_reg.id select emp_reg"
        }
    }
}
