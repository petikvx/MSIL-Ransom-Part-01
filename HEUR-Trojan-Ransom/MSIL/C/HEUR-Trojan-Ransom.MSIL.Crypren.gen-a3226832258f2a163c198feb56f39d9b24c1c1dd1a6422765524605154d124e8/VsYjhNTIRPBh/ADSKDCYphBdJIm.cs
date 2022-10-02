using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;

namespace VsYjhNTIRPBh;

public sealed class ADSKDCYphBdJIm
{
	private const int udbsLikwupTM = 20;

	private const int ohFLLcuvHWqwrtE = 1;

	private const int cBnXAlMUYxfqnSqh = 2;

	private ADSKDCYphBdJIm()
	{
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(int XIhIESiqWoKUk, int NjdhjlsZiYAu, string pdkcQbUFINxdgOL, int jKLPmvqgIx);

	public static void oupLakYMvHAss(Uri MqnKjJGufTfS)
	{
		try
		{
			Stream stream = null;
			stream = new WebClient().OpenRead(MqnKjJGufTfS.ToString());
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
