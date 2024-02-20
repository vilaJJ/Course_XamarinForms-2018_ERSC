using Vagas.Database;
using Vagas.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Vagas.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditarVaga : ContentPage
    {
        private readonly int _id;

        public EditarVaga(Vaga vaga)
        {
            InitializeComponent();

            _id = vaga.Id;

            CarregarDados(vaga);
        }

        private void CarregarDados(Vaga vaga)
        {
            BindingContext = vaga;

            Switch_TipoContratacao.IsToggled = vaga.TipoContratacao is "PJ";
        }

        private void Button_Atualizar_Clicked(object sender, System.EventArgs e)
        {
            if (ValidarEntradas() is false)
            {
                return;
            }

            var vaga = new Vaga
            {
                Id = _id,
                Nome = Entry_Vaga.Text.Trim(),
                Quantidade = int.Parse(Entry_Quantidade.Text.Trim()),
                Empresa = Entry_Empresa.Text.Trim(),
                Cidade = Entry_Cidade.Text.Trim(),
                Salario = float.Parse(Entry_Salario.Text.Trim()),
                DescricaoCargo = Editor_Descricao.Text.Trim(),
                TipoContratacao = Switch_TipoContratacao.IsToggled ? "PJ" : "CLT",
                Telefone = Entry_Telefone.Text.Trim(),
                Email = Entry_Email.Text.Trim()
            };

            using (var databaseHelper = new DatabaseHelper())
            {
                databaseHelper.Atualizar(vaga);
            }

            Navigation.PopAsync();

            DisplayAlert(
                "Cadastro de Vaga",
                "Vaga atualizada com sucesso!",
                "OK"
                );
        }

        private bool ValidarEntradas()
        {
            string campo = null;

            if (string.IsNullOrEmpty(Entry_Vaga.Text.Trim()))
            {
                campo = "Nome da Vaga";
            }
            else if (int.TryParse(Entry_Quantidade.Text.Trim(), out int _) is false)
            {
                campo = "Quantidade";
            }
            else if (string.IsNullOrEmpty(Entry_Empresa.Text.Trim()))
            {
                campo = "Nome da Empresa";
            }
            else if (string.IsNullOrEmpty(Entry_Cidade.Text.Trim()))
            {
                campo = "Nome da Cidade";
            }
            else if (float.TryParse(Entry_Salario.Text.Trim(), out float _) is false)
            {
                campo = "Salário";
            }
            else if (string.IsNullOrEmpty(Editor_Descricao.Text.Trim()))
            {
                campo = "Descrição da Vaga";
            }
            else if (string.IsNullOrEmpty(Entry_Telefone.Text.Trim()))
            {
                campo = "Número de Telefone";
            }
            else if (string.IsNullOrEmpty(Entry_Email.Text.Trim()))
            {
                campo = "Endereço de Email";
            }

            if (campo is string)
            {
                DisplayAlert(
                    "Validação de Dados",
                    "Corrija os dados do seguinte campo: " + campo,
                    "OK"
                    );
            }

            return campo is null;
        }
    }
}