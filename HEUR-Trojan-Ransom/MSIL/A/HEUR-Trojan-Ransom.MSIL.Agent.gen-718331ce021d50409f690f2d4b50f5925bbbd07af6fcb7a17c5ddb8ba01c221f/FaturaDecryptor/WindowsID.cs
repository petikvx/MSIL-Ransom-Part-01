using System;
using System.Management;
using System.Security.Cryptography;
using System.Text;

namespace FaturaDecryptor;

internal class WindowsID
{
	public static string getWindowsID()
	{
		return WindowsId();
	}

	private static string WindowsId()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		string text = "";
		ManagementObjectCollection obj = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_OperatingSystem").Get();
		bool flag = !string.IsNullOrEmpty(Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432"));
		ManagementObjectEnumerator enumerator = obj.GetEnumerator();
		try
		{
			if (enumerator.MoveNext())
			{
				ManagementObject val = (ManagementObject)enumerator.get_Current();
				text = ((ManagementBaseObject)val).get_Properties().get_Item("Caption").get_Value()
					.ToString() + Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432") + ((ManagementBaseObject)val).get_Properties().get_Item("Version").get_Value()
					.ToString();
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		text.Replace(" ", "");
		text.Replace("Windows", "");
		text.Replace("windows", "");
		text += (flag ? ":64" : "=32");
		return BitConverter.ToString(MD5.Create().ComputeHash(Encoding.Default.GetBytes(text))).Replace("-", "");
	}
}
