using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace PMpBbYpvEb;

public sealed class eNOZsuRDtvDVyd
{
	[NonSerialized]
	internal static GetString getString_0;

	private eNOZsuRDtvDVyd()
	{
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(int int_0, int int_1, string string_0, int int_2);

	public static void JrQaTHxbOuAqF(Uri uri_0)
	{
		try
		{
			Stream stream = null;
			stream = new WebClient().OpenRead(uri_0.ToString());
			Image val = Image.FromStream(stream);
			string text = Path.Combine(Path.GetTempPath(), getString_0(107412433));
			val.Save(text, ImageFormat.get_Bmp());
			SystemParametersInfo(20, 0, text, 3);
			Thread.Sleep(5000);
		}
		catch (Exception)
		{
		}
	}

	static eNOZsuRDtvDVyd()
	{
		Strings.CreateGetStringDelegate(typeof(eNOZsuRDtvDVyd));
	}
}
