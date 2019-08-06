using System;
using System.Collections.Generic;
using System.Text;
using App1_Mimica.Model;

namespace App1_Mimica.Armazenamento
{
    public class BD
    {
        public static Jogo Jogo { get; set; }
        public static short RodadaAtual { get; set; }

        public static string[][] Palavras =
        {
            //Fac.
            new string[]{"Correr","Escovar Dente","pular"},
            //Med.
            new string[]{"Jogar futebol","Pesca","Nadar", "Pensar", "perder","tropeçar","voar"},
            //Dif.
            new string[]{"Voar","criptonita","segunda guerra"},
        };
    }
}
