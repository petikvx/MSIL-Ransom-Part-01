using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;

namespace ALzLGBAFaCqNDAE;

public sealed class IjCNGWkEdGsDqk
{
	private const int XBXpRnycbOuoC = 20;

	private const int bdAblPusDaBnM = 1;

	private const int OmODFpTwRuSJdQ = 2;

	private IjCNGWkEdGsDqk()
	{
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(int AiWQTCZEfc, int EkqKpPpPdOdmdl, string ObIjnzeAoaz, int DEEDFlVVOEiw);

	public static void HtoxKGsdNdZq(Uri WJHjSrGXLQvTr)
	{
		try
		{
			Stream stream = null;
			stream = new WebClient().OpenRead(WJHjSrGXLQvTr.ToString());
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
