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
    /// Interaction logic for reg_employee.xaml
    /// </summary>
    public partial class reg_employee : Window
    {
        int role_combo;
        public reg_employee()
        {
            InitializeComponent();


        role.Items.Add("Eye technitian");
            role.Items.Add("Manager");
        role.Items.Add("Receptionist");
            role.Items.Add("Workshop Operator");
        }


        private void reg_Click(object sender, RoutedEventArgs e)
        {
            string fname = f_name.Text;
            string emp_email = email.Text;
            string emp_username = username.Text;
            string emp_password = password.Password;
            string emp_c_password = c_password.Password;

            if (role.SelectedIndex == 0) { role_combo = 1; }
            else if (role.SelectedIndex == 1) { role_combo = 2; }
            else if (role.SelectedIndex == 2) { role_combo = 3; }
            else if (role.SelectedIndex == 3) { role_combo = 4; }
            

            Exception Exception = new Exception();

            if (emp_c_password.Equals(emp_password)) /*|| (role.SelectedIndex != 0) && (role.SelectedIndex != 1) && (role.SelectedIndex != 2) && (role.SelectedIndex != 3) )*/
            {
                if (role.SelectedIndex == 1 || role.SelectedIndex == 2 || role.SelectedIndex == 3 || role.SelectedIndex == 4)
                {
                    SqlConnection connect = new SqlConnection(@"Data Source=THISITHA_KAVIND\SQLEXPRESS; Initial Catalog=login; Integrated Security=SSPI;");
                    ///SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-FLRVOGO\SQLEXPRESS; Initial Catalog=user; Integrated Security=SSPI;");
                    string query = "INSERT INTO emp_reg(f_name,email,username,password,state) VALUES('" + fname + "','" + emp_email + "','" + emp_username + "','" + emp_password + "','" + role_combo + "')";
                    string loginValue = " INSERT INTO login_tb(username,password,state) VALUES('" + emp_username + "','" + emp_password + "','" + role_combo + "')";
                    SqlCommand cmd_2 = new SqlCommand(query, connect);
                    SqlCommand cmd = new SqlCommand(loginValue, connect);
                    connect.Open();
                    cmd_2.ExecuteNonQuery();
                    cmd.ExecuteNonQuery();

                    // ((role.SelectedIndex != 0) && (role.SelectedIndex != 1) && (role.SelectedIndex != 2) && (role.SelectedIndex != 3)) { MessageBox.Show("Select a roal"); }


                    MessageBox.Show("All entries are added");
                }
                else
                {
                    MessageBox.Show("enter a valid entry type");
                        }

            }

            //else
            //{
            //    MessageBox.Show("dfgdfgdfgdfg");
            //}
        }

        private void back_btn_Click(object sender, RoutedEventArgs e)
        {
            //MainWindow manWindow = new MainWindow();
            //manWindow.Show();
            //this.Close();
            manager.MainWindow max = new MainWindow();
            max.Show();
        }

        //public static bool EmailIsValid(string email)
        //{
        //    string expression = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

        //    if (Regex.IsMatch(email, expression))
        //    {
        //        if (Regex.Replace(email, expression, string.Empty).Length == 0)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
    }
}
