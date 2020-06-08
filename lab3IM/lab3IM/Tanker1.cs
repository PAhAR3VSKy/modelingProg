using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3IM
{
    class Tanker1 : Tanker
    {

        Random rand = new Random();
        public Tanker1() { }

        public override void LoadingTimeTanker()
        {
            Time++;
        }

        public override void WaitingTimeTanker()
        {
            WaitTimeTanker++;
        }

        public override int SetSpecificTanker()
        {
            return rand.Next(16, 20);
        }
    }
}
