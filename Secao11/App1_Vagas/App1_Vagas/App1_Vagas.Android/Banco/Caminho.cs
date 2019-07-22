using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using App1_Vagas.Banco;
using System.IO;
using Xamarin.Forms;
using App1_Vagas.Droid.Banco;


[assembly:Dependency(typeof(Caminho))]
namespace App1_Vagas.Droid.Banco
{
    public class Caminho : ICaminho // Classe Caminho implementa a interface ICaminho
    {
        public string ObterCaminho(string NomeArquivoBanco)
        {
            // Caminho da Pasta do banco.
            var caminhoDaPasta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
           
            // O Path.Combine (System.IO) Monta o caminho entre a string recebida do caminhoDoBanco e o NomeAequivoBanco
            var caminhoBanco = Path.Combine(caminhoDaPasta, NomeArquivoBanco);

            return caminhoBanco;
        }
    }
}