using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
	class Person
    {
        private string name;
        private int age;
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public static void ShowInfo(Person p)
        {
            Console.WriteLine("This is " + p.name + ". Age: " + p.age);
        }

        public void TellMeAboutYourself()
        {
            ShowInfo(this);
        }
    }

    class SomeClass
    {
        static void Main(string[] args)
        {
            Person person = new Person("Anna", 21);
            Person.ShowInfo(person);
            person.TellMeAboutYourself();
        }
    }
}
