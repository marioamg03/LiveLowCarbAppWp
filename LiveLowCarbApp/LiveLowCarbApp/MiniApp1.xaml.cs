using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace LiveLowCarbApp
{
    public partial class MiniApp1 : PhoneApplicationPage
    {
        public MiniApp1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            double Peso = Convert.ToDouble (TextBox1.Text);
            int Altura = Convert.ToInt32(TextBox2.Text);
            int Edad = Convert.ToInt32(TextBox3.Text);
            double TMB = 0;

            if (RadioButton1.IsChecked == false && RadioButton2.IsChecked == false)
            {
                TextBlock1.Text = "";
            }

            if (RadioButton1.IsChecked == false && RadioButton2.IsChecked == true)
            {
                TMB = (10 * Peso) + (6.25 * Altura) - (5 * Edad) + 5;
                TextBlock1.Text = TMB + " TMB";
            }

            if (RadioButton1.IsChecked == true && RadioButton2.IsChecked == false)
            {
                TMB = (10 * Peso) + (6.25 * Altura) - (5 * Edad) - 161;
                TextBlock1.Text = TMB + " TMB";
            }

        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBlock1.Text = "";
        }
    }
}