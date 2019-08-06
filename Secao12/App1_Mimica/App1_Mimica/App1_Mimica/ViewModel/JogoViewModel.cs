using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.ComponentModel;
using App1_Mimica.Armazenamento;
using App1_Mimica.Model;

namespace App1_Mimica.ViewModel
{
    class JogoViewModel : INotifyPropertyChanged
    {
        public Grupo Grupo { get; set; }

        public string NomeGrupo { get; set; }

        private string _Palavra;
        public string Palavra { get { return _Palavra; } set { _Palavra = value; OnPropertyChanged("Palavra");  } }

        public short _PalavraPontuacao;
        public short PalavraPontuacao { get { return _PalavraPontuacao; } set { _PalavraPontuacao = value; OnPropertyChanged("PalavraPontuacao"); } }

        public string _TextoContagem;
        public string TextoContagem { get { return _TextoContagem; } set { _TextoContagem = value; OnPropertyChanged("TextoContagem"); } }

        public bool _IsVisibleContainerContagem;
        public bool IsVisibleContainerContagem { get { return _IsVisibleContainerContagem; } set { _IsVisibleContainerContagem = value; OnPropertyChanged("IsVisibleContainerContagem"); } }

        public bool _IsVisibleContainerIniciar;
        public bool IsVisibleContainerIniciar { get { return _IsVisibleContainerIniciar; } set { _IsVisibleContainerIniciar = value; OnPropertyChanged("IsVisibleContainerIniciar"); } }

        public bool _IsVisibleBtnMostrar;
        public bool IsVisibleBtnMostrar { get { return _IsVisibleBtnMostrar; } set { _IsVisibleBtnMostrar = value; OnPropertyChanged("IsVisibleBtnMostrar"); } }


        
        public Command MostrarPalavra { get; set; }
        public Command Acertou { get; set; }
        public Command Errou { get; set; }
        public Command Iniciar { get; set; }
        

   
        public JogoViewModel(Grupo grupo)
        {
            Grupo = grupo;
            NomeGrupo = grupo.Nome;

            IsVisibleContainerContagem = false;
            IsVisibleContainerIniciar = false;
            IsVisibleBtnMostrar = true;

            Palavra = "********";

            MostrarPalavra = new Command(MostrarPalavraAction);
            Acertou = new Command(AcertouAction);
            Errou = new Command(ErrouAction);
            Iniciar = new Command(IniciarAction);
        }

      

        public void MostrarPalavraAction()
        {
            //PalavraPontuacao = 3;
            //Palavra = "Correr";

            var NumNivel = Armazenamento.BD.Jogo.NivelNumerico;
            if(NumNivel == 0)
            {
                //Aleatório
                Random rd = new Random();

                int Niv = rd.Next(0,2);
                int indice = rd.Next(0, Armazenamento.BD.Palavras[Niv].Length);
                Palavra = Armazenamento.BD.Palavras[Niv][indice];
                PalavraPontuacao = (byte)((Niv == 0) ? 1 : (Niv == 1) ? 3 : 5);


            }
            if (NumNivel == 1)
            {
                //Fac.
                Random rd = new Random();
                int indice = rd.Next(0, Armazenamento.BD.Palavras[NumNivel -1].Length);
                Palavra = Armazenamento.BD.Palavras[NumNivel - 1][indice];
                PalavraPontuacao = 1;
            }
            if (NumNivel == 2)
            {
                //Med.
                Random rd = new Random();
                int indice = rd.Next(0, Armazenamento.BD.Palavras[NumNivel - 1].Length);
                Palavra = Armazenamento.BD.Palavras[NumNivel - 1][indice];
                PalavraPontuacao = 3;

            }
            if (NumNivel == 3)
            {
                //Dif.
                Random rd = new Random();
                int indice = rd.Next(0, Armazenamento.BD.Palavras[NumNivel - 1].Length);
                Palavra = Armazenamento.BD.Palavras[NumNivel - 1][indice];
                PalavraPontuacao = 5;
            }



            IsVisibleBtnMostrar = false;
            IsVisibleContainerIniciar = true;
           
        }

        private void IniciarAction()
        {
            IsVisibleContainerIniciar = false;
            IsVisibleContainerContagem = true;

            //TODO - Quando o tempo terminar parar a contagem.,

            int i = BD.Jogo.TempoPalavra;

            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                TextoContagem = i.ToString();
                i--;
                if (i < 0)
                {
                    TextoContagem = "Tempo Esgotado!" ;
                    
                }

                return true;
            });

        }

        private void AcertouAction()
        {
            Grupo.Pontuacao += PalavraPontuacao;

            GoProximoGrupo();

        }

        private void ErrouAction()
        {
            GoProximoGrupo();
        }

        private void GoProximoGrupo()
        {
            Grupo grupo;
            if (BD.Jogo.Grupo1 == Grupo)
            {
                grupo = BD.Jogo.Grupo2;
            }
            else
            {
                grupo = BD.Jogo.Grupo1;
                BD.RodadaAtual++;
            }
            
            //Verifica a quantidade de rodadas, comparando com os parâmetros setados na tela Inicio.
            if(BD.RodadaAtual > BD.Jogo.Rodadas)
            {
                App.Current.MainPage = new View.Resultado();
            }
            else
            {
                App.Current.MainPage = new View.Jogo(grupo);
            }


            
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string NomeProperty)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(NomeProperty));
            }
        }

    }
}
