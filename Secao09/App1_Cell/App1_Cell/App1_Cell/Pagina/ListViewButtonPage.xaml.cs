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
	public partial class ListViewButtonPage : ContentPage
	{
		public ListViewButtonPage ()
		{
			InitializeComponent ();

            List<Funcionario> Lista = new List<Funcionario>();

            Lista.Add(new Funcionario() { Nome = "José", Cargo = "Presidente" });
            Lista.Add(new Funcionario() { Nome = "Elaine", Cargo = "Gerente" });
            Lista.Add(new Funcionario() { Nome = "Tassi", Cargo = "Administradora" });
            Lista.Add(new Funcionario() { Nome = "Marcelo", Cargo = "Vendedor" });

            ListaFuncionario.ItemsSource = Lista;
        }

        private void ActionFerias(Object sender, EventArgs args)
        {
            Button botao = (Button)sender;
            Funcionario func = (Funcionario)botao.CommandParameter;

            DisplayAlert("Funcionario", func.Nome + " está de férias!", "OK");
        }

    }
}