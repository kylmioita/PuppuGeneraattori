using System;
using System.Collections.Generic;

namespace RandomGenerator
{
    internal class Program
    {
        static List<string> Addresses = new List<string>() { "Arvoisa yleisö, ", "Arvoisat juhlavieraat, ", "Te urheat koodin vääntäjät, ", "" };
        static List<string> Beginnings = new List<string>() { "On huomattava, että, ", "Kuitenkin, ", "Tämän vuoksi, " };
        static List<string> Factors = new List<string>() { "opintojen suorittaminen ", "tenttitilaisuusien järjestäminen ", "ohjelmointi-kielen erityispiirteiden hahmottaminen ja huomiointi " };
        static List<string> Actions = new List<string>() { "auttaa myös ", "vaikuttaa suoraan mutta myös kiertoteitse ", "on ratkaisevassa osassa " };
        static List<string> Endings = new List<string>() { "loppututkinnon suorittamisessa.", "työelämässä.", "saamaan ystäviä ja vaikutusvaltaa." };

        static void Main(string[] args)
        {
            int input = GetUserInput();

            for (int i = 0; i < input; i++)
            {
                Console.WriteLine($"\n{GenerateRandomSpeech()}");
            }
        }

        static int GetUserInput()
        {
            int input;
            Console.WriteLine("Tervetuloa Puppugeneraattoriin");
            Console.WriteLine("Kuinka monta lausetta haluat?");
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Vastauksen tulee olla numero");
            }
            return input;
        }

        static string GenerateRandomSpeech()
        {
            Random random = new Random();

            string speech = "";
            speech += PickRandomWord(Addresses, 0);
            speech += PickRandomWord(Beginnings, 1);
            speech += PickRandomWord(Factors, 2);
            speech += PickRandomWord(Actions, 3);
            speech += PickRandomWord(Endings, 4);

            return speech;
        }

        static string PickRandomWord(List<string> list, int i)
        {
            Random random = new Random();
            int index = random.Next(1, list.Count);
            string item = list[index];
            list.RemoveAt(index);
            list.Insert(0, item);
            return list[index];
        }
    }
}