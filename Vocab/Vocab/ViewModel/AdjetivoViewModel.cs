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
    public class AdjetivoViewModel
    {
        public List<Adjetivo> Adjetivo { get; set; }
        public IList<Adjetivo> Items { get; private set; }
        public List<ObservableGroupCollection<string, Adjetivo>> DadosAgrupados { get; set; }



        public AdjetivoViewModel()
        {
            var Adjetivo = new AdjetivoDataAccess();


            Items = Adjetivo.GetAdjetivo().OrderBy(c => c.Nome).ToList();

            DadosAgrupados = Items.OrderBy(p => p.Nome)

                             .GroupBy(p => p.Nome.ToString())
                             .Select(p => new ObservableGroupCollection<string, Adjetivo>(p)).ToList();



        }

    }
}
