using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using App1_Mimica.Model;
using Xamarin.Forms;
using App1_Mimica.Armazenamento;

namespace App1_Mimica.ViewModel
{
    public class InicioViewModel : INotifyPropertyChanged
    {
        public Jogo Jogo { get; set; }
        public Command IniciarCommando { get; set; }

        public InicioViewModel()
        {
            IniciarCommando = new Command(IniciarJogo);
            Jogo = new Jogo();
            Jogo.Grupo1 = new Grupo();
            Jogo.Grupo2 = new Grupo();
        }

        private void IniciarJogo()
        {
            //BD.Jogo.Rodadas = this.Jogo.
            BD.Jogo = this.Jogo;
            BD.RodadaAtual = 1;
            App.Current.MainPage = new View.Jogo(Jogo.Grupo1);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged (string NameProperty)
        {
           if (PropertyChanged != null)
           {
                PropertyChanged(this, new PropertyChangedEventArgs(NameProperty));
           }

            //Posso substituir o IF acima pela linha abaixo
            // PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(NameProperty));

        }

    }
}
