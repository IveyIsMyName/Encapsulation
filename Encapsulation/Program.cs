//#define STRUCT_POINT
//#define DISTANCE

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
#if DISTANCE
			Point A = new Point(2, 3);
			Point B = new Point();      //Default Constructor
			B.X = 3;
			B.Y = 4;
			Point C = new Point(B);
			A.Print();
			B.Print();
			C.Print();
			Point D;
			D = C;

			Console.WriteLine($"Расстояние от точки 'A' до точки 'B':{A.Distance(B)}");
			Console.WriteLine($"Расстояние от точки 'B' до точки 'A':{B.Distance(A)}");
			Console.WriteLine($"Расстояние между точками 'A' и 'B':{Point.Distance(A, B)}");
			Console.WriteLine($"Расстояние между точками 'B' и 'A':{Point.Distance(B, A)}"); 
#endif
			Point A = new Point(2, 3);
			Point B = new Point(7, 8);
			Point C = new Point(A + B);	
			C.Print();
			Point D = new Point(A - B);
			D.Print();

			for (Point i = new Point(); i.X < 10; i++)
			{
				i.Print();
			}

		}
	}
}
