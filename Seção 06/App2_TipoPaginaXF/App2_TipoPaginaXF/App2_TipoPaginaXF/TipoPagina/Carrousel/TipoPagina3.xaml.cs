using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2_TipoPaginaXF.TipoPagina.Carrousel
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TipoPagina3 : ContentPage
	{
		public TipoPagina3 ()
		{
			InitializeComponent ();
		}
        public void MudarPagina(Object ssender, EventArgs args)
        {
            //App.Current.MainPage = new NavigationPage(new Navigation.Pagina1()) { BarBackgroundColor = Color.Blue};
            //App.Current.MainPage = new NavigationPage(new Tabbed.Abas()) { BarBackgroundColor = Color.Blue };
            App.Current.MainPage = new Tabbed.Abas(); 
        }
	}
}