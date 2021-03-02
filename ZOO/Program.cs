using System;
using System.Collections.Generic;

namespace ZOO
{
    class Program
    {
        static void Main(string[] args)
        {

            //Skriver ut text från metoden Animate , punkt för punkt. om skriver nedan så är klassen inte statisk.
            //TextUtils textUtils = new TextUtils();

            

            //Behöver inte "New:a upp och lägga en instans om man har en instans. Räcker då att anropa enligt nedan.
            TextUtils.Animate("Welcome to the Zoo!")
;
            //Alla saker ligger i Animal
            List<Animal> animals = new List<Animal>();

            animals.Add(new Cat());
            animals.Add(new Dog(10));


            foreach (var animal in animals)
            {
                Grass lunch = new Grass(1); // varje djur ska få äta en hund som väger 1k.
                animal.Eat(new Grass(1)); // lunch är en dog och läggs in i metoden Eat. svaret blir att djuren går upp 1 k.
                
                Console.WriteLine(animal.Weight);// weighten djuren har har ökat med 1 k förutom hunden som har ökat 0,8k då vi har lagt in en override.
                Console.WriteLine(animal.ToString());//vi har overridat ToString- se i animal
            }

            //Skapar en ny instans av cat. Se api'n så ärvs det från animal
            //Cat cat = new Cat();

        }
    }



}
