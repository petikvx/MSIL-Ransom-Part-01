using System;
using System.Collections.Generic;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Serialization;
using ns13;
using ns4;
using ns5;
using ns8;

namespace ns0;

internal static class Class49
{
	internal enum Enum23
	{
		const_0,
		const_1,
		const_2,
		const_3
	}

	[CompilerGenerated]
	private sealed class Class50
	{
		public Delegate1<object?, object?> delegate1_0;

		internal object? method_0(object? object_0)
		{
			return delegate1_0(null, object_0);
		}
	}

	internal static readonly Dictionary<Type, Enum21> dictionary_0 = new Dictionary<Type, Enum21>
	{
		{
			typeof(char),
			Enum21.const_2
		},
		{
			typeof(char?),
			Enum21.const_3
		},
		{
			typeof(bool),
			Enum21.const_4
		},
		{
			typeof(bool?),
			Enum21.const_5
		},
		{
			typeof(sbyte),
			Enum21.const_6
		},
		{
			typeof(sbyte?),
			Enum21.const_7
		},
		{
			typeof(short),
			Enum21.const_8
		},
		{
			typeof(short?),
			Enum21.const_9
		},
		{
			typeof(ushort),
			Enum21.const_10
		},
		{
			typeof(ushort?),
			Enum21.const_11
		},
		{
			typeof(int),
			Enum21.const_12
		},
		{
			typeof(int?),
			Enum21.const_13
		},
		{
			typeof(byte),
			Enum21.const_14
		},
		{
			typeof(byte?),
			Enum21.const_15
		},
		{
			typeof(uint),
			Enum21.const_16
		},
		{
			typeof(uint?),
			Enum21.const_17
		},
		{
			typeof(long),
			Enum21.const_18
		},
		{
			typeof(long?),
			Enum21.const_19
		},
		{
			typeof(ulong),
			Enum21.const_20
		},
		{
			typeof(ulong?),
			Enum21.const_21
		},
		{
			typeof(float),
			Enum21.const_22
		},
		{
			typeof(float?),
			Enum21.const_23
		},
		{
			typeof(double),
			Enum21.const_24
		},
		{
			typeof(double?),
			Enum21.const_25
		},
		{
			typeof(DateTime),
			Enum21.const_26
		},
		{
			typeof(DateTime?),
			Enum21.const_27
		},
		{
			typeof(DateTimeOffset),
			Enum21.const_28
		},
		{
			typeof(DateTimeOffset?),
			Enum21.const_29
		},
		{
			typeof(decimal),
			Enum21.const_30
		},
		{
			typeof(decimal?),
			Enum21.const_31
		},
		{
			typeof(Guid),
			Enum21.const_32
		},
		{
			typeof(Guid?),
			Enum21.const_33
		},
		{
			typeof(TimeSpan),
			Enum21.const_34
		},
		{
			typeof(TimeSpan?),
			Enum21.const_35
		},
		{
			typeof(BigInteger),
			Enum21.const_36
		},
		{
			typeof(BigInteger?),
			Enum21.const_37
		},
		{
			typeof(Uri),
			Enum21.const_38
		},
		{
			typeof(string),
			Enum21.const_39
		},
		{
			typeof(byte[]),
			Enum21.const_40
		},
		{
			typeof(DBNull),
			Enum21.const_41
		}
	};

	internal static readonly Class48[] class48_0 = new Class48[19]
	{
		new Class48(typeof(object), Enum21.const_0),
		new Class48(typeof(object), Enum21.const_1),
		new Class48(typeof(object), Enum21.const_41),
		new Class48(typeof(bool), Enum21.const_4),
		new Class48(typeof(char), Enum21.const_2),
		new Class48(typeof(sbyte), Enum21.const_6),
		new Class48(typeof(byte), Enum21.const_14),
		new Class48(typeof(short), Enum21.const_8),
		new Class48(typeof(ushort), Enum21.const_10),
		new Class48(typeof(int), Enum21.const_12),
		new Class48(typeof(uint), Enum21.const_16),
		new Class48(typeof(long), Enum21.const_18),
		new Class48(typeof(ulong), Enum21.const_20),
		new Class48(typeof(float), Enum21.const_22),
		new Class48(typeof(double), Enum21.const_24),
		new Class48(typeof(decimal), Enum21.const_30),
		new Class48(typeof(DateTime), Enum21.const_26),
		new Class48(typeof(object), Enum21.const_0),
		new Class48(typeof(string), Enum21.const_39)
	};

	internal static readonly Class111<Struct5<Type, Type>, Func<object?, object?>?> class111_0 = new Class111<Struct5<Type, Type>, Func<object, object>>(smethod_0);

	private static Func<object?, object?>? smethod_0(Struct5<Type, Type> struct5_0)
	{
		Type gparam_ = struct5_0.gparam_0;
		Type gparam_2 = struct5_0.gparam_1;
		MethodInfo methodInfo = gparam_2.GetMethod("op_Implicit", new Type[1] { gparam_ }) ?? gparam_2.GetMethod("op_Explicit", new Type[1] { gparam_ });
		if (methodInfo == null)
		{
			return null;
		}
		Delegate1<object?, object?> delegate1_0 = JsonTypeReflector.ReflectionDelegateFactory.vmethod_0<object>(methodInfo);
		return (object? object_0) => delegate1_0(null, object_0);
	}
}
