using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ns14;
using ns4;

namespace ns10;

internal static class Class109
{
	private enum Enum25
	{
		const_0,
		const_1,
		const_2,
		const_3
	}

	[CompilerGenerated]
	private sealed class Class110<T> where T : notnull
	{
		public Func<T, string> func_0;

		public string string_0;

		internal bool method_0(T gparam_0)
		{
			return string.Equals(func_0(gparam_0), string_0, StringComparison.OrdinalIgnoreCase);
		}

		internal bool method_1(T gparam_0)
		{
			return string.Equals(func_0(gparam_0), string_0, StringComparison.Ordinal);
		}
	}

	public const string string_0 = "\r\n";

	public const string string_1 = "";

	public const char char_0 = '\r';

	public const char char_1 = '\n';

	public const char char_2 = '\t';

	public static bool smethod_0([Attribute1(false)] string? string_2)
	{
		return string.IsNullOrEmpty(string_2);
	}

	public static string smethod_1(this string string_2, IFormatProvider iformatProvider_0, object? object_0)
	{
		return string_2.smethod_5(iformatProvider_0, object_0);
	}

	public static string smethod_2(this string string_2, IFormatProvider iformatProvider_0, object? object_0, object? object_1)
	{
		return string_2.smethod_5(iformatProvider_0, object_0, object_1);
	}

	public static string smethod_3(this string string_2, IFormatProvider iformatProvider_0, object? object_0, object? object_1, object? object_2)
	{
		return string_2.smethod_5(iformatProvider_0, object_0, object_1, object_2);
	}

	public static string smethod_4(this string string_2, IFormatProvider iformatProvider_0, object? object_0, object? object_1, object? object_2, object? object_3)
	{
		return string_2.smethod_5(iformatProvider_0, object_0, object_1, object_2, object_3);
	}

	private static string smethod_5(this string string_2, IFormatProvider iformatProvider_0, params object?[] object_0)
	{
		Class113.smethod_0(string_2, "format");
		return string.Format(iformatProvider_0, string_2, object_0);
	}

	public static T smethod_6<T>(this IEnumerable<T> ienumerable_0, Func<T, string> func_0, string string_2)
	{
		Func<T, string> func_ = func_0;
		string string_3 = string_2;
		if (ienumerable_0 == null)
		{
			throw new ArgumentNullException("source");
		}
		if (func_ == null)
		{
			throw new ArgumentNullException("valueSelector");
		}
		IEnumerable<T> source = ienumerable_0.Where((T gparam_0) => string.Equals(func_(gparam_0), string_3, StringComparison.OrdinalIgnoreCase));
		if (source.Count() <= 1)
		{
			return source.SingleOrDefault();
		}
		return ienumerable_0.Where((T gparam_0) => string.Equals(func_(gparam_0), string_3, StringComparison.Ordinal)).SingleOrDefault();
	}

	public static bool smethod_7(this string string_2, char char_3)
	{
		if (string_2.Length > 0)
		{
			return string_2[0] == char_3;
		}
		return false;
	}

	public static bool smethod_8(this string string_2, char char_3)
	{
		if (string_2.Length > 0)
		{
			return string_2[string_2.Length - 1] == char_3;
		}
		return false;
	}

	public static string smethod_9(this string string_2, int int_0, int int_1)
	{
		if (string_2 == null)
		{
			throw new ArgumentNullException();
		}
		if (int_0 < 0)
		{
			throw new ArgumentOutOfRangeException("start");
		}
		if (int_1 < 0)
		{
			throw new ArgumentOutOfRangeException("length");
		}
		int num = int_0 + int_1 - 1;
		if (num >= string_2.Length)
		{
			throw new ArgumentOutOfRangeException("length");
		}
		while (int_0 < num && char.IsWhiteSpace(string_2[int_0]))
		{
			int_0++;
		}
		while (num >= int_0 && char.IsWhiteSpace(string_2[num]))
		{
			num--;
		}
		return string_2.Substring(int_0, num - int_0 + 1);
	}
}
