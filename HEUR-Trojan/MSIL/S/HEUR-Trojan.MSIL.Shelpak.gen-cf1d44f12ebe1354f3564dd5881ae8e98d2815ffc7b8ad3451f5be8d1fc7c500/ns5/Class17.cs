using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using ns13;

namespace ns5;

internal sealed class Class17
{
	public static bool smethod_0(string string_0)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		try
		{
			Rectangle bounds = Screen.GetBounds(Point.Empty);
			Bitmap val = new Bitmap(bounds.Width, bounds.Height);
			try
			{
				Graphics val2 = Graphics.FromImage((Image)(object)val);
				try
				{
					val2.CopyFromScreen(Point.Empty, Point.Empty, bounds.Size);
				}
				finally
				{
					((IDisposable)val2)?.Dispose();
				}
				((Image)val).Save(string_0 + "\\WorldWind.jpg", ImageFormat.get_Jpeg());
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
			Class54.bool_5 = true;
			return true;
		}
		catch
		{
			return false;
		}
	}
}
