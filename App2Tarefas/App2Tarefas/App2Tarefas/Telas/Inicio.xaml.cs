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
	public partial class Inicio : ContentPage
	{
		public Inicio ()
		{
			InitializeComponent ();
            DataHoje.Text = DateTime.Now.DayOfWeek.ToString() + ", " + DateTime.Now.ToString("dd/MM");

            CarregarTarefas();

        }

        public void ActionGoCadastro(Object sender, EventArgs args)
        {
            Navigation.PushAsync(new Cadastro());
        }

        private void CarregarTarefas()
        {
            SLTarefas.Children.Clear();
            List<Tarefas> Lista = new GerenciadorTarefas().Listagem();
            int i = 0;
            foreach(Tarefas tarefa in Lista)
            {
                LinhaStackLayout(tarefa, i);
                i++;
            }
             
        }

        //Criando a Lista de Tarefas da tela Inicio via C#
        public void LinhaStackLayout(Tarefas tarefa, int index)
        {
            // Cria imagem da Delete
            Image Delete = new Image() { VerticalOptions = LayoutOptions.Center, Source = ImageSource.FromFile("Delete.png") };
            if (Device.RuntimePlatform == Device.UWP)
            {
                Delete.Source = ImageSource.FromFile("Resources/Delete.png");
            }
            TapGestureRecognizer DeleteTap = new TapGestureRecognizer();
            DeleteTap.Tapped += delegate
            {
                new GerenciadorTarefas().Deletar(index);
                CarregarTarefas();

            };
            Delete.GestureRecognizers.Add(DeleteTap);


            // Cria imagem da Prioridade
            Image Prioridade = new Image() { VerticalOptions = LayoutOptions.Center, Source = ImageSource.FromFile("p" + tarefa.Prioridade + ".png") };
            if (Device.RuntimePlatform == Device.UWP)
            {
                Prioridade.Source = ImageSource.FromFile("Resources/p"+ tarefa.Prioridade + ".png");
            }

            //Cria a Label
            View StackCentral = null;
            if(tarefa.DataFinalizacao == null)
            {
                StackCentral = new Label() { VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.FillAndExpand, Text = tarefa.Nome };
                
            }
            else
            {
                StackCentral = new StackLayout() { VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.FillAndExpand };
                ((StackLayout)StackCentral).Children.Add(new Label() { Text = tarefa.Nome, TextColor = Color.Gray });
                ((StackLayout)StackCentral).Children.Add(new Label() { Text = tarefa.DataFinalizacao.Value.ToString("dd/MM/yyyy - hh:mm") + "h", TextColor = Color.Gray, FontSize = 10 });
            }
                
                

            //Cria a Image de "Checado e não checado "
            Image Check = new Image() { VerticalOptions = LayoutOptions.Center, Source = ImageSource.FromFile("CheckOff.png") };
            if (Device.RuntimePlatform == Device.UWP)
            {
                Check.Source = ImageSource.FromFile("Resources/CheckOff.png");
            }
            if (tarefa.DataFinalizacao != null)
            {
                Check.Source = ImageSource.FromFile("CheckOn.png");
                if (Device.RuntimePlatform == Device.UWP)
                {
                    Check.Source = ImageSource.FromFile("Resources/CheckOn.png");
                }
            }


            TapGestureRecognizer CheckeTap = new TapGestureRecognizer();
            CheckeTap.Tapped += delegate
            {
                new GerenciadorTarefas().Finalizar(index, tarefa);
                CarregarTarefas();

            };
            Check.GestureRecognizers.Add(CheckeTap);


            //Cria a linha (StackLayout que havia sido criado via XAML
            StackLayout Linha = new StackLayout() { Orientation = StackOrientation.Horizontal, Spacing = 15 };

            //Adiciona a imagem a linha criada.
            Linha.Children.Add(Check);
            Linha.Children.Add(StackCentral);
            Linha.Children.Add(Prioridade);
            Linha.Children.Add(Delete);

            SLTarefas.Children.Add(Linha);

        }

    }
}