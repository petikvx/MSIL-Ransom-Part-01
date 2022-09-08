using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using Orcus.Shared.Commands.FunActions;

namespace Orcus.Commands.FunActions;

internal class DesktopWallpaper
{
	private const int SPI_SETDESKWALLPAPER = 20;

	private const int SPIF_UPDATEINIFILE = 1;

	private const int SPIF_SENDWININICHANGE = 2;

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

	public static void Set(string url, DesktopWallpaperStyle style)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Invalid comparison between Unknown and I4
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Invalid comparison between Unknown and I4
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		Image obj = Image.FromStream(new WebClient().OpenRead(url));
		string text = Path.Combine(Path.GetTempPath(), "wallpaper.bmp");
		obj.Save(text, ImageFormat.get_Bmp());
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", writable: true);
		if ((int)style == 2)
		{
			registryKey.SetValue("WallpaperStyle", 2.ToString());
			registryKey.SetValue("TileWallpaper", 0.ToString());
		}
		if ((int)style == 1)
		{
			registryKey.SetValue("WallpaperStyle", 1.ToString());
			registryKey.SetValue("TileWallpaper", 0.ToString());
		}
		if ((int)style == 0)
		{
			registryKey.SetValue("WallpaperStyle", 1.ToString());
			registryKey.SetValue("TileWallpaper", 1.ToString());
		}
		SystemParametersInfo(20, 0, text, 3);
	}
}
