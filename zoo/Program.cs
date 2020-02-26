using System;

namespace zoo
{
    public class Animal
    {
        public string Name;
        public int Age;
        public string Gender;
        public int FedTimes;

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

    class Program
    {
        static void Main(string[] args)
        {
            var horse = new Animal("Roach");
            Console.WriteLine(horse.ToString());
        }
    }
}
