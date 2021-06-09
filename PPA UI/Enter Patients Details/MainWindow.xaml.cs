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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Enter_Patients_Details
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int max;
        public Window LoginWindow { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

   
     
        private void button1_Click(object sender, RoutedEventArgs e)
        {
          
                SqlConnection connect = new SqlConnection(@"Data Source=THISITHA_KAVIND\SQLEXPRESS; Initial Catalog=login; Integrated Security=SSPI;");
                string query1 = "INSERT INTO job_tb (right_pwr,left_pwr,lens_id,frame_id,discription,p_id) VALUES('" +right_txt.Text + "', '" + left_txt.Text + "','"+lens_txt.Text+"', '"+frame_txt.Text+"','"+dec_txt.Text+"','"+get_pid.Text+"')";
                SqlCommand cmd1 = new SqlCommand(query1, connect);
                connect.Open();
                cmd1.ExecuteNonQuery();

                MessageBox.Show("All entries are added");

                
            //string r_eye = right_txt.Text;
            //string l_eye = left_txt.Text;
            //string lenseid = lens_txt.Text;
            //string frameid = frame_txt.Text;
            //    string discription = dec_txt.Text;
            ////}
            //catch (Exception io)
            //{
            //    MessageBox.Show("Invalid data type");
            //}
        }





        private void button2_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow.Show();
            this.Close();

        }

        private void viewbtn_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection connect = new SqlConnection(@"Data Source=THISITHA_KAVIND\SQLEXPRESS; Initial Catalog=login; Integrated Security=SSPI;");
            //  SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-FLRVOGO\SQLEXPRESS; Initial Catalog=user; Integrated Security=SSPI;");
            string query = "SELECT * FROM patient_tb WHERE p_id = " + get_pid.Text;

            SqlCommand selectFrame = new SqlCommand(query, connect);
            connect.Open();

            SqlDataReader reader = selectFrame.ExecuteReader();
            reader.Read();

            string patient_name = Convert.ToString(reader["f_name"]);
            string patient_age = Convert.ToString(reader["age"]);
            string patient_date = Convert.ToString(reader["date"]);
            
            show_name.Text = patient_name;
            show_age.Text = patient_age;
            show_date.Text = patient_date;

            reader.Close();
        }
    }
}
