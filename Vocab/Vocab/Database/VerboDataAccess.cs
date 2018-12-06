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
    class VerboDataAccess
    {
        private SQLiteConnection _database;

        public VerboDataAccess()
        {
            _database = DependencyService.Get<IDatabase>().GetConnection();
            _database.CreateTable<Verbo>();
        }
        public List<Verbo> GetVerbo()
        {
            return _database.Table<Verbo>().ToList();
        }
        public int SalvarVerbo(Verbo Palavra)
        {
            return _database.Insert(Palavra);
        }
        public int AtualizarVerbo(Verbo Palavra)
        {
            return _database.Update(Palavra);
        }

    }
}