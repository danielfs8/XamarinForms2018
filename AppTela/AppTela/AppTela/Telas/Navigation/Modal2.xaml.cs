using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTela.Telas.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Modal2 : ContentPage
    {
        public Modal2()
        {
            InitializeComponent();
        }
        private void FecharModal2 (object sender, EventArgs args)
        {
            Navigation.PopModalAsync();
        }
    }
}