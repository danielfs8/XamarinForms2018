using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App1_Vagas.Banco;
using App1_Vagas.Modelos;

namespace App1_Vagas.Paginas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MinhasVagasCadastradas : ContentPage
	{
        List<Vaga> Lista { get; set; }

		public MinhasVagasCadastradas ()
		{
			InitializeComponent ();

            AtualizarLista();

        }

        private void AtualizarLista()
        {
            Database database = new Database();
            Lista = database.Consultar();

            ListaVagas.ItemsSource = Lista;

            lblCount.Text = "Numero de Registros: " + Lista.Count.ToString();
        }

        public void MaisDetalheAction(Object sender, EventArgs args)
        {

        }


        public void EditarAction(object sender, EventArgs args)
        {
            Label LblEditar = (Label)sender;
            TapGestureRecognizer tapGest = (TapGestureRecognizer)LblEditar.GestureRecognizers[0];
            Vaga vaga = tapGest.CommandParameter as Vaga;


            Navigation.PushAsync(new EditarVagas(vaga));

           

        }









        public void ExcluirAction (object sender, EventArgs args)
        {
            Label LblExcluir = (Label)sender;
            TapGestureRecognizer tapp = (TapGestureRecognizer)LblExcluir.GestureRecognizers[0];

            Vaga vaga = tapp.CommandParameter as Vaga;

            Database database = new Database();
            database.Exclusao(vaga);

            // App.Current.MainPage = new NavigationPage(new MinhasVagasCadastradas());
            AtualizarLista();


        }
        public void AddVaga(object sender, EventArgs args)
        {
            Navigation.PushAsync(new CadastroVagas());
        }

        public void PesquisaVaga(object sender, TextChangedEventArgs args)
        {

            ListaVagas.ItemsSource = Lista.Where(a => a.NomeVaga.Contains(args.NewTextValue)).ToList();
        }

    }
}