using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

internal sealed class Class80
{
	public static List<Struct4> smethod_0(string string_0)
	{
		List<Struct4> list = new List<Struct4>();
		try
		{
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
				string[] array2 = Regex.Split(text, Class85.string_0);
				foreach (string string_ in array2)
				{
					num++;
					Struct4 item = default(Struct4);
					if (Class85.smethod_1(string_))
					{
						item.String_1 = Class85.smethod_2(text, num);
						item.String_0 = Class85.smethod_2(text, num + 3);
						if (!string.IsNullOrEmpty(item.String_1) && !string.IsNullOrEmpty(item.String_0) && !item.String_0.Contains("Failed to parse url"))
						{
							Class36.int_5++;
							list.Add(item);
						}
					}
				}
			}
			return list;
		}
		catch
		{
			return list;
		}
	}
}
