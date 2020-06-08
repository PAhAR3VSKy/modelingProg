using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3IM
{
    public partial class Form1 : Form
    {

        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadingHours.Series[0].Points.Clear();
            loadingHours.Series[1].Points.Clear();
            loadingPercent.Series[0].Points.Clear();
            loadingPercent.Series[1].Points.Clear();
            meanNumbTanker.Series[0].Points.Clear();
            meanNumbTanker.Series[1].Points.Clear();
            meanTimeTanker.Series[0].Points.Clear();
            meanTimeTanker.Series[1].Points.Clear();
            meanWaitTanker.Series[0].Points.Clear();
            meanWaitTanker.Series[1].Points.Clear();

            int modelingTime = Convert.ToInt32(numericUpDown1);
            //Port<Tanker1> tanker1 = new Port<Tanker1>();

            Port<Tanker1> tanker1 = new Port<Tanker1>();
            Port<Tanker2> tanker2 = new Port<Tanker2>();
            Port<Tanker3> tanker3 = new Port<Tanker3>();

            for (int i = 0; i < modelingTime; i++)
            {
                double chance = rand.Next(1, 11);

                if (chance <= 2.5)
                    tanker1.Service(1);
                else if (chance > 2.5 && chance <= 8)
                    tanker2.Service(1);
                else
                    tanker3.Service(1);
            }
        }
    }
}
