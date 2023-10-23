using AppConsultarCEP.Service.Model;
using Newtonsoft.Json;
using System.Net;

namespace AppConsultarCEP.Service
{
    public class ViaCEPService
    {
        /// <summary>
        /// {0} = Localização onde o CEP deve ser inserido
        /// </summary>
        private static readonly string URL = "http://viacep.com.br/ws/{0}/json/";

        public static EnderecoModel BuscarEndereco(string cep) 
        {
            string url = string.Format(URL, cep);

            WebClient webClient = new WebClient();
            var response = webClient.DownloadString(url);

            EnderecoModel endereco = JsonConvert.DeserializeObject<EnderecoModel>(response);

            if (endereco.erro)
            {
                return null;
            }

            return endereco;
        }
    }
}
