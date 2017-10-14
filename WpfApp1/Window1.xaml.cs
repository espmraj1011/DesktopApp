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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            
        }

        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            int a, b, c;
            a = int.Parse(num1.Text);
            b=int.Parse(num2.Text);
            c = a + b;
            string res = c.ToString();
            result.Text =res;

        }

        private void Sub_Button_Click(object sender, RoutedEventArgs e)
        {
            int a, b, c;
            a = int.Parse(num1.Text);
            b = int.Parse(num2.Text);
            c = a - b;
            string res = c.ToString();
            result.Text = res;
        }

        private void Mul_Button_Click(object sender, RoutedEventArgs e)
        {
            int a, b, c;
            a = int.Parse(num1.Text);
            b = int.Parse(num2.Text);
            c = a * b;
            string res = c.ToString();
            result.Text = res;
        }
        private void Div_Button_Click(object sender, RoutedEventArgs e)
        {
            int a, b, c;
            a = int.Parse(num1.Text);
            b = int.Parse(num2.Text);
            c = a / b;
            string res = c.ToString();
            result.Text = res;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            var window = new Window4();
            window.Show();
            this.Close();
            
        }
    }
}
