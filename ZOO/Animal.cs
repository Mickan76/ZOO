using System;
using System.Collections.Generic;
using System.Text;

namespace ZOO
{
    abstract class Animal: IEdible
    {

            //För att skapa en animal så måste man skicka med vikt när man skapar ex katt.
        
        public double Weight { get; set; }
        
        
        public Animal(double weight)
        {
            Weight = weight;
            MakeSound();
        }

        public abstract void MakeSound();


        //Vi overridar ToString som ligger i Object som är klassen över Animal (dvs basklassernas fader)Denna är inte obligatorisk 
        //för basklasserna som parametern med vikt ovan.
        //Måste ha samma signatur på basklasserna - samma visibilitet, samma parameter namn etc.
        //Nedan gör att det komemr stå Wight:och så kattens och hundens vikt när man skriver ut.
        public override string ToString()
        {
            return $"Weight: {Weight}";
        }

        //Om vi vill att katt ska kunna äta hund+  hund äta katt etc. Svaret är att vikten ökar med det vi äter.
        //Vi har gjort ett api.
        //Lägger en virtuell för at vi ska ha en specialegenskap hos hunden- se hund class
        //This är det djuret man anropar. Så om katt äter hund så är this.weight = katten och food.weight blir hund.
        public virtual void Eat(IEdible food)
        {
            this.Weight += food.Weight;// vikten ska öka med det vi äter.

        }
    }
}
