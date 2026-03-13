using System.Linq;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        public void Start()
        {
            Reverse();
        }

        public int Reverse(int x = -321)
        {
            string str = x.ToString();
            string add = "";

            if (str[0] == '-')
            {
                add = "-";
                str = str.Substring(1); 
            }

            char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            string reversed = new string(chars);

            return int.Parse(add + reversed);
        }


    }
}
