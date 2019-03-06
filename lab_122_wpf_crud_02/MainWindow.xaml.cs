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

namespace lab_122_wpf_crud_02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    // MAIN WINDW : WELCOME PAGE TO ACCESS STUDENT DATABASE
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StudentDataWindow window = new StudentDataWindow();
            window.Show();
            this.Close();
        }
    }
}
