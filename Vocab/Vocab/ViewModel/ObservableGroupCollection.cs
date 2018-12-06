using System.Collections.ObjectModel;
using System.Linq;

namespace Vocab.ViewModel
{
    public class ObservableGroupCollection<T1, T2>: ObservableCollection<T2>

    {
        private readonly T1 _key;
        
        public ObservableGroupCollection(IGrouping<T1, T2> group)

           : base(group)

       {

           _key = group.Key;

       }

       public T1 Key

       {

           get { return _key; }

       }
        

    }

}
