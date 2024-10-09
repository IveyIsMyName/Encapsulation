//#define STRUCT_POINT

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
	internal class Program
	{
		static void Main(string[] args)
		{
#if STRUCT_POINT
			Point A = new Point(22, 33);
			//Console.WriteLine($"X = {A.GetX()}\tY = {A.GetY()}");
			//A.SetX(2000);
			//A.SetY(3000);
			//A.Print();
			//A.X = 22;
			//A.Y = 33;
			A.Print(); 
#endif
			Point A = new Point(2, 3);
			Point B = new Point(7, 8);

			A.Print();
			B.Print();

            Console.WriteLine($"Расстояние от точки 'A' до точки 'B':{A.Distance(B)}");
            Console.WriteLine($"Расстояние от точки 'B' до точки 'A':{B.Distance(A)}");
            Console.WriteLine($"Расстояние между точками 'A' и 'B':{Point.Distance(A, B)}");
            Console.WriteLine($"Расстояние между точками 'B' и 'A':{Point.Distance(B, A)}");
		}
	}
}
