using System.Drawing;
using System.Windows;

namespace com.poweriwb.PowerDesk;

public static class PointUtil
{
	public static PointF ToDrawingPointF(this Point p)
	{
		return new PointF((float)((Point)(ref p)).get_X(), (float)((Point)(ref p)).get_Y());
	}

	public static Point ToDrawingPointF(this PointF p)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		return new Point((double)p.X, (double)p.Y);
	}

	public static string SafeSubstring(this string text, int start, int length)
	{
		if (text == null)
		{
			return "";
		}
		return (text.Length <= start) ? "" : ((text.Length - start <= length) ? text.Substring(start) : text.Substring(start, length));
	}
}
