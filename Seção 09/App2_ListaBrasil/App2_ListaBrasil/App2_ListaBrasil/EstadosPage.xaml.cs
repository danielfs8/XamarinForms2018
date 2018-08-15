using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using App2_ListaBrasil.Modelo;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace App2_ListaBrasil
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EstadosPage : ContentPage
	{
		public EstadosPage ()
		{
			InitializeComponent ();

            ListaEstados.ItemsSource =  Servicos.Servico.CarregaEstados();
           


           
        }
        private void SelecaoItensAction(Object sender, SelectedItemChangedEventArgs args)
        {
            Estado estado = (Estado)args.SelectedItem;
         
            Navigation.PushAsync(new MunicipiosPage(estado));
        }

    }
}