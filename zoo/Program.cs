using System;
using System.Security.Cryptography;

namespace zoo
{
    public class Animal
    {
        public string Name;
        public int Age;
        public string Gender;
        public int FedTimes;

        public Animal()
        {
            this.Name = "unknown";
            this.Age = 1;
            this.Gender = "unknown";
            this.FedTimes = 0;
        }
        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.FedTimes = 0;
        }

        public Animal(string name)
        {
            this.Name = name;
            this.Age = 1;
            this.Gender = "unknown";
            this.FedTimes = 0;
        }

        // I didn't manage to write method that increases Fed.Times 


        public string ToString()
        {
            return ($"{this.Name} is a {this.Age} years old {this.Gender} animal and was fed {this.FedTimes} times");
        }
    }

    public class Lion : Animal
    {
        public Lion(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.FedTimes = 0;
        }

        public Lion(string name)
        {
            this.Name = name;
            this.Age = 1;
            this.Gender = "unknown";
            this.FedTimes = 0;
        }
        public bool IsHungry()
        {
            return true;
        }
    }

    public class Monkey : Animal
    {
        public Monkey(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.FedTimes = 0;
        }

        public Monkey(string name)
        {
            this.Name = name;
            this.Age = 1;
            this.Gender = "unknown";
            this.FedTimes = 0;
        }

        public bool IsHungry()
        {
            // randomness doesn't work
            var rand = new Random();
            if (rand.Next(1) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            var monkey = new Monkey("Roach");
            Console.WriteLine(monkey.ToString());
            Console.WriteLine(monkey.IsHungry());
            Console.WriteLine(monkey.IsHungry());
            Console.WriteLine(monkey.IsHungry());
            Console.WriteLine(monkey.IsHungry());
        }
    }
}
