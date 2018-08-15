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
	public partial class ViewCellPage : ContentPage
	{
		public ViewCellPage ()
		{
			InitializeComponent ();

            List<Funcionario> Lista = new List<Funcionario>();
            Lista.Add(new Funcionario() { Nome = "Daniel", Cargo = "Propietario" });
            Lista.Add(new Funcionario() { Nome = "Elaine", Cargo = "Gerente" });
            Lista.Add(new Funcionario() { Nome = "Jose", Cargo = "ADM" });
            ListaFuncionario.ItemsSource = Lista;
        }
	}
}