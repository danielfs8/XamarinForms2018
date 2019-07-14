using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App1_Cell.Modelo;

namespace App1_Cell.Pagina
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListViewPage : ContentPage
	{
		public ListViewPage ()
		{
			InitializeComponent ();

            List<Funcionario> Lista = new List<Funcionario>();

            Lista.Add(new Funcionario() { Nome = "José", Cargo = "Presidente" });
            Lista.Add(new Funcionario() { Nome = "Elaine", Cargo = "Gerente" });
            Lista.Add(new Funcionario() { Nome = "Tassi", Cargo = "Administradora" });
            Lista.Add(new Funcionario() { Nome = "Marcelo", Cargo = "Vendedor" });

            ListaFuncionario.ItemsSource = Lista;

        }

        private void ItemSelecionadoAction(Object sender, SelectedItemChangedEventArgs args)
        {
            Funcionario func = (Funcionario)args.SelectedItem;

            Navigation.PushAsync(new Detail.DetailPage(func));
            
        }
        private void FeriasAction(Object sender, EventArgs args)
        {
            MenuItem menu = (MenuItem)sender;
            Funcionario func = (Funcionario)menu.CommandParameter;

            DisplayAlert("Funcionario: " +func.Nome , "Mensagem: O " + func.Nome + " ( " +  func.Cargo + " ) " + "está de férias", "OK");        }

    }
}