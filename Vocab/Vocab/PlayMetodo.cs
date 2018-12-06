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
    public class PlayMetodo
    {
        public string PlayMethod()
        {
            ListaAdjetivos lista = new ListaAdjetivos();
            var aleatorio1 = lista.Aleatorio();
            ListaAdverbios lista2 = new ListaAdverbios();
            var aleatorio2 = lista2.Aleatorio();
            ListaSubstantivos lista3 = new ListaSubstantivos();
            var aleatorio3 = lista3.Aleatorio();
            ListaSubstantivos2 lista4 = new ListaSubstantivos2();
            var aleatorio4 = lista4.Aleatorio();
            ListaSubstantivos3 lista5 = new ListaSubstantivos3();
            var aleatorio5 = lista5.Aleatorio();
            ListaSubstantivos4 lista6 = new ListaSubstantivos4();
            var aleatorio6 = lista6.Aleatorio();
            ListaSubstantivos5 lista7 = new ListaSubstantivos5();
            var aleatorio7 = lista7.Aleatorio();
            ListaSubstantivos6 lista8 = new ListaSubstantivos6();
            var aleatorio8 = lista8.Aleatorio();
            ListaSubstantivos7 lista9 = new ListaSubstantivos7();
            var aleatorio9 = lista9.Aleatorio();
            ListaSubstantivos8 lista10 = new ListaSubstantivos8();
            var aleatorio10 = lista10.Aleatorio();
            ListaSubstantivos9 lista11 = new ListaSubstantivos9();
            var aleatorio11 = lista11.Aleatorio();
            ListaSubstantivos10 lista12 = new ListaSubstantivos10();
            var aleatorio12 = lista12.Aleatorio();
            ListaSubstantivos11 lista13 = new ListaSubstantivos11();
            var aleatorio13 = lista13.Aleatorio();
            ListaSubstantivos12 lista14 = new ListaSubstantivos12();
            var aleatorio14 = lista14.Aleatorio();
            ListaVerbos lista15 = new ListaVerbos();
            var aleatorio15 = lista15.Aleatorio();

            List<string> ListaAleatorio = new List<string>
                {
                aleatorio1,
                aleatorio2,
                aleatorio3,
                aleatorio4,
                aleatorio5,
                aleatorio6,
                aleatorio7,
                aleatorio8,
                aleatorio9,
                aleatorio10,
                aleatorio11,
                aleatorio12,
                aleatorio13,
                aleatorio14,
                aleatorio15
                };

            var rnd = new Random();
            var valorAleatorio = ListaAleatorio[rnd.Next(ListaAleatorio.Count)];

            while (ListaAleatorio.IndexOf(valorAleatorio) % 2 == 0)
            {
                valorAleatorio = ListaAleatorio[rnd.Next(ListaAleatorio.Count)];

            }
            return valorAleatorio;
        }

    }
}
