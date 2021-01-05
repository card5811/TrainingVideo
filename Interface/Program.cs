using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Stay();
            dog.Sit();
            dog.RollOver();
            dog.Attack();

            Console.WriteLine("Tell us your dog's name.");
            dog.DogName = Console.ReadLine();
            Console.WriteLine($"The dog is {dog.DogName}");

            Console.WriteLine("What Breed of wolf is it?");
            dog.WolfBreed = Console.ReadLine();
            Console.WriteLine($"{dog.DogName} is {dog.WolfBreed}");

            dog.Train();
            Console.ReadKey();
        }

        //contain definitons for a group of related functionalities that a class or struct can impliment.

        //Interfaces are a contract between structs and class.
        //The interface defines the What in the contract.
        //Classes and the struct define the how.
    }

    interface ITrainer
    {
        void Train();
    }
        interface IAnimalCommands
        {
        void Stay();
        void Sit();
        void RollOver();
        void Attack();
        string DogName { get; set; }
        }


        public class Dog : Wolf, IAnimalCommands, ITrainer
        {
        public string DogName { get; set; }
        public void Stay()
        {
            Console.WriteLine("The Dog is Staying");
        }
        public void Sit()
        {
            Console.WriteLine("The Dog is Sitting");
        }
        public void RollOver()
        {
            Console.WriteLine("The Dog is rolling over");
        }
        public void Attack()
        {
            Console.WriteLine("The Dog is attacking");
        }
        public void Train()
        {
            Console.WriteLine($"the trainer is training {DogName}");
        }
    }

    public class Wolf
    {
        public string WolfBreed { get; set; }

        public bool isWolf;

        public int age;
    }
    
    public class Cat
    {
        public string CatName;
        public string Breed;
        public int age;
    }

}
