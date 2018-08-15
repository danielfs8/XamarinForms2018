using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using App2_ListaBrasil.Modelo;
using Newtonsoft.Json;

namespace App2_ListaBrasil.Servico
{
    public class Servico
    {
        private static string UrlEstado = "https://servicodados.ibge.gov.br/api/v1/localidades/estados";
        private static string UrlMunicipal = "https://servicodados.ibge.gov.br/api/v1/localidades/estados/{0}/municipios";

        public List<Estados> CarregaEstado()
        {
            WebClient wc = new WebClient();
            String conteudo = wc.DownloadString(UrlEstado);

            return JsonConvert.DeserializeObject<List<Estados>>(conteudo);
        }
        public List<Estados> CarregaMunicipio(int estado)
        {
            String NewURL = string.Format(UrlMunicipal, estado);

            WebClient wc = new WebClient();
            String conteudo = wc.DownloadString(NewURL);

            return JsonConvert.DeserializeObject<List<Estados>>(conteudo);
        }

    }
}
