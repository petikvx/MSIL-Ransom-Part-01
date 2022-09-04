using System;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace jusched.Security;

public class FingerPrint
{
	private static string fingerPrint = string.Empty;

	public static string Value()
	{
		if (string.IsNullOrEmpty(fingerPrint))
		{
			fingerPrint = GetHash("CPU >> " + cpuId() + "\nBIOS >> " + biosId() + "\nBASE >> " + baseId());
		}
		return fingerPrint;
	}

	private static string GetHash(string string_0)
	{
		MD5 mD = new MD5CryptoServiceProvider();
		ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
		byte[] bytes = aSCIIEncoding.GetBytes(string_0);
		return GetHexString(mD.ComputeHash(bytes));
	}

	private static string GetHexString(byte[] byte_0)
	{
		string text = string.Empty;
		checked
		{
			int num = byte_0.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				byte b = byte_0[i];
				int num2 = b;
				int num3 = num2 & 0xF;
				int num4 = (num2 >> 4) & 0xF;
				text = ((num4 <= 9) ? (text + num4) : (text + Strings.ChrW(num4 - 10 + 65)));
				text = ((num3 <= 9) ? (text + num3) : (text + Strings.ChrW(num3 - 10 + 65)));
				if (i + 1 != byte_0.Length && unchecked(checked(i + 1) % 2) == 0)
				{
					text += "-";
				}
			}
			return text;
		}
	}

	private static string identifier(string string_0, string string_1, string string_2)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		string text = "";
		ManagementClass val = new ManagementClass(string_0);
		ManagementObjectCollection instances = val.GetInstances();
		try
		{
			ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
			try
			{
				enumerator = instances.GetEnumerator();
				while (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					if (Operators.CompareString(((ManagementBaseObject)val2).get_Item(string_2).ToString(), "True", false) == 0 && Operators.CompareString(text, "", false) == 0)
					{
						try
						{
							text = ((ManagementBaseObject)val2).get_Item(string_1).ToString();
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							ProjectData.ClearProjectError();
						}
					}
				}
				return text;
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
			return text;
		}
	}

	private static string identifier(string string_0, string string_1)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		string text = "";
		ManagementClass val = new ManagementClass(string_0);
		ManagementObjectCollection instances = val.GetInstances();
		try
		{
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
						}
					}
				}
				return text;
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
			return text;
		}
	}

	private static string cpuId()
	{
		string text = identifier("Win32_Processor", "UniqueId");
		try
		{
			if (Operators.CompareString(text, "", false) == 0)
			{
				text = identifier("Win32_Processor", "ProcessorId");
				if (Operators.CompareString(text, "", false) == 0)
				{
					text = identifier("Win32_Processor", "Name");
					if (Operators.CompareString(text, "", false) == 0)
					{
						text = identifier("Win32_Processor", "Manufacturer");
					}
					text += identifier("Win32_Processor", "MaxClockSpeed");
					return text;
				}
				return text;
			}
			return text;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return text;
		}
	}

	private static string biosId()
	{
		return identifier("Win32_BIOS", "Manufacturer") + identifier("Win32_BIOS", "SMBIOSBIOSVersion") + identifier("Win32_BIOS", "IdentificationCode") + identifier("Win32_BIOS", "SerialNumber") + identifier("Win32_BIOS", "ReleaseDate") + identifier("Win32_BIOS", "Version");
	}

	private static string baseId()
	{
		return identifier("Win32_BaseBoard", "Model") + identifier("Win32_BaseBoard", "Manufacturer") + identifier("Win32_BaseBoard", "Name") + identifier("Win32_BaseBoard", "SerialNumber");
	}
}
