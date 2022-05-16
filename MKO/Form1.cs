using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Classes;

namespace MKO
{
    public partial class Form1 : Form
    {
        Coefs coefs;

        public Form1()
        {
            InitializeComponent();
            coefs = new Coefs();
        }

        private void readInputButton_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
            {
                return;
            }

            BuildGraph();
        }

        private void BuildGraph()
        {
            int n = (int)inputN.Value;
            string name = $"uh, n = {n}";

            DeleteSeries($"Points {name}");
            DeleteSeries($"Line {name}");

            AddPoints(name, System.Drawing.Color.Red);

            FillMatrix(n, out SimplifiedMatrix matrix);

            var result = new List<double>(matrix.Solve());
            result.Insert(0, 0);

            var points = chart1.Series[$"Points {name}"].Points;
            var lines = chart1.Series[$"Line {name}"].Points;

            double h = 1.0 / n;

            for (int i = 0; i < result.Count; ++i)
            {
                if (result[i] == double.NaN)
                    continue;
                var point = new System.Windows.Forms.DataVisualization.Charting.DataPoint(h * i , result[i]);
                lines.Add(point);
                points.Add(point);
            }

            var L = Math.Round(normL(result, h), 6);
            var H = Math.Round(normH(result, h, L), 6);

            labelL.Text = L.ToString();
            labelH.Text = H.ToString();
        }

        private bool SetValues()
        {
            coefs.t = inputT.Text;
            coefs.b = inputB.Text;
            coefs.sigma = inputSigma.Text;
            coefs.f = inputF.Text;

            if (double.TryParse(inputQ.Text, out coefs.q))
            {
                return true;
            }

            return false;
        }

        private bool InputsFilled()
        {
            TextBox[] boxes = new TextBox[] 
            { inputT, inputB, inputSigma, inputF, inputQ };

            foreach (var box in boxes)
            {
                if (box.Text == "")
                {
                    return false;
                }
            }

            return true;
        }

        private bool CheckInput()
        {
            if (!InputsFilled())
            {
                MessageBox.Show("An empty input field is present");
                return false;
            }

            if (!SetValues())
            {
                MessageBox.Show("Q must be a constant value");
                return false;
            }

            if (!coefs.ProperFunctions())
            {
                MessageBox.Show("One (or more) of the fields does not contain a proper function");
                return false;
            }

            return true;
        }

        private void FillMatrix(int n, out SimplifiedMatrix matrix)
        {
            double h = 1.0 / n;
            int n1 = n - 1;

            matrix = new SimplifiedMatrix(n);

            matrix.Rows[0].b = coefs.FindA(h, 1, 1);
            matrix.Rows[0].c = coefs.FindA(h, 2, 1);
            matrix.Rows[0].d = coefs.FindL(h, 1);

            matrix.Rows[n1].a = coefs.FindA(h, n1, n);
            matrix.Rows[n1].b = coefs.FindA(h, n, n);
            matrix.Rows[n1].d = coefs.FindL(h, n);

            for (int i = 1; i < n1; ++i)
            {
                int I = i + 1;
                int Ipp = i + 2;
                int Imm = i;

                matrix.Rows[i].a = coefs.FindA(h, Imm, I);
                matrix.Rows[i].b = coefs.FindA(h, I, I);
                matrix.Rows[i].c = coefs.FindA(h, Ipp, I);

                matrix.Rows[i].d = coefs.FindL(h, I);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            SetDefaultChart();
        }

        private double normL(List<double> qs, double h)
        {
            double result = 0;

            for (int i = 0; i < qs.Count - 1; ++i) 
            {
                var qi = qs[i];
                var qi1 = qs[i + 1];
                result += Math.Pow(qi, 2) + Math.Pow(qi1, 2) + qi * qi1;
            }

            result = result * h / 3;

            return Math.Pow(result, 0.5);
        }

        private double normH(List<double> qs, double h, double L)
        {
            double result = 0;

            for (int i = 0; i < qs.Count - 1; ++i)
            {
                var qi = qs[i];
                var qi1 = qs[i + 1];
                result += Math.Pow(qi, 2) + Math.Pow(qi1, 2) - 2 * qi * qi1;
            }

            result = result / h + Math.Pow(L, 2);

            return Math.Pow(result, 0.5);
        }
    }
}
