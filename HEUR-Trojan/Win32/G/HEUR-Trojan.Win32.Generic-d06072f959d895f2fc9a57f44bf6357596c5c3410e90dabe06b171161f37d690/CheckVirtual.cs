using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Windows.Forms;

public static class CheckVirtual
{
	public static bool IsRdpAvailable => SystemInformation.get_TerminalServerSession();

	public static bool SandBoxies
	{
		get
		{
			if (Process.GetProcessesByName("SbieCtrl").Length != 0)
			{
				return NativeMethods.GetModuleHandle("SbieDll.dll") != IntPtr.Zero;
			}
			return false;
		}
	}

	public static bool CheckWMI()
	{
		List<string> list = new List<string>
		{
			"virtual", "vmbox", "vmware", "virtualbox", "box", "thinapp", "VMXh", "innotek gmbh", "tpvcgateway", "tpautoconnsvc",
			"vbox", "kvm", "red hat"
		};
		using (List<string>.Enumerator enumerator = GetModelsAndManufactures().GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				string current = enumerator.Current;
				return list.Contains(current);
			}
		}
		return false;
	}

	private static List<string> GetModelsAndManufactures()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		List<string> list = new List<string>();
		try
		{
			ManagementObject val = (from p in ((IEnumerable)new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_ComputerSystem").Get()).OfType<ManagementObject>()
				where p != null
				select p).FirstOrDefault();
			list.Add(((ManagementBaseObject)val).get_Item("Manufacturer")?.ToString().ToLower());
			list.Add(((ManagementBaseObject)val).get_Item("Model")?.ToString().ToLower());
			return list;
		}
		catch
		{
			return list;
		}
	}

	public static bool Inizialize()
	{
		if (!SandBoxies && !IsRdpAvailable)
		{
			return CheckWMI();
		}
		return true;
	}
}
