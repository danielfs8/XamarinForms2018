using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Apps_ListaBrasil.Modelo;

namespace Apps_ListaBrasil
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Estados : ContentPage
	{
		public Estados ()
		{
			InitializeComponent ();
            ListaDeEstados.ItemsSource = Servico.Servico.GetEstados();
		}

        private void SelecaoEstadosAction(object sender, SelectedItemChangedEventArgs args)
        {
            Estado estado =(Estado)args.SelectedItem;

            Navigation.PushAsync(new Municipios(estado));
        }
    }
}