using System;

namespace TreehouseDefense;

internal class Point
{
	public readonly int X;

	public readonly int Y;

	public Point(int x, int y)
	{
		X = x;
		Y = y;
	}

	public override string ToString()
	{
		int x = X;
		string text = x.ToString();
		x = Y;
		return text + "," + x;
	}

	public override bool Equals(object obj)
	{
		if (!(obj is Point))
		{
			return false;
		}
		Point point = obj as Point;
		return X == point.X && Y == point.Y;
	}

	public override int GetHashCode()
	{
		int x = X;
		int num = x.GetHashCode() * 31;
		x = Y;
		return num + x.GetHashCode();
	}

	public int DistanceTo(int x, int y)
	{
		return (int)Math.Sqrt(Math.Pow(X - x, 2.0) + Math.Pow(Y - y, 2.0));
	}

	public int DistanceTo(Point point)
	{
		return DistanceTo(point.X, point.Y);
	}
}
