﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_ControleXF.Controles
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SwitchPage : ContentPage
	{
		public SwitchPage ()
		{
			InitializeComponent ();
		}
        private void AcaoTrocou(object sender, ToggledEventArgs args)
        {
            lbl_result.Text = DateTime.Now.ToString("HH:mm")+"\nValor: "+ args.Value.ToString();  
        }

    }
}