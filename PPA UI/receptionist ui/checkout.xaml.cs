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
    /// Interaction logic for checkout.xaml
    /// </summary>
    public partial class checkout : Window
    {
        public checkout()
        {
            InitializeComponent();
        }
        string pid;
        string name;
        string lens;
        string frame;
        float lens_p;
        float frame_p;
        float s_charge;
        float l_charge;
        float total;
        SqlConnection connect = new SqlConnection(@"Data Source=THISITHA_KAVIND\SQLEXPRESS; Initial Catalog=login; Integrated Security=SSPI;");
        private void button_Click(object sender, RoutedEventArgs e)
        {
            patient_Details pati = new patient_Details();
            pati.Show();
            this.Close();
        }

        private void view_btn_Click(object sender, RoutedEventArgs e)
        {
            

            string query = "SELECT * FROM patient_tb WHERE p_id = " + chk_pid.Text;

            string get_lens_id = "SELECT * FROM job_tb WHERE p_id =" +chk_pid.Text;
            string get_frame_id = "SELECT * FROM job_tb WHERE p_id =" + chk_pid.Text;

            SqlCommand chek = new SqlCommand(query,connect);
            connect.Open();
            SqlDataReader check_read = chek.ExecuteReader();
            check_read.Read();
           pid = Convert.ToString(check_read["p_id"]);
           name = Convert.ToString(check_read["f_name"]);
            string age = Convert.ToString(check_read["age"]);
            
            check_read.Close();


            SqlCommand chek_1 = new SqlCommand(get_lens_id, connect);
            SqlDataReader check_reader_1 = chek_1.ExecuteReader();
            check_reader_1.Read();
             lens = Convert.ToString(check_reader_1["lens_id"]);
            check_reader_1.Close();


            SqlCommand chek_2 = new SqlCommand(get_frame_id, connect);
            SqlDataReader check_reader_2 = chek_2.ExecuteReader();
            check_reader_2.Read();
            frame = Convert.ToString(check_reader_2["frame_id"]);
            check_reader_2.Close();


            string get_lens_price = "SELECT * FROM lens_t WHERE l_id = " + lens;       
            string get_frame_price = "SELECT * FROM frame_t WHERE f_id = " + frame;


            SqlCommand chek_3 = new SqlCommand(get_frame_price, connect);
            SqlDataReader check_reader_3 = chek_3.ExecuteReader();
            check_reader_3.Read();
            string frame_1 = Convert.ToString(check_reader_3["price"]);
            check_reader_3.Close();

          


            SqlCommand chek_4 = new SqlCommand(get_lens_price, connect);
            SqlDataReader check_reader_4 = chek_4.ExecuteReader();
            check_reader_4.Read();
            string lens_1 = Convert.ToString(check_reader_4["price"]);
            check_reader_4.Close();


            chk_name.Text = name;
            chk_age.Text = age;
            //chk_lens.Text = lens;
            //chk_frame.Text = frame;
            frame_pri.Text = frame_1;
            lens_pri.Text = lens_1;

        }

       

        private void chk_service_TextChanged(object sender, TextChangedEventArgs e)
        {
           
            lens_p = float.Parse(frame_pri.Text);
         frame_p = float.Parse(lens_pri.Text);
         s_charge = float.Parse(chk_service.Text);
          l_charge = float.Parse(chk_labour.Text);
          total = s_charge + l_charge+frame_p+lens_p ;
            chk_Gtotal.Text = Convert.ToString(total);

            string insertSales = "INSERT INTO sales_report (patient_name,p_id,lens_id,lens_price,frame_id,frame_price,date) VALUES('" + name + "','" + pid + "','" + lens + "','" + lens_p + "','" + frame + "','" + frame_p + "','" + DateTime.Today + "')";

            SqlCommand report1_2 = new SqlCommand(insertSales, connect);
        
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string query_get = "SELECT * FROM patient_tb WHERE p_id = " + pid;

            SqlCommand selectFrame = new SqlCommand(query_get, connect);

            SqlDataReader reader_pid = selectFrame.ExecuteReader();
            reader_pid.Read();

            string patientName = Convert.ToString(reader_pid["f_name"]);

            string insertSales = "INSERT INTO sales_report (patient_name,p_id,lens_id,lens_price,frame_id,frame_price,date,service_charge,labour_charge,unit_total) VALUES('" + name + "','" + pid + "','" + lens + "','" + lens_p + "','" + frame + "','" + frame_p + "','" + DateTime.Today + "','"+ s_charge + "','"+l_charge+"','"+total+"')";
            MessageBox.Show("got pid");
            reader_pid.Close();
            SqlCommand report1_2 = new SqlCommand(insertSales, connect);
            report1_2.ExecuteNonQuery();
            MessageBox.Show("All entries are added");
        }
    }
}
