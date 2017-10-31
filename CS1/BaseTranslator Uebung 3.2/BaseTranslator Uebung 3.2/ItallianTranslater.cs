using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseTranslator_Uebung_3._2
{
    class ItallianTranslater: Program
    {
        public override void TranslateWord()
        {
            Console.WriteLine("Bitte zu übersetzendes Wort eingeben:");
            word = Console.ReadLine();
            switch (word)
            {
                case "Beispiel":
                    translate = "l'esempio";
                    break;

                case "Stadt":
                    translate = "la città";
                    break;

                case "Strasse":
                    translate = "la Strada";
                    break;

                case "Fernseher":
                    translate = "la televisione";
                    break;
            }


            Console.WriteLine("{0} = {1}", word, translate);
        }

        public override void TranslateSentence()
        {
            Console.WriteLine("Bitte zu übersetzenden Satz eingeben:");
            sentence = Console.ReadLine();
            switch (sentence)
            {
                case "Ich komme aus Neapel":
                    translate = "Sono di Napoli";
                    break;

            }


            Console.WriteLine("{0} = {1}", sentence, translate);
        }
    }
}

