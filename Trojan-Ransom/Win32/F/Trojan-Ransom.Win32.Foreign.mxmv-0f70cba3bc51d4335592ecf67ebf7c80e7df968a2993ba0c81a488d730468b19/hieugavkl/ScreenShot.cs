using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace hieugavkl;

internal class ScreenShot
{
	public static void CaptureImage(Point SourcePoint, Point DestinationPoint, Rectangle SelectionRectangle, string FilePath)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		try
		{
			Bitmap val = new Bitmap(SelectionRectangle.Width, SelectionRectangle.Height);
			try
			{
				Graphics val2 = Graphics.FromImage((Image)(object)val);
				try
				{
					val2.CopyFromScreen(SourcePoint, DestinationPoint, SelectionRectangle.Size);
				}
				finally
				{
					((IDisposable)val2)?.Dispose();
				}
				((Image)val).Save(FilePath, ImageFormat.get_Png());
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch
		{
		}
	}
}
