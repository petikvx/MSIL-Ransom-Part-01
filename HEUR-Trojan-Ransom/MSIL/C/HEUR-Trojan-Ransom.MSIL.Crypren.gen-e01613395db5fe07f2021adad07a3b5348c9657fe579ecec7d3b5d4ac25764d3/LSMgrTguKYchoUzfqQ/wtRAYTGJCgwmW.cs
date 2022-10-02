using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;

namespace LSMgrTguKYchoUzfqQ;

public sealed class wtRAYTGJCgwmW
{
	private const int AufNcuxnDi = 20;

	private const int dmtAIddKeUrR = 1;

	private const int FZmEIzeEiIM = 2;

	private wtRAYTGJCgwmW()
	{
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(int MhyATOWPqwyN, int KLcKSYqDsje, string MJVSWRqlzah, int qhXIntjNZg);

	public static void bSLBLlKmJHr(Uri VecjwrRVAPxNFf)
	{
		try
		{
			Stream stream = null;
			stream = new WebClient().OpenRead(VecjwrRVAPxNFf.ToString());
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
