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
            if (RadioButton1.IsChecked == false && RadioButton2.IsChecked == false)
            {
                TextBlock1.Text = "Enter your gender";
            }

            if (TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "")
            {
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBlock1.Text = "Please Fill The Fields";
            }
            else
            {
                double Peso = Convert.ToDouble(TextBox1.Text);
                int Altura = Convert.ToInt32(TextBox2.Text);
                int Edad = Convert.ToInt32(TextBox3.Text);
                double TMB = 0;
                double fisico = 0;

                if (RadioButton1.IsChecked == false && RadioButton2.IsChecked == true)
                {
                    // ES UNA MUJER
                    TMB = (10 * Peso) + (6.25 * Altura) - (5 * Edad) + 5;
                    TextBlock1.Text = TMB + " Kcal/day";
                }

                if (RadioButton1.IsChecked == true && RadioButton2.IsChecked == false)
                {
                    // ES UN HOMBRE
                    TMB = (10 * Peso) + (6.25 * Altura) - (5 * Edad) - 161;
                    TextBlock1.Text = TMB + " Kcal/day";
                }
                if (RadioButton3.IsChecked == true && RadioButton4.IsChecked == false && RadioButton5.IsChecked ==  false)
                {
                    //bajo
                    fisico=TMB*(1.4);
                    TextBlock2.Text = fisico + " kcal/day according to their physical activity";
                }
                if (RadioButton3.IsChecked == false && RadioButton4.IsChecked == true && RadioButton5.IsChecked == false)
                {
                    //medio
                    fisico = TMB * (1.6);
                    TextBlock2.Text = fisico + " kcal/day according to their physical activity";
                }
                if (RadioButton3.IsChecked == false && RadioButton4.IsChecked == false && RadioButton5.IsChecked == true)
                {
                    //alto
                    fisico = TMB * (2.2);
                    TextBlock2.Text = fisico + " kcal/day according to their physical activity";
                }
            }
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {

            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBlock1.Text = "BMR";
            TextBlock2.Text = "";
            RadioButton1.IsChecked = false;
            RadioButton2.IsChecked = false;
            TextBox1.Focus();
        }
    }
}