using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        double S, K, v, r, T, x;
        Int32 steps, paths;

        public Form1()
        {
            InitializeComponent();
        }

        
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                S = Convert.ToDouble(tbUnder.Text);
            }

            catch
            {
                rTBresults.Text = "Error, please enter Underlying Price as a number";
                return;
            }
            try
            {
                K = Convert.ToDouble(TbStrike.Text);
            }
            catch
            {
                rTBresults.Text = "Error, please enter Strike Price as a number";
                return;
            }
            try
            {
                v = Convert.ToDouble(TbVol.Text);
            }
            catch
            {
                rTBresults.Text = "Error, please enter Volatility as a decimal";
                return;
            }
            try
            {
                r = Convert.ToDouble(TbRate.Text);
            }
            catch
            {
                rTBresults.Text = "Error, please enter Risk-Free Rate as a decimal";
                return;
            }
            try
            {
                T = Convert.ToDouble(TbTenor.Text);
            }
            catch
            {
                rTBresults.Text = "Error, please enter Tenor as a number";
                return;
            }
            try
            {
                steps = Convert.ToInt32(TbSteps.Text);
            }
            catch
            {
                rTBresults.Text = "Error, please enter Number of Steps as an integer";
                return;
            }
            try
            {
                paths = Convert.ToInt32(TbPaths.Text);
            }
            catch
            {
                rTBresults.Text = "Error, please enter Number of Paths as an integer";
                return;
            }

            if (raBCall.Checked == true)
            {
                int type = 0;
                double[,] w = new double[paths, steps];
                double[] price, d1, d2, v1, v2, r1, r2, t1 = new double[2];
                Random1 rnd = new Random1();
                w = rnd.PolarReject(paths, steps);
                EuroOption euro = new EuroOption();
                price = euro.Pricing(w, S, K, v, r, T, steps, paths, type);
                d1 = euro.Pricing(w, S + S * 0.001, K, v, r, T, steps, paths, type);
                d2 = euro.Pricing(w, S - S * 0.001, K, v, r, T, steps, paths, type);
                v1 = euro.Pricing(w, S, K, v + v * 0.001, r, T, steps, paths, type);
                v2 = euro.Pricing(w, S, K, v - v * 0.001, r, T, steps, paths, type);
                t1 = euro.Pricing(w, S, K, v, r, T + T * 0.001, steps, paths, type);
                r1 = euro.Pricing(w, S, K, v, r + r * 0.001, T, steps, paths, type);
                r2 = euro.Pricing(w, S, K, v, r - r * 0.001, T, steps, paths, type);

                rTBresults.Text = "Price: " + Convert.ToString(price[0])+ "\n" +
                "Delta: " + Convert.ToString((d1[0] - d2[0]) / (2 * 0.001 * S))+"\n"+
                "Gamma: " + Convert.ToString((d1[0] - 2 * price[0] + d2[0]) / (Math.Pow(S * 0.001, 2)))+ "\n" +
                "Vega: " + Convert.ToString((v1[0] - v2[0]) / (2 * 0.001 * v))+ "\n" +
                "Theta: " +  Convert.ToString((t1[0] - price[0])*-1 / (0.001 * T))+ "\n" +
                "Rho: " + Convert.ToString((r1[0] - r2[0]) / (2 * 0.001 * r))+ "\n" +
                "Error: " + Convert.ToString(price[1]);
            }

            else if (rdbPut.Checked == true)
            {
                int type = 1;
                double[,] w = new double[paths, steps];
                double[] price, d1, d2,v1,v2,r1,r2,t1 = new double[2];
                Random1 rnd = new Random1();
                w = rnd.PolarReject(paths, steps);
                EuroOption euro = new EuroOption();
                price = euro.Pricing(w, S, K, v, r, T, steps, paths, type);
                d1 = euro.Pricing(w, S + S * 0.001, K, v, r, T, steps, paths, type);
                d2 = euro.Pricing(w, S - S * 0.001, K, v, r, T, steps, paths, type);
                v1 = euro.Pricing(w, S, K, v + v * 0.001, r, T, steps, paths, type);
                v2 = euro.Pricing(w, S, K, v - v * 0.001, r, T, steps, paths, type);
                t1 = euro.Pricing(w, S, K, v, r, T + T * 0.001, steps, paths, type);
                r1 = euro.Pricing(w, S, K, v, r + r * 0.001, T, steps, paths, type);
                r2 = euro.Pricing(w, S, K, v, r - r * 0.001, T, steps, paths, type);

                rTBresults.Text = "Price: " + Convert.ToString(price[0]) + "\n" +
                "Delta: " + Convert.ToString((d1[0] - d2[0]) / (2 * 0.001 * S)) + "\n" +
                "Gamma: " + Convert.ToString((d1[0] - 2 * price[0] + d2[0]) / (Math.Pow(S * 0.001, 2))) + "\n" +
                "Vega: " + Convert.ToString((v1[0] - v2[0]) / (2 * 0.001 * v)) + "\n" +
                "Theta: " + Convert.ToString((t1[0] - price[0]) * -1 / (0.001 * T)) + "\n" +
                "Rho: " + Convert.ToString((r1[0] - r2[0]) / (2 * 0.001 * r)) + "\n" +
                "Error: " + Convert.ToString(price[1]);
            }

            else
            {
                rTBresults.Text = "Error: Please select Call or Put";
            }
        }
    }
    abstract class Option
    {
        public double S { get; set; }
        public double K { get; set; }
        public double V { get; set; }
        public double R { get; set; }
        public double T { get; set; }
    }

    sealed class EuroOption : Option
    {
        public double[] Pricing(double[,] rand, double s, double k, double v, double r, double T, int steps, int paths, int type)
        {
            double vj = 0;
            double er = 0;
            double[] answer = new double[2];
            Simulator sim = new Simulator();
            double[,] payoff = new double[paths, steps + 1];
            payoff = sim.GetPrice(rand, s, k, v, r, T, steps, paths);
            if (type == 0)
            {
                for (int i = 0; i < paths; i++)
                {
                    if (payoff[i, steps] - k > 0)
                    {
                        vj += payoff[i, steps] - k;
                        payoff[i, steps] = payoff[i, steps] - k;
                    }
                    else
                    {
                        vj += 0;
                        payoff[i, steps] = 0;
                    }
                }
            }
            else if (type == 1)
            {
                for (int i = 0; i < paths; i++)
                {
                    if (k - payoff[i, steps] > 0)
                    {
                        vj += k - payoff[i, steps];
                        payoff[i, steps] = k - payoff[i, steps];
                    }
                    else
                    {
                        vj += 0;
                        payoff[i, steps] = 0;
                    }
                }
            }
            answer[0] = (vj / paths) * Math.Pow(Math.E, -r * T);
            for (int i = 0; i < paths; i++)
            {
                er += Math.Pow(((payoff[i, steps] * Math.Pow(Math.E, -r * T)) - answer[0]), 2);
            }
            er = Math.Sqrt(er / (paths - 1));
            er = er / Math.Sqrt(paths);
            answer[1] = er;

            return answer;
        }

    }


    public class Random1
    {

        // Create the Polar Rejection Method for turning uniformally distributed RV's to normally distributed RV's
        public double[,] PolarReject(int p, int s)
        {
            //Declare Variables

            double[,] prand = new double[p + 1, s];
            double rand;
            double rand2;
            double w;
            double c;
            Random rnd = new Random();
            // Create a for loop that creates a matrix of random numbers
            for (int a = 0; a < s; a++)
            {
                for (int b = 0; b <= p - 1; b += 2)
                {

                    // Create a do while function that will refind rand and rand2 if w>1
                    do
                    {
                        rand = 2 * rnd.NextDouble() - 1;
                        rand2 = 2 * rnd.NextDouble() - 1;
                        w = rand * rand + rand2 * rand2;
                    }
                    while (w > 1);
                    //Run the arithmatic to get normally distributed RV's
                    c = Math.Sqrt(-2 * Math.Log(w) / w);
                    prand[b, a] = c * rand;
                    prand[b + 1, a] = c * rand2;

                }
            }
            //Return the matrix of doubles 
            return prand;
        }
    }

    public class Simulator
    {
        public double[,] GetPrice(double[,] rand, double s, double k, double v, double r, double T, int steps, int paths)
        {
            double steps1 = Convert.ToDouble(steps);
            double t = T / steps1;
            double[,] payoff = new double[paths, steps + 1];
            for (int i = 0; i < paths; i++)
            {
                payoff[i, 0] = s;
            }

            for (int i = 0; i < paths; i++)
            {
                for (int j = 0; j < steps; j++)
                {
                    payoff[i, j + 1] = payoff[i, j] * Math.Pow(Math.E, (r - ((v * v) / 2)) * t + v * Math.Sqrt(t) * rand[i, j]);
                }
            }

            return payoff;
        }
    }






}
