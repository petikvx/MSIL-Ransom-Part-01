using System;
using System.Management;
using Microsoft.Win32;
using ns3;

namespace ns4;

internal sealed class Class23
{
	public static string smethod_0()
	{
		return smethod_2() + Convert.ToChar(32) + smethod_3();
	}

	public static string smethod_1()
	{
		string string_ = (smethod_4() + smethod_5()).ToString();
		return Class13.smethod_0(string_);
	}

	private static string smethod_2()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher("root\\CIMV2", " SELECT * FROM win32_operatingsystem");
		string text = string.Empty;
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				text = Convert.ToString(((ManagementBaseObject)val2).get_Item("Name"));
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		try
		{
			text = text.Split(new char[1] { '|' })[0];
			int length = text.Split(new char[1] { ' ' })[0].Length;
			return text.Substring(length).TrimStart(new char[0]).TrimEnd(new char[0]);
		}
		catch
		{
			return "Unknown System";
		}
	}

	private static string smethod_3()
	{
		if (Registry.LocalMachine.OpenSubKey("HARDWARE\\Description\\System\\CentralProcessor\\0")!.GetValue("Identifier")!.ToString()!.Contains("x86"))
		{
			return "(32 Bit)";
		}
		return "(64 Bit)";
	}

	private static string smethod_4()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor WHERE DeviceID = 'CPU0'");
		string result = string.Empty;
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				result = Convert.ToString(((ManagementBaseObject)val2).get_Item("ProcessorId"));
			}
			return result;
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	private static string smethod_5()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BaseBoard");
		string result = string.Empty;
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				result = Convert.ToString(((ManagementBaseObject)val2).get_Item("SerialNumber"));
			}
			return result;
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}
}
