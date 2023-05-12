using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_s_intake
{
    class Program
    {
        static void Main(string[] args)
        {
            //A program 2 intake name,roll no. and field of interestof the User
            string K;
            string B;
            string R;

            Console.WriteLine("Enter your name");
            K = Console.ReadLine();

            Console.WriteLine("Enter your Roll number");
            B = Console.ReadLine();

            Console.WriteLine("Enter your Field of interest");
            R = Console.ReadLine();
            Console.WriteLine("HEY, MY NAME IS {0} AND MY ROLL NUMBER IS {1}.MY FIELDS OF INTEREST ARE {2}.", K, B, R);
        }
    }
}
