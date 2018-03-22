using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deMorgansTheorem
{
    class Program
    {
        static void Main(string[] args)
        {

            bool A = true;
            bool B = false;

            // Условие до применения теоремы Де Моргана.
            if (A | B)
                Console.WriteLine("A | B = {0}", A | B);
            else
                Console.WriteLine("A | B = {0}", A | B);

            if (A & B)
                Console.WriteLine("A & B = {0}", A & B);
            else
                Console.WriteLine("A & B = {0}", A & B);

            // Условие после применения теоремы Де Моргана.
            if (!(!A & !B))
                Console.WriteLine("!(!A & !B) = {0}", !(!A & !B));
            else
                Console.WriteLine("!(!A & !B) = {0}", !(!A & !B));

            if(!(!A | !B))
                Console.WriteLine("!(!A | !B) = {0}", !(!A | !B));
            else
                Console.WriteLine("!(!A | !B) = {0}", !(!A | !B));

            //Альтернативный вариант.


            bool X = false;
            bool Y = false;

            Console.WriteLine("{0} || {1} = {2}", X, Y, X || Y);
            Console.WriteLine("!(!{0} && !{1}) = {2}", X, Y, !(!X && !Y));

            Console.ReadKey();


        }
    }
}
