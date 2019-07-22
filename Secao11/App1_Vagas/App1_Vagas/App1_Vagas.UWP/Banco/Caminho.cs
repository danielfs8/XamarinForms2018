using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Xamarin.Forms;
using System.IO;
using App1_Vagas.UWP.Banco;
using App1_Vagas.Banco;
using Windows.Storage;

[assembly:Dependency(typeof(Caminho))]
namespace App1_Vagas.UWP.Banco
{
    public class Caminho : ICaminho
    {
        public string ObterCaminho(string NomeArquivoBanco)
        {
            //No windows não utilizamos a API (System.Environment.GetFolderPath) e sim uma Api Nativa do windows(ApplicationData.Current.LocalFolder.Path). 
            var caminhoDaPasta = ApplicationData.Current.LocalFolder.Path;

            string caminhoBanco = Path.Combine(caminhoDaPasta, NomeArquivoBanco);

            return caminhoBanco;
        }
    }
}
