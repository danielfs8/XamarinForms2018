using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1_Cell.Modelo;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1_Cell.Pagina
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListViewPage : ContentPage
	{
		public ListViewPage ()
		{
			InitializeComponent ();

            List<Funcionario> Lista = new List<Funcionario>();
            Lista.Add(new Funcionario() { Nome = "Daniel", Cargo = "Propietario" });
            Lista.Add(new Funcionario() { Nome = "Elaine", Cargo = "Gerente" });
            Lista.Add(new Funcionario() { Nome = "Jose", Cargo = "ADM" });
            ListaFuncionario.ItemsSource = Lista;
        }

        private void ItemSelecionado(object sender, SelectedItemChangedEventArgs args)
        {
            Funcionario pessoa = (Funcionario)args.SelectedItem;

            Navigation.PushAsync(new Detalhes.DetailPage(pessoa));
        }

        private void FeriasAction(Object sender, EventArgs args)
        {
            MenuItem Menu = (MenuItem)sender;
            Funcionario Func = (Funcionario)Menu.CommandParameter;

            DisplayAlert("Funcionario: "+ Func.Nome,"Mensagem: "+ Func.Cargo,"OK");
        }
        private void AbonoAction(Object sender, EventArgs args)
        {

        }

    }
}