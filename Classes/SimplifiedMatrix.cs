namespace Classes
{
    public class SimplifiedMatrix
    {
        public int N
        {
            get;
            private set;
        }
        public Row[] Rows
        {
            get;
            private set;
        }

        public SimplifiedMatrix(int n)
        {
            N = n;
            Rows = new Row[n];
            for (int i = 0; i < N; ++i)
            {
                Rows[i] = new Row();
            }
        }

        public double[] Solve()
        {
            double[] result = new double[N];
            double[] c = new double[N-1];
            double[] d = new double[N];

            c[0] = Rows[0].c / Rows[0].b;
            d[0] = Rows[0].d / Rows[0].b;

            for (int i = 1; i < N-1; ++i) 
            {
                double divider = 1 / (Rows[i].b - c[i - 1] * Rows[i].a);
                c[i] = Rows[i].c * divider;
                d[i] = (Rows[i].d - d[i - 1] * Rows[i].a) * divider;
            }
            d[N - 1] = (Rows[N - 1].d - d[N - 2] * Rows[N - 1].a) / (Rows[N - 1].b - c[N - 2] * Rows[N - 1].a);

            result[N - 1] = d[N - 1];
            for (int i = N - 2; i >= 0; --i) 
            {
                result[i] = d[i] - c[i] * result[i + 1];
            }

            return result;
        }
    }

    public class Row
    {
        public double a;
        public double b;
        public double c;
        public double d;

        public Row()
        {
            a = b = c = d = 0;
        }
    }
}
