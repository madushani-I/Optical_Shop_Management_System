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

namespace receptionist_ui
{
    /// <summary>
    /// Interaction logic for patient_Details.xaml
    /// </summary>
    public partial class patient_Details : Window
    {
        List<user> items = new List<user>();
        List<user> items_2 = new List<user>();
        public patient_Details()
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
            SqlConnection connect = new SqlConnection(@"Data Source=THISITHA_KAVIND\SQLEXPRESS; Initial Catalog=login; Integrated Security=SSPI;");
            //SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-FLRVOGO\SQLEXPRESS; Initial Catalog=user; Integrated Security=SSPI;");
            string query = "SELECT * FROM patient_tb WHERE [p_id] = " + patient_Id.Text;

            SqlCommand selectFrame = new SqlCommand(query, connect);
            connect.Open();
            SqlDataReader reader = selectFrame.ExecuteReader();
            reader.Read();

            string pid = Convert.ToString(reader["p_id"]);
            string name = Convert.ToString(reader["f_name"]);
            string email = Convert.ToString(reader["email"]);
            string contact = Convert.ToString(reader["contact"]);
            string address = Convert.ToString(reader["address"]);
            string age = Convert.ToString(reader["age"]);
            string date = Convert.ToString(reader["date"]);

            box_name.Text = name;
            box_email.Text = email;
            box_contact.Text = contact;
            box_address.Text = address;
            box_age.Text = age;
            box_date.Text = date;

           // MessageBox.Show(pid+ " / " +name+ " / " + email + " / " + contact + " / " + address+ "/" +"/" + age+ "/" +date);

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            receptionist_ui.MainWindow max = new MainWindow();
            max.Show();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            checkout chek = new checkout();
            chek.Show();
            this.Close();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            items.Clear();
            SqlConnection connect = new SqlConnection(@"Data Source=THISITHA_KAVIND\SQLEXPRESS; Initial Catalog=login; Integrated Security=SSPI;");

            string query = "SELECT * FROM patient_tb ";
            SqlCommand selectFrame = new SqlCommand(query, connect);
            connect.Open();
            SqlDataReader reader = selectFrame.ExecuteReader();


            while (reader.Read())
            {


                string name = Convert.ToString(reader["f_name"]);
                string e_id = Convert.ToString(reader["p_id"]);


                items.Add(new user() { Name = name, age = e_id });


            }


            lvUsers.ItemsSource = items;

            lvUsers.Items.Refresh();

        }
    }
}
