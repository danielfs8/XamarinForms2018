using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1_Cell.Modelo;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1_Cell.Pagina.Detalhes
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetailPage : ContentPage
	{
		public DetailPage (Funcionario pessoa)
        {
			InitializeComponent ();

            Lbl_nome.Text = pessoa.Nome;

        }
        
	}
}