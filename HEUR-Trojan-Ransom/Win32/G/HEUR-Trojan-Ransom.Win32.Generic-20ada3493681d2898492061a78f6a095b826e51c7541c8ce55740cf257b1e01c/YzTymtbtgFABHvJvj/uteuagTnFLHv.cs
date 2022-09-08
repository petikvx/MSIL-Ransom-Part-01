using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;

namespace YzTymtbtgFABHvJvj;

public sealed class uteuagTnFLHv
{
	private const int EWhCCXvKqwpLbYC = 20;

	private const int QMbXVzrgTThj = 1;

	private const int DacPGYPkRZYz = 2;

	private uteuagTnFLHv()
	{
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(int EwnAvKpiTdtdS, int ooEyCDsVyhcnufI, string IjPkoGdbVDCeI, int ltFlrvXSdgKxKw);

	public static void rXFpNnDuCzhwVPF(Uri SZdDGeTljKewfQt)
	{
		try
		{
			Stream stream = null;
			stream = new WebClient().OpenRead(SZdDGeTljKewfQt.ToString());
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
