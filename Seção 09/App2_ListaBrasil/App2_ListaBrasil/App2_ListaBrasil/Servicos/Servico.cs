using System;
using System.Collections.Generic;
using System.Text;

using System.Net;
using App2_ListaBrasil.Modelo;
using Newtonsoft.Json;

namespace App2_ListaBrasil.Servicos
{
    public class Servico
    {
        private static string UrlEstados = "https://servicodados.ibge.gov.br/api/v1/localidades/estados";
        private static string UrlMunicipios = "https://servicodados.ibge.gov.br/api/v1/localidades/estados/{0}/municipios";

        public static List<Estado> CarregaEstados()
        {
            WebClient wc = new WebClient();
            string conteudo = wc.DownloadString(UrlEstados);

            return JsonConvert.DeserializeObject<List<Estado>>(conteudo);

        }
        public static List<Municipio> CarregaMunicipios(int UF)
        {
            string newURL = string.Format(UrlMunicipios, UF);

            WebClient wc = new WebClient();
            string conteudo = wc.DownloadString(newURL);

            return JsonConvert.DeserializeObject<List<Municipio>>(conteudo);

        }
    }
}
