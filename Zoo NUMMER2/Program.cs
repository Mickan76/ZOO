using System;
using System.Collections.Generic;

namespace Zoo_NUMMER2
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Animal> animals = new List<Animal>();
            animals.Add(new Cat());
            animals.Add(new Dog(10));



            foreach (var animal in animals)
            {
                Dog lunch = new Dog(1);
                animal.Eat(lunch);

                Console.WriteLine(animal);
            }

        }

    }


    abstract class Animal
    {

        public double Weight { get; set; }

        public Animal(double weight)
        {
            Weight = weight;

        }

        public override string ToString()
        {
            return $"Weight: {Weight}";        }

        public virtual void Eat(Animal food)
        {
            this.Weight += food.Weight;

        }

    }

    class Cat : Animal
    {

        public Cat() : base(4.5)
        {

        }

        public override string ToString()
        {
            return $"Cat {base.ToString()}";
        }
    }

    class Dog : Animal
    {

        public Dog(double weight) : base(weight)
        {

        }

        public override void Eat(Animal food)
        {
            Weight += food.Weight * 0.8;
        }

        public override string ToString()
        {
            return $"Dog {base.ToString()}";
        }
    }
}
