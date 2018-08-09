using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1_Cell.Pagina;
using App1_Cell.Modelo;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1_Cell.Pagina
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TextCellPage : ContentPage
	{
		public TextCellPage ()
		{
			InitializeComponent ();

            List<Funcionario> Lista = new List<Funcionario>();
            Lista.Add(new Funcionario() { Nome = "José", Cargo = "Gerente"});
            Lista.Add(new Funcionario() { Nome = "Tassi", Cargo = "Admin" });
            Lista.Add(new Funcionario() { Nome = "Daniel", Cargo = "Developer" });
            Lista.Add(new Funcionario() { Nome = "Elaine", Cargo = "Gestora" });
        }
	}
}