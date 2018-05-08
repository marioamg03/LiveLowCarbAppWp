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
    public partial class MiniApp2 : PhoneApplicationPage
    {
        public MiniApp2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            double Cintura = Convert.ToDouble(TextBox1.Text);
            double Cadera = Convert.ToDouble(TextBox2.Text);
            double icc = 0;
            if (Cadera == 0)
            {
                ///// Mostrar que no es posible
            }
            else
            {
                icc = (Cintura / Cadera);
                if (RadioButton1.IsChecked == true)
                {
                    //// MUJER
                    if (icc >= 0.71 || icc <= 0.84)
                    {
                        TextBlock1.Text = Math.Round(icc, 2) + " ICC";
                        TextBlock2.Text = "Cuerpo dentro del estandar";
                    }
                    if (icc < 0.71)
                    {
                        TextBlock1.Text = Math.Round(icc, 2) + " ICC";
                        TextBlock2.Text = "Cuerpo de pera.";
                    }
                    else
                    {
                        if (icc > 0.84)
                        {
                            TextBlock1.Text = Math.Round(icc, 2) + " ICC";
                            TextBlock2.Text = "Cuerpo de manzana.";
                        }
                    }
                }
                if (RadioButton2.IsChecked == true)
                {
                    if (icc >= 0.78 || icc <=0.94)
                    {
                        TextBlock1.Text = Math.Round(icc, 2) + " ICC";
                        TextBlock2.Text = "Cuerpo dentro del estandar";
                    }
                    if (icc < 0.78)
                    {
                        TextBlock1.Text = Math.Round(icc, 2) + " ICC";
                        TextBlock2.Text = "Cuerpo de pera.";
                    }
                    else
                    {
                    if (icc> 0.94)
                    {
                        TextBlock1.Text = Math.Round(icc, 2) + " ICC";
                        TextBlock2.Text = "Cuerpo de manzana.";
                    }   
                    }
                }
            }
        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBlock1.Text = "";
            TextBlock2.Text = "";
            RadioButton1.IsChecked = false;
            RadioButton2.IsChecked = false;
            TextBox1.Focus();
        }
    }
}