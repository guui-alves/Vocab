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
    public partial class Substantivos : ContentPage
    {
        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);


            if (height >= 1024)
            {
                BackgroundSubstantivo.Source = "substantivo_page-1024h@3x.png";
            }

        }
        public Substantivos()
        {
            InitializeComponent();
            Label Meaning = new Label();

            Meaning.FontFamily = Device.RuntimePlatform == Device.iOS ? "IndieFlower" :
            Device.RuntimePlatform == Device.Android ? "IndieFlower.ttf#IndieFlower" : "Assets/IndieFlower.ttf#IndieFlower";
            Meaning.FontSize = Device.RuntimePlatform == Device.iOS ? 18 :
            Device.RuntimePlatform == Device.Android ? Device.GetNamedSize(NamedSize.Medium, Meaning) : Device.GetNamedSize(NamedSize.Large, Meaning);

            BindingContext = new SubstantivoViewModel();
        }
    }
}