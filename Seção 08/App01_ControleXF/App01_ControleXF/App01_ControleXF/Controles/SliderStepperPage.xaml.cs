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
	public partial class SliderStepperPage : ContentPage
	{
		public SliderStepperPage ()
		{
			InitializeComponent ();
		}
        private void TrocouValorSlider(object sender, ValueChangedEventArgs args)
        {
            LabelSlider.Text = args.NewValue.ToString();
        }
        private void TrocouValorStepper(object sender, ValueChangedEventArgs args)
        {
            LabelStepper.Text = args.NewValue.ToString();
        }

    }
}