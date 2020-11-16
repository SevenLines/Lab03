using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            var triangle = new Triangle();
            Console.WriteLine(
                "Ура изменения! =) Мы в ветке master!" 
                + triangle.ToString()
            );
            Console.ReadKey();
        }
    }
}
