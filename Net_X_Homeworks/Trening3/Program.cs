using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace Trening3
{
    class Program
    {
        static void Main(string[] args)
        {

            #region TASK1

            Console.WriteLine("---------------TASK1---------------");
            Console.WriteLine();

            List<Person> people = new List<Person>(){
                new Person("Volodymyr", 23, new List<string>{"380243423543", "380943453783", "380684858343" }),
                new Person("Andrianna", 20, new List<string>{"380244354443", "380234233783", "380611158343" }),
                new Person("Max",       30, new List<string>{"382233242354", "380943438041", "380683219063" }),
                new Person("Peter",     19, new List<string>{"380434500923", "380084042783", "380684457062" }),
                new Person("Igor",      25, new List<string>{"380243423543", "380943453783", "380684508634" }),
                new Person("Bogdan",    29, new List<string>{"380243087654", "380912345678", "380605368085" }),
                new Person("Serhii",    21, new List<string>{"380242367890", "380987654356", "380685676544" }),
                new Person("Mykola",    18, new List<string>{"380665434565", "384354566643", "380684568900" }),
                new Person("Roman",     25, new List<string>{"383435677700", "380943344452", "380324325456" })
            };

            foreach (Person person in people)
            {
                Console.WriteLine("Name: {0,-12} Age: {1} years old", person.Name, person.Age);
            }
            Console.WriteLine();

            #endregion

            #region TASK2

            Console.WriteLine("---------------TASK2---------------");
            Console.WriteLine();

            List<Person> additionalPeople = new List<Person>(){
                new Person("Peter",     19, new List<string>{"380999322000", "380044949999", "380684424420" }),
                new Person("Igor",      25, new List<string>{"380232312222", "384888820003", "389999991992" })
            };

            people.AddRange(additionalPeople);

            foreach (Person person in people)
            {
                Console.Write("{0,-12}", person.Name);
                person.printNumbers();
                Console.WriteLine();
            }

            #endregion

            #region TASK3

            Console.WriteLine("---------------TASK3---------------");
            Console.WriteLine();

            List<string> randomWords = GetListOfStrings();
            int initialSize = randomWords.Count;

            RemoveWordsStartZ(ref randomWords);
            RemoveDuplicates(ref randomWords);

            Console.WriteLine("Initial size: {0} , Size after changes: {1}", initialSize, randomWords.Count);

            randomWords.Sort();
            randomWords.Reverse();

            Console.Write("Input page number: ");

            int pageNumber = 0;

            if (Int32.TryParse(Console.ReadLine(), out pageNumber))
            {
                DisplayPage(pageNumber, randomWords);
            }
            else
            {
                Process.GetCurrentProcess().Kill();
            }

            #endregion
        }

        public static List<string> GetListOfStrings()
        {
            List<string> randomStrings = new List<string>();
            Random rand = new Random();
            for (int i = 0; i < 200; i++)
            {
                StringBuilder word = new StringBuilder();
                for (int j = 0; j < 5; j++)
                {
                    word.Append(((char)rand.Next(65, 91)).ToString());
                }
                randomStrings.Add(word.ToString());
            }
            return randomStrings;
        }

        public static void RemoveWordsStartZ(ref List<string> words)
        {
            for (int i = words.Count - 1; i >= 0; i--)
            {
                if (words[i][0] == 'Z')
                {
                    words.RemoveAt(i);
                }
            }
        }

        public static void RemoveDuplicates(ref List<string> words)
        {
            HashSet<string> wordsSet = new HashSet<string>(words);
            words.Clear();
            foreach (string word in wordsSet)
            {
                words.Add(word);
            }
        }

        public static void DisplayPage(int pageNumber, List<string> words)
        {
            if ((pageNumber * 5 - words.Count) >= 5)
            {
                Console.WriteLine("Wrong page!");
            }
            else
            {
                Console.WriteLine("Words at page {0}:", pageNumber);
                int index = (pageNumber - 1) * 5;
                int counter = 0;
                do
                {
                    Console.WriteLine(words[index]);
                    index++;
                    counter++;
                } while ((index < words.Count) && (counter < 5));
            }
        }

    }
}
