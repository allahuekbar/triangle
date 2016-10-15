using System;

namespace triange
{


public enum TriangleType
{
	_90Triangle,
	IsoscelesTriangle,
	RightTriangle,
	GeneralTriangle
}


struct data
{
	public double angleA;
	public double angleB;
	public double angleC;
	public double Square;
	public double Perimeter;
	public TriangleType triangleForm;
	public double inscribed;
	public double desribed;
}





class Triangle
{

	private double _sideAb;
	private double _sideBc;
	private double _sideCa;
	private data _trPrms;
	private string _trType;
	public string TrType;




	public double SideAb 
	{

		get { return _sideAb; } 

		set {
			if (value <= 0) 
			{
				throw new Exception ("Variable should be greater than 0");
			}

			_sideAb = value;
		}
	} 




	public double SideBc 
	{

		get 
		{ 
			return _sideBc; 
		} 


		set {
			if (value <= 0) 
			{
				throw new Exception ("Variable should be greater than 0");
			}
			_sideBc = value;  
		}

	}




	public double SideCa 
	{
		get { return _sideCa; }
		set {
			if (value <= 0) 
			{
				throw new Exception ("Variable should be greater than 0");
			}
			_sideCa = value; 
		}

	} 

	public data TriangleParams
	{
		get{ return _trPrms;}
		set
		{
			_trPrms = new data ();
		}
	}






	private void TriangleParamsInit(double a, double b, double c)
	{
		_trPrms.Perimeter = a+b+c;

			_trPrms.angleA = Math.Acos( ((b * b) + (c * c) - (a * a)) / (2 * b * c));
			_trPrms.angleB = Math.Acos (((a * a) + (c * c) - (b * b)) / (2 * a * c));
		_trPrms.angleC = Math.Acos (((a * a) + (b * b) - (c * c)) / (2 * a * b);

		double p = (a + b + c) / 2;

		_trPrms.Square = Math.Sqrt (p * (p - a) * (p - b) * (p - c));
		_trPrms.desribed = a * b * c / (4 * (_trPrms.Square));
		_trPrms.inscribed=(_trPrms.Square/p);


	if ((a.Equals (b)) || (b.Equals (c)) || (c.Equals (a))) 
		{

		TrType = TriangleType.IsoscelesTriangle.ToString ();
		
				if ((a.Equals(c))&&(b.Equals(c))) 
		TrType = TriangleType.RightTriangle.ToString ();
			
		} 		
	else if ((a == Math.Sqrt (b * b + c * c)) || (b == Math.Sqrt (a * a + c * c)) || (c == Math.Sqrt (b * b + a * a))) 
		{
			TrType = TriangleType._90Triangle.ToString();
		}	
		else 
			TrType = TriangleType.GeneralTriangle.ToString();
		//angle calc formula
	}


	public Triangle(double a, double b, double c)
	{
		SideAb = c;
		SideBc = a;
		SideCa = b;



		if((a+b<c)||(a+c<b)||(b+c<a))
			{
			
				throw new Exception ("error");

			}

			TriangleParamsInit (a, b, c);
	//	_trPrms.angleA = getAngleA (a, b, c);
	}


}
}

