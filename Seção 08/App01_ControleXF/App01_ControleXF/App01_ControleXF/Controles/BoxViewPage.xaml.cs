using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_ControleXF.Controles
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BoxViewPage : ContentPage
	{
		public BoxViewPage ()
		{
			InitializeComponent ();
		}
        private void TrocarCor(Object sender, EventArgs args)
        {
            Box.Color = Color.Yellow;
        }

    }
}