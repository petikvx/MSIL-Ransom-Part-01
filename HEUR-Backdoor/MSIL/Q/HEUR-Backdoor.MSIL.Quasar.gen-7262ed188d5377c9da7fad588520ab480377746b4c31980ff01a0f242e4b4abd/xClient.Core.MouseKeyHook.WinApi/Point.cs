namespace xClient.Core.MouseKeyHook.WinApi;

internal struct Point
{
	public int X;

	public int Y;

	public Point(int x, int y)
	{
		X = x;
		Y = y;
	}

	public static bool operator ==(Point a, Point b)
	{
		if (a.X == b.X)
		{
			return a.Y == b.Y;
		}
		return false;
	}

	public static bool operator !=(Point a, Point b)
	{
		return !(a == b);
	}

	public bool Equals(Point other)
	{
		if (other.X == X)
		{
			return other.Y == Y;
		}
		return false;
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			return false;
		}
		if (obj.GetType() != typeof(Point))
		{
			return false;
		}
		return Equals((Point)obj);
	}

	public override int GetHashCode()
	{
		return (X * 397) ^ Y;
	}
}
