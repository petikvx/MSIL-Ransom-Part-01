namespace InstagramApiSharp.Classes.Models;

public class InstaPosition
{
	public double X { get; set; }

	public double Y { get; set; }

	public InstaPosition(double x, double y)
	{
		X = x;
		Y = y;
	}
}
