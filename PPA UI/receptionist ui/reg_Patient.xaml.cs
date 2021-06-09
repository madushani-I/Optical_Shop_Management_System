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
    /// Interaction logic for reg_Patient.xaml
    /// </summary>
    public partial class reg_Patient : Window
    {
        public reg_Patient()
        {
            InitializeComponent();
        }

        string patient_id;

        SqlConnection connect = new SqlConnection(@"Data Source=THISITHA_KAVIND\SQLEXPRESS; Initial Catalog=login; Integrated Security=SSPI;");

        private void reg_Click(object sender, RoutedEventArgs e)
        {
            try
            {

               // SqlConnection connect = new SqlConnection(@"Data Source=THISITHA_KAVIND\SQLEXPRESS; Initial Catalog=login; Integrated Security=SSPI;");
                //SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-FLRVOGO\SQLEXPRESS; Initial Catalog=user; Integrated Security=SSPI;");
                string query = "INSERT INTO patient_tb (f_name,email,contact,address,age,date) VALUES('" + man_name_txt.Text + "','" + man_email_txt.Text + "','" + man_contact_txt.Text + "','"+address.Text+"','" + man_age_txt.Text + "','"+DateTime.Today+"')";
                // string loginValue = " INSERT INTO login_tb(username,password,state) VALUES('" + fname + "','" + emp_password + "','" + role_combo + "')";
                SqlCommand cmd = new SqlCommand(query, connect);
                //SqlCommand cmd = new SqlCommand(loginValue, connect);
                connect.Open();
                cmd.ExecuteNonQuery();
                // cmd.ExecuteNonQuery();

                MessageBox.Show("All entries are added");
               


                //string patientname = man_name_txt.Text;
                //string patientemail = man_email_txt.Text;
                //string patientcontact = man_contact_txt.Text;
                //string patientage = man_age_txt.Text;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Pleasw enter valid details");
            }


           
            string shw_pid_query = "SELECT * FROM patient_tb";
            SqlCommand shw_pid_cmd = new SqlCommand(shw_pid_query,connect);
            SqlDataReader read_pid = shw_pid_cmd.ExecuteReader();

            while (read_pid.Read())
            {
                patient_id= Convert.ToString(read_pid["p_id"]);
            }

            shw_pid.Text = patient_id;
        

            
        }

        private void bck_btn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow rec = new MainWindow();
            rec.Show();
            this.Close();
        }
    }
}
