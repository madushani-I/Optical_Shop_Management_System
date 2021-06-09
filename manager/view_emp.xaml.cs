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
    /// Interaction logic for view_emp.xaml
    /// </summary>
    public partial class view_emp : Window
    {
        List<user> items = new List<user>();
        public view_emp()
        {
            InitializeComponent();
        }

        public class user
        {
            public String Name { get; set; }
            public String age { get; set; }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("hwllo");
           // SqlConnection connect = new SqlConnection(@"Data Source=THISITHA_KAVIND\SQLEXPRESS; Initial Catalog=login; Integrated Security=SSPI;");
           // SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-FLRVOGO\SQLEXPRESS; Initial Catalog=user; Integrated Security=SSPI;");
            SqlConnection connect = new SqlConnection(@"Data Source=THISITHA_KAVIND\SQLEXPRESS; Initial Catalog=login; Integrated Security=SSPI;");
            string query = "SELECT * FROM emp_reg WHERE [id] = " + employeeId.Text;
         
            SqlCommand selectFrame = new SqlCommand(query, connect);
            connect.Open();
            SqlDataReader reader = selectFrame.ExecuteReader();
            reader.Read();
            string name = Convert.ToString(reader["f_name"]);
            string mail = Convert.ToString(reader["email"]);
            string user_name = Convert.ToString(reader["username"]);
            string pass = Convert.ToString(reader["password"]);
            string e_id = Convert.ToString(reader["id"]);
            // MessageBox.Show(frameType + " / " + frameSize.ToString() + " / " + price.ToString() + " / " + color + " / " + fid);
            fullName.Text = name;
            empEmail.Text = mail;
            userName.Text = user_name;
            empPassword.Text = pass;
            empId.Text = e_id;
            //while (reader.Read())
            //{
            //    string frameType = Convert.ToString(reader["frame_type"]);
            //    int frameSize = Convert.ToInt32(reader["frame_size"]);
            //    decimal price = Convert.ToDecimal(reader["price"]);
            //    string color = Convert.ToString(reader["colour"]);
            //    string fid = Convert.ToString(reader["f_id"]);
            //}

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            items.Clear();
           // SqlConnection connect = new SqlConnection(@"Data Source=THISITHA_KAVIND\SQLEXPRESS; Initial Catalog=login; Integrated Security=SSPI;");
           
            // SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-FLRVOGO\SQLEXPRESS; Initial Catalog=user; Integrated Security=SSPI;");
            SqlConnection connect = new SqlConnection(@"Data Source=THISITHA_KAVIND\SQLEXPRESS; Initial Catalog=login; Integrated Security=SSPI;");
            //  lvUsers.Items.Clear();
            string query_1 = "SELECT * FROM emp_reg ";
          
            SqlCommand select_id = new SqlCommand(query_1, connect);
            connect.Open();
            SqlDataReader reader = select_id.ExecuteReader();
            //reader.Read();
            //string name = Convert.ToString(reader["f_name"]);
            //string mail = Convert.ToString(reader["email"]);
            //string user_name = Convert.ToString(reader["username"]);
            //string pass = Convert.ToString(reader["password"]);
            //string e_id = Convert.ToString(reader["id"]);
            // MessageBox.Show(frameType + " / " + frameSize.ToString() + " / " + price.ToString() + " / " + color + " / " + fid);

            while (reader.Read())
            {
                //string frameType = Convert.ToString(reader["frame_type"]);
                //int frameSize = Convert.ToInt32(reader["frame_size"]);
                //decimal price = Convert.ToDecimal(reader["price"]);
                //string color = Convert.ToString(reader["colour"]);
                //string fid = Convert.ToString(reader["f_id"]);

                string name = Convert.ToString(reader["f_name"]);
                string mail = Convert.ToString(reader["email"]);
                string user_name = Convert.ToString(reader["username"]);
                string pass = Convert.ToString(reader["password"]);
                string e_id = Convert.ToString(reader["id"]);


                items.Add(new user() { Name = name, age = e_id });
                // lvUsers.ItemsSource = items;

            }


            lvUsers.ItemsSource = items;

            lvUsers.Items.Refresh();


        }
    

    }
}
