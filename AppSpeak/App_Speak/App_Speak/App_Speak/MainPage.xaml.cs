using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App_Speak
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
            InitializeComponent();

           
			

		}
        public void ActionFala(Object sender, EventArgs args)
        {
            string texto = speakText.Text;
            DependencyService.Get<ISpeak>().ConverteEmFala(speakText.Text);
            
         }  
	}
}
/*
            var speakText = new Entry
            {

                Placeholder = "Digite seu texto",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,

            };
            speakText.Text = "Bom dia!";
            var speakButton = new Button
            {
                Text = "Olá, Forms",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,

            };
            speakButton.Clicked += (sender, e) =>
            {
                DependencyService.Get<ISpeak>().ConverteEmFala(speakText.Text);
            };
            Content = speakText;
            Content = speakButton;
*/