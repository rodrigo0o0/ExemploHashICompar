using ExemploHashICompar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHashICompar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<Product> a = new HashSet<Product>();
            a.Add(new Product("TV", 900.00));
            a.Add(new Product("Notebook", 1200.00));

            HashSet<Point> b= new HashSet<Point>();
            b.Add(new Point(3, 4));
            b.Add(new Point(5, 10));

            Product prod = new Product("Notebook", 1200.00);
            foreach (var item in a)
            {
                Console.WriteLine(item.GetHashCode());
            }
            Console.WriteLine(a.Contains(prod));

            Point point = new Point(3, 4);

            Console.WriteLine(b.Contains(point));


            Console.ReadKey();
        }
    }
}
