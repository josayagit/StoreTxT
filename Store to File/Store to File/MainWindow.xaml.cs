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
using System.IO;


namespace Store_to_File
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        
        private void txbPassword_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        
        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {


            writingMethod();
            MessageBox.Show("You have successfully stored your data");
            txbModuleName.Clear();
            txbModuleCode.Clear();


        }

        public void writingMethod()
        {
            string file = "mytextfile.txt";
            string folder = @"C:\";

            //StreamWriter write = new StreamWriter(file);
            //write.WriteLine("Module Code: " + txbModuleCode.Text + "\n" + "Module Name: " + txbModuleName.Text);
            //write.Close();

            //string output = File.ReadAllText(file);




            StreamWriter writee = new StreamWriter(file, append:true);
            writee.WriteLine("Module Code: " + txbModuleCode.Text + "\n" + "Module Name: " + txbModuleName.Text);
           writee.Close();

            string output2 = File.ReadAllText(file);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("YOUR DATA IS STORED");
        }
    }
}
