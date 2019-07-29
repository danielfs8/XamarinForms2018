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
	public partial class EditarVagas : ContentPage
	{
        private Vaga vaga { get; set; }

		public EditarVagas ( Vaga vaga)
		{
			InitializeComponent ();

            this.vaga = vaga;
           

            NomeDaVaga.Text = vaga.NomeVaga;
            NomeEmpresa.Text = vaga.Empresa;
            QuantidadeVagas.Text = vaga.Quantidade.ToString();
            NomeCidade.Text = vaga.Cidade;
            ValorSalario.Text = vaga.Salario.ToString();
            EditorMSG.Text = vaga.Descricao;
            TipoContratacao.IsToggled =(vaga.TipoContratacao == "CLT") ? false : true;
            NumeroTelefone.Text = vaga.Telefone;
            EndEmail.Text = vaga.Email;

        }
        public void SalvarAction (object sender, EventArgs args)
        {
            vaga.NomeVaga = NomeDaVaga.Text;
            vaga.Empresa = NomeEmpresa.Text;
            vaga.Quantidade = short.Parse(QuantidadeVagas.Text);
            vaga.Cidade = NomeCidade.Text;
            vaga.Salario = double.Parse(ValorSalario.Text);
            vaga.Descricao = EditorMSG.Text;
            vaga.TipoContratacao = (TipoContratacao.IsToggled) ? "PJ" : "CLT";
            vaga.Telefone = NumeroTelefone.Text;
            vaga.Email = EndEmail.Text;

            Database database = new Database();
            database.Atualizacao(vaga);

            App.Current.MainPage = new NavigationPage(new MinhasVagasCadastradas());

        }



    }
}