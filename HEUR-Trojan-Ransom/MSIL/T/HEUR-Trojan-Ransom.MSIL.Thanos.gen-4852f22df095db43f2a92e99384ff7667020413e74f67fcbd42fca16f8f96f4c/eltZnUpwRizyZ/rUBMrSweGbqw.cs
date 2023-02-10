using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace eltZnUpwRizyZ;

public sealed class rUBMrSweGbqw
{
	[NonSerialized]
	internal static GetString _0008;

	private rUBMrSweGbqw()
	{
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "SystemParametersInfo")]
	private static extern int KndhztRbwlHGc(int P_0, int P_1, string P_2, int P_3);

	public static void gCojoUEPTW(Uri P_0)
	{
		try
		{
			Stream stream = null;
			if (stream == null)
			{
				stream = new WebClient().OpenRead(P_0.ToString());
			}
			Image val = Image.FromStream(stream);
			string text = Path.Combine(Path.GetTempPath(), _0008(107402022));
			val.Save(text, ImageFormat.get_Bmp());
			KndhztRbwlHGc(20, 0, text, 3);
			Thread.Sleep(5000);
		}
		catch (Exception)
		{
		}
	}

	static rUBMrSweGbqw()
	{
		Strings.CreateGetStringDelegate(typeof(rUBMrSweGbqw));
	}
}
