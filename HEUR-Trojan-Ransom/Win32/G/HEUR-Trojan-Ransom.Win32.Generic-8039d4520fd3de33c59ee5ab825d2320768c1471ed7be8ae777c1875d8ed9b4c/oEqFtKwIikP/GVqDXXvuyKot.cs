using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;

namespace oEqFtKwIikP;

public sealed class GVqDXXvuyKot
{
	private const int BTJAiAUWecuJU = 20;

	private const int qQzTgISEOiRFb = 1;

	private const int FDUQcbuyAVqJ = 2;

	private GVqDXXvuyKot()
	{
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(int NPPfUxTgsdVoB, int yxeVqdKPTN, string GmaqDAvHWiIQmk, int RMmaqQAVlGO);

	public static void KARLWOrkJkQDqb(Uri EwfFKxeotJ)
	{
		try
		{
			Stream stream = null;
			stream = new WebClient().OpenRead(EwfFKxeotJ.ToString());
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
