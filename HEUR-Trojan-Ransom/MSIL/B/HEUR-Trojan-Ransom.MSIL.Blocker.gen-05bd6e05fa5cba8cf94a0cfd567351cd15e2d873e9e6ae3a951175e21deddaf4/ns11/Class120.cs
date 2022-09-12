using System;
using System.Collections.Generic;
using Newtonsoft.Json.Serialization;
using ns0;
using ns2;
using ns7;
using ns9;

namespace ns11;

internal class Class120 : DefaultContractResolver
{
	private static readonly object object_0 = new object();

	private static readonly Class7 class7_1 = new Class7();

	private static Dictionary<Struct5<Type, Type>, Class137>? dictionary_0;

	public Class120()
	{
		base.NamingStrategy = new Class116
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

	internal override Class7 vmethod_14()
	{
		return class7_1;
	}
}
