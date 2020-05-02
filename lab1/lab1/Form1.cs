using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }


        double generationCPT(double sigma, double mu, int num)
        {
            double V = 0;
            for(int i = 0; i < num; i++)
            {
                double r = rand.NextDouble();
                V += r;
            }
            double x = (V - (double)num/2) / Math.Sqrt(num/12);
            return mu + sigma*x;
        }

        double generationBM(double sigma, double mu)
        {
            double r1 = ((double)rand.Next(0, 10000) / 10000);
            double r2 = ((double)rand.Next(0, 10000) / 10000);
            double Z = Math.Sqrt(-2 * Math.Log(r1)) * Math.Cos(Math.PI * 2 * r2);
            return Z*sigma + mu;
        }

        double CriterionPearson(int[] a, int[] b)
        {
            double xi = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (b[i] != 0)
                    xi += Math.Pow((a[i] - b[i]), 2) / b[i];
            }
            return xi;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart2.Series[0].Points.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            int sample = (int)numericUpDown1.Value, 
                numberIntervals = (int)numericUpDown2.Value;
            double[] valueCPT = new double[sample];
            double[] valueBM = new double[sample];
            int[] intervalsCPT = new int[numberIntervals];
            int[] intervalsBM = new int[numberIntervals];
            
            for (int i = 0; i < sample; i++)
            {
                valueCPT[i] = generationCPT(1, 2, 12);
                valueBM[i] = generationBM(1, 2);
            }

            for (int i = 0; i < sample; i++)
            {
                for (int j = 0; j < numberIntervals; j++)
                {
                    if ((int)valueCPT[i] == j)
                        intervalsCPT[j]++;
                    if ((int)valueBM[i] == j)
                        intervalsBM[j]++;
                }
            }

            for (int i = 0; i < numberIntervals; i++)
            {
                chart1.Series[0].Points.AddXY(i, intervalsBM[i]);
                chart2.Series[0].Points.AddXY(i, intervalsCPT[i]);
            }
            for (int i = 0; i < sample; i++)
            {
                listBox1.Items.Add(valueBM[i]);
                listBox2.Items.Add(valueCPT[i]);
            }

            textBox1.Text = CriterionPearson(intervalsBM, intervalsCPT).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
