using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireGame
{
   public  class Click
    {
        //instance of the class that is used to generate the random no.
        Random rd = new Random();
        //create an user define function that is used to send the hint to generate  the sound of the fire
        public int gen()
        {
            return rd.Next(1, 6);
        }
    }
}
