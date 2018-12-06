using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vocab.Database;
using Vocab.Model;
using Xamarin.Forms;

namespace Vocab.ViewModel
{
    public class AdverbioViewModel
    {
        public List<Adverbio> Adverbio { get; set; }
        public IList<Adverbio> Items { get; private set; }
        public List<ObservableGroupCollection<string, Adverbio>> DadosAgrupados { get; set; }



        public AdverbioViewModel()
        {
            var Adverbio = new AdverbioDataAccess();


            Items = Adverbio.GetAdverbio().OrderBy(c => c.Nome).ToList();

            DadosAgrupados = Items.OrderBy(p => p.Nome)

                             .GroupBy(p => p.Nome.ToString())
                             .Select(p => new ObservableGroupCollection<string, Adverbio>(p)).ToList();



        }
    }

}

