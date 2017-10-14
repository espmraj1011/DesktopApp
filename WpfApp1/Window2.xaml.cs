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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
            dataGrid.ItemsSource = LoadCollectionData();
        }

        

        private List<Author> LoadCollectionData()
        {
            List<Author> authors = new List<Author>();
            authors.Add(new Author()
            {
                ID = 101,
                Name = "Muthuraj",
                FatherName= "Subramanian",
                Department = "Mechanical",
                City = "Tenkasi",
                DOB = new DateTime(1996, 6, 28),
                Medium = "Tamil"
            });
            authors.Add(new Author()
            {
                ID = 201,
                Name = "Guruvayurappa",
                Department = "Mechanical",
                FatherName = "Kamaraj Shanmugam",
                City = "Sankarankovil",
                DOB = new DateTime(1996, 10, 10),
                Medium = "Tamil"
            });
            authors.Add(new Author()
            {
                ID = 101,
                Name = "Prasanna Venkatesh",
                Department = "Mechanical",
                FatherName = "Rajaram",
                City = "Madurai",
                DOB = new DateTime(1995, 6, 26),
                Medium = "English"
            });
            authors.Add(new Author()
            {
                ID = 101,
                Name = "Aathithya",
                Department = "Mechanical",
                FatherName = "Jeyachandran",
                City = "Aandipatti",
                DOB = new DateTime(1995, 11, 22),
                Medium = "English"
            });
            return authors;
        }

        
    }
    public class Author
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string Medium { get; set; }
        public String City { get; set; }
        public string Department { get; set; }
        public String FatherName { get; set; }
    }
}
