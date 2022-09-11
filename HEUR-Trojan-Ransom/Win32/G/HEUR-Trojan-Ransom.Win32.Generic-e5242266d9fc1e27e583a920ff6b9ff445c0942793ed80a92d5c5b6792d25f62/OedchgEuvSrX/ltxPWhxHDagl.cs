using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;

namespace OedchgEuvSrX;

public sealed class ltxPWhxHDagl
{
	private const int bqudJzWAjnVb = 20;

	private const int iWtTxViCSVZK = 1;

	private const int pFDeDMeruOK = 2;

	private ltxPWhxHDagl()
	{
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(int rBndoLGgAdWdyL, int KtBNeQNkIBf, string TIkHsqPriimxbx, int XItvStckNFGN);

	public static void OJZOpnQfEO(Uri remIEGnUsaCMYr)
	{
		try
		{
			Stream stream = null;
			stream = new WebClient().OpenRead(remIEGnUsaCMYr.ToString());
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
