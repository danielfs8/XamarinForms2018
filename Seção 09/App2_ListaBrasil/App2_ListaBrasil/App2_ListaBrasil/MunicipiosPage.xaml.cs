using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using App2_ListaBrasil.Modelo;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2_ListaBrasil
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MunicipiosPage : ContentPage
	{
        private List<Municipio> ListaInternaMUnicipios { get; set; }
        private List<Municipio> ListaFiltradaMunicípios { get; set; }

		public MunicipiosPage (Estado estado)
		{
            InitializeComponent();
            ListaInternaMUnicipios = Servicos.Servico.CarregaMunicipios(estado.id);
            ListaMunicipio.ItemsSource = ListaInternaMUnicipios;
        }
        private void BuscaRapida(object sender, TextChangedEventArgs args)
        {
            ListaFiltradaMunicípios = ListaInternaMUnicipios.Where(a => a.nome.Contains(args.NewTextValue)).ToList();
            ListaMunicipio.ItemsSource = ListaFiltradaMunicípios;
        }

    }
}