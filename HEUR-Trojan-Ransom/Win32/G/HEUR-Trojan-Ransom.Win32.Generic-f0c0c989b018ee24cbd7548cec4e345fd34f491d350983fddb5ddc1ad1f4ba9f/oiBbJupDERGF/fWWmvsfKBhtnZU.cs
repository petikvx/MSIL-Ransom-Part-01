using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;

namespace oiBbJupDERGF;

public sealed class fWWmvsfKBhtnZU
{
	private const int gxwZPXvfccFcUUX = 20;

	private const int WJiXyyFoxGtQ = 1;

	private const int dbWnsRKxvSVdu = 2;

	private fWWmvsfKBhtnZU()
	{
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(int ocVeTdbLEewmX, int GYRpQLweMoMMD, string qEzqqmArCJ, int MmDGcHgsTz);

	public static void eQnCtCULhHGgmtl(Uri vcwxtmmJoVJHbJee)
	{
		try
		{
			Stream stream = null;
			stream = new WebClient().OpenRead(vcwxtmmJoVJHbJee.ToString());
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
