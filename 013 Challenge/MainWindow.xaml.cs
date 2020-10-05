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
            
            //choices
            string subsize = "";
            string bread = "";
            string meat = "";
            string american = "";
            string swiss = "";
            string pepperjack = "";
            string cucumber = "";
            string pepper = "";
            string lettuce = "";
            string onion = "";
            string all = "";
            
            //cost
            double cost = 0;
            double peppercost = 0;
            double lettucecost = 0;
            double onioncost = 0;

            //sub size
            if (radioSix.IsChecked == true)
            {
                subsize = "Six Inch Sub, " ;
                cost = cost + 3.50;
            }
            else if (radioFoot.IsChecked == true)
            {
                subsize = "Foot Long Sub, ";
                cost = cost + 5;
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
                cost = cost + .50;
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
                cost = cost + 1;
            }
            else if (radioSteak.IsChecked == true)
            {
                meat = "Steak, ";
                cost = cost + 1.50;
            }

            //cheese
            if (checkAmerican.IsChecked == true)
            {
                american = "American, ";
                cost = cost + .25;
            }
            if (checkSwiss.IsChecked == true)
            {
                swiss = "Swiss, ";
                cost = cost + .30;
            }
            if (checkPepperjack.IsChecked == true)
            {
                pepperjack = "Pepperjack, ";
                cost = cost + .75;
            }

            //veggie
            if (checkCucumber.IsChecked == true)
            {
                cucumber = "Cucumber, ";
            }
            if (checkPepper.IsChecked == true)
            {
                pepper = "Green Pepper, ";
                peppercost = .25;
            }
            if (checkLettuce.IsChecked == true)
            {
                lettuce = "Lettuce, ";
                lettucecost = .15;
            }
            if (checkOnion.IsChecked == true)
            {
                onion = "Red Onion, ";
                onioncost = .10;
            }
            if (checkAll.IsChecked == true)
            {
                all = "All Veggies";
                cucumber = "";
                pepper = "";
                lettuce = "";
                onion = "";

                cost = cost + .25 - peppercost - lettucecost - onioncost;
            }
            if ((radioFoot.IsChecked == true)&&(radioWheat.IsChecked == true)&&(radioMeatball.IsChecked == true)&&(checkAmerican.IsChecked == true))
            {
                cost = cost - 2.00;
            }
            cost = cost + peppercost + lettucecost + onioncost;
            choiceLabel.Content = subsize + bread + meat + american + swiss + pepperjack + cucumber + pepper + lettuce + onion + all;
            costLabel.Content = "$" + cost;

        }
    }
}
