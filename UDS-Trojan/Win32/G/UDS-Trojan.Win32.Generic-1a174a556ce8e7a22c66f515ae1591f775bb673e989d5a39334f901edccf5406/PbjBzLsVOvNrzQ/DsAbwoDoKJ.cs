using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;

namespace PbjBzLsVOvNrzQ;

public sealed class DsAbwoDoKJ
{
	private const int uLoiTxAwJNGklSLZj = 20;

	private const int gsbTzwZFFUCZnRPW = 1;

	private const int iLffNodwdMwYv = 2;

	private DsAbwoDoKJ()
	{
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(int eEtVyiejvFHP, int CgSJzDhdJFzj, string kLymzVuJhnT, int WNVeoQnrxKyCXb);

	public static void LJDfYXoYMzx(Uri FfaaMGzpIiPTW)
	{
		try
		{
			Stream stream = null;
			stream = new WebClient().OpenRead(FfaaMGzpIiPTW.ToString());
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
