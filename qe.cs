using System; 


public class Quadratic_eq
{
	private double discr, x1, x2, x1x2;
		
	public double get_x1(int a, int b, double discriminant)
	{
		if (b < 0)
		{
			x1 = (b + Math.Sqrt(discriminant))/(2*a);
		}
		else
		{
		    x1 = (-b + Math.Sqrt(discriminant))/(2*a);
		}
		return x1;
	}
	
	public double get_common_x1x2(int a, int b)
	{
		x1x2 = -(b/(2*a));
		return x1x2;
	}
	
	public double get_x2(int a, int b, double discriminant)
	{
		if (b < 0)
		{
			x2 = (b - Math.Sqrt(discriminant))/(2*a);
		}
		else
		{
		    x2 = (-b - Math.Sqrt(discriminant))/(2*a);
		}
		return x2;
	}
	
	public double GetSolution(int a, int b, int c)
	{		
		discr = Math.Pow(b,2) - (4*a*c);
		return discr;
	}
}
///////////////////////////////////////////////////
					
public class Program
{
	public static void Main()
	{	  
	   int a, b, c;
	   double discr, x1, x2, x1x2;
       Quadratic_eq qe = new Quadratic_eq();
	   Console.WriteLine("Solving of quadratic equatuons like ax^2 + bx + c = 0\n");
	   Console.WriteLine("Input value a:");
	   a = int.Parse(Console.ReadLine());
	   Console.WriteLine("Input value b:");
	   b = int.Parse(Console.ReadLine());
	   Console.WriteLine("Input value c:");
	   c = int.Parse(Console.ReadLine());
		
		 discr = qe.GetSolution(a, b, c);
		if (discr < 0) 
		{
			Console.WriteLine("Discriminant less than 0. No solutions.");
			return;
		}
		else if (discr == 0)
		{
			x1x2 = qe.get_common_x1x2(a, b);
			Console.WriteLine("Discriminant={0}, x1=x2={1}", discr, x1x2);
			return;
		}
		else
		{
		    x1 = qe.get_x1(a, b, discr);
		    x2 = qe.get_x2(a, b, discr);
			Console.WriteLine("Discriminant={0}, x1={1}, x2={2}", discr, x1, x2);
			return;
		}
				
	}
}