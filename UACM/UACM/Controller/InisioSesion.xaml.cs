using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UACM.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class InisioSesion : ContentPage
	{
		public InisioSesion ()
		{
			InitializeComponent ();


        }


        private void Btn_AceptarInicioSesion(object sender, EventArgs e)
        {
           this.Navigation.PushModalAsync(new Principal());

        }
    }

}