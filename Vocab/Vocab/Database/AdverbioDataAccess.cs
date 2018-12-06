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
    class AdverbioDataAccess
    {
        private SQLiteConnection _database;

        public AdverbioDataAccess()
        {
            _database = DependencyService.Get<IDatabase>().GetConnection();
            _database.CreateTable<Adverbio>();
        }
        public List<Adverbio> GetAdverbio()
        {
            return _database.Table<Adverbio>().ToList();
        }
        public int SalvarAdverbio(Adverbio Palavra)
        {
            return _database.Insert(Palavra);
        }
        public int AtualizarAdverbio(Adverbio Palavra)
        {
            return _database.Update(Palavra);
        }

    }
}
