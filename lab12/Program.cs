using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("exercise 12.1");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("exercise 12.2");
            Rational r = new Rational(3,12);
            Console.WriteLine(r);
            Rational r1 = new Rational(11, 4);
            Console.WriteLine(r1);
            Rational r2 = r - r1;
            Console.WriteLine("вычитание-->  " + r2);
            r2 = r + r1;
            Console.WriteLine("сложение-->  "+r2);
            


            Console.WriteLine("HomeTask 12.1");
            Complex c1 = new Complex(12, 8);
            Complex c2 = new Complex(4, -8);
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine($"сложение{c1+c2}");
            Console.WriteLine($"умножение{c1*c2}");
            Console.WriteLine(); ;

            Console.WriteLine("HomeTask 12.2");
            Array<Book> library = new Array<Book>();
            library.Add(new Book("Технический анализ", "Джек Швагер", "Альпина Паблишер"));
            library.Add(new Book("Зональный трейдинг", "Марк Дуглас", "Альпина паблишер"));
            library.Sort(Array<Book>.byName);

        }
    }
}
