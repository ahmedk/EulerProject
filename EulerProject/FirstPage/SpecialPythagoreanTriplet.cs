namespace EulerProject.FirstPage
{
    public class SpecialPythagoreanTriplet : IProblem
    {
        public object Solve(params object[] args)
        {
            if (args.Any())
            {
                if (args[0].GetType() == typeof(int))
                {
                    var sum = (int)args[0];
                    //return FindTriplet(sum);
                    return OptimizedFindTriplet(sum);
                }
            }
            return 0;
        }

        private long FindTriplet(int sum)
        {
            long a = 0, b = 0, c = 0;
            bool end = false;
            for (a = 3; a <= (sum - 3) / 3; a++)
            {
                for (b = a + 1; b <= (sum - 1 - a) / 2; b++)
                {
                    c = sum - a - b;
                    var left = Math.Pow(a, 2) + Math.Pow(b, 2);
                    var right = Math.Pow(c, 2);
                    if (left == right && a + b + c == 1000)
                    {
                        end = true;
                        break;
                    }
                }
                if (end)
                    break;
            }

            return a * b * c;
        }

        private long OptimizedFindTriplet(int sum)
        {
            var sum2 = sum / 2;
            var mlimit = Math.Sqrt(sum2) - 1;
            for(var m = 2; m <= mlimit; m++)
            {
                if (sum2 % m == 0)
                {
                    var sm = sum2 / m;
                    while(sm % 2 == 0)
                        sm /= 2;
                    var k = m % 2 == 1 ? m + 2 : m + 1;
                    while(k < 2 * m && k <= sm)
                    {
                        if(sm % k == 0 && GCD(k,m) == 1)
                        {
                            var d = sum2 / (k * m);
                            var n = k - m;
                            var a = d * (n + 1);
                            var b = d * (n + 2);
                            var c = d * (n + 3);
                            return a * b * c;
                        }
                    }
                }
            }
            return 0;
        }

        private static int GCD(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            return a | b;
        }
    }
}
