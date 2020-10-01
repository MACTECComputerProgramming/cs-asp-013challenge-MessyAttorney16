using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace _013_Challenge
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

        private void orderButton_Click(object sender, RoutedEventArgs e)
        {
            choiceLabel.Content = "";
            costLabel.Content = "";
            string subsize = "";
            string bread = "";

            //sub size
            if (radioSix.IsChecked == true)
            {
                subsize = "Six Inch Sub, " ;
            }
            else if (radioFoot.IsChecked == true)
            {
                subsize = "Foot Long Sub, ";
            }
            
            //bread
            if (radioWheat.IsChecked == true)
            {
                bread = "Wheat Bread, ";
            }
            else if (radioItalian.IsChecked == true)
            {
                bread = "Italian Bread, ";
            }
            else if (radioFlat.IsChecked == true)
            {
                bread = "Flatbread, ";
            }

            choiceLabel.Content = subsize + bread;

            ////meat
            //if (radioHam.IsChecked == true)
            //{
            //    choiceLabel.Content = "Ham, ";
            //}
            //else if (radioChicken.IsChecked == true)
            //{
            //    choiceLabel.Content = "Roasted Chicken, ";
            //}
        }
    }
}
