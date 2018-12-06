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
using Vocab.Listas;
using System.IO;

namespace Vocab
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Add : ContentPage
    {
        private bool r1;
        private bool r2;
        private bool r3;
        private bool r4;
        private bool r5;
        private bool r6;
        private bool r7;
        private bool r8;
        private bool r9;
        private bool r10;
        private bool r11;
        private bool r12;
        private bool r13;
        private bool r14;
        private bool r15;
        private string l1;
        private string l2;
        private string l3;
        private string l4;
        private string l5;
        private string l6;
        private string l7;
        private string l8;
        private string l9;
        private string l10;
        private string l11;
        private string l12;
        private string l13;
        private string l14;
        private string l15;

        public Add()
        {
            InitializeComponent();

            Palavra.FontFamily = Device.RuntimePlatform == Device.iOS ? "IndieFlower" :
            Device.RuntimePlatform == Device.Android ? "IndieFlower.ttf#IndieFlower" : "Assets/IndieFlower.ttf#IndieFlower";
            Palavra.FontSize = Device.RuntimePlatform == Device.iOS ? 20 :
            Device.RuntimePlatform == Device.Android ? Device.GetNamedSize(NamedSize.Medium, Palavra) : Device.GetNamedSize(NamedSize.Large, Palavra);
            
            BtnAdd.Clicked += delegate
            {
                string palavraUsuario = Palavra.Text;
                if (string.IsNullOrEmpty(palavraUsuario))
                {
                    DisplayAlert("Something Went Wrong :(", "Ué...não vai digitar nada?", "Sorry");
                }
                else
                {
                    
                    string palavraUpper = palavraUsuario.ToUpper();
                    ListaAdjetivos result = new ListaAdjetivos();
                    r1 = result.Contem(palavraUpper);
                    ListaAdverbios result2 = new ListaAdverbios();
                    r2 = result2.Contem(palavraUpper);
                    ListaSubstantivos result3 = new ListaSubstantivos();
                    r3 = result3.Contem(palavraUpper);
                    ListaSubstantivos2 result4 = new ListaSubstantivos2();
                    r4 = result4.Contem(palavraUpper);
                    ListaSubstantivos3 result5 = new ListaSubstantivos3();
                    r5 = result5.Contem(palavraUpper);
                    ListaSubstantivos4 result6 = new ListaSubstantivos4();
                    r6 = result6.Contem(palavraUpper);
                    ListaSubstantivos5 result7 = new ListaSubstantivos5();
                    r7 = result7.Contem(palavraUpper);
                    ListaSubstantivos6 result8 = new ListaSubstantivos6();
                    r8 = result8.Contem(palavraUpper);
                    ListaSubstantivos7 result9 = new ListaSubstantivos7();
                    r9 = result9.Contem(palavraUpper);
                    ListaSubstantivos8 result10 = new ListaSubstantivos8();
                    r10 = result10.Contem(palavraUpper);
                    ListaSubstantivos9 result11 = new ListaSubstantivos9();
                    r11 = result11.Contem(palavraUpper);
                    ListaSubstantivos10 result12 = new ListaSubstantivos10();
                    r12 = result12.Contem(palavraUpper);
                    ListaSubstantivos11 result13 = new ListaSubstantivos11();
                    r13 = result13.Contem(palavraUpper);
                    ListaSubstantivos12 result14 = new ListaSubstantivos12();
                    r14 = result14.Contem(palavraUpper);
                    ListaVerbos result15 = new ListaVerbos();
                    r15 = result15.Contem(palavraUpper);


                    if (r1 == true)
                    {
                        BindingContext = new AdjetivoViewModel();
                        ListaAdjetivos next = new ListaAdjetivos();
                        l1 = next.Indice(palavraUpper);
                        var palavra = new Adjetivo { Nome = palavraUpper, Significado = l1 };
                        new AdjetivoDataAccess().SalvarAdjetivo(palavra);


                    }

                    while (r1 == true)
                    {
                        DisplayAlert("That's what we call a GENIUS! :)", "Você acabou de adicionar um adjetivo ao seu Vocab!", "Cool");
                        if (r1 == true)
                        {
                            break;
                        }
                    }

                    if (r2 == true)
                    {
                        BindingContext = new AdverbioViewModel();
                        ListaAdverbios next = new ListaAdverbios();
                        l2 = next.Indice(palavraUpper);
                        var palavra = new Adverbio { Nome = palavraUpper, Significado = l2 };
                        new AdverbioDataAccess().SalvarAdverbio(palavra);

                    }

                    while (r2 == true)
                    {
                        DisplayAlert("That's what we call a GENIUS! :)", "Você acabou de adicionar um advérbio ao seu Vocab!", "Cool");
                        if (r2 == true)
                        {
                            break;
                        }
                    }

                    if (r3 == true)
                    {
                        BindingContext = new SubstantivoViewModel();
                        ListaSubstantivos next = new ListaSubstantivos();
                        l3 = next.Indice(palavraUpper);
                        var palavra = new Substantivo { Nome = palavraUpper, Significado = l3 };
                        new SubstantivoDataAccess().SalvarSubstantivo(palavra);

                    }

                    if (r4 == true)
                    {
                        BindingContext = new SubstantivoViewModel();
                        ListaSubstantivos2 next = new ListaSubstantivos2();
                        l4 = next.Indice(palavraUpper);
                        var palavra = new Substantivo { Nome = palavraUpper, Significado = l4 };
                        new SubstantivoDataAccess().SalvarSubstantivo(palavra);

                    }

                    if (r5 == true)
                    {
                        BindingContext = new SubstantivoViewModel();
                        ListaSubstantivos3 next = new ListaSubstantivos3();
                        l5 = next.Indice(palavraUpper);
                        var palavra = new Substantivo { Nome = palavraUpper, Significado = l5 };
                        new SubstantivoDataAccess().SalvarSubstantivo(palavra);

                    }

                    if (r6 == true)
                    {
                        BindingContext = new SubstantivoViewModel();
                        ListaSubstantivos4 next = new ListaSubstantivos4();
                        l6 = next.Indice(palavraUpper);
                        var palavra = new Substantivo { Nome = palavraUpper, Significado = l6 };
                        new SubstantivoDataAccess().SalvarSubstantivo(palavra);

                    }

                    if (r7 == true)
                    {
                        BindingContext = new SubstantivoViewModel();
                        ListaSubstantivos5 next = new ListaSubstantivos5();
                        l7 = next.Indice(palavraUpper);
                        var palavra = new Substantivo { Nome = palavraUpper, Significado = l7 };
                        new SubstantivoDataAccess().SalvarSubstantivo(palavra);

                    }

                    if (r8 == true)
                    {
                        BindingContext = new SubstantivoViewModel();
                        ListaSubstantivos6 next = new ListaSubstantivos6();
                        l8 = next.Indice(palavraUpper);
                        var palavra = new Substantivo { Nome = palavraUpper, Significado = l8 };
                        new SubstantivoDataAccess().SalvarSubstantivo(palavra);

                    }

                    if (r9 == true)
                    {
                        BindingContext = new SubstantivoViewModel();
                        ListaSubstantivos7 next = new ListaSubstantivos7();
                        l9 = next.Indice(palavraUpper);
                        var palavra = new Substantivo { Nome = palavraUpper, Significado = l9 };
                        new SubstantivoDataAccess().SalvarSubstantivo(palavra);

                    }

                    if (r10 == true)
                    {
                        BindingContext = new SubstantivoViewModel();
                        ListaSubstantivos8 next = new ListaSubstantivos8();
                        l10 = next.Indice(palavraUpper);
                        var palavra = new Substantivo { Nome = palavraUpper, Significado = l10 };
                        new SubstantivoDataAccess().SalvarSubstantivo(palavra);

                    }

                    if (r11 == true)
                    {
                        BindingContext = new SubstantivoViewModel();
                        ListaSubstantivos9 next = new ListaSubstantivos9();
                        l11 = next.Indice(palavraUpper);
                        var palavra = new Substantivo { Nome = palavraUpper, Significado = l11 };
                        new SubstantivoDataAccess().SalvarSubstantivo(palavra);

                    }

                    if (r12 == true)
                    {
                        BindingContext = new SubstantivoViewModel();
                        ListaSubstantivos10 next = new ListaSubstantivos10();
                        l12 = next.Indice(palavraUpper);
                        var palavra = new Substantivo { Nome = palavraUpper, Significado = l12 };
                        new SubstantivoDataAccess().SalvarSubstantivo(palavra);

                    }

                    if (r13 == true)
                    {
                        BindingContext = new SubstantivoViewModel();
                        ListaSubstantivos11 next = new ListaSubstantivos11();
                        l13 = next.Indice(palavraUpper);
                        var palavra = new Substantivo { Nome = palavraUpper, Significado = l13 };
                        new SubstantivoDataAccess().SalvarSubstantivo(palavra);

                    }

                    if (r14 == true)
                    {
                        BindingContext = new SubstantivoViewModel();
                        ListaSubstantivos12 next = new ListaSubstantivos12();
                        l14 = next.Indice(palavraUpper);
                        var palavra = new Substantivo { Nome = palavraUpper, Significado = l14 };
                        new SubstantivoDataAccess().SalvarSubstantivo(palavra);

                    }

                    while (r3 == true || r4 == true || r5 == true || r6 == true || r7 == true || r8 == true || r9 == true || r10 == true || r11 == true || r12 == true || r13 == true || r14 == true)
                    {
                        DisplayAlert("That's what we call a GENIUS! :)", "Você acabou de adicionar um substantivo ao seu Vocab!", "Cool");
                        if (r3 == true || r4 == true || r5 == true || r6 == true || r7 == true || r8 == true || r9 == true || r10 == true || r11 == true || r12 == true || r13 == true || r14 == true)
                        {
                            break;
                        }
                    }

                    if (r15 == true)
                    {
                        BindingContext = new VerboViewModel();
                        ListaVerbos next = new ListaVerbos();
                        l15 = next.Indice(palavraUpper);
                        var palavra = new Verbo { Nome = palavraUpper, Significado = l15 };
                        new VerboDataAccess().SalvarVerbo(palavra);

                    }

                    while (r15 == true)
                    {
                        DisplayAlert("That's what we call a GENIUS! :)", "Você acabou de adicionar um verbo ao seu Vocab!", "Cool");
                        if (r15 == true)
                        {
                            break;
                        }
                    }

                    if (r1 == false && r2 == false && r3 == false && r4 == false && r5 == false && r6 == false && r7 == false && r8 == false && r9 == false && r10 == false && r11 == false && r12 == false && r13 == false && r14 == false && r15 == false)
                    {
                        DisplayAlert("We might be wrong, but we don't think that's a word :(", "Não encontramos uma correspondência para essa palavra...Tente novamente!", "Cool");
                    }


                    Palavra.Text = "";
                }
                
            };

        }
    }
}