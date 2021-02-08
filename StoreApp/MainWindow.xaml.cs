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

namespace StoreApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void Focus(ComboBox cmdtitle)
        {
            List<string> titles = new List<string>()
            {
                "Mr.",
                "Miss",
                "Md.",
                "Mrs."
            };
            this.cmdtitle.ItemsSource = titles;
        }
        public MainWindow()
        {
            this.MaxHeight = 496;
            this.MaxWidth = 794;
            InitializeComponent();
            this.Focus(cmdtitle);
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"ID \t  :{text_id.Text} \nName \t  :{cmdtitle.SelectedItem +" "+ text_Fname.Text+" "+text_Lname.Text} \nEmail \t  :{text_Email.Text} \nContact No :+88{text_ContactNo.Text}");
        }
    }
}
