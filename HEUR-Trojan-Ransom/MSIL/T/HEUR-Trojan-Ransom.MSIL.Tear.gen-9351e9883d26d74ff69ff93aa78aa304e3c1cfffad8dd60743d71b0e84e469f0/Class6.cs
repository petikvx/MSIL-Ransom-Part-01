using System;
using System.Management;
using System.Security.Cryptography;
using System.Text;

internal class Class6
{
	public static string smethod_0()
	{
		return smethod_1();
	}

	private static string smethod_1()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		string text = "";
		ManagementObjectEnumerator enumerator = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_OperatingSystem").Get().GetEnumerator();
		try
		{
			if (enumerator.MoveNext())
			{
				ManagementObject val = (ManagementObject)enumerator.get_Current();
				text = ((ManagementBaseObject)val).get_Properties().get_Item("Caption").get_Value()?.ToString() + Environment.UserName + (string)((ManagementBaseObject)val).get_Properties().get_Item("Version").get_Value();
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		text.Replace(" ", "");
		text.Replace("Windows", "");
		text.Replace("windows", "");
		return BitConverter.ToString(MD5.Create().ComputeHash(Encoding.Default.GetBytes(text))).Replace("-", "");
	}

	public Class6()
	{
		Class9.T7DkdFQzGSTU8();
		base._002Ector();
	}
}
