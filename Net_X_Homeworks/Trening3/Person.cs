using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trening3
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public IEnumerable<string> PhoneNumbers { get; set; }

        public Person()
        {
            Name = "";
            Age = 0;
            PhoneNumbers = new string[] { };
        }

        public Person(string name,int age,List<string> phoneNumbers)
        {
            Name = name;
            Age = age;
            PhoneNumbers = phoneNumbers;
        }

        public void printNumbers()
        {
            foreach (string number in PhoneNumbers)
            {
                Console.Write(String.Format("{0:+##(###)-###-##-##}   ",Convert.ToInt64(number)));
            }
        }
    }
}
