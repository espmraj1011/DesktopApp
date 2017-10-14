using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        public object DateTimePickerFormat { get; }

        public Window5()
        {
            InitializeComponent();
            firstName.Text = "";
            lastName.Text = "";
            dob.SelectedDate = DateTime.Today;
            company.Text = "";
            department.Text = "";
            passedOut.Text = "";
            password.Password = "";
            password1.Password = "";
        }


        private void GetIn_Button_Click(object sender, RoutedEventArgs e)
        {
            if (password.Password == password1.Password)
            {

                var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8080/RESTfulExample/rest/admin/createuser");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = "{\"firstName\":\"" + firstName.Text+"\","+
                                    "\"lastName\":\"" + lastName.Text+"\","+
                                    "\"department\":\"" + department.Text +"\","+
                                    "\"dob\":\"" + dob.SelectedDate + "\"," +
                                    "\"passedOut\":\"" + passedOut.Text + "\"," +
                                    "\"company\":\"" + company.Text + "\"," +
                                    "\"password\":\"" + password.Password + "\"" +
                                   "}";
                    Console.WriteLine(json);

                    streamWriter.Write(json);
                    streamWriter.Flush();
                    streamWriter.Close();
                }
                try
                {
                    var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                    }
                }
                catch (System.IO.IOException exp)
                {
                    Console.WriteLine("Error reading from {0}. Message = {1}", exp.Message);
                }
                
                Data_Load();
            }
            else
            {
                alert.Content = "Password doesn't match";
            }

        }
        private void Data_Load()
        {
            this.Show();
            firstName.Text = "";
            lastName.Text = "";
            dob.SelectedDate = DateTime.Today;
            
            company.Text = "";
            department.Text = "";
            passedOut.Text = "";
            password.Password = "";
            password1.Password = "";
            alert.Content = "Successfully created";
        }

        private void Sign_Button_Click(object sender, RoutedEventArgs e)
        {
            var window = new Window3();
            window.Show();
            this.Close();
        }
    }
}
