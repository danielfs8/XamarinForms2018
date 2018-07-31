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
	public partial class DatePickerPage : ContentPage
	{
		public DatePickerPage ()
		{
			InitializeComponent ();
		}

        private void DataEscolhida(object sender, DateChangedEventArgs args)
        {
           
            lbl_data.Text = "Data antiga: " + args.OldDate +"\n Nova data: " + args.NewDate+"\n\n";
            
        }

    }
}