using System;
using System.Diagnostics;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace jusched.Security;

public class FingerPrint
{
	private static string fingerPrint = string.Empty;

	[DebuggerNonUserCode]
	public FingerPrint()
	{
	}

	public static string Value()
	{
		if (string.IsNullOrEmpty(fingerPrint))
		{
			fingerPrint = GetHash("CPU >> " + cpuId() + "\nBIOS >> " + biosId() + "\nBASE >> " + baseId());
		}
		return fingerPrint;
	}

	private static string GetHash(string s)
	{
		MD5 mD = new MD5CryptoServiceProvider();
		ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
		byte[] bytes = aSCIIEncoding.GetBytes(s);
		return GetHexString(mD.ComputeHash(bytes));
	}

	private static string GetHexString(byte[] bt)
	{
		string text = string.Empty;
		checked
		{
			int num = bt.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				byte b = bt[num2];
				int num5 = b;
				int num6 = num5 & 0xF;
				int num7 = (num5 >> 4) & 0xF;
				text = ((num7 <= 9) ? (text + num7) : (text + Strings.ChrW(num7 - 10 + 65)));
				text = ((num6 <= 9) ? (text + num6) : (text + Strings.ChrW(num6 - 10 + 65)));
				if ((num2 + 1 != bt.Length && unchecked(checked(num2 + 1) % 2) == 0) ? true : false)
				{
					text += "-";
				}
				num2++;
			}
			return text;
		}
	}

	private static string identifier(string wmiClass, string wmiProperty, string wmiMustBeTrue)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		string text = "";
		ManagementClass val = new ManagementClass(wmiClass);
		ManagementObjectCollection instances = val.GetInstances();
		ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
		try
		{
			enumerator = instances.GetEnumerator();
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				if (Operators.CompareString(((ManagementBaseObject)val2).get_Item(wmiMustBeTrue).ToString(), "True", false) == 0 && Operators.CompareString(text, "", false) == 0)
				{
					try
					{
						text = ((ManagementBaseObject)val2).get_Item(wmiProperty).ToString();
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		return text;
	}

	private static string identifier(string wmiClass, string wmiProperty)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		string text = "";
		ManagementClass val = new ManagementClass(wmiClass);
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
						text = ((ManagementBaseObject)val2).get_Item(wmiProperty).ToString();
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		return text;
	}

	private static string cpuId()
	{
		string text = identifier("Win32_Processor", "UniqueId");
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
			}
		}
		return text;
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
