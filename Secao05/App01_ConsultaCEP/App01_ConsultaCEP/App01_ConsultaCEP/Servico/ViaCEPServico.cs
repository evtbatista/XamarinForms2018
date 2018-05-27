using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using App01_ConsultaCEP.Modelo;
using Newtonsoft.Json;

namespace App01_ConsultaCEP.Servico
{
    public class ViaCEPServico
    {
        //private static string EnderecoURL = "http://viacep.com.br/ws/{0}/json/";

        public static Endereco BuscarEnderecoViaCEP(string cep)
        {
            string EnderecoURL = $"http://viacep.com.br/ws/{cep}/json/";

            WebClient webClient = new WebClient();
            string resultado = webClient.DownloadString(EnderecoURL);

            Endereco endereco = JsonConvert.DeserializeObject<Endereco>(resultado);

            return endereco;
        }
            
    }
}
