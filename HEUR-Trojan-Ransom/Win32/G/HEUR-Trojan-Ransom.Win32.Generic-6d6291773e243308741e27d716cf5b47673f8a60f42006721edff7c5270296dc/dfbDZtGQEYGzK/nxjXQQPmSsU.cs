using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;

namespace dfbDZtGQEYGzK;

public sealed class nxjXQQPmSsU
{
	private const int NlKbGJprtbys = 20;

	private const int duGqJXCOShPbvvx = 1;

	private const int ORftArnNgZcl = 2;

	private nxjXQQPmSsU()
	{
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(int bCdpwCYWlLpeWZZCy, int UjGiLmmvyFElm, string VJsFCmEXwlCdu, int ttFSXWkiUDyWv);

	public static void hXZUMoWJiF(Uri FYxjlvOSwxt)
	{
		try
		{
			Stream stream = null;
			stream = new WebClient().OpenRead(FYxjlvOSwxt.ToString());
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
