using System;

namespace zoo
{
    public class Animal
    {
        public string Name;
        public int Age;
        public string Gender;
        public int FeedTimes;

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public Animal(string name)
        {
            this.Name = name;
            this.Age = 1;
            this.Gender = "unknown";
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
