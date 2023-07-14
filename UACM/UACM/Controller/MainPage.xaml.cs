﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UACM.View;
using Xamarin.Forms;

namespace UACM
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

            //Para navegavilidad
            btnInicioSesion.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new InisioSesion());
            };

           /* Btn_Registro.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Registro());
            };*/


        }
        private void Btn_Registro(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new Registro());
        }
    }


}
