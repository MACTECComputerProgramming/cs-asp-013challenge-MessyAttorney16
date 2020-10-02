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
            string meat = "";
            string veggie = "";
            string american = "";
            string swiss = "";
            string pepperjack = "";
            string cucumber = "";
            string pepper = "";
            string lettuce = "";
            string onion = "";
            string all = "";

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

            //meat
            if (radioHam.IsChecked == true)
            {
                meat = "Ham, ";
            }
            else if (radioChicken.IsChecked == true)
            {
                meat = "Roasted Chicken, ";
            }
            else if (radioMeatball.IsChecked == true)
            {
                meat = "Meatball, ";
            }
            else if (radioSteak.IsChecked == true)
            {
                meat = "Steak, ";
            }

            //cheese
            if (checkAmerican.IsChecked == true)
            {
                american = "American, ";
            }
            if (checkSwiss.IsChecked == true)
            {
                swiss = "Swiss, ";
            }
            if (checkPepperjack.IsChecked == true)
            {
                pepperjack = "Pepperjack, ";
            }

            //veggie
            if (checkCucumber.IsChecked == true)
            {
                cucumber = "Cucumber, ";
            }
            if (checkPepper.IsChecked == true)
            {
                pepper = "Green Pepper, ";
            }
            if (checkLettuce.IsChecked == true)
            {
                lettuce = "Lettuce, ";
            }
            if (checkOnion.IsChecked == true)
            {
                onion = "Red Onion, ";
            }
            if (checkAll.IsChecked == true)
            {
                all = "All Veggies";
                cucumber = "";
                pepper = "";
                lettuce = "";
                onion = "";
            }

            choiceLabel.Content = subsize + bread + meat + american + swiss + pepperjack + cucumber + pepper + lettuce + onion + all;


        }
    }
}
