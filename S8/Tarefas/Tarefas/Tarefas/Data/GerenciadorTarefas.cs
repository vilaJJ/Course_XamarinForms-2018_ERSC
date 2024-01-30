using System;
using System.Collections.Generic;
using Tarefas.Modelos;
using Xamarin.Forms;

namespace Tarefas.Data
{
    public static class GerenciadorTarefas
    {
        private const string ListaTarefasKey = "ListaTarefas";
        private static List<Tarefa> _lista;
        
        static GerenciadorTarefas()
        {
            _lista = new List<Tarefa>();
        }

        public static void Salvar(this Tarefa tarefa)
        {
            _lista.Add(tarefa);
            AtualizarRegistroLocal();
        }

        public static void Apagar(this Tarefa tarefa)
        {
            _lista.Remove(tarefa);
            AtualizarRegistroLocal();
        }

        public static void Finalizar(this Tarefa tarefa)
        {
            var indice = _lista.IndexOf(tarefa);

            tarefa.Finalizada = true;
            tarefa.DataFinalizacao = DateTime.Now;

            _lista.RemoveAt(indice);
            _lista.Insert(indice, tarefa);

            AtualizarRegistroLocal();
        }

        public static List<Tarefa> Obter()
        {
            if (Application.Current.Properties.ContainsKey(ListaTarefasKey))
            {
                _lista = Application.Current.Properties[ListaTarefasKey] as List<Tarefa>;
            }
            else
            {
                _lista = new List<Tarefa>();
            }

            return _lista;
        }

        private static void AtualizarRegistroLocal()
        {
            if (Application.Current.Properties.ContainsKey(ListaTarefasKey) is true)
            {
                Application.Current.Properties.Remove(ListaTarefasKey);
            }

            Application.Current.Properties.Add(ListaTarefasKey, _lista);
        }
    }
}
