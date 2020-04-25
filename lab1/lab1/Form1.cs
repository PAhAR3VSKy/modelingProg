﻿using System;
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
                double r = ((double)rand.Next(0, 10000) / 10000);
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

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            int sample = (int)numericUpDown1.Value;
            int numberIntervals = (int)numericUpDown2.Value;
            for(int i = 0; i < sample; i++)
            {
                double value;
                if (radioButton1.Checked)
                    value = generationCPT(1, 2, 50);
                else
                    value = generationBM(1, 2);

                listBox1.Items.Add(value);
            }

        }
    }
}