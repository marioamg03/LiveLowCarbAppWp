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
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            double Masa = Convert.ToDouble (TextBox1.Text );
            double Estatura = Convert.ToDouble (TextBox2.Text );
            double Imc=0;
            if (Estatura==0)
            {
                TextBlock1.Text ="Rellenar los Campos";
            }
            else
            {
                Imc = (Masa) / (Estatura * Estatura);
                TextBlock1.Text = Math.Round(Imc, 2) + "Kg/m²";
            }

            if (Imc <= 18.49)
            {
                TextBlock2.Text = "Bajo peso";
            }
            if (Imc > 18.49 || Imc <= 24.99)
            {
                TextBlock2.Text = "Normal";
            }
            if (Imc >= 25 || Imc <=29.99)
            {
                TextBlock2.Text = "Sobrepeso";
            }
            if (Imc >= 30 || Imc <= 39.99)
            {
                TextBlock2.Text = "Obesidad";
            }
            if (Imc >=40)
            {
                TextBlock2.Text = "Obesidad mórbida";
            }
        }
    }
}