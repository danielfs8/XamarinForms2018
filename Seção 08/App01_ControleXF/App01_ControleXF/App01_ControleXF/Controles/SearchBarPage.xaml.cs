using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_ControleXF.Controles
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SearchBarPage : ContentPage
	{
        private List<String> empresasTI;

        public SearchBarPage ()
		{
			InitializeComponent ();
            // Preenche nossa lista com os itens desejados
            empresasTI = new List<string>();
            empresasTI.Add("Microsoft");
            empresasTI.Add("Apple");
            empresasTI.Add("Oracle");
            empresasTI.Add("IBM");
            empresasTI.Add("99Taxi");

            Preencher(empresasTI);
            
        }
        //Filtra quando clicar no botão
        private void PesquisarBotao(object sender, EventArgs args)
        {
            var resultado = empresasTI.Where(a => a.Contains(((SearchBar)sender).Text)).ToList<String>();
            //Chamo o Preencher para ele mostrar na tela o filtro
            Preencher(resultado);
        }

        //Filtra Em tempo real ::Abaixo
        //Filtra dentro da Lista Populada acima, os caracteres ou palavras digitadas.
        private void Pesquisar(object sender, TextChangedEventArgs args)
        {
            var resultado = empresasTI.Where(a=> a.Contains(args.NewTextValue)).ToList<String>();
            //Chamo o Preencher para ele mostrar na tela o filtro
            Preencher(resultado);
        }
        //Apresenta os itens que possuem o filtro (letra ou palavra)
        private void Preencher(List<String> empresasTI)
        {
            ListResult.Children.Clear();
            foreach (var emp in empresasTI)
            {
                ListResult.Children.Add(new Label { Text = emp });
            }
        }
	}
}