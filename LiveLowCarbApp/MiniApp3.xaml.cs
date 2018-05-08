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
    public partial class MiniApp3 : PhoneApplicationPage
    {
        public MiniApp3()
        {
            InitializeComponent();
            gordo.Visibility = Visibility.Collapsed;
            mediano.Visibility = Visibility.Collapsed;
            flaco.Visibility = Visibility.Collapsed;
            ideal.Visibility = Visibility.Collapsed;
            mediog.Visibility = Visibility.Collapsed;
            muyflaco.Visibility = Visibility.Collapsed;
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox1.Text == "" || TextBox2.Text == "")
            {
                TextBlock1.Text = "Please Fill The Fields";
                TextBlock2.Text = "";
                TextBox1.Focus();
            }
            else
            {
                double Masa = Convert.ToDouble(TextBox1.Text);
                double Estatura = Convert.ToDouble(TextBox2.Text);
                double denominador=((Estatura * Estatura) / 100);
                double Imc = ((Masa / denominador) * 100);
                TextBlock1.Text = Math.Round(Imc, 2) + " Kg/m²";
                if (Imc <= 15.99)
                {
                    TextBlock2.Text = "Severe thinness";
                    flaco.Visibility = Visibility.Collapsed;
                    gordo.Visibility = Visibility.Collapsed;
                    mediano.Visibility = Visibility.Collapsed;
                    ideal.Visibility = Visibility.Collapsed;
                    mediog.Visibility = Visibility.Collapsed;
                    muyflaco.Visibility = Visibility.Visible;
                }
                if (Imc >= 16 && Imc <= 18.49)
                {
                    TextBlock2.Text = "Thinness";
                    flaco.Visibility = Visibility.Visible;
                    gordo.Visibility = Visibility.Collapsed;
                    mediano.Visibility = Visibility.Collapsed;
                    ideal.Visibility = Visibility.Collapsed;
                    mediog.Visibility = Visibility.Collapsed;
                    muyflaco.Visibility = Visibility.Collapsed;
                }
                if (Imc > 18.49 && Imc <= 24.99)
                {
                    TextBlock2.Text = "Normal";
                    ideal.Visibility = Visibility.Visible;
                    gordo.Visibility = Visibility.Collapsed;
                    mediano.Visibility = Visibility.Collapsed;
                    flaco.Visibility = Visibility.Collapsed;
                    mediog.Visibility = Visibility.Collapsed;
                    muyflaco.Visibility = Visibility.Collapsed;
                }
                if (Imc >= 25 && Imc <= 29.99)
                {
                    TextBlock2.Text = "Overweight";
                    mediano.Visibility = Visibility.Visible;
                    gordo.Visibility = Visibility.Collapsed;
                    ideal.Visibility = Visibility.Collapsed;
                    flaco.Visibility = Visibility.Collapsed;
                    mediog.Visibility = Visibility.Collapsed;
                    muyflaco.Visibility = Visibility.Collapsed;
                }
                if (Imc >= 30 && Imc <= 39.99)
                {
                    TextBlock2.Text = "Obesity";
                    gordo.Visibility = Visibility.Collapsed;
                    mediano.Visibility = Visibility.Collapsed;
                    flaco.Visibility = Visibility.Collapsed;
                    ideal.Visibility = Visibility.Collapsed;
                    mediog.Visibility = Visibility.Visible;
                    muyflaco.Visibility = Visibility.Collapsed;

                }
                if (Imc >= 40)
                {
                    TextBlock2.Text = "Morbid obesity";
                    gordo.Visibility = Visibility.Visible;
                    mediano.Visibility = Visibility.Collapsed;
                    flaco.Visibility = Visibility.Collapsed;
                    ideal.Visibility = Visibility.Collapsed;
                    mediog.Visibility = Visibility.Collapsed;
                    muyflaco.Visibility = Visibility.Collapsed;
                }
            }
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBlock1.Text = "IMB";
            TextBlock2.Text = "";
            gordo.Visibility = Visibility.Collapsed;
            mediano.Visibility = Visibility.Collapsed;
            flaco.Visibility = Visibility.Collapsed;
            ideal.Visibility = Visibility.Collapsed;
            mediog.Visibility = Visibility.Collapsed;
            muyflaco.Visibility = Visibility.Collapsed;
            TextBox1.Focus();
        }
    }
}