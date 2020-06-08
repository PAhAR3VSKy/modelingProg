using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3IM
{
    class Port<T> where T: Tanker, new()
    {
        Random rand = new Random();
        List<T> turnTankerPortA = new List<T>();
        //List<T> turnTankerPortB = new List<T>();
        List<T> turnServicePortA = new List<T>();
        //List<T> turnServicePortB = new List<T>();
        int timeTanker1 = 0;
        int timeTanker2 = 0;
        int timeTanker3 = 0;
        int arrivalTime = 0;
        int time = 0;


        public double Storm()
        {
            return 0;
        }

        public bool funcArrivalTime(int timeCheck)  //проверка прибудет ли новый танкер
        {
            if(arrivalTime == 0)
            {
                arrivalTime = rand.Next(1, 8);
                return true;
            }
            else
            {
                arrivalTime--;
                return false;
            }
        }

        public void setTimeServiceTanker(int SpecificTanker, int arrivalTime)//установка времени для нового танкера
        {
            switch(SpecificTanker)
            {
                case 1:
                    timeTanker1 = arrivalTime;
                    break;
                case 2:
                    timeTanker2 = arrivalTime;
                    break;
                case 3:
                    timeTanker3 = arrivalTime;
                    break;
            }
        }

        public int getTimeServiceTanker(int SpecificTanker) //возврат времени обслуживания танкера
        {
            switch (SpecificTanker)
            {
                case 1:
                    return timeTanker1;
                case 2:
                    return timeTanker2;
                case 3:
                    return timeTanker3;
                default:
                    return 0;
            }
        }



        public void Service(int numberPort)// обслуживание
        {

            for (int i = 0; i < turnTankerPortA.Count(); i++)
            {
                if(/*не шторм*/true)
                {
                    turnTankerPortA[i].LoadingTimeTanker();

                }
                else
                {
                    turnTankerPortA[i].WaitingTimeTanker();
                }
            }

            switch (numberPort)
            {
                case 1:
                    if (funcArrivalTime(time) && turnServicePortA.Count() < 3)
                    {
                        turnServicePortA.Add(SpecificTanker);
                        setTimeServiceTanker(SpecificTanker, arrivalTime);
                    }else if(funcArrivalTime(time))
                    {
                        turnServicePortA.Add(SpecificTanker);
                    }
                    break;
                case 2:
                    break;
            }
            time++;
        }
    }
}
