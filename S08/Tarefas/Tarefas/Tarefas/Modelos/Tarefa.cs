using System;
using Xamarin.Forms;

namespace Tarefas.Modelos
{
    public class Tarefa
    {
        public bool Finalizada { get; set; }
        public string Nome { get; set; }
        public byte Prioridade { get; set; }
        public DateTime? DataFinalizacao { get; set; }

        public Tarefa(string nome, byte prioridade)
        {
            Finalizada = false;
            Nome = nome;
            Prioridade = prioridade;
            DataFinalizacao = null;
        }

        public string ObterNomeImagemPrioridade()
        {
            string nome;

            switch (Prioridade)
            {
                case 1:
                    nome = "green_dot.png";
                    break;
                case 2:
                    nome = "yellow_dot.png";
                    break;
                case 3:
                    nome = "orange_dot.png";
                    break;
                case 4:
                    nome = "red_dot.png";
                    break;
                default:
                    throw new InvalidOperationException("Valor de prioridade inválido.");
            }

            if (Device.RuntimePlatform is "iOS")
            {
                nome = string.Format("Images/{0}", nome);
            }

            return nome;
        }

        public string ObterNomeImagemExcluir()
        {
            string nome = "delete.png";

            if (Device.RuntimePlatform is "iOS")
            {
                nome = string.Format("Images/{0}", nome);
            }

            return nome;
        }

        public string ObterFinalizadoEm()
        {
            if (DataFinalizacao is null)
            {
                throw new InvalidOperationException("Não é possível obter texto de finalizado em uma tarefa ainda em aberto.");
            }

            var dataFinalizacao = DataFinalizacao.Value;

            var finalizadoEm = string.Format(
                "Finalizado em {0} - {1}h{2}",
                dataFinalizacao.ToString("dd/MM/yyyy"),
                dataFinalizacao.Hour,
                dataFinalizacao.Minute
                );

            return finalizadoEm;
        }
    }
}
