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
    public partial class Play : ContentPage
    {
        private bool r1;
        private string i1;
        private bool r2;
        private string i2;
        private bool r3;
        private string i3;
        private bool r4;
        private string i4;
        private bool r5;
        private string i5;
        private bool r6;
        private string i6;
        private bool r7;
        private string i7;
        private bool r8;
        private string i8;
        private bool r9;
        private string i9;
        private bool r10;
        private string i10;
        private bool r11;
        private string i11;
        private bool r12;
        private string i12;
        private bool r13;
        private string i13;
        private bool r14;
        private string i14;
        private bool r15;
        private string i15;
        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);

            
            if (height >= 1024)
            {
                LayoutCima.Margin = new Thickness(60, 50, 40, 0);
                Instrucao.FontSize = 30;
                Meaning.Margin = new Thickness(90, 120, 90, 0);
                Meaning.FontSize = 28;
                LayoutBaixo.Margin = new Thickness(90, 70, 100, 0);
            }
            if (height <= 568)
            {
                LayoutCima.Margin = new Thickness(40, 30, 30, 0);
                Instrucao.FontSize = 18;
                Meaning.Margin = new Thickness(40, 80, 30, 0);
                Meaning.FontSize = 18;
            }
             

        }

        public Play()
        {
            
            InitializeComponent();

            Meaning.FontFamily = Device.RuntimePlatform == Device.iOS ? "IndieFlower" :
            Device.RuntimePlatform == Device.Android ? "IndieFlower.ttf#IndieFlower" : "Assets/IndieFlower.ttf#IndieFlower";
            Meaning.FontSize = Device.RuntimePlatform == Device.iOS ? 18 :
            Device.RuntimePlatform == Device.Android ? Device.GetNamedSize(NamedSize.Medium, Meaning) : Device.GetNamedSize(NamedSize.Large, Meaning);
            Instrucao.FontFamily = Device.RuntimePlatform == Device.iOS ? "IndieFlower" :
            Device.RuntimePlatform == Device.Android ? "IndieFlower.ttf#IndieFlower" : "Assets/IndieFlower.ttf#IndieFlower";
            Instrucao.FontSize = Device.RuntimePlatform == Device.iOS ? 20 :
            Device.RuntimePlatform == Device.Android ? Device.GetNamedSize(NamedSize.Medium, Instrucao) : Device.GetNamedSize(NamedSize.Large, Instrucao);
            Palavra.FontFamily = Device.RuntimePlatform == Device.iOS ? "IndieFlower" :
            Device.RuntimePlatform == Device.Android ? "IndieFlower.ttf#IndieFlower" : "Assets/IndieFlower.ttf#IndieFlower";
            Palavra.FontSize = Device.RuntimePlatform == Device.iOS ? 18 :
            Device.RuntimePlatform == Device.Android ? Device.GetNamedSize(NamedSize.Medium, Palavra) : Device.GetNamedSize(NamedSize.Large, Palavra);


            PlayMetodo valorInicio = new PlayMetodo();
            var valorAleatorio = valorInicio.PlayMethod();
            
            Meaning.Text = valorAleatorio;
            
            BtnPlay.Clicked += delegate
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
                        i1 = result.Indice(palavraUpper);
                        ListaAdverbios result2 = new ListaAdverbios();
                        r2 = result2.Contem(palavraUpper);
                        i2 = result2.Indice(palavraUpper);
                        ListaSubstantivos result3 = new ListaSubstantivos();
                        r3 = result3.Contem(palavraUpper);
                        i3 = result3.Indice(palavraUpper);
                        ListaSubstantivos2 result4 = new ListaSubstantivos2();
                        r4 = result4.Contem(palavraUpper);
                        i4 = result4.Indice(palavraUpper);
                        ListaSubstantivos3 result5 = new ListaSubstantivos3();
                        r5 = result5.Contem(palavraUpper);
                        i5 = result5.Indice(palavraUpper);
                        ListaSubstantivos4 result6 = new ListaSubstantivos4();
                        r6 = result6.Contem(palavraUpper);
                        i6 = result6.Indice(palavraUpper);
                        ListaSubstantivos5 result7 = new ListaSubstantivos5();
                        r7 = result7.Contem(palavraUpper);
                        i7 = result7.Indice(palavraUpper);
                        ListaSubstantivos6 result8 = new ListaSubstantivos6();
                        r8 = result8.Contem(palavraUpper);
                        i8 = result8.Indice(palavraUpper);
                        ListaSubstantivos7 result9 = new ListaSubstantivos7();
                        r9 = result9.Contem(palavraUpper);
                        i9 = result9.Indice(palavraUpper);
                        ListaSubstantivos8 result10 = new ListaSubstantivos8();
                        r10 = result10.Contem(palavraUpper);
                        i10 = result10.Indice(palavraUpper);
                        ListaSubstantivos9 result11 = new ListaSubstantivos9();
                        r11 = result11.Contem(palavraUpper);
                        i11 = result11.Indice(palavraUpper);
                        ListaSubstantivos10 result12 = new ListaSubstantivos10();
                        r12 = result12.Contem(palavraUpper);
                        i12 = result12.Indice(palavraUpper);
                        ListaSubstantivos11 result13 = new ListaSubstantivos11();
                        r13 = result13.Contem(palavraUpper);
                        i13 = result13.Indice(palavraUpper);
                        ListaSubstantivos12 result14 = new ListaSubstantivos12();
                        r14 = result14.Contem(palavraUpper);
                        i14 = result14.Indice(palavraUpper);
                        ListaVerbos result15 = new ListaVerbos();
                        r15 = result15.Contem(palavraUpper);
                        i15 = result15.Indice(palavraUpper);

                        if (r1 == true && i1 == valorAleatorio)
                        {
                            BindingContext = new AdjetivoViewModel();
                            var palavra = new Adjetivo { Nome = palavraUpper, Significado = i1 };
                            new AdjetivoDataAccess().SalvarAdjetivo(palavra);
                            DisplayAlert("You're absolutely right! :)", "Você acabou de adicionar um adjetivo ao seu Vocab!", "Cool");
                        }

                        else if (r2 == true && i2 == valorAleatorio)
                        {
                            BindingContext = new AdverbioViewModel();
                            var palavra = new Adverbio { Nome = palavraUpper, Significado = i2 };
                            new AdverbioDataAccess().SalvarAdverbio(palavra);
                            DisplayAlert("We think you're awesome and stuff :)", "Você acabou de adicionar um advérbio ao seu Vocab!", "Cool");
                        }

                        else if (r3 == true && i3 == valorAleatorio)
                        {
                            BindingContext = new SubstantivoViewModel();
                            var palavra = new Substantivo { Nome = palavraUpper, Significado = i3 };
                            new SubstantivoDataAccess().SalvarSubstantivo(palavra);
                            DisplayAlert("You get it right? Brilliant :)", "Você acabou de adicionar um substantivo ao seu Vocab!", "Cool");
                        }
                        else if (r4 == true && i4 == valorAleatorio)
                        {
                            BindingContext = new SubstantivoViewModel();
                            var palavra = new Substantivo { Nome = palavraUpper, Significado = i4 };
                            new SubstantivoDataAccess().SalvarSubstantivo(palavra);
                            DisplayAlert("Touchdown! :)", "Você acabou de adicionar um substantivo ao seu Vocab!", "Cool");
                        }

                        else if (r5 == true && i5 == valorAleatorio)
                        {
                            BindingContext = new SubstantivoViewModel();
                            var palavra = new Substantivo { Nome = palavraUpper, Significado = i5 };
                            new SubstantivoDataAccess().SalvarSubstantivo(palavra);
                            DisplayAlert("We might be in love with you <3", "Você acabou de adicionar um substantivo ao seu Vocab!", "Cool");
                        }

                        else if (r6 == true && i6 == valorAleatorio)
                        {
                            BindingContext = new SubstantivoViewModel();
                            var palavra = new Substantivo { Nome = palavraUpper, Significado = i6 };
                            new SubstantivoDataAccess().SalvarSubstantivo(palavra);
                            DisplayAlert("How does it feel to be amazing?", "Você acabou de adicionar um substantivo ao seu Vocab!", "Cool");
                        }

                        else if (r7 == true && i7 == valorAleatorio)
                        {
                            BindingContext = new SubstantivoViewModel();
                            var palavra = new Substantivo { Nome = palavraUpper, Significado = i7 };
                            new SubstantivoDataAccess().SalvarSubstantivo(palavra);
                            DisplayAlert("How did you get that? :0", "Você acabou de adicionar um substantivo ao seu Vocab!", "Cool");
                        }

                        else if (r8 == true && i8 == valorAleatorio)
                        {
                            BindingContext = new SubstantivoViewModel();
                            var palavra = new Substantivo { Nome = palavraUpper, Significado = i8 };
                            new SubstantivoDataAccess().SalvarSubstantivo(palavra);
                            DisplayAlert("Did you know that smart is the new sexy?", "Você acabou de adicionar um substantivo ao seu Vocab!", "Cool");
                        }

                        else if (r9 == true && i9 == valorAleatorio)
                        {
                            BindingContext = new SubstantivoViewModel();
                            var palavra = new Substantivo { Nome = palavraUpper, Significado = i9 };
                            new SubstantivoDataAccess().SalvarSubstantivo(palavra);
                            DisplayAlert("Is it weird that we're thinking about the same word?", "Você acabou de adicionar um substantivo ao seu Vocab!", "Cool");
                        }

                        else if (r10 == true && i10 == valorAleatorio)
                        {
                            BindingContext = new SubstantivoViewModel();
                            var palavra = new Substantivo { Nome = palavraUpper, Significado = i10 };
                            new SubstantivoDataAccess().SalvarSubstantivo(palavra);
                            DisplayAlert("You might consider applying for president. For real.", "Você acabou de adicionar um substantivo ao seu Vocab!", "Cool");
                        }

                        else if (r11 == true && i11 == valorAleatorio)
                        {
                            BindingContext = new SubstantivoViewModel();
                            var palavra = new Substantivo { Nome = palavraUpper, Significado = i11 };
                            new SubstantivoDataAccess().SalvarSubstantivo(palavra);
                            DisplayAlert("We're out of words for what just happened. Ironic. Get it? :)", "Você acabou de adicionar um substantivo ao seu Vocab!", "Cool");
                        }

                        else if (r12 == true && i12 == valorAleatorio)
                        {
                            BindingContext = new SubstantivoViewModel();
                            var palavra = new Substantivo { Nome = palavraUpper, Significado = i12 };
                            new SubstantivoDataAccess().SalvarSubstantivo(palavra);
                            DisplayAlert("You got knowledge for days, huh?", "Você acabou de adicionar um substantivo ao seu Vocab!", "Cool");
                        }

                        else if (r13 == true && i13 == valorAleatorio)
                        {
                            BindingContext = new SubstantivoViewModel();
                            var palavra = new Substantivo { Nome = palavraUpper, Significado = i13 };
                            new SubstantivoDataAccess().SalvarSubstantivo(palavra);
                            DisplayAlert("Beautiful and smart? Well, hello there...", "Você acabou de adicionar um substantivo ao seu Vocab!", "Cool");
                        }

                        else if (r14 == true && i14 == valorAleatorio)
                        {
                            BindingContext = new SubstantivoViewModel();
                            var palavra = new Substantivo { Nome = palavraUpper, Significado = i14 };
                            new SubstantivoDataAccess().SalvarSubstantivo(palavra);
                            DisplayAlert("Ok, maybe you just born great or whateaver...", "Você acabou de adicionar um substantivo ao seu Vocab!", "Cool");
                        }

                        else if (r15 == true && i15 == valorAleatorio)
                        {
                            BindingContext = new VerboViewModel();
                            var palavra = new Verbo { Nome = palavraUpper, Significado = i15 };
                            new VerboDataAccess().SalvarVerbo(palavra);
                            DisplayAlert("That was beautiful to see. We're a little emotional right now.", "Você acabou de adicionar um verbo ao seu Vocab!", "Cool");
                        }

                        else
                        {
                            DisplayAlert("That happens to the best of us :(", "Tente novamente!", "Cool");

                        }

                        Palavra.Text = "";

                        PlayMetodo repete = new PlayMetodo();
                        var valorAleatorio2 = repete.PlayMethod();
                        valorAleatorio = valorAleatorio2;
                        Meaning.Text = valorAleatorio;
                    }
                        

                };
                

        }
    }
}