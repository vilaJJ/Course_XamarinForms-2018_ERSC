using AppConsultarCEP.Service;
using System;
using Xamarin.Forms;

namespace AppConsultarCEP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            ButtonBuscarCEP.Clicked += ButtonBuscarCEP_Clicked;
        }

        private void ButtonBuscarCEP_Clicked(object sender, EventArgs e)
        {
            // TODO - Lógica do Programa
            var cep = EntryCEP.Text.Trim();

            #region Validações
            if (IsValidCEP(cep) == false)
            {
                return;
            }
            #endregion

            try
            {
                #region Consulta na API
                var endereco = ViaCEPService.BuscarEndereco(cep);

                if (endereco == null) 
                {
                    DisplayAlert(
                        "Informação",
                        string.Format("O endereço não foi encontrado para o CEP informado ({0}).", cep),
                        "Voltar"
                    );
                    return;
                }
                #endregion

                #region Exibição do resultado
                var enderecoView = string.Format(
                    "CEP: {0}\nLogradouro: {1}\nBairro: {2}\nLocalidade: {3} - {4}",
                    endereco.cep,
                    endereco.logradouro,
                    endereco.bairro,
                    endereco.localidade,
                    endereco.uf
                );
                LabelResultado.Text = enderecoView;
                #endregion
            }
            catch (Exception ex)
            {
                DisplayAlert(
                    "Erro crítico",
                    "Erro ao acessar a API: " + ex.Message,
                    "Voltar"
                );
            }
        }

        private bool IsValidCEP(string cep)
        {
            var validate = true;
            
            if (cep.Length != 8)
            {
                DisplayAlert(
                    "Erro",
                    "CEP Inválido. O valor do CEP deve conter 8 caracteres.",
                    "OK"
                );
                validate = false;
            }

            if (int.TryParse(cep, out _) == false)
            {
                DisplayAlert(
                    "Erro",
                    "CEP Inválido. O valor do CEP deve conter apenas valores números inteiros.",
                    "OK"
                );
                validate = false;
            }

            return validate;
        }
    }
}
