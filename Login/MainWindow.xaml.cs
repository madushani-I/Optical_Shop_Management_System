using System;
using System.Collections.Generic;
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
using System.Data.SqlClient;

namespace Login
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Window manager { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            
            comboBox.Items.Add("Eye technitian");
            comboBox.Items.Add("Manager");
            comboBox.Items.Add("Receptionist");
            comboBox.Items.Add("Workshop Operator");
        }
        int a;
        int b;
        int x=1;
        int y=2;
        int f = 3;
        int g = 4;
        int z =5;
        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (comboBox.SelectedIndex == 0) { a = 1; }
            else if (comboBox.SelectedIndex == 1) { a = 2; }
            else if (comboBox.SelectedIndex == 2) { a = 3; }
            else if (comboBox.SelectedIndex == 3) { a = 4; }

            if (IsvalidUser(user.Text, pass.Password, a) == 1)
            {

                // MessageBox.Show("eye tech valid");
                Enter_Patients_Details.MainWindow eyetectnicianwindow = new Enter_Patients_Details.MainWindow();
                eyetectnicianwindow.LoginWindow = new Login.MainWindow();
                eyetectnicianwindow.Show();
                this.Close();


            }
            else if (IsvalidUser(user.Text, pass.Password, a) == 2)
            {
                // MessageBox.Show("manager valid");
                manager.MainWindow managerwindow = new manager.MainWindow();
                managerwindow.LoginWindow = new Login.MainWindow();
                managerwindow.Show();
                this.Close();

            }
            else if (IsvalidUser(user.Text, pass.Password, a) == 3)
            {
                // MessageBox.Show("receptionist valid");
                receptionist_ui.MainWindow receptionistwindow = new receptionist_ui.MainWindow();
                receptionistwindow.LoginWindow = new Login.MainWindow();
                receptionistwindow.Show();
                this.Close();
            }
            else if (IsvalidUser(user.Text, pass.Password, a) == 4)
            {
                // MessageBox.Show("workshop operartor valid");
                workshop.MainWindow workshopwindow = new workshop.MainWindow();
                workshopwindow.LoginWindow = new Login.MainWindow();
                workshopwindow.Show();
                this.Close();

            }
            else if (IsvalidUser(user.Text, pass.Password, a) == 5){
                MessageBox.Show("Enter Valid Credentials");
            }

        }

        public int IsvalidUser(string userName, string password, int a)
        {
            DataClasses1DataContext log = new DataClasses1DataContext();
            //Database and table name change
            if (a == 1)
            {
                var q = from p in log.login_tbs
                        where p.username == user.Text && p.password == pass.Password && p.state == a
                        select p;
                if (q.Any())
                {

                    return x;

                }
            }
            else if (a == 2)
            {

                var c = from p in log.login_tbs
                        where p.username == user.Text && p.password == pass.Password && p.state == a
                        select p;

                if (c.Any())
                {

                    return y;
                }

            }
            else if (a == 3)
            {

                var d = from p in log.login_tbs
                        where p.username == user.Text && p.password == pass.Password && p.state == a
                        select p;

                if (d.Any())
                {

                    return f;
                }

            }
            else if (a == 4)
            {

                var i = from p in log.login_tbs
                        where p.username == user.Text && p.password == pass.Password && p.state == a
                        select p;

                if (i.Any())
                {

                    return g;
                }

            }
           


            return z;
            
            

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            
        }
    

         
    }

}