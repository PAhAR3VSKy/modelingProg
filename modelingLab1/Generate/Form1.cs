using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Generate
{
    public partial class Form1 : Form
    {
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }



        int getIntervalOfValue(double leftLimit, double rightLimit, double countIntervals, double value)
        {
            if (value > rightLimit || value < leftLimit) return 0;
            if (rightLimit < leftLimit) return 0;

            double sizeInterval = (rightLimit - leftLimit) / countIntervals;
            return (int)Math.Truncate((value - leftLimit) / sizeInterval) + 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Series["Series1"].IsValueShownAsLabel = true;
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
        }


        private double gcpt(double sg, double m, int n)
        {
            double v = 0;

            for (int i = 0; i < n; i++)
            {
                double r = ((double)rand.Next(0, 10000) / 10000); // рандом от 0 до 1 (10000 чисел)
                v += r;
            }

            double z = (v - (double)n / 2) / (Math.Sqrt((double)n / 12));
            return z * sg + m;
        }

        private double gbm(double sg, double m)
        {

            double r = ((double)rand.Next(0, 10000) / 10000); // рандом от 0 до 1 (10000 чисел)
            double f = ((double)rand.Next(0, 10000) / 10000); // рандом от 0 до 1 (10000 чисел)

            double y = Math.Sqrt(-2 * Math.Log(r)) * Math.Cos(2 * Math.PI * f);
            return y * sg + m;
        }

        double integral(double a, double b)
        {
            int sigma = 1, m = 2;
            double func;

            double intervals = 10000;
            double dx = (b - a) / intervals;

            double res = 0;
            double x = a;
            for (int i = 0; i < intervals; i++)
            {
                x = a + dx*i;
                func = ((1 / (sigma * Math.Sqrt(2 * Math.PI)))) * Math.Exp(-(Math.Pow(x - m, 2)) / (2 * Math.Pow(sigma, 2)));
                res += func * dx;
            }

            return res;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int countIntervals = (int)numericUpDown2.Value;
            int countValues = (int)numericUpDown1.Value;

            int[] intervals = new int[countIntervals];

            listBox1.Items.Clear();

            int t = 0;
            double x2 = 0;

            double rightLim = 4;
            double leftLim = 0;

            //for (int k = 0; k < numericUpDown3.Value; k++)
           // {
                Array.Clear(intervals, 0, intervals.Length);

                for (int i = 0; i < countValues; i++)
                {
                    double value;
                    if (radioButton1.Checked) value = gcpt(1, 2, 50);
                    else value = gbm(1, 2);

                    listBox1.Items.Add(value);
                    int interval = getIntervalOfValue(leftLim, rightLim, countIntervals, value);
                    if (interval > 0) intervals[interval - 1]++;
                }

            //double[] probs = { 0.032, 0.0603, 0.0968, 0.1327, 0.1554, 0.1554, 0.1327, 0.0968, 0.0603, 0.032 };
            //double[] probs20 = { 0.013, 0.019, 0.026, 0.034, 0.044, 0.053, 0.062, 0.070, 0.076, 0.079, 0.079, 0.076, 0.070, 0.062, 0.053, 0.044, 0.034, 0.026, 0.019, 0.013 };

            double[] probs = new double[countIntervals];
            double dx = (rightLim - leftLim) / countIntervals;
            for (int i = 0; i < countIntervals; i++)
            {
                probs[i] = integral(leftLim + dx * i, leftLim + dx * (i + 1));
            }

                x2 = 0;

                for (int i = 0; i < countIntervals; i++)
                {
                    x2 += Math.Pow(intervals[i] - probs[i] * countValues, 2) / (probs[i] * countValues);
                }

               // if (x2 >= 14.684) t++;
           // }

            List<MyData> list = new List<MyData>();

            for (int i = 0; i < countIntervals; i++) 
            {
                list.Add(new MyData(i + 1, (double)intervals[i] / countValues));
            }

            chart1.Series[0].XValueMember = "X";
            chart1.Series[0].YValueMembers = "Y";
            chart1.DataSource = list;
            chart1.DataBind();

            textBox1.Text = x2.ToString();
            textBox2.Text = t.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
