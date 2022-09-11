using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;

namespace JcxFVLIspytryi;

public sealed class hXWdgqexDRLIc
{
	private const int QrozAcjCIapB = 20;

	private const int IUdsnNsTsmwr = 1;

	private const int YPVVinIOdZriDp = 2;

	private hXWdgqexDRLIc()
	{
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(int qKyDGFKXHlNO, int vtOyhiTBBlch, string rTnvsZBHPrWFZ, int jcnlMAdnsd);

	public static void ESdkRDxtbOmiAe(Uri EIzBRPFlzTEOvDDc)
	{
		try
		{
			Stream stream = null;
			stream = new WebClient().OpenRead(EIzBRPFlzTEOvDDc.ToString());
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
