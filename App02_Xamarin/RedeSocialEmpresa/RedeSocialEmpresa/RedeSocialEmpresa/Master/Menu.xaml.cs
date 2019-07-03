using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RedeSocialEmpresa.Master
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Menu : MasterDetailPage
	{
		public Menu ()
		{
			InitializeComponent ();
		}

        private void GoPaginaPerfil1(object sender, EventArgs args)
        {
           Detail = new RedeSocialEmpresa.Paginas.Perfil1();
            IsPresented = false;
        }

        private void GoPaginaPerfil2(object sender, EventArgs args)
        {
            Detail = new RedeSocialEmpresa.Paginas.Perfil2();
            IsPresented = false;
        }

    }
}