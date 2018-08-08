using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App2_Tarefas.Modelos;

namespace App2_Tarefas.Telas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Cadastro : ContentPage
	{
        private byte Prioridade { get; set; }

		public Cadastro ()
		{
			InitializeComponent ();
		}
        public void PrioridadeSelectedAction(object sender, EventArgs args)
        {
            var Stacks = SLPrioridades.Children;

            foreach (var Linha in Stacks)
            {
                Label LblPrioridade = ((StackLayout)Linha).Children[1] as Label;
                LblPrioridade.TextColor = Color.Gray;
            }
            ((Label)((StackLayout)sender).Children[1]).TextColor = Color.Black;
            FileImageSource Source = ((Image)((StackLayout)sender).Children[0]).Source as FileImageSource;
            string Prioridade = Source.File.ToString().Replace(".png", "").Replace("p", "");
           
            this.Prioridade = byte.Parse(Prioridade);
        }

        public void SalvarAction(object sender, EventArgs args)
        {
            bool ErroExiste = false;
            if (!(TxtNome.Text.Trim().Length >0))
            {
                ErroExiste = true;
                DisplayAlert("Erro", "Descrição não preechida!", "OK");
            }
            
            if (!(this.Prioridade > 0))
            {
                ErroExiste = true;
                DisplayAlert("Erro", "Prioridade não Selecionada!", "OK");
            }
            if (ErroExiste == false)
            {
                //Salva tarefa
                Tarefa tarefa = new Tarefa();
                tarefa.Nome = TxtNome.Text.Trim();
                tarefa.Prioridade = this.Prioridade;

                new GerenciadorTarefa().Salvar(tarefa);
                App.Current.MainPage = new NavigationPage(new Inicio());
            }
        }

    }
}