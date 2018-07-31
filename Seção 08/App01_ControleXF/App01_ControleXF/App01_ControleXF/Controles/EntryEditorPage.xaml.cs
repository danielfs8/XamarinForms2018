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
	public partial class EntryEditorPage : ContentPage
	{
		public EntryEditorPage ()
		{
			InitializeComponent ();

            txtEmail.TextChanged += delegate (object sender, TextChangedEventArgs args)
            {
                lbl_Duplicado.Text = args.NewTextValue;
            };
            txtSenha.TextChanged += delegate (object sender, TextChangedEventArgs args)
            {
                lbl_ContaSenha.Text = args.NewTextValue;
            };

            txt_Mensagem.Completed += delegate (object sender, EventArgs args)
            {
                lbl_ContaCaracteres.Text = txt_Mensagem.Text.Length.ToString();
            };

        }
        private void Ver(Object sender, EventArgs args)
        {
            if (txtSenha.IsPassword)
            {
                txtSenha.IsPassword = false;
            }
            else
            {
                txtSenha.IsPassword = true;
            }
        }
       

	}
}