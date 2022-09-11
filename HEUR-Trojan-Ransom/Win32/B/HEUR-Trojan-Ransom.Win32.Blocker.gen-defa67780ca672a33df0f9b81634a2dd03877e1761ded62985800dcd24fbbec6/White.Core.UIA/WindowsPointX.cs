using System.Drawing;
using System.Windows;
using White.Core.SystemExtensions;

namespace White.Core.UIA;

public static class WindowsPointX
{
	public static Point ToDrawingPoint(this Point point)
	{
		return new Point((int)((Point)(ref point)).get_X(), (int)((Point)(ref point)).get_Y());
	}

	public static bool IsInvalid(this Point point)
	{
		if (!((Point)(ref point)).get_X().IsInvalid())
		{
			return ((Point)(ref point)).get_Y().IsInvalid();
		}
		return true;
	}
}
