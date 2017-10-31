using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseTranslator_Uebung_3._2
{
    class Program
    {
        public string translate;
        public string word;
        public string sentence;


        public virtual void TranslateWord()
        {


            Console.WriteLine("Bitte zu übersetzendes Wort eingeben:");
            word = Console.ReadLine();
            switch (word)
            {
                case "Beispiel":
                    translate = "example";
                    break;

            }


            Console.WriteLine("{0} = {1}", word, translate);
        }

        public virtual void TranslateSentence()
        {
            Console.WriteLine("Bitte zu übersetzenden Satz eingeben:");
            sentence = Console.ReadLine();
            switch (sentence)
            {
                case "Dies ist sein Beispiel":
                    translate = "this is an example";
                    break;

            }


            Console.WriteLine("{0} = {1}", sentence, translate);
        }

        static void Main(string[] args)
        {


            Console.WriteLine("In welche Sprache soll übersetzt werden? (E oder I)?");
            string Sprachauswahl = Console.ReadLine();

            if (Sprachauswahl == "E")
            {
                EnglishTranslator et = new EnglishTranslator();

                Console.WriteLine("Möchten Sie ein Wort oder einen Satz übersetzen? (W oder S?");
                string Uebersetzungsart = Console.ReadLine();

                if (Uebersetzungsart == "W")
                {
                    et.TranslateWord();
                }
                else if (Uebersetzungsart == "S")
                {
                    et.TranslateSentence();
                }
            }
            else if (Sprachauswahl == "I")
            {
                ItallianTranslater it = new ItallianTranslater();

                Console.WriteLine("Möchten Sie ein Wort oder einen Satz übersetzen? (W oder S?");
                string Uebersetzungsart = Console.ReadLine();

                if (Uebersetzungsart == "W")
                {
                    it.TranslateWord();
                }
                else if (Uebersetzungsart == "S")
                {
                    it.TranslateSentence();

                }
            }
        }
    }
}

