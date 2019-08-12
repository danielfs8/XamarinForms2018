using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1_Mimica.View.Util
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Cabecalho : ContentView
	{
		public Cabecalho ()
		{
			InitializeComponent ();
            BindingContext = new ViewModel.CabecalhoViewModel();
		}

        public void SairEvento(object sender, EventArgs args)
        {
            var ViewModel = (ViewModel.CabecalhoViewModel)this.BindingContext;

            if (ViewModel.Sair.CanExecute(null))
            {
                ViewModel.Sair.Execute(null);
            }
        }
    }
}