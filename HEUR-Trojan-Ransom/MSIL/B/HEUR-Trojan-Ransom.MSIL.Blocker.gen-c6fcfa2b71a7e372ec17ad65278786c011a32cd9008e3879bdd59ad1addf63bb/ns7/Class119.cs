using System;
using System.Collections.Generic;
using Newtonsoft.Json.Serialization;
using ns0;
using ns13;
using ns5;

namespace ns7;

internal class Class119 : DefaultContractResolver
{
	private static readonly object object_0 = new object();

	private static readonly Class6 class6_1 = new Class6();

	private static Dictionary<Struct5<Type, Type>, Class137>? dictionary_0;

	public Class119()
	{
		base.NamingStrategy = new Class115
		{
			ProcessDictionaryKeys = true,
			OverrideSpecifiedNames = true
		};
	}

	public override Class137 imethod_0(Type type_0)
	{
		if (type_0 == null)
		{
			throw new ArgumentNullException("type");
		}
		Struct5<Type, Type> key = new Struct5<Type, Type>(GetType(), type_0);
		Dictionary<Struct5<Type, Type>, Class137> dictionary = dictionary_0;
		if (dictionary == null || !dictionary.TryGetValue(key, out var value))
		{
			value = vmethod_12(type_0);
			lock (object_0)
			{
				dictionary = dictionary_0;
				Dictionary<Struct5<Type, Type>, Class137> obj = ((dictionary != null) ? new Dictionary<Struct5<Type, Type>, Class137>(dictionary) : new Dictionary<Struct5<Type, Type>, Class137>());
				obj[key] = value;
				dictionary_0 = obj;
				return value;
			}
		}
		return value;
	}

	internal override Class6 vmethod_14()
	{
		return class6_1;
	}
}
