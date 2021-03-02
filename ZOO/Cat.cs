using System;
using System.Collections.Generic;
using System.Text;

namespace ZOO
{
    class Cat : Animal
    {
        //För att anmal har weight i sin parameter så måste man ha det kravet med här om vikt.
        //skulle man skriva in en till vikt inom katt så läggs det på då exekveringen går motosols. dvs baes(4,5) går först
        // innan i kattens konstruktor. Här säger vi att katten väger alltid 4,5k.
        public Cat() : base(4.5)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("Meoowww");
        }

        //Vi overridar en nivå till ToString. Så att det som står i i base lägger vi in här  extra text.
        //Så texten blir "Cat weight 4.5"
        public override string ToString()
        {
            return $"Cat ({base.ToString()})";
        }

    }
}
