using System;
using System.Diagnostics;
using System.Management;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class Misc
{
	public static double ConvertToEpoch(DateTime datetime)
	{
		DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0);
		return (datetime - dateTime).TotalSeconds;
	}

	public static void ExecuteCMDCommand(string command)
	{
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			ProcessStartInfo processStartInfo2 = processStartInfo;
			processStartInfo2.FileName = "cmd.exe";
			processStartInfo2.CreateNoWindow = true;
			processStartInfo2.ErrorDialog = false;
			processStartInfo2.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo2.Arguments = "/c" + command;
			processStartInfo2 = null;
			Process.Start(processStartInfo);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static string ExecuteWMIQuery(string wmiClass, string wmiValue = "Caption", string wmiQuery = "")
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		StringBuilder stringBuilder = new StringBuilder();
		try
		{
			object obj = null;
			ManagementObjectSearcher val = new ManagementObjectSearcher($"SELECT {wmiValue} FROM Win32_{wmiClass} {wmiQuery}");
			try
			{
				ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
				try
				{
					enumerator = val.Get().GetEnumerator();
					while (enumerator.MoveNext())
					{
						ManagementObject val2 = (ManagementObject)enumerator.get_Current();
						obj = RuntimeHelpers.GetObjectValue(((ManagementBaseObject)val2).get_Item(wmiValue));
						if (obj != null)
						{
							stringBuilder.Append(RuntimeHelpers.GetObjectValue(((ManagementBaseObject)val2).get_Item(wmiValue)));
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
				((IDisposable)val)?.Dispose();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return stringBuilder.ToString();
	}
}
