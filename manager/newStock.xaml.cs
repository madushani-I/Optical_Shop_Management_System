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
using System.Collections;
using System.Data;

namespace manager
{
    /// <summary>
    /// Interaction logic for newStock.xaml
    /// </summary>
    public partial class newStock : Window
    {
        List<user> item = new List<user>();
 
        public newStock()
        {
            InitializeComponent();
            comboBox.Items.Add("Lens");
            comboBox.Items.Add("Frame");
            comboBox.SelectedIndex = 1;

        }

        public class user
        {
            public string i_name { get; set; }
            public string i_id { get; set; }
            public string i_qty { get; set; }
        }
        SqlConnection connect = new SqlConnection(@"Data Source=THISITHA_KAVIND\SQLEXPRESS; Initial Catalog=login; Integrated Security=SSPI;");

        private void button_Click(object sender, RoutedEventArgs e)
        {
            item.Clear();
            if (comboBox.SelectedIndex == 0)
            {
                connect.Open();
                string get_lid = "SELECT * FROM lens_t;";
                SqlCommand getl_id = new SqlCommand(get_lid, connect);
                SqlDataReader get_l_id = getl_id.ExecuteReader();
                while (get_l_id.Read()) {
                    string l_name = Convert.ToString(get_l_id["lens_type"]);
                    string lens_id = Convert.ToString(get_l_id["l_id"]);
                    string qty_l = Convert.ToString(get_l_id["l_qty"]);
                    item.Add(new user { i_name = l_name, i_id = lens_id,  i_qty = qty_l });
                }

            }
            else if (comboBox.SelectedIndex == 1)
            {
                item.Clear();
                connect.Open();
                string get_id = "SELECT * FROM frame_t;";
                SqlCommand getf_id = new SqlCommand(get_id, connect);
                SqlDataReader get_f_id = getf_id.ExecuteReader();
                while (get_f_id.Read())
                {
                   
                    string id = Convert.ToString(get_f_id["f_id"]);
                    string name = Convert.ToString(get_f_id["frame_type"]);
                    string qty_f = Convert.ToString(get_f_id["qty"]);
                    item.Add(new user { i_name = name, i_id = id , i_qty = qty_f });
                }

            }
            else { MessageBox.Show("Enter a valid Item Type"); }
            connect.Close();
            listView.ItemsSource = item;
            listView.Items.Refresh();

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (comboBox.SelectedIndex == 0)
            {
                connect.Open();
                string edit_lens = "UPDATE lens_t set l_qty = l_qty + '" + quantity.Text + "' WHERE l_id = '" + item_id.Text + "' ";
                SqlCommand e_lens = new SqlCommand(edit_lens, connect);
                e_lens.ExecuteNonQuery();
                MessageBox.Show("Quantity added is  " +quantity.Text);
                connect.Close();
            }
            else if(comboBox.SelectedIndex == 1)
            {
                connect.Open();
                string edit_frame = "UPDATE frame_t set qty = qty +  '" + quantity.Text + "' WHERE f_id = '" + item_id.Text + "';";
                SqlCommand e_frame = new SqlCommand(edit_frame, connect);
                e_frame.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Quantity added is  " + quantity.Text);


            }
        }
    }
}
