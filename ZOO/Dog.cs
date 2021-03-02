using System;
using System.Collections.Generic;
using System.Text;

namespace ZOO
{
    class Dog: Animal
    {
        //Dog måste ha en parameter där vi skiver in vikten vid varje new Dog. Detta för att det kan skilja mycket mellan stor/liten hund
        //så vi vill inte sätta en fast vikt som hos en katt.
        public Dog(double weight): base(weight)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("Voff!");
        }

        //Skriv ovveride och mellanslag så får vi upp det som går att overrida.
        public override void Eat(IEdible food)
        {
            Weight += food.Weight * 0.8;// lägger in så att hunden får vikten den äter * 0.8 istället för 1kilo. Dvs den overridar det som
                                         //finns i Animal så att den går upp det som står här och inte 1 kilo.
                                        
        }

       
        public override string ToString()
        {
            return $"Dog ({base.ToString()})";
        }
    }
}
