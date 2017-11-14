using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseTranslator_Uebung_3._2
{
    class EnglishTranslator : Program
    {
        public override void TranslateWord()
        {
            Console.WriteLine("Bitte zu übersetzendes Wort eingeben:");
            word = Console.ReadLine();
            switch (word)
            {
                case "Beispiel":
                    translate = "example";
                    break;

                case "Stadt":
                    translate = "city";
                    break;

                case "Strasse":
                    translate = "street";
                    break;

                case "Fernseher":
                    translate = "TV";
                    break;

                default:
                    translate = "Wort ist nicht vorhanden";
            }


            Console.WriteLine("{0} = {1}", word, translate);
        }

        public override void TranslateSentence()
        {
            Console.WriteLine("Bitte zu übersetzenden Satz eingeben:");
            sentence = Console.ReadLine();
            switch (sentence)
            {
                case "Dies ist ein Beispiel":
                    translate = "This is an example";
                    break;

                case "Meine Uhr zeigt die Zeit an":
                    translate = "My watch shows the time";
                    break;

                case "Ich lebe auf einer Insel":
                    translate = "I live on an island";
                    break;

            }


            Console.WriteLine("{0} = {1}", sentence, translate);
        }
    }
    }

