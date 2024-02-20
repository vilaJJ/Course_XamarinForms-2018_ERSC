using SQLite;
using System;
using System.Collections.Generic;
using Vagas.Database.Path.Interfaces;
using Vagas.Models;
using Xamarin.Forms;

namespace Vagas.Database
{
    public class DatabaseHelper : IDisposable
    {
        #region Campos

        private const string DATABASE_NAME = "Vagas.db";
        private readonly SQLiteConnection _conexao;
        private readonly IDatabasePath _databasePath;

        #endregion

        internal DatabaseHelper()
        {
            _databasePath = DependencyService.Get<IDatabasePath>();

            var databasePath = _databasePath.GetPath(DATABASE_NAME);

            _conexao = new SQLiteConnection(databasePath);

            CriarTabelas();
        }

        internal Vaga Obter(int codigo)
        {
            return
                _conexao
                .Table<Vaga>()
                .Where(v => v.Id == codigo)
                .First();
        }

        internal List<Vaga> Obter(string pesquisa = null)
        {
            List<Vaga> lista;

            if (pesquisa is string)
            {
                lista =
                    _conexao
                    .Table<Vaga>()
                    .Where(v => v.Nome.ToLower().Contains(pesquisa.ToLower()))
                    .ToList();                
            }
            else
            {
                lista =
                  _conexao
                  .Table<Vaga>()
                  .ToList();
            }

            return lista;
        }

        internal void Incluir(Vaga vaga)
        {
            _conexao.Insert(vaga);
        }

        internal void Atualizar(Vaga vaga)
        {
            _conexao.Update(vaga);
        }

        internal void Excluir(int codigo)
        {
            _conexao.Delete<Vaga>(codigo);
        }

        #region Métodos Privados

        private void CriarTabelas()
        {
            _conexao.CreateTable<Vaga>();
        }

        #endregion

        public void Dispose()
        {
            _conexao.Dispose();

            GC.SuppressFinalize(this);
        }
    }
}
