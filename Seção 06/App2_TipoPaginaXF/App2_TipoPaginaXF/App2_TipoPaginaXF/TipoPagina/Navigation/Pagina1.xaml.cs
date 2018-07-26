using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2_TipoPaginaXF.TipoPagina.Navigation
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Pagina1 : ContentPage
	{
		public Pagina1 ()
		{
			InitializeComponent ();
		}

        private  void Mudarpagina2(Object sender, EventArgs args)
        {
            Navigation.PushAsync(new Pagina2());
        }
        private void ChamarModal(Object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new Modal());
        }
    }
}