using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3IM
{
    class Tanker
    {
        Random rand = new Random();

        

        public Tanker()
        {

        }

        public int SetSpecificTanker(int k)
        {
            switch(k)
            {
                case 1:
                    return rand.Next(16, 20); 
                case 2:
                    return rand.Next(21, 27);
                case 3:
                    return rand.Next(31, 39);
                default:
                    return 0;
            }
        }
    }
}
