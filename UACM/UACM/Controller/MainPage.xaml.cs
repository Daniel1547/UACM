using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                Navigation.PushAsync(new Page1());
            };
        }
    }
}
