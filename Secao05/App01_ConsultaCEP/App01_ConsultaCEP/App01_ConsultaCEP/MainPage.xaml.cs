using App01_ConsultaCEP.Modelo;
using App01_ConsultaCEP.Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App01_ConsultaCEP
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            BTNBUSCAR.Clicked += BuscarCEP;
		}

        private void BuscarCEP(object sender, EventArgs e)
        {
            string cep = CEP.Text.Trim();

            Endereco end = ViaCEPServico.BuscarEnderecoViaCEP(cep);

            RESULTADO.Text = $"Endereço: {end.Logradouro} -  {end.Complemento} - {end.Bairro} - {end.UF}";
        }
    }
}
