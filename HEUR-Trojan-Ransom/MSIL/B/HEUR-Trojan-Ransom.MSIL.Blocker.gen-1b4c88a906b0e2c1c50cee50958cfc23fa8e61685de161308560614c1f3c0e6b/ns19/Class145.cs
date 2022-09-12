using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ns10;
using ns12;
using ns4;
using ns9;

namespace ns19;

internal class Class145 : Class137
{
	[CompilerGenerated]
	private Enum21 enum21_0;

	private static readonly Dictionary<Type, Enum8> dictionary_0 = new Dictionary<Type, Enum8>
	{
		[typeof(byte[])] = Enum8.const_3,
		[typeof(byte)] = Enum8.const_1,
		[typeof(short)] = Enum8.const_1,
		[typeof(int)] = Enum8.const_1,
		[typeof(decimal)] = Enum8.const_5,
		[typeof(bool)] = Enum8.const_9,
		[typeof(string)] = Enum8.const_4,
		[typeof(DateTime)] = Enum8.const_6,
		[typeof(DateTimeOffset)] = Enum8.const_7,
		[typeof(float)] = Enum8.const_8,
		[typeof(double)] = Enum8.const_8,
		[typeof(long)] = Enum8.const_2
	};

	internal Enum21 TypeCode
	{
		[CompilerGenerated]
		get
		{
			return enum21_0;
		}
		[CompilerGenerated]
		set
		{
			enum21_0 = value;
		}
	}

	public Class145(Type type_3)
		: base(type_3)
	{
		enum26_0 = Enum26.const_3;
		TypeCode = Class7.smethod_524(type_3);
		bool_3 = true;
		if (dictionary_0.TryGetValue(type_0, out var value))
		{
			enum8_0 = value;
		}
	}
}
