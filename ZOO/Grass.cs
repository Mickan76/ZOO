using System;
using System.Collections.Generic;
using System.Text;

namespace ZOO
{

    //Ska implementera IEdible in i Grass. Denna ärver från I Edible.
    class Grass:IEdible
    {

        public double Weight { get; set; }

        public Grass(double weight)

        {

           this.Weight = weight;
        }
    }


}
