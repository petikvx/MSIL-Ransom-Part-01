using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace dopr;

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

	public static void Set(string path)
	{
		RegistryKey? registryKey = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", writable: true);
		registryKey!.SetValue("WallpaperStyle", 1.ToString());
		registryKey!.SetValue("TileWallpaper", 0.ToString());
		SystemParametersInfo(20, 0, path, 3);
	}
}
