using System.Runtime.InteropServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using Photos.My;

namespace Photos;

public class Wallpaper
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

	[DllImport("user32")]
	public static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

	public void SetWallpaper(string path, Style selectedStyle)
	{
		RegistryKey registryKey = ((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().OpenSubKey("Control Panel\\Desktop", writable: true);
		switch (selectedStyle)
		{
		case Style.Stretched:
			registryKey.SetValue("WallpaperStyle", "2");
			registryKey.SetValue("TileWallpaper", "0");
			break;
		case Style.Centered:
			registryKey.SetValue("WallpaperStyle", "1");
			registryKey.SetValue("TileWallpaper", "0");
			break;
		case Style.Tiled:
			registryKey.SetValue("WallpaperStyle", "1");
			registryKey.SetValue("TileWallpaper", "1");
			break;
		}
		SystemParametersInfo(20, 0, path, 3);
	}
}
