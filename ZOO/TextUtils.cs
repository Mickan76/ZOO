using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ZOO
{
     static class TextUtils
    {

        //Metod för att skriva ut en bokstav i taget. 
        //Gör denna statisk.
        public  static void Animate(string text)

        {

            foreach (var c in text)
            {
                Console.Write(c);
                Thread.Sleep(100);// Detta gör att texten stannar till och bokstav för bokstav kommer steg för steg.Pausa exikveringen
            }
            Console.WriteLine();
           
        }

    }
}
