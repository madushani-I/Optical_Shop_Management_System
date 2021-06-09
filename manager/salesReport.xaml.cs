
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
    /// Interaction logic for salesReport.xaml
    /// </summary>
    public partial class salesReport : Window
    {
        List<user> items = new List<user>();
        public salesReport()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection(@"Data Source=THISITHA_KAVIND\SQLEXPRESS; Initial Catalog=login; Integrated Security=SSPI;");

        public class user
        {
          public string transaction_id { get; set;}
            //  public string transaction_id { get; set; }
            public string  p_name { get; set; }
            public string p_id { get; set; }
            public string  lens_id { get; set; }

            public string l_price { get; set; }
            public string frame_id { get; set; }
            public string f_price { get; set; }
            public string t_date { get; set; }

            public string s_charge { get; set; }
            public string l_charge { get; set; }
            public string total { get; set; }


        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            connect.Open();
            string sales_r = "SELECT * FROM sales_report ;";
            SqlCommand report = new SqlCommand(sales_r, connect);

            SqlDataReader get_report_details = report.ExecuteReader();
            while (get_report_details.Read()) {
                string t_id = Convert.ToString(get_report_details["t_id"]);
                string patient_name = Convert.ToString(get_report_details["patient_name"]);
                string patient_identity = Convert.ToString(get_report_details["p_id"]);
                string l_identity = Convert.ToString(get_report_details["lens_id"]);
                string len_price = Convert.ToString(get_report_details["lens_price"]);
                string f_id = Convert.ToString(get_report_details["frame_id"]);
                string frame_price = Convert.ToString(get_report_details["frame_price"]);
                string transaction_date = Convert.ToString(get_report_details["date"]);
                string service_charge = Convert.ToString(get_report_details["service_charge"]);
                string labour_charge = Convert.ToString(get_report_details["labour_charge"]);
                string unit_p = Convert.ToString(get_report_details["unit_total"]);


                items.Add(new user() { transaction_id = t_id, p_name = patient_name ,p_id = patient_identity, lens_id = l_identity, l_price = len_price, frame_id = f_id, f_price = frame_price, t_date = transaction_date, s_charge = service_charge, l_charge = labour_charge, total = unit_p });
            }




            sales_report.ItemsSource = items;
            sales_report.Items.Refresh();
            connect.Close();
   
        }
    }
}
