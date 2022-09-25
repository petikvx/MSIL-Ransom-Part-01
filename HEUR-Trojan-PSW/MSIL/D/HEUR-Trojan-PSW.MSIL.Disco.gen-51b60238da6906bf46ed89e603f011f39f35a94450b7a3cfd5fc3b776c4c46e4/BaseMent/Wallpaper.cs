using System;
using System.Drawing;
using System.Runtime.InteropServices;
using BaseMent.Properties;

namespace BaseMent;

internal class Wallpaper
{
	private static uint SPI_SETWALL = 20u;

	private static uint SPIF_UPDATE = 1u;

	private static uint SPIF_SWEDWINI = 2u;

	private static string fileName;

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern int SystemParametersInfo(uint uAction, int uParam, string lpvParam, uint fuWinIni);

	public static void ChangeWallpaper()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		fileName = folderPath + "\\wallpaper.png";
		((Image)Resources.wl).Save(fileName);
		SystemParametersInfo(SPI_SETWALL, 0, fileName, SPIF_UPDATE | SPIF_SWEDWINI);
	}
}
