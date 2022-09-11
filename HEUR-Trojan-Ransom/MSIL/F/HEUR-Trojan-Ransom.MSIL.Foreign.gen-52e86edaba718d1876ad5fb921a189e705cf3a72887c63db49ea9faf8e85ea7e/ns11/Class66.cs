using System.Collections.Generic;
using ns18;
using ns19;

namespace ns11;

internal sealed class Class66 : Class58<Class42, Class54>
{
	internal string[] string_0;

	internal List<object[]> list_0 = new List<object[]>();

	internal object[] object_0;

	internal Class66(Class42 class42_0, string[] string_1)
		: base(class42_0)
	{
		string_0 = string_1;
	}

	public override Class54 vmethod_0()
	{
		try
		{
			return base.Target.Session.XSession.method_30(this);
		}
		finally
		{
			list_0.Clear();
		}
	}

	public Class66 method_2(params object[] object_1)
	{
		list_0.Add(object_1);
		return this;
	}
}
