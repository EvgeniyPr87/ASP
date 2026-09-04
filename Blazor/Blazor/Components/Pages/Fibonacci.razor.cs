namespace Blazor.Components.Pages
{
    public partial class Fibonacci
    {

        int num;
        int[] result;

        public int[] FibCalculate(int num)
        {

        int[]fib = new int[num];
            fib[0] = 0;
            fib[1] = 1;

            for(int i=2; i<num; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }
                return fib;

        }
        public void FibCreate()
        {
            result = FibCalculate(num);
        }
    }
}
