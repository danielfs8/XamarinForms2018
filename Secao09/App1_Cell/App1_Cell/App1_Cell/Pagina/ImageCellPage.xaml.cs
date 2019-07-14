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
	public partial class ImageCellPage : ContentPage
	{
		public ImageCellPage ()
		{
			InitializeComponent ();

            List<Funcionario> Lista = new List<Funcionario>();

            Lista.Add(new Funcionario() {Foto = "homen1.jpg", Nome = "José", Cargo = "Presidente" });
            Lista.Add(new Funcionario() {Foto = "", Nome = "Elaine", Cargo = "Gerente" });
            Lista.Add(new Funcionario() {Foto = "", Nome = "Tassi", Cargo = "Administradora" });
            Lista.Add(new Funcionario() {Foto = "", Nome = "Marcelo", Cargo = "Vendedor" });

            ListaFuncionario.ItemsSource = Lista;
        }
	}
}
