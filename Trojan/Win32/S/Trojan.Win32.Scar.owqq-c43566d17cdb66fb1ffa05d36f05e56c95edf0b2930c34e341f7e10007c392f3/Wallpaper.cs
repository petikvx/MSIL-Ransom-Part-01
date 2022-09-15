using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using Microsoft.Win32;

public sealed class Wallpaper
{
	public enum Style
	{
		Tiled,
		Centered,
		Stretched
	}

	private const int SPI_SETDESKWALLPAPER = 20;

	private const int SPIF_UPDATEINIFILE = 1;

	private const int SPIF_SENDWININICHANGE = 2;

	private Wallpaper()
	{
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

	public static void Set(Uri uri, Style style)
	{
		Stream stream = new WebClient().OpenRead(uri.ToString());
		Image val = Image.FromStream(stream);
		string text = Path.Combine(Path.GetTempPath(), "wallpaper.bmp");
		val.Save(text, ImageFormat.get_Bmp());
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", writable: true);
		if (style == Style.Stretched)
		{
			registryKey.SetValue("WallpaperStyle", 2.ToString());
			registryKey.SetValue("TileWallpaper", 0.ToString());
		}
		if (style == Style.Centered)
		{
			registryKey.SetValue("WallpaperStyle", 1.ToString());
			registryKey.SetValue("TileWallpaper", 0.ToString());
		}
		if (style == Style.Tiled)
		{
			registryKey.SetValue("WallpaperStyle", 1.ToString());
			registryKey.SetValue("TileWallpaper", 1.ToString());
		}
		SystemParametersInfo(20, 0, text, 3);
	}
}
