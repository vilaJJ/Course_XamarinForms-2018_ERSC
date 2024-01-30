using System;

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
    }
}
