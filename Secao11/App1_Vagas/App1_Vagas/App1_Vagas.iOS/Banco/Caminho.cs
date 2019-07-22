using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;
using App1_Vagas.Banco;
using System.IO;
using App1_Vagas.iOS.Banco;


[assembly:Dependency(typeof(Caminho))] // Classe Caminho implementa a interface ICaminho (using App1_Vagas.iOS.Banco;)
namespace App1_Vagas.iOS.Banco
{
    public class Caminho : ICaminho
    {
        public string ObterCaminho(string NomeArquivoBanco)
        {

            // Caminho da Pasta do banco.
            var caminhoDaPasta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

            // Pega o caminho da pasta e volta um diretório ".." para entrar na pasta Library
            string caminhoDaBiblioteca = Path.Combine(caminhoDaPasta, "..", "Library");

            // O Path.Combine (System.IO) Monta o caminho entre a string recebida do caminhoDoBanco e o NomeAequivoBanco
            string caminhoBanco = Path.Combine(caminhoDaBiblioteca, NomeArquivoBanco);

            return caminhoBanco;
        }
    }
}