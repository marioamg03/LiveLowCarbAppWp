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
            manzana.Visibility = Visibility.Collapsed;
            pera.Visibility = Visibility.Collapsed;
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            manzana.Visibility = Visibility.Collapsed;
            pera.Visibility = Visibility.Collapsed;
            if ((TextBox1.Text =="" || TextBox2.Text =="")||(RadioButton1.IsChecked==false && RadioButton2.IsChecked==false))
            {
                TextBox1.Text = "";
                TextBox1.Focus();
                TextBox2.Text ="";
                TextBlock1.Text = "Enter real fields";
                TextBlock2.Text = "";
            }
            else
            {
                double Cintura = Convert.ToDouble(TextBox1.Text);
                double Cadera = Convert.ToDouble(TextBox2.Text);
                double icc =(Cintura / Cadera);
                if (RadioButton1.IsChecked == true)
                {
                    //// HOMBRE
                    if (icc >= 0.71 || icc <= 0.84)
                    {
                        TextBlock1.Text = Math.Round(icc, 2) + " WHR";
                        TextBlock2.Text = "Within the standard body";
                     }
                    if (icc < 0.71)
                    {
                        TextBlock1.Text = Math.Round(icc, 2) + " WHR";
                        TextBlock2.Text = "Pear body";
                        pera.Visibility = Visibility.Visible;
                    }
                        if (icc > 0.84)
                        {
                            TextBlock1.Text = Math.Round(icc, 2) + " WHR";
                            TextBlock2.Text = "Apple body";
                            manzana.Visibility = Visibility.Visible;
                        }
                    }
                 if (RadioButton2.IsChecked == true)
                {
                    //MUJER
                    if (icc >= 0.78 || icc <=0.94)
                    {
                        TextBlock1.Text = Math.Round(icc, 2) + " WHR";
                        TextBlock2.Text = "Within the standard body";
                    }
                    if (icc < 0.78)
                    {
                        TextBlock1.Text = Math.Round(icc, 2) + " WHR";
                        TextBlock2.Text = "Pear body";
                        pera.Visibility = Visibility.Visible;
                    }
                    if (icc> 0.94)
                    {
                        TextBlock1.Text = Math.Round(icc, 2) + " WHR";
                        TextBlock2.Text = "Apple body";
                        manzana.Visibility = Visibility.Visible;
                    }   
                  }
                }
              }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBlock1.Text = "WHR";
            TextBlock2.Text = "";
            manzana.Visibility = Visibility.Collapsed;
            pera.Visibility = Visibility.Collapsed;
            RadioButton1.IsChecked = false;
            RadioButton2.IsChecked = false;
            TextBox1.Focus();
        }
    }
}