using System;
using System.Collections.Generic;
using Mysqlx.Crud;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns13;
using ns18;
using ns20;
using ns21;
using ns5;

namespace ns6;

internal sealed class Class64 : Class59<Class64, Class39, Class54>
{
	internal List<Class75> list_0;

	[NonSerialized]
	internal static GetString getString_0;

	internal Class64(Class39 class39_0, string string_0)
		: base(class39_0, string_0)
	{
		list_0 = new List<Class75>();
	}

	public Class64 method_9(string string_0, object object_0)
	{
		list_0.Add(new Class75(UpdateOperation.Class34.Enum20.const_3, string_0).method_2(object_0));
		return this;
	}

	public Class64 method_10(string string_0, object object_0)
	{
		list_0.Add(new Class75(UpdateOperation.Class34.Enum20.const_4, string_0).method_2(object_0));
		return this;
	}

	public Class64 method_11(string string_0)
	{
		list_0.Add(new Class75(UpdateOperation.Class34.Enum20.const_2, string_0));
		return this;
	}

	public Class64 method_12(object object_0)
	{
		if (object_0 == null)
		{
			throw new ArgumentNullException(getString_0(107407794));
		}
		if (object_0 is string && string.IsNullOrWhiteSpace((string)object_0))
		{
			throw new ArgumentNullException(getString_0(107407794), Class121.ParameterNullOrEmpty);
		}
		Class43 @class = ((object_0 is Class43) ? (object_0 as Class43) : new Class43(object_0));
		list_0.Add(new Class75(UpdateOperation.Class34.Enum20.const_8, string.Empty).method_2(@class.dictionary_0));
		return this;
	}

	public override Class54 vmethod_0()
	{
		return vmethod_1(base.Target.Session.XSession.method_26, this);
	}

	static Class64()
	{
		Strings.CreateGetStringDelegate(typeof(Class64));
	}
}
