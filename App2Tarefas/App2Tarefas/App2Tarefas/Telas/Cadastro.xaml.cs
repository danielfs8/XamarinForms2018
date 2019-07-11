using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App2Tarefas.Modelos;

namespace App2Tarefas.Telas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Cadastro : ContentPage
	{
        private byte Prioridade { get; set; }

		public Cadastro ()
		{
			InitializeComponent ();
		}
        public void PrioridadeSelectAction (Object sender, EventArgs args)
        {
            var Stacks = SLPrioridades.Children ;

            foreach (var Linha in Stacks)
            {
                Label LblPrioridade = ((StackLayout)Linha).Children[1] as Label;
                LblPrioridade.TextColor = Color.Gray;
            }
           ((Label)((StackLayout)sender).Children[1]).TextColor = Color.Black;
            FileImageSource Source = ((Image)((StackLayout)sender).Children[0]).Source as FileImageSource;
            String Prioridade = Source.File.ToString().Replace("Resources/p", "").Replace(".png","");
            this.Prioridade = byte.Parse(Prioridade);
        }

        public void SalvarAction(Object sender, EventArgs args)
        {
            bool ErroExiste = false;

            if(!(TxtNome.Text.Trim().Length > 0))
            {
                ErroExiste = true;
                DisplayAlert("Erro", "Nome não foi informado!", "OK");
           
            }
            if(!(this.Prioridade > 0))
            {
                ErroExiste = true;
                DisplayAlert("Erro", "Prioridade não foi informada!", "OK");
            }
            if(ErroExiste == false)
            {
                Tarefas tarefa  = new Tarefas();
                tarefa.Nome = TxtNome.Text.Trim();
                tarefa.Prioridade = this.Prioridade;

                new GerenciadorTarefas().Salvar(tarefa);

                App.Current.MainPage = new NavigationPage(new Inicio());

            }
        }

    }
}