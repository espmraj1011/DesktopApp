using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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

    public class Device
    {
        public int id { get; set; }
        public double ratedPowerKA { get; set; }
        public string status { get; set; }
        public bool active { get; set; }
        public int customerId { get; set; }
        public string companyName { get; set; }
        public string deviceProfile { get; set; }
        public int deviceId { get; set; }
        public double ratedPowerKW { get; set; }
        public int clusterId { get; set; }
        public int facilityId { get; set; }
        public string deviceClass { get; set; }
        public string deviceName { get; set; }
        public string readingDateTime { get; set; }
        public string clusterName { get; set; }
        public string shortDescription { get; set; }
        public string facilityName { get; set; }
        public string deviceProfileName { get; set; }
        public string deviceSubClass { get; set; }
        public string deviceClassName { get; set; }
        public string longDescription { get; set; }
    }
    public class Status
    {
        public string status { get; set; }
    }

        public class RootObject
    {
        public List<Device> device { get; set; }
    }
    public class User
    {
        public String resp { get; set; }
    }
    /// <summary>
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        { 
            if (CallGetMethod())
            {
                signInBut.Visibility = Visibility.Hidden;
                var window = new Window1();
                window.Show();
                this.Close();
            }
            else
            {
                signInBut.Visibility = Visibility.Visible;
                status.Content="Invalid Username/Password";
            }
        }
        private Boolean CallGetMethod()
        {
            var result = "";
            string url = "http://localhost:8080/RESTfulExample/rest/admin/login";
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "{\"firstName\":\"" + userName.Text + "\"," +
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
                    result = streamReader.ReadToEnd();
                }
            }
            catch (System.IO.IOException exp)
            {
                Console.WriteLine("Error reading from {0}. Message = {1}", exp.Message);
            }
            User m = JsonConvert.DeserializeObject<User>(result);
            Console.WriteLine("String " + result);

            Console.WriteLine("m " + m.resp);
            if (m.resp == "true")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    
}
