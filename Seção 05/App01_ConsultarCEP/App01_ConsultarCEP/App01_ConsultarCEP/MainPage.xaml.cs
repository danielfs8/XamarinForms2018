using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App01_ConsultarCEP.Servico;
using App01_ConsultarCEP.Servico.Modelo;

namespace App01_ConsultarCEP
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            BOTAO.Clicked += BuscarCEP;
   
		}
        private void BuscarCEP (Object sender, EventArgs argas)
        {
            string cep = CEP.Text;
            
            

            if (isValidCEP(cep))
             {
                try
                {
                    Endereco end = ViaCEPServico.BuscarEnderecoViaCEP(cep);

                    if (end != null)
                    {
                        RESULTADO.Text = string.Format("Endereço: {0}\nBairro: {1}\nUF: {2}\nIBGE: {3}", end.logradouro, end.bairro, end.uf, end.ibge);
                    }
                    else
                    {
                        DisplayAlert("Info", "CEP não Encontrado", "O CEP digitado: "+cep+" não foi encontrado!", "OK");
                    }
                    
                }
                catch (Exception e)
                {
                    DisplayAlert("Erro Crítico", e.Message, "OK");
                }
            }
        
        }

        private bool isValidCEP(string cep)
        {
            bool valido = true;

            if (CEP.Text == null)
            {
                DisplayAlert("Erro", "CEP não informado", "Informe o CEP que deseja consultar!", "OK");
                //Erro
                valido = false;
            }
            else
            {
                cep = CEP.Text.Trim();
                 
               if (cep.Length != 8)
                {
                    DisplayAlert("Erro", "CEP Inválido", "CEP deve conter 8 caracteres!", "OK");
                    //Erro
                    valido = false;
                }
                int NovoCep = 0;
                if (!int.TryParse(cep, out NovoCep))
                {
                    //Erro
                    DisplayAlert("Erro", "CEP Inválido", "CEP deve ser conter apenas números!", "OK");
                    valido = false;
                }
            }
            return valido;
        }
	}
}
