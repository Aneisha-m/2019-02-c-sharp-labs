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

namespace Lab_15_Panels
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Tracks which panel we are on
        int index;

        public MainWindow()
        {
            InitializeComponent();
            Intialize();
        }
        void Initialize()
        {
            index = 1;
        }
        private void ButtonChangePanel_Click(object sender, RoutedEventArgs)
        {
            index++;
            if(index == 4)
            {
                index = 1;
            }
            displayPanel(index);
        }

            void displayPanel(int index)
             {
        switch(index)
        {
            case 1:
                StackPanel101.Visibility = Visibility.Visible;
                StackPanel102.Visibility = Visibility.Collapsed;
                StackPanel103.Visibility = Visibility.Collapsed;
                break;

            case 2:
                StackPanel101.Visibility = Visibility.Collapsed;
                StackPanel102.Visibility = Visibility.Visible;
                StackPanel103.Visibility = Visibility.Collapsed;
                break;
            case 3:
                StackPanel101.Visibility = Visibility.Collapsed;
                StackPanel102.Visibility = Visibility.Collapsed;
                StackPanel103.Visibility = Visibility.Visible;
                break;

        }
    }
        private void ButtonChangePanel_Click(object sender, RoutedEventArgs)
        {
            if (TabControl.SelectedIndex < TabControl.Items.Count-1)
            {
                TabControl101.SelectedIndex++;
            }
            else
            {
                TabControl.SelectedIndex = 0;
            }
        }
        private void ButtonChangeTabByName_Click(object sender, RoutedEventArgs)
        {
            MessageBox.Show((TabControl101.SelectedItem as TabItem).Header.ToString());
            switch (headerName)
            {
                case "First":
                    TabControl01.SelectedIndex = (int)tabs.Second;
                    break;
                case "Second":
                    TabControl02.SelectedIndex = (int)tabs.Third;
                    break;
                case "Third":
                    TabControl03.SelectedIndex = (int)tabs.First;
                    break;
            }

        }
}
