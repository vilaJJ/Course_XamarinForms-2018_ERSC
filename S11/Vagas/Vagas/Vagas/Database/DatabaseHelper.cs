using SQLite;
using System;
using System.Collections.Generic;
using Vagas.Database.Path.Interfaces;
using Vagas.Models;
using Xamarin.Forms;

namespace Vagas.Database
{
    internal class DatabaseHelper : IDisposable
    {
        private const string DATABASE_NAME = "Vagas.db";

        private readonly SQLiteConnection _conexao;

        private readonly IDatabasePath _databasePath;

        internal DatabaseHelper()
        {
            _databasePath = DependencyService.Get<IDatabasePath>();

            var databasePath = _databasePath.GetPath(DATABASE_NAME);

            _conexao = new SQLiteConnection(databasePath);
        }

        internal Vaga Obter(int codigo)
        {
            return null;
        }

        internal List<Vaga> Obter()
        {
            return null;
        }

        internal void Incluir(Vaga vaga)
        {

        }

        internal void Atualizar(Vaga vaga)
        {

        }

        internal void Excluir(int codigo)
        {

        }

        public void Dispose()
        {
            _conexao.Dispose();

            GC.SuppressFinalize(this);
        }
    }
}
