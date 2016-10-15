using System;


namespace triange
{
	class MainClass
	{
		public static void Main ()
		{
			try{
			double a = Convert.ToDouble(Console.ReadLine());
			double b = Convert.ToDouble(Console.ReadLine());
			double c = Convert.ToDouble(Console.ReadLine());
			

			Triangle t = new Triangle (a,b,c);
				//Pr

				Console.WriteLine(t.TriangleParams.Perimeter);
				Console.WriteLine(t.TriangleParams.angleA);
				Console.WriteLine(t.TriangleParams.angleB);
				Console.WriteLine(t.TriangleParams.angleC);
				Console.WriteLine(t.TriangleParams.desribed);
				Console.WriteLine(t.TriangleParams.inscribed);
				Console.WriteLine(t.TrType);





					
		

//				Console.WriteLine("");

			}

			catch(Exception e) 
			{
				Console.WriteLine ("error");
				Main ();
			}

		}

		void PrintTriangle(Triangle t)
		{
			//Console.WriteLine(t.SideAb
		}
	}
}
