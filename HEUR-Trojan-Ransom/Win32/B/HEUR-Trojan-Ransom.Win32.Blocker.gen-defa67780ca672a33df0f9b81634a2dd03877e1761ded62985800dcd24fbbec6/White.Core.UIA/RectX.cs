using System.Windows;

namespace White.Core.UIA;

public static class RectX
{
	public static readonly Point UnlikelyWindowPosition = new Point(-10000.0, -10000.0);

	public static bool IsZeroSize(this Rect rect)
	{
		if (((Rect)(ref rect)).get_Height() == 0.0)
		{
			return ((Rect)(ref rect)).get_Width() == 0.0;
		}
		return false;
	}

	public static Point Center(this Rect rect)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		double left = ((Rect)(ref rect)).get_Left();
		double right = ((Rect)(ref rect)).get_Right();
		return new Point((double)(int)(left + (right - left) / 2.0), (double)(int)(((Rect)(ref rect)).get_Top() + (((Rect)(ref rect)).get_Bottom() - ((Rect)(ref rect)).get_Top()) / 2.0));
	}

	public static Point East(this Rect rectangle, int by)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		double num = (int)(((Rect)(ref rectangle)).get_Right() + (double)by);
		Point val = rectangle.Center();
		return new Point(num, ((Point)(ref val)).get_Y());
	}

	public static Point ImmediateExteriorEast(this Rect rectangle)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		double num = (int)(((Rect)(ref rectangle)).get_Right() + 1.0);
		Point val = rectangle.Center();
		return new Point(num, ((Point)(ref val)).get_Y());
	}

	public static Point ImmediateInteriorEast(this Rect rectangle)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		double num = (int)(((Rect)(ref rectangle)).get_Right() - 1.0);
		Point val = rectangle.Center();
		return new Point(num, ((Point)(ref val)).get_Y());
	}

	public static Point ImmediateExteriorWest(this Rect rectangle)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		double num = (int)(((Rect)(ref rectangle)).get_Left() - 1.0);
		Point val = rectangle.Center();
		return new Point(num, ((Point)(ref val)).get_Y());
	}

	public static Point ImmediateInteriorNorth(this Rect rectangle)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		Point val = rectangle.Center();
		return new Point(((Point)(ref val)).get_X(), ((Rect)(ref rectangle)).get_Top() + 1.0);
	}

	public static Point ImmediateInteriorSouth(this Rect rectangle)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		Point val = rectangle.Center();
		return new Point(((Point)(ref val)).get_X(), ((Rect)(ref rectangle)).get_Bottom() - 1.0);
	}
}
