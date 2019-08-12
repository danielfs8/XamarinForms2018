using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App1_Mimica.ViewModel
{
    public class CabecalhoViewModel
    {
        public Command Sair { get; set; }

        public CabecalhoViewModel()
        {
            Sair = new Command(SairInicio);
        }

        private void SairInicio()
        {
            App.Current.MainPage = new View.Inicio();
        }

    }
}
