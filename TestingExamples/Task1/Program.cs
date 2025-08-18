namespace Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        public void Start()
        {

        }

        public double Calculator(double val1, double val2)
        {
            return val1 * val2;
        }

        public double Divider(double val1, double val2)
        {
            if (val1 == 0 || val2 == 0)
                throw new DivideByZeroException("Attempted to divide by zero");

            return val1 * val2;
        }
    }
}