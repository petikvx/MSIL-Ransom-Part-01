using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;

namespace vQzMGKHeycFziMq;

public sealed class VpeKMCeorSCh
{
	private const int UlrfPwkMRZxa = 20;

	private const int FKvEDqoqgbFDE = 1;

	private const int XTOOuUDAVgAA = 2;

	private VpeKMCeorSCh()
	{
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(int myfTZTZEHMTMJ, int zxXlFmYUVVAKJ, string IehtxKuRpjBT, int ZXxhdkSJxs);

	public static void JiIQNRoOuMrH(Uri nmEzXIRVAeFG)
	{
		try
		{
			Stream stream = null;
			stream = new WebClient().OpenRead(nmEzXIRVAeFG.ToString());
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
