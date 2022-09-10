using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace ConsoleApp2;

internal class CenterScreen
{
	public enum UAction
	{
		SPI_SETDESKWALLPAPER = 20,
		SPI_GETDESKWALLPAPER = 115
	}

	[DllImport("user32.dll")]
	public static extern int SystemParametersInfo(UAction uAction, int uParam, StringBuilder lpvParam, int fuWinIni);

	public static string GetBackgroud()
	{
		StringBuilder stringBuilder = new StringBuilder(300);
		SystemParametersInfo(UAction.SPI_GETDESKWALLPAPER, 300, stringBuilder, 0);
		return stringBuilder.ToString();
	}

	public static int SetBackgroud(string fileName)
	{
		int result = 0;
		if (File.Exists(fileName))
		{
			StringBuilder lpvParam = new StringBuilder(fileName);
			result = SystemParametersInfo(UAction.SPI_SETDESKWALLPAPER, 0, lpvParam, 2);
		}
		return result;
	}
}
