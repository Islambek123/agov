using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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
using asdasd.Context;

namespace asdasd
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static EFContext _efContext;
        public MainWindow()
        {
            InitializeComponent();
            DatabaseLogin();
        }

        private void DatabaseLogin()
        {/*
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from [AutoBazar]";
            cmd.Connection = con;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("AutoBazar");
            dataAdapter.Fill(dt);*/
            //dorou.ItemsSource = dt.DefaultView;
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (txtEmail.Text == string.Empty || !txtEmail.Text.Contains(".com") || txtEmail.Text.Length < 8 || txtPassword.Text == string.Empty || txtPassword.Text.Length < 6)
            {
                foreach (var item in _efContext.login.ToList())
                {
                    if (txtEmail.Text == item.Email && txtPassword.Text == item.Password)
                    {
                        

                    }
                }
            }
            else
            { }
            
        }

        private void MainForm_Loaded(object sender, RoutedEventArgs e)
        {
            _efContext = new EFContext();
        }
    }
}
