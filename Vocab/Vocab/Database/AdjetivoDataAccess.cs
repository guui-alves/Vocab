using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using Vocab.Model;

namespace Vocab.Database
{
    class AdjetivoDataAccess
    {
        private SQLiteConnection _database;

        public AdjetivoDataAccess()
        {
            _database = DependencyService.Get<IDatabase>().GetConnection();
            _database.CreateTable<Adjetivo>();
        }
        public List<Adjetivo> GetAdjetivo()
        {
            return _database.Table<Adjetivo>().ToList();
        }
        public int SalvarAdjetivo(Adjetivo Palavra)
        {
            return _database.Insert(Palavra);
        }
        public int AtualizarAdjetivo(Adjetivo Palavra)
        {
            return _database.Update(Palavra);
        }

    }
}
