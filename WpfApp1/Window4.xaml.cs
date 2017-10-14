using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
            CallGetMethod();
        }

        private void CallGetMethod()
        {
            string url = "http://localhost:8080/RESTfulExample/rest/admin/allusers";
            string strResult = string.Empty;
            HttpWebRequest webrequest = (HttpWebRequest)WebRequest.Create(url);
            webrequest.Method = "GET";
            webrequest.ContentType = "application/json";
            HttpWebResponse webresponse = (HttpWebResponse)webrequest.GetResponse();
            Encoding enc = System.Text.Encoding.GetEncoding("utf-8");
            StreamReader loResponseStream = new StreamReader
                (webresponse.GetResponseStream(), enc);
            strResult = loResponseStream.ReadToEnd();
            loResponseStream.Close();
            webresponse.Close();
            List<UserDetails> m = JsonConvert.DeserializeObject<List<UserDetails>>(strResult);

            Console.WriteLine("String " 
                + strResult);

            Console.WriteLine("m " + m[0].Company);
            dataGrid.ItemsSource = m;

        }
        public class RootObject
        {
            public List<UserDetails> user { get; set; }
        }

        private List<UserDetails> LoadCollectionData()
        {
            List<UserDetails> authors = new List<UserDetails>();
            return authors;
        }

        public class UserDetails
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Company { get; set; }
            public int Id { get; set; }
            public int PassedOut { get; set; }
            public string Department { get; set; }
        }
    }
}
