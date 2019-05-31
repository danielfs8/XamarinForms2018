using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Layouts
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

      

        public void GoPaginaStack(object sender,  EventArgs args)
        {
            Navigation.PushAsync(new Layouts.LayoutsPage.Stack.StackPage());
        }

        public void GoPaginaGrid(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Layouts.LayoutsPage.Grid.GridPage());
        }

        public void GoPaginaAbsolute(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Layouts.LayoutsPage.Absolute.AbsolutePage());
        }

        public void GoPaginaRelative(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Layouts.LayoutsPage.Relative.RelativePage());
        }

        public void GoPaginaScroll(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Layouts.LayoutsPage.Scroll.ScrollPage());
        }
    }
}
