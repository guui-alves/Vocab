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
    class SubstantivoDataAccess
    {
        private SQLiteConnection _database;

        public SubstantivoDataAccess()
        {
            _database = DependencyService.Get<IDatabase>().GetConnection();
            _database.CreateTable<Substantivo>();
        }
        public List<Substantivo> GetSubstantivo()
        {
            return _database.Table<Substantivo>().ToList();
        }
        public int SalvarSubstantivo(Substantivo Palavra)
        {
            return _database.Insert(Palavra);
        }
        public int AtualizarSubstantivo(Substantivo Palavra)
        {
            return _database.Update(Palavra);
        }

    }
}
