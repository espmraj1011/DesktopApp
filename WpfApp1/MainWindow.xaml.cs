using System;
using System.Windows;

namespace WpfApp1
{

    public class DataObject
    {
        public string Name { get; set; }
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private const string URL = "http://localhost:8080/RESTfulExample/rest/hello/login/";
    

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (UserName.Text == "muthuraj" && password.Password == "abcd1234")
            {
                success.Content = "Login Succeed";
            }
            else
            {
                success.Content = "Login Failed";
            }

            Console.WriteLine(UserName.Text);

            
        }

    }
}
