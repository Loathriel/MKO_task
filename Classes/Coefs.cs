using System;
using Z.Expressions;

namespace Classes
{
    public class Coefs
    {
        private const string paramName = "x";

        // variables to pass functions into class
        public string t
        {
            set;
            private get;
        }
        public string b
        {
            set;
            private get;
        }
        public string sigma
        {
            set;
            private get;
        }
        public string f
        {
            set;
            private get;
        }

        // functions that can be used to get values
        private Func<double, double> T;
        private Func<double, double> B;
        private Func<double, double> Sigma;
        private Func<double, double> F;

        // const q
        public double q;

        // a-coefs
        private double Aii(double xmm, double xpp, double h)
        {
            return
                1.0 / h * (T(xmm) + T(xpp)) +
                0.5 * (B(xmm) - B(xpp)) +
                h / 3 * (Sigma(xmm) + Sigma(xpp));
        }
        private double Aii1(double x, double h)
        {
            return
                -1.0 / h * T(x)
                -0.5 * B(x) +
                h / 6 * Sigma(x);
        }
        private double Ai1i(double x, double h)
        {
            return
                -1.0 / h * T(x) +
                0.5 * B(x) +
                h / 6 * Sigma(x);
        }
        private double Ann(double x, double h)
        {
            return
                1.0 / h * T(x) +
                0.5 * B(x) +
                h / 3 * Sigma(x);
        }

        // l-coefs
        private double Li(double xmm, double xpp, double h)
        {
            return h * 0.5 * (F(xmm) + F(xpp));
        }
        private double Ln(double x, double h)
        {
            return h * 0.5 * F(x) - q;
        }

        // uniformed a
        public double FindA(double h, int pos, int curr)
        {
            double x = curr * h;
            double xmm = x - h / 2;
            double xpp = x + h / 2;

            if (pos > curr)
            {
                return Ai1i(xpp, h);
            }

            if (pos < curr)
            {
                return Aii1(xmm, h);
            }

            if (x == 1)
            {
                return Ann(xmm, h);
            }

            return Aii(xmm, xpp, h);
        }

        // uniformed l
        public double FindL(double h, int i)
        {
            double x = h * i;
            double xmm = x - h / 2;
            double xpp = x + h / 2;
            if (x == 1)
            {
                return Ln(xmm, h);
            }

            return Li(xmm, xpp, h);
        }

        public bool ProperFunctions()
        {
            try
            {
                T = Eval.Compile<Func<double, double>>(t, paramName); 
                B = Eval.Compile<Func<double, double>>(b, paramName);
                Sigma = Eval.Compile<Func<double, double>>(sigma, paramName);
                F = Eval.Compile<Func<double, double>>(f, paramName);
            }
            catch
            {
                return false;
            }
            
            return true;
        }
    }
}
