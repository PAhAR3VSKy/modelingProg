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

        public int Time { get; set; }

        public int LoadTimeTanker { get; set; }

        public int WaitTimeTanker { get; set; }

        public Tanker()
        {
            Time = 0;
            LoadTimeTanker = 0;
            WaitTimeTanker = 0;
        }

        virtual public void LoadingTimeTanker()
        {
            Time++;
        }

        virtual public void WaitingTimeTanker()
        {
            WaitTimeTanker++;
        }

        virtual public int SetSpecificTanker() { return 0; }
    }
}
