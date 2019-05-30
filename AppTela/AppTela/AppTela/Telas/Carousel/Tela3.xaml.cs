using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTela.Telas.Tipos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Tela3 : ContentPage
    {
        public Tela3()
        {
            InitializeComponent();
        }

        private void MudarPagina(object sender, EventArgs args)
        {
            App.Current.MainPage = new NavigationPage(new Navigation.Pagina1()) {BarBackgroundColor = Color.Azure};
        }
    }
}