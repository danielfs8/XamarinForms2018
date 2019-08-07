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

        private string _MsgErro;
        public string MsgErro { get { return _MsgErro; } set { _MsgErro = value; OnPropertyChanged("MsgErro"); } }

        public InicioViewModel()
        {
            IniciarCommando = new Command(IniciarJogo);
            Jogo = new Jogo();
            Jogo.Grupo1 = new Grupo();
            Jogo.Grupo2 = new Grupo();

            Jogo.TempoPalavra = 60;
            Jogo.Rodadas = 3;
        }

        private void IniciarJogo()
        {
            string error = "";
            if(Jogo.TempoPalavra < 10)
            {
                error += "O tempo mínimo para o tempo da palavra é 10 segundos.";
            }
            if (Jogo.Rodadas < 1)
            {
                error += "A quantidade mínima para a rodada é 1.";
            }
            if(error.Length > 0)
            {
                MsgErro = error;
            }
            else
            {
                BD.Jogo = this.Jogo;
                BD.RodadaAtual = 1;
                App.Current.MainPage = new View.Jogo(Jogo.Grupo1);
            }
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
