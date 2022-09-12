using System;
using System.Management;
using System.Security.Cryptography;
using System.Text;

namespace ns0;

internal class Class3
{
	public static string smethod_0()
	{
		return smethod_1();
	}

	private static string smethod_1()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		string text = "";
		ManagementObjectSearcher val = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_OperatingSystem");
		ManagementObjectCollection val2 = val.Get();
		bool flag = !string.IsNullOrEmpty(Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432"));
		ManagementObjectEnumerator enumerator = val2.GetEnumerator();
		try
		{
			if (enumerator.MoveNext())
			{
				ManagementObject val3 = (ManagementObject)enumerator.get_Current();
				text = ((ManagementBaseObject)val3).get_Properties().get_Item("Caption").get_Value()
					.ToString() + Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432") + ((ManagementBaseObject)val3).get_Properties().get_Item("Version").get_Value()
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
		MD5 mD = MD5.Create();
		byte[] array = mD.ComputeHash(Encoding.Default.GetBytes(text));
		string text2 = BitConverter.ToString(array);
		return text2.Replace("-", "");
	}
}
