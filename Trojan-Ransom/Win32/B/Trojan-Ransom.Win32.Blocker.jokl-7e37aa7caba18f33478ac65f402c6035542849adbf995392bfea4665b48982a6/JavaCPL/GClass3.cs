using System.Drawing;

namespace JavaCPL;

public class GClass3
{
	public Point[] point_0;

	public GClass3(Point[] point_1)
	{
		point_0 = point_1;
	}

	public GClass2.RECT method_0()
	{
		GClass2.RECT result = GClass2.smethod_2(0, 0, 0, 0);
		int num = point_0.Length;
		if (num < 1)
		{
			return result;
		}
		result = GClass2.smethod_2(point_0[0].X, point_0[0].Y, point_0[0].X, point_0[0].Y);
		for (int i = 1; i < num; i++)
		{
			if (point_0[i].X > result.right)
			{
				result.right = point_0[i].X;
			}
			else if (point_0[i].X < result.left)
			{
				result.left = point_0[i].X;
			}
			else if (point_0[i].Y > result.bottom)
			{
				result.bottom = point_0[i].Y;
			}
			else if (point_0[i].Y < result.top)
			{
				result.top = point_0[i].Y;
			}
		}
		return result;
	}

	public Point method_1()
	{
		GClass2.RECT rECT = method_0();
		int num = rECT.right - rECT.left;
		int num2 = rECT.bottom - rECT.top;
		if (num == 0)
		{
			return new Point(-1, -1);
		}
		return new Point(num, num2 * num2);
	}

	public double method_2()
	{
		Point point = method_1();
		if (point.X == -1)
		{
			return 0.0;
		}
		double num = (double)(point.X * point.Y) + 1E-18;
		return (double)point_0.Length / num;
	}

	public bool method_3(Point point_1)
	{
		Point[] array = point_0;
		int num = 0;
		while (true)
		{
			if (num < array.Length)
			{
				Point point = array[num];
				if (point.X == point_1.X && point.Y == point_1.Y)
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	public int method_4(bool bool_0)
	{
		GClass2.RECT rECT = method_0();
		int num = 0;
		if (bool_0)
		{
			for (int i = rECT.top; i < rECT.bottom; i++)
			{
				num = 0;
				for (int j = rECT.left; j < rECT.right; j++)
				{
					if (method_3(new Point(j, i)))
					{
						num++;
					}
				}
				if (num > 0)
				{
					return num;
				}
			}
		}
		else
		{
			int num2 = rECT.bottom;
			while (num2 > rECT.top)
			{
				num = 0;
				for (int k = rECT.left; k < rECT.right; k++)
				{
					if (method_3(new Point(k, num2)))
					{
						num++;
					}
				}
				if (num <= 0)
				{
					num2--;
					continue;
				}
				return num;
			}
		}
		return 0;
	}
}
