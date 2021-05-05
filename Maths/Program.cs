using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maths
{
    class Program
    {
        static void Main(string[] args)
        {
            FourOperations fourOperations = new FourOperations();
            fourOperations.Addition(5,6);
            fourOperations.Division(5, 6);
            fourOperations.Extraction(5, 6);
            fourOperations.Multiplication(5, 6);

            Console.ReadLine();
        }
    }
}
