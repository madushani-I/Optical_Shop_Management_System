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
    /// Interaction logic for edit_employee.xaml
    /// </summary>
    public partial class edit_employee : Window
    {
        List<user> items = new List<user>();
        List<user> items_2 = new List<user>();
        public edit_employee()
        {
            InitializeComponent();
        }
        public class user{
            public string name { get; set; }
            public string emp_id { get; set; }

            }
       

        private void edit_Click(object sender, RoutedEventArgs e)
        {

            string edit_name = edit_f_name.Text;
            string edit_mail = edit_email.Text;
            string edit_u_name = edit_username.Text;
            string password = edit_password.Password;
            string empid = edit_empid.Text;

            SqlConnection conect = new SqlConnection(@"Data Source=THISITHA_KAVIND\SQLEXPRESS; Initial Catalog=login; Integrated Security=SSPI;");
       
            //SqlConnection conect = new SqlConnection(@"Data Source=DESKTOP-FLRVOGO\SQLEXPRESS; Initial Catalog=user; Integrated Security=SSPI;");
            string query = "UPDATE emp_reg set f_name = '" + edit_name + "',email='" + edit_mail + "',username='" + edit_u_name + "',password='" + password + "'  WHERE id='" + empid + "';";

            SqlCommand cmd_2 = new SqlCommand(query, conect);
            
            
            SqlDataReader myreader;
            try
            {
                conect.Open();
                myreader = cmd_2.ExecuteReader();
                MessageBox.Show("Entry Edited Successfully");
                while (myreader.Read()) { }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Entry not Edited");
                this.Close();

              
            }
        }

        private void back_btn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow manWindow = new MainWindow();
            manWindow.Show();
            this.Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            items.Clear();
            SqlConnection connect = new SqlConnection(@"Data Source=THISITHA_KAVIND\SQLEXPRESS; Initial Catalog=login; Integrated Security=SSPI;");

            string query = "SELECT * FROM emp_reg ";
            SqlCommand selectFrame = new SqlCommand(query, connect);
            connect.Open();
            SqlDataReader reader = selectFrame.ExecuteReader();


            while (reader.Read())
            {


                string name = Convert.ToString(reader["f_name"]);
                string mail = Convert.ToString(reader["email"]);
                string user_name = Convert.ToString(reader["username"]);
                string pass = Convert.ToString(reader["password"]);
                string e_id = Convert.ToString(reader["id"]);


                items.Add(new user() { name = name, emp_id = e_id });


            }


            emp_list.ItemsSource = items;

            emp_list.Items.Refresh();
        }
    }
}
