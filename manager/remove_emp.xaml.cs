using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for remove_emp.xaml
    /// </summary>
    public partial class remove_emp : Window
    {
        List<user> items = new List<user>();
        List<user> items_2 = new List<user>();
        public remove_emp()
        {
            InitializeComponent();
           
           // lvUsers.ItemsSource = items;
        }
        
        public class user {
            public String Name { get; set; }
            public String age { get; set; }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            items.Clear();
           
            string empid = emp_id.Text;
          //  MessageBox.Show(empid);
            SqlConnection connect = new SqlConnection(@"Data Source=THISITHA_KAVIND\SQLEXPRESS; Initial Catalog=login; Integrated Security=SSPI;");
            //SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-FLRVOGO\SQLEXPRESS; Initial Catalog=user; Integrated Security=SSPI;");
            //SqlConnection conect = new SqlConnection(@"Data Source=THISITHA_KAVIND\SQLEXPRESS;Initial Catalog=login;Integrated Security=SSPI;");
            string query = ("DELETE FROM emp_reg WHERE id='" + empid + "'");

            SqlCommand cmd_2 = new SqlCommand(query, connect);

            //cmd_2.ExecuteNonQuery();
            SqlDataReader myreader;
            try
            {   
                connect.Open();
                myreader = cmd_2.ExecuteReader();
                MessageBox.Show("Entry Deleted Successfully");
                while (myreader.Read()) { }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Entry not deleted");
            }

           
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

              
                items.Add(new user() { Name = name, age = e_id });
           

            }

           
            lvUsers.ItemsSource = items;
           
         lvUsers.Items.Refresh();
           
          
        }
        }
    }

