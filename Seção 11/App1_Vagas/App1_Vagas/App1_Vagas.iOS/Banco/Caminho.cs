using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

using Xamarin.Forms;
using System.IO;
using App1_Vagas.iOS.Banco;
using App1_Vagas.Banco;

[assembly:Dependency(typeof(Caminho))]
namespace App1_Vagas.iOS.Banco
{
     public class Caminho
    {
        public string ObterCaminho(string NomeArquivoBanco)
        {

            string CaminhoDaPasta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string CaminhoDaBiblioteca = Path.Combine(CaminhoDaPasta, "..", "Library");
            string CaminhoDoBanco = Path.Combine(CaminhoDaBiblioteca, NomeArquivoBanco);
            return CaminhoDoBanco;

        }
    }
}