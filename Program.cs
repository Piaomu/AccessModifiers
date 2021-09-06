using System;

namespace AccessModifiers
{
    class Person
    {
        private string FullName;

        private DateTime Birthdate;

        public void SetName(string name)
        {
            FullName = name;
        }

        public string TellYouMyName()
        {
            return FullName;
        }

        public void SetBirthdate(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        public DateTime ItsMyBirthday()
        {
            return Birthdate;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();

            // These two methods are like printing your birth certificate
            // I'm storing data that I don't want the outside world to have.
            person.SetName("Fred Flintstone");
            person.SetBirthdate(new DateTime(1990, 09, 22));

            // These two methods are like telling someone your name and birthday.
            // I'm accessing the information on that certificate and giving it to the world.
            Console.WriteLine(person.TellYouMyName());
            Console.WriteLine(person.ItsMyBirthday());
        }
    }
}
