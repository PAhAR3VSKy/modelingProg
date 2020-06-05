using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3IM
{
    class Port
    {
        Random rand = new Random();
        List<int> turnTankerPortA = new List<int>();
        //List<T> turnTankerPortB = new List<T>();
       // List<T> turnServicePortA = new List<T>();
        //List<T> turnServicePortB = new List<T>();
        int timeTanker1 = 0;
        int timeTanker2 = 0;
        int timeTanker3 = 0;
        int time = 0;

        public double Storm()
        {
            return 0;
        }

        public void Service(int k, int SpecificTanker, int arrivalTime)
        {
            Tanker tanker = new Tanker();
            if(time == arrivalTime)
            { }
            switch (k)
            {
                case 1:
                    break;
                case 2:
                    break;
            }
            time++;
        }
    }
}
