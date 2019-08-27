using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trening3;

namespace NUnintTests
{
    [TestFixture]
    public class Tests
    {
        List<Person> people = new List<Person>()
        {
            new Person("Volodymyr", 23, new List<string>{"380243423543", "380943453783", "380684858343" }),
            new Person("Andrianna", 20, new List<string>{"380244354443", "380234233783", "380611158343" })
        };

        #region Testing tasks 1-2

        [Test]
        public void CheckNames()
        {
            Assert.AreEqual("Volodymyr", people[0].Name);
            Assert.AreEqual("Andrianna", people[1].Name);
        }

        [Test]
        public void CheckNumbers()
        {
            List<string> VolodyaNumbers = new List<string>()
            {
                "380243423543",
                "380943453783",
                "380684858343"
            };
            List<string> AndriannaNumbers = new List<string>()
            {
                "380244354443",
                "380234233783",
                "380611158343"
            };
            Assert.AreEqual(VolodyaNumbers, people[0].PhoneNumbers);
            Assert.AreEqual(AndriannaNumbers, people[1].PhoneNumbers);
        }

        [Test]
        public void CheckAge()
        {
            Assert.AreEqual(23, people[0].Age);
            Assert.AreEqual(20, people[1].Age);
        }

        #endregion

        #region Testing task 3

        [Test]
        public void CheckRandomWordsSize()
        {
            List<string> myRandomWords = Program.GetListOfStrings();

            foreach (string word in myRandomWords)
            {
                Assert.AreEqual(word.Length, 5);
            }
        }

        [Test]
        public void CheckIfUpperCase()
        {
            List<string> myRandomWords = Program.GetListOfStrings();

            foreach (string word in myRandomWords)
            {
                Assert.AreEqual(word.ToUpper(), word);
            }
        }

        [Test]
        public void CheckRemoveZFunction()
        {
            List<string> myRandomWords = Program.GetListOfStrings();

            Program.RemoveWordsStartZ(ref myRandomWords);

            foreach (string word in myRandomWords)
            {
                Assert.AreNotEqual(word[0], 'Z');
            }
        }

        [Test]
        public void CheckRemoveDuplicatesFunction()
        {
            List<string> myRandomWords = Program.GetListOfStrings();

            //In case myRandomWords do not contain duplicates
            myRandomWords.Add("ASDFA");
            myRandomWords.Add("ASDFA");

            Program.RemoveDuplicates(ref myRandomWords);

            int size = myRandomWords.Count;

            HashSet<string> myWords = new HashSet<string>(myRandomWords);

            Assert.AreEqual(myWords.Count, size);
        }

        #endregion
    }
}
