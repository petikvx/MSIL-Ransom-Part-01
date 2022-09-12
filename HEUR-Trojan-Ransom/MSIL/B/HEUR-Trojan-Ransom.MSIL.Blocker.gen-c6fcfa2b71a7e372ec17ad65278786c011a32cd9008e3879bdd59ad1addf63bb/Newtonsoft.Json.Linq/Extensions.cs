using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ns1;
using ns13;
using ns15;
using ns19;
using ns3;
using ns8;

namespace Newtonsoft.Json.Linq;

public static class Extensions
{
	public static Interface10<JToken> smethod_0<T>(this IEnumerable<T> ienumerable_0) where T : JToken
	{
		Class112.smethod_0(ienumerable_0, "source");
		return ienumerable_0.SelectMany((T gparam_0) => Class131.smethod_525((JToken)gparam_0)).smethod_16();
	}

	public static Interface10<JToken> smethod_1<T>(this IEnumerable<T> ienumerable_0) where T : JToken
	{
		Class112.smethod_0(ienumerable_0, "source");
		return ienumerable_0.SelectMany((T gparam_0) => Class131.smethod_268((JToken)gparam_0)).smethod_16();
	}

	public static Interface10<JToken> smethod_2<T>(this IEnumerable<T> ienumerable_0) where T : Class176
	{
		Class112.smethod_0(ienumerable_0, "source");
		return ienumerable_0.SelectMany((T gparam_0) => Class131.smethod_189((Class176)gparam_0)).smethod_16();
	}

	public static Interface10<JToken> smethod_3<T>(this IEnumerable<T> ienumerable_0) where T : Class176
	{
		Class112.smethod_0(ienumerable_0, "source");
		return ienumerable_0.SelectMany((T gparam_0) => Class131.smethod_378((Class176)gparam_0)).smethod_16();
	}

	public static Interface10<JProperty> smethod_4(this IEnumerable<JObject> ienumerable_0)
	{
		Class112.smethod_0(ienumerable_0, "source");
		return ienumerable_0.SelectMany((JObject jobject_0) => Class131.smethod_727(jobject_0)).smethod_17();
	}

	public static Interface10<JToken> smethod_5(this IEnumerable<JToken> ienumerable_0, object? object_0)
	{
		return ienumerable_0.smethod_11<JToken, JToken>(object_0).smethod_16();
	}

	public static Interface10<JToken> smethod_6(this IEnumerable<JToken> ienumerable_0)
	{
		return ienumerable_0.smethod_5(null);
	}

	public static IEnumerable<T?> smethod_7<T>(this IEnumerable<JToken> ienumerable_0, object object_0)
	{
		return ienumerable_0.smethod_11<JToken, T>(object_0);
	}

	public static IEnumerable<T?> smethod_8<T>(this IEnumerable<JToken> ienumerable_0)
	{
		return ienumerable_0.smethod_11<JToken, T>(null);
	}

	public static T? smethod_9<T>(this IEnumerable<JToken> ienumerable_0)
	{
		return ienumerable_0.smethod_10<JToken, T>();
	}

	public static U? smethod_10<T, U>(this IEnumerable<T> ienumerable_0) where T : JToken
	{
		Class112.smethod_0(ienumerable_0, "value");
		return ((ienumerable_0 as JToken) ?? throw new ArgumentException("Source value must be a JToken.")).smethod_15<JToken, U>();
	}

	internal static IEnumerable<U?> smethod_11<T, U>(this IEnumerable<T> ienumerable_0, object? object_0) where T : JToken
	{
		//yield-return decompiler failed: Method not found
		return new Class174<T, U>(-2)
		{
			ienumerable_1 = ienumerable_0,
			object_1 = object_0
		};
	}

	public static Interface10<JToken> smethod_12<T>(this IEnumerable<T> ienumerable_0) where T : JToken
	{
		return ienumerable_0.smethod_13<T, JToken>().smethod_16();
	}

	public static IEnumerable<U?> smethod_13<T, U>(this IEnumerable<T> ienumerable_0) where T : JToken
	{
		Class112.smethod_0(ienumerable_0, "source");
		return ienumerable_0.SelectMany((T gparam_0) => gparam_0.vmethod_3()).smethod_14<JToken, U>();
	}

	internal static IEnumerable<U?> smethod_14<T, U>(this IEnumerable<T> ienumerable_0) where T : JToken
	{
		//yield-return decompiler failed: Method not found
		return new Class175<T, U>(-2)
		{
			ienumerable_1 = ienumerable_0
		};
	}

	internal static U? smethod_15<T, U>(this T gparam_0) where T : JToken?
	{
		if (gparam_0 == null)
		{
			return default(U);
		}
		if (gparam_0 is U)
		{
			U result = (U)(object)((gparam_0 is U) ? gparam_0 : null);
			if (typeof(U) != typeof(IComparable) && typeof(U) != typeof(IFormattable))
			{
				return result;
			}
		}
		if (!(gparam_0 is Class179 @class))
		{
			throw new InvalidCastException("Cannot cast {0} to {1}.".smethod_2(CultureInfo.InvariantCulture, gparam_0.GetType(), typeof(T)));
		}
		object value = @class.Value;
		if (value is U)
		{
			return (U)value;
		}
		Type type = typeof(U);
		if (Class131.smethod_175(type))
		{
			if (@class.Value == null)
			{
				return default(U);
			}
			type = Nullable.GetUnderlyingType(type);
		}
		return (U)Convert.ChangeType(@class.Value, type, CultureInfo.InvariantCulture);
	}

	public static Interface10<JToken> smethod_16(this IEnumerable<JToken> ienumerable_0)
	{
		return ienumerable_0.smethod_17();
	}

	public static Interface10<T> smethod_17<T>(this IEnumerable<T> ienumerable_0) where T : JToken
	{
		if (ienumerable_0 == null)
		{
			return null;
		}
		if (ienumerable_0 is Interface10<T> result)
		{
			return result;
		}
		return new Struct6<T>(ienumerable_0);
	}
}
