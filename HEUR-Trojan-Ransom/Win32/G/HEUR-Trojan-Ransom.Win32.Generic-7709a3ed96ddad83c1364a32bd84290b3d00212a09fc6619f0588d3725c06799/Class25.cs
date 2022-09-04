using System;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;

internal sealed class Class25
{
	[DllImport("kernel32.dll")]
	private static extern int GetLocaleInfo(uint uint_0, uint uint_1, [Out] StringBuilder stringBuilder_0, int int_0);

	public static string smethod_0()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		try
		{
			ManagementObjectSearcher val = new ManagementObjectSearcher("SELECT * FROM  Win32_OperatingSystem");
			string text = string.Empty;
			ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					object propertyValue = ((ManagementBaseObject)val2).GetPropertyValue("Caption");
					if (propertyValue != null)
					{
						text = Regex.Replace(propertyValue.ToString(), "[^A-Za-z0-9 ]", string.Empty);
						if (text.StartsWith("Microsoft"))
						{
							text = text.Substring(9);
							text = text.Replace("dows ", string.Empty);
							text = text.Split(new char[1] { ' ' })[1];
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
		catch
		{
			return "Err";
		}
	}

	public static string smethod_1()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher("SELECT * FROM  Win32_OperatingSystem");
		string text = string.Empty;
		int num = 0;
		try
		{
			ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					object propertyValue = ((ManagementBaseObject)val2).GetPropertyValue("Caption");
					if (propertyValue == null)
					{
						continue;
					}
					string text2 = Regex.Replace(propertyValue.ToString(), "[^A-Za-z0-9 ]", string.Empty);
					if (text2.StartsWith("Microsoft"))
					{
						text2 = text2.Substring(9);
					}
					text = text2.Trim();
					if (!string.IsNullOrEmpty(text))
					{
						object obj = null;
						try
						{
							obj = ((ManagementBaseObject)val2).GetPropertyValue("ServicePackMajorVersion");
							if (obj != null && obj.ToString() != "0")
							{
								text = text + " Service Pack " + obj.ToString();
							}
						}
						catch (Exception)
						{
						}
					}
					object obj2 = null;
					try
					{
						obj2 = ((ManagementBaseObject)val2).GetPropertyValue("OSArchitecture");
						if (obj2 != null)
						{
							string text3 = obj2.ToString();
							num = (text3.Contains("64") ? 64 : 86);
						}
					}
					catch (Exception)
					{
					}
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
		}
		catch (Exception)
		{
		}
		if (text == string.Empty)
		{
			text = "Error";
		}
		if (num != 0)
		{
		}
		return text + " x" + num;
	}

	public static string smethod_2()
	{
		StringBuilder stringBuilder = new StringBuilder(256);
		int localeInfo = GetLocaleInfo(1024u, 7u, stringBuilder, stringBuilder.Capacity);
		if (localeInfo > 0)
		{
			return stringBuilder.ToString().Substring(0, localeInfo - 1);
		}
		return string.Empty;
	}

	public static string smethod_3()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher("SELECT * FROM Win32_DisplayConfiguration");
		string result = string.Empty;
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				PropertyDataEnumerator enumerator2 = ((ManagementBaseObject)val2).get_Properties().GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						PropertyData current = enumerator2.get_Current();
						if (current.get_Name() == "Description")
						{
							result = current.get_Value().ToString();
						}
					}
				}
				finally
				{
					if (enumerator2 is IDisposable disposable)
					{
						disposable.Dispose();
					}
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		return result;
	}
}
