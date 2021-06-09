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

namespace workshop
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow.Show();
        

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection connect = new SqlConnection(@"Data Source=THISITHA_KAVIND\SQLEXPRESS; Initial Catalog=login; Integrated Security=SSPI;");
            //SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-FLRVOGO\SQLEXPRESS; Initial Catalog=user; Integrated Security=SSPI;");

            string query = "SELECT * FROM job_tb WHERE p_id = " + txt_pid.Text;


            SqlCommand selectFrame = new SqlCommand(query, connect);

            connect.Open();
            SqlDataReader reader = selectFrame.ExecuteReader();

            reader.Read();
            string righteyepwr = Convert.ToString(reader["right_pwr"]);
            string lefteyepwr = Convert.ToString(reader["left_pwr"]);
            string lensid = Convert.ToString(reader["lens_id"]);
            string framid = Convert.ToString(reader["frame_id"]);
            string disc = Convert.ToString(reader["discription"]);

           

            show_r_pwr.Text = righteyepwr;
            show_l_pwr.Text = lefteyepwr;
            show_lid.Text = lensid;
            show_fid.Text = framid;
            show_discription.Text = disc;

           
            reader.Close();
      


         }

        private void done_btn_Click(object sender, RoutedEventArgs e)
        {
           SqlConnection connect = new SqlConnection(@"Data Source=THISITHA_KAVIND\SQLEXPRESS; Initial Catalog=login; Integrated Security=SSPI;");
       
            string query_1 = "SELECT * FROM frame_t WHERE f_id = '"+show_fid.Text+"' ";
            SqlCommand edit_frame = new SqlCommand(query_1, connect);
            connect.Open();
            SqlDataReader reader_2 = edit_frame.ExecuteReader();
         
            reader_2.Read();
             string fid = Convert.ToString(reader_2["f_id"]);
           
            string update_qty = "UPDATE frame_t set qty = qty - 1 WHERE f_id='" + fid + "';";
            SqlCommand cmd_2 = new SqlCommand(update_qty, connect);
            reader_2.Close();

            SqlDataReader myreader;
            myreader = cmd_2.ExecuteReader();
            MessageBox.Show("quantity edited");
            while (myreader.Read()) { }
          
            reader_2.Close();
            myreader.Close();


            string query_2 = "SELECT * FROM lens_t WHERE l_id = '" + show_lid.Text + "' ";
            SqlCommand edit_lens_qty = new SqlCommand(query_2, connect);
          
                reader_2 = edit_lens_qty.ExecuteReader();

            reader_2.Read();
            string lid = Convert.ToString(reader_2["l_id"]);
           
            string update_l_qty = "UPDATE lens_t set l_qty= l_qty - 1 WHERE l_id='" + lid + "';";
            SqlCommand cmd_3 = new SqlCommand(update_l_qty, connect);
            reader_2.Close();
            MessageBox.Show(Convert.ToString(fid));
            try
            {
                myreader = cmd_3.ExecuteReader();
                while (myreader.Read()) { }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lens Quantity not edited Plz contact Database Admin for more support");
            }
            reader_2.Close();
            myreader.Close();
            MessageBox.Show("reader 2.close");





            /********************************************************************************************************************************/

           
        }
    }
}
