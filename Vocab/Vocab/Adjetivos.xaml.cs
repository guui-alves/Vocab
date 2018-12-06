using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Vocab.Database;
using Vocab.Model;
using Vocab.ViewModel;

namespace Vocab
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Adjetivos : ContentPage
    {
        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);


            if (height >= 1024)
            {
                BackgroundAdjetivo.Source = "adjetivo_page-1024h@3x.png";
            }
            
        }
        public Adjetivos()
        {
            InitializeComponent();

            BindingContext = new AdjetivoViewModel();

        }

        
    }
}