using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace coxZRmDhvSAWo;

public sealed class uhnJdcZsoCQU
{
	[NonSerialized]
	internal static GetString f000049;

	private uhnJdcZsoCQU()
	{
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(int p0, int p1, string p2, int p3);

	public static void LlIJhyFJOrlN(Uri p0)
	{
		try
		{
			Stream stream = null;
			stream = new WebClient().OpenRead(p0.ToString());
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

	static uhnJdcZsoCQU()
	{
		Strings.CreateGetStringDelegate(typeof(uhnJdcZsoCQU));
	}
}
