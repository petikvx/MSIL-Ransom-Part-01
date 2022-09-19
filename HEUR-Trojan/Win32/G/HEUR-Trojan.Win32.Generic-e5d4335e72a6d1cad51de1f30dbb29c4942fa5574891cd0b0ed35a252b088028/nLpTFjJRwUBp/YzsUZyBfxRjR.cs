using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;

namespace nLpTFjJRwUBp;

public sealed class YzsUZyBfxRjR
{
	private const int ZlHBMQgubXTbnh = 20;

	private const int wgBMhFDhYHygTr = 1;

	private const int SymznmqBZaNqqmQ = 2;

	private YzsUZyBfxRjR()
	{
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(int YGZqooTEMkQjL, int KSrYsLBLGgA, string HIlNzKdWoNi, int zOERrmDyBJw);

	public static void YfuSsQsOVdlQI(Uri qjcPdQuugoTKOl)
	{
		try
		{
			Stream stream = null;
			stream = new WebClient().OpenRead(qjcPdQuugoTKOl.ToString());
			Image val = Image.FromStream(stream);
			string text = Path.Combine(Path.GetTempPath(), "wallpaper.bmp");
			val.Save(text, ImageFormat.get_Bmp());
			SystemParametersInfo(20, 0, text, 3);
			Thread.Sleep(5000);
		}
		catch (Exception)
		{
		}
	}
}
