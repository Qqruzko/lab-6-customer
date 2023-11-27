using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            init();
            Console.ReadLine();
        }
        static void init()
        {
            Console.WriteLine("Enter first side of trinagle");
            int AB = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second side of trinagle");
            int BC = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third side of trinagle");
            int CA = int.Parse(Console.ReadLine());
            Triangle triangle1 = new Triangle();
            triangle1.populate(AB, BC, CA);
            Console.WriteLine("You entered: side a={0},side b={1},side c={2}", triangle1.pAB(),triangle1.pBC(), triangle1.pCA());
            real_triangle(triangle1);
            
        }
        static void real_triangle(Triangle tri)
        {
            if (tri.pAB() + tri.pBC() < tri.pCA()|| tri.pBC() + tri.pCA()< tri.pAB()|| tri.pAB()+ tri.pBC()< tri.pCA())
            {
                Console.WriteLine("False");
                
            }
            else 
                if (tri.pAB() + tri.pBC() > tri.pCA() || tri.pBC() + tri.pCA() > tri.pAB() || tri.pAB() + tri.pBC() > tri.pCA())
            {
                Console.WriteLine("True");
                triangle_perimeter(tri);
            }
                

        }

        static void triangle_perimeter(Triangle tri)
        {
            int perimeter = tri.pBC() + tri.pCA() + tri.pCA();
            Console.WriteLine("Perimeter ={0}", perimeter);
            triangle_space(tri, perimeter);
        }
        static void triangle_space(Triangle tri, int perimeter)
        {
             int p = perimeter/2;
            double S = Math.Sqrt(p*(p-tri.pAB())* (p - tri.pBC()) * (p - tri.pCA()));
            Console.WriteLine("S of your triangle = {0}", S);
        }
        }
    }

