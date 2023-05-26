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

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Library;

namespace _8_Test
{
    public partial class MainWindow : Window
    {
        int count = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        public class MyClass
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        private void serial_Click(object sender, RoutedEventArgs e)
        {
            string txt = txt_ser.Text;

            MyClass obj1 = new MyClass { Id = count, Name = txt };
            count++;
            DataSerialization.SerializeToFile(obj1, path.Text);
        }

        private void deser_Click(object sender, RoutedEventArgs e)
        {
            MyClass result1 = DataSerialization.DeserializeFromFile<MyClass>(path.Text);

            txt_deser.Text = result1.Name;
        }
    }
}
