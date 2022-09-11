using System.Collections.Generic;
using Mysqlx.Crud;
using ns18;
using ns6;

namespace ns5;

internal sealed class Class62 : Class59<Class62, Class42, Class54>
{
	internal List<Class75> list_0 = new List<Class75>();

	internal Class62(Class42 class42_0)
		: base(class42_0, (string)null)
	{
		base.FilterData.bool_0 = true;
		base.FilterData.dictionary_0 = new Dictionary<string, object>();
	}

	public override Class54 vmethod_0()
	{
		return vmethod_1(base.Target.Session.XSession.method_27, this);
	}

	public Class62 method_9(string string_0, object object_0)
	{
		list_0.Add(new Class75(UpdateOperation.Class34.Enum20.const_1, string_0).method_2(object_0));
		return this;
	}
}
