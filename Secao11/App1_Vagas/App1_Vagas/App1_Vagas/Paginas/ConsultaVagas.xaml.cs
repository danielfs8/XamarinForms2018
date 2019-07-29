using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App1_Vagas.Modelos;
using App1_Vagas.Banco;

namespace App1_Vagas.Paginas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ConsultaVagas : ContentPage
	{
        List<Vaga> Lista { get; set; }

		public ConsultaVagas ()
		{
			InitializeComponent ();
            Database  database = new Database();

            Lista = database.Consultar();
            ListaVagas.ItemsSource = Lista;

            lblCount.Text = "Numero de Registros: " + Lista.Count.ToString();

        }

        public void GoCadastroAction(object sender, EventArgs args)
        {
            Navigation.PushAsync(new CadastroVagas());
        }

        public void GoMinhasVagasAction(object sender, EventArgs args)
        {
            Navigation.PushAsync(new MinhasVagasCadastradas());
        }

        public void MaisDetalheAction(object sender, EventArgs args)
        {
            Label lblDetalhe = (Label)sender;
            TapGestureRecognizer tapGest = (TapGestureRecognizer)lblDetalhe.GestureRecognizers[0];
            Vaga vaga = tapGest.CommandParameter as Vaga;

            // Vaga vaga = ((TapGestureRecognizer)lblDetalhe.GestureRecognizers[0]).CommandParameter as Vaga;
            // Pode ser como a linha acima comentada, ou da forma que foi criado abaixo


            Navigation.PushAsync(new DetalheVagas(vaga));
        }

        public void PesquisaVaga(object sender, TextChangedEventArgs args)
        {
            
            ListaVagas.ItemsSource = Lista.Where(a => a.NomeVaga.Contains(args.NewTextValue)).ToList();


            // Pode ser acessado o método que está na classe DataBase conforme código abaixo;
            /* 
              Database database = new Database();
             
              string palavra = args.NewTextValue;
              Lista = database.Pesquisar(palavra);
              ListaVagas.ItemsSource = Lista;
            */


        }




    }
}