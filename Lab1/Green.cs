namespace Lab1
{
    public class Green
    {
        public bool Task1(double d)
        {
            bool answer = false;

            // code here
            answer = Math.Abs(d) >= 1;
            // end

            return answer;
        }
        public bool Task2(double d, double f)
        {
            bool answer = false;

            // code here
            answer = ((d + f) / 2) > 0;
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            answer = (a + b) > ((a + b) / 2);
            // end

            return answer;
        }
        public int Task4(int a, int b, int c)
        {
            int answer = 0;

            // code here
            answer = Math.Max(a, Math.Max(b, c));
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            answer = (Math.Abs(x) > 1 ? 0 : x * x - 1);
            // end

            return answer;
        }
        public bool Task6(double x, double y)
        {
            bool answer = false;

            // code here
            if(x < 0)
            {
                answer = (1 + x >= y) && (y >= 0);
            }
            else
            {
                answer = (1 - x >= y) && (y >= 0);
            }
            // end

            return answer;
        }

        public bool Task7(int n)
        {
            bool answer = true;

            // code here
            answer = !(n < 0 || n % 2 == 0);
            // end

            return answer;
        }
        public bool Task8(int X, int Y)
        {
            bool answer = false;

            // code here
            int now = 10 * 60;
            if (X < 7)
            {
                answer = false;
            }
            else
            {
                now = 10 * 60 - 7 * 60 + (X / 2 + X % 2) * Y;
                if(7 * 60 <= now && now <= 9 * 60) answer = true;
            }
            Console.WriteLine($"{X}, {Y}, {answer}");
            // end

            return answer;
        }
    }
}
