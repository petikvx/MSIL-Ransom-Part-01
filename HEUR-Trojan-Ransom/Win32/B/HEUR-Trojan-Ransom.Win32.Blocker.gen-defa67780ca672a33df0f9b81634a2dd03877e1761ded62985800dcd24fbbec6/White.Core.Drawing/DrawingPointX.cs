using System.Drawing;
using System.Windows;

namespace White.Core.Drawing;

public static class DrawingPointX
{
	public static Point ConvertToWindowsPoint(this Point point)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		return new Point((double)point.X, (double)point.Y);
	}
}
