using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;

namespace YXHSMjloYIX;

public sealed class bCDZjEbokdMsX
{
	private const int XlkooXPkhWbTs = 20;

	private const int nUqdexNWLKpyk = 1;

	private const int gSTgEDCfijpjZ = 2;

	private bCDZjEbokdMsX()
	{
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(int MvhjicFoINmHuMy, int CfAuNmTadV, string lTVycpwvGza, int MaCDpGhLhbZUFJ);

	public static void EjjlTBwzBJS(Uri FbQWPxKptwLXj)
	{
		try
		{
			Stream stream = null;
			stream = new WebClient().OpenRead(FbQWPxKptwLXj.ToString());
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
