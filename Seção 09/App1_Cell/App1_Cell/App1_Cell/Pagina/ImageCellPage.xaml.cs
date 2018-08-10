using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1_Cell.Modelo;
using App1_Cell.Pagina;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1_Cell.Pagina
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ImageCellPage : ContentPage
	{
		public ImageCellPage ()
		{
			InitializeComponent ();
            List<Funcionario> Lista = new List<Funcionario>();
            Lista.Add(new Funcionario() { Foto = "http://i.imgur.com/zQQxvc9.png?1",Nome = "José", Cargo = "Gerente" });
            Lista.Add(new Funcionario() { Foto = "http://i1134.photobucket.com/albums/m602/PW_PrimeiroChefe/kitana.png", Nome = "Tassi", Cargo = "Admin" });
            Lista.Add(new Funcionario() { Foto = "http://i1134.photobucket.com/albums/m602/PW_PrimeiroChefe/Kratos.png", Nome = "Daniel", Cargo = "Developer" });
            Lista.Add(new Funcionario() { Foto = "http://i52.tinypic.com/23ifnty.png", Nome = "Elaine", Cargo = "Gestora" });

            ListaFuncionario.ItemsSource = Lista;
        }

	}
}