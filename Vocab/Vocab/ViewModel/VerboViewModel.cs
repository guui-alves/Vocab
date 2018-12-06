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
    public class VerboViewModel
    {
        public List<Verbo> Verbo { get; set; }
        public IList<Verbo> Items { get; private set; }
        public List<ObservableGroupCollection<string, Verbo>> DadosAgrupados { get; set; }



        public VerboViewModel()
        {
            var Verbo = new VerboDataAccess();


            Items = Verbo.GetVerbo().OrderBy(c => c.Nome).ToList();

            DadosAgrupados = Items.OrderBy(p => p.Nome)

                             .GroupBy(p => p.Nome.ToString())
                             .Select(p => new ObservableGroupCollection<string, Verbo>(p)).ToList();



        }
    }

}
