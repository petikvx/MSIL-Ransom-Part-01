using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace Ransimware;

public class Wallpaper
{
	public enum Style
	{
		Tiled,
		Centered,
		Stretched
	}

	public static readonly uint SPI_SETDESKWALLPAPER = 20u;

	public static readonly uint SPIF_UPDATEINIFILE = 1u;

	public static readonly uint SPIF_SENDWININICHANGE = 2u;

	public bool ReturnTrue()
	{
		return true;
	}

	[DllImport("user32.dll")]
	public static extern int SystemParametersInfo(uint action, uint uParam, string vParam, uint winIni);

	public static bool SetWallpaper(string filePath, Style style)
	{
		bool result = false;
		try
		{
			SetImage(Image.FromFile(Path.GetFullPath(filePath)), style);
			result = true;
			return result;
		}
		catch
		{
			return result;
		}
	}

	private static bool SetImage(Image image, Style style)
	{
		bool result = false;
		try
		{
			string text = Path.Combine(Path.GetTempPath(), "wallpaper.bmp");
			image.Save(text, ImageFormat.get_Bmp());
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", writable: true);
			switch (style)
			{
			default:
				registryKey.SetValue("WallpaperStyle", 1.ToString());
				registryKey.SetValue("TileWallpaper", 1.ToString());
				break;
			case Style.Centered:
				registryKey.SetValue("WallpaperStyle", 1.ToString());
				registryKey.SetValue("TileWallpaper", 0.ToString());
				break;
			case Style.Stretched:
				registryKey.SetValue("WallpaperStyle", 2.ToString());
				registryKey.SetValue("TileWallpaper", 0.ToString());
				break;
			}
			SystemParametersInfo(SPI_SETDESKWALLPAPER, 0u, text, SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
			result = true;
			return result;
		}
		catch
		{
			Console.WriteLine("Failed to set image background");
			return result;
		}
	}
}
