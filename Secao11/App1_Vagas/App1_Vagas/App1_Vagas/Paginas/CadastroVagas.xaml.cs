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
	public partial class CadastroVagas : ContentPage
	{
		public CadastroVagas ()
		{
			InitializeComponent ();
		}
        
        public void SalvarAction(object sender, EventArgs args)
        {
            Vaga vaga = new Vaga();

            vaga.NomeVaga = NomeDaVaga.Text;
            vaga.Empresa = NomeEmpresa.Text;
            vaga.Quantidade = short.Parse(QuantidadeVagas.Text);
            vaga.Cidade = NomeCidade.Text;
            vaga.Salario = double.Parse(ValorSalario.Text);
            vaga.Descricao = EditorMSG.Text;
            vaga.TipoContratacao = (TipoContratacao.IsToggled) ? "PJ" : "CLT" ;
            vaga.Telefone = NumeroTelefone.Text;
            vaga.Email = EndEmail.Text;

            Database database = new Database();
            database.Cadastro(vaga);


            App.Current.MainPage = new NavigationPage(new ConsultaVagas()); 


        }

            

    }
}