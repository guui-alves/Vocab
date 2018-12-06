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
    public class SubstantivoViewModel
    {
        public List<Substantivo> Substantivo { get; set; }
        public IList<Substantivo> Items { get; private set; }
        public List<ObservableGroupCollection<string, Substantivo>> DadosAgrupados { get; set; }



        public SubstantivoViewModel()
        {
            var Substantivo = new SubstantivoDataAccess();
            
            
            Items = Substantivo.GetSubstantivo().OrderBy(c => c.Nome).ToList();

            DadosAgrupados = Items.OrderBy(p => p.Nome)

                             .GroupBy(p => p.Nome.ToString())
                             .Select(p => new ObservableGroupCollection<string, Substantivo>(p)).ToList();



        }
    }

}
