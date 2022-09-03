using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace setup;

internal class WallpaperChanger
{
	private const int SPI_SETDESKWALLPAPER = 20;

	private const int SPIF_UPDATEINIFILE = 1;

	private const int SPIF_SENDWININICHANGE = 2;

	[DllImport("user32")]
	private static extern int SystemParametersInfo(int uAction, int uParam, [MarshalAs(UnmanagedType.LPStr)] string lpvParam, int fuWinIni);

	public static void SetWallpaper(string bitmapFile, WallpaperLocation style)
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", writable: true);
		if (registryKey != null)
		{
			if (style == WallpaperLocation.Stretch)
			{
				registryKey.SetValue("TileWallpaper", 0.ToString());
				registryKey.SetValue("Wallpaperstyle", 2.ToString());
			}
			else
			{
				registryKey.SetValue("TileWallpaper", style.ToString());
				registryKey.SetValue("Wallpaperstyle", 0.ToString());
			}
			registryKey.Close();
		}
		SystemParametersInfo(20, 0, bitmapFile, 3);
	}

	public static void RemoveWallpaper()
	{
		SystemParametersInfo(20, 0, "\0", 3);
	}
}
