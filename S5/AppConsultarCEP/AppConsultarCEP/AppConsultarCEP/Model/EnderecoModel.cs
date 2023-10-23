#pragma warning disable IDE1006 // Naming Styles

using System;

namespace AppConsultarCEP.Service.Model
{
    [Serializable]
    public class EnderecoModel
    {
        public bool erro { get; set; }
        public string cep { get; set; }
        public string logradouro { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string localidade { get; set; }
        public string uf { get; set; }
        public string unidade { get; set; }
        public string ibge { get; set; }
        public string gia { get; set; }
    }
}