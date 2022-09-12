using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using ns1;
using ns10;
using ns17;
using ns6;
using ns8;

namespace ns4;

internal struct Struct0
{
	private static readonly char[] char_0 = new char[18]
	{
		'.', ' ', '\'', '/', '"', '[', ']', '(', ')', '\t',
		'\n', '\r', '\f', '\b', '\\', '\u0085', '\u2028', '\u2029'
	};

	internal JsonContainerType jsonContainerType_0;

	internal int int_0;

	internal string? string_0;

	internal bool bool_0;

	public Struct0(JsonContainerType jsonContainerType_1)
	{
		jsonContainerType_0 = jsonContainerType_1;
		bool_0 = smethod_0(jsonContainerType_1);
		int_0 = -1;
		string_0 = null;
	}

	internal int method_0()
	{
		switch (jsonContainerType_0)
		{
		default:
			throw new ArgumentOutOfRangeException("Type");
		case JsonContainerType.Array:
		case JsonContainerType.Constructor:
			return Class4.smethod_71((ulong)int_0) + 2;
		case JsonContainerType.Object:
			return string_0!.Length + 5;
		}
	}

	internal void method_1(StringBuilder stringBuilder_0, ref StringWriter? stringWriter_0, ref char[]? char_1)
	{
		switch (jsonContainerType_0)
		{
		case JsonContainerType.Array:
		case JsonContainerType.Constructor:
			stringBuilder_0.Append('[');
			stringBuilder_0.Append(int_0);
			stringBuilder_0.Append(']');
			break;
		case JsonContainerType.Object:
		{
			string text = string_0;
			if (text.IndexOfAny(char_0) != -1)
			{
				stringBuilder_0.Append("['");
				if (stringWriter_0 == null)
				{
					stringWriter_0 = new StringWriter(stringBuilder_0);
				}
				Class88.smethod_0(stringWriter_0, text, '\'', bool_3: false, Class88.bool_0, Enum17.const_0, null, ref char_1);
				stringBuilder_0.Append("']");
			}
			else
			{
				if (stringBuilder_0.Length > 0)
				{
					stringBuilder_0.Append('.');
				}
				stringBuilder_0.Append(text);
			}
			break;
		}
		}
	}

	internal static bool smethod_0(JsonContainerType jsonContainerType_1)
	{
		if (jsonContainerType_1 != JsonContainerType.Array)
		{
			return jsonContainerType_1 == JsonContainerType.Constructor;
		}
		return true;
	}

	internal static string smethod_1(List<Struct0> list_0, Struct0? nullable_0)
	{
		int num = 0;
		if (list_0 != null)
		{
			for (int i = 0; i < list_0.Count; i++)
			{
				num += list_0[i].method_0();
			}
		}
		if (nullable_0.HasValue)
		{
			num += nullable_0.GetValueOrDefault().method_0();
		}
		StringBuilder stringBuilder = new StringBuilder(num);
		StringWriter stringWriter_ = null;
		char[] char_ = null;
		if (list_0 != null)
		{
			foreach (Struct0 item in list_0)
			{
				item.method_1(stringBuilder, ref stringWriter_, ref char_);
			}
		}
		nullable_0?.method_1(stringBuilder, ref stringWriter_, ref char_);
		return stringBuilder.ToString();
	}

	internal static string smethod_2(Interface1? interface1_0, string string_1, string string_2)
	{
		if (!string_2.EndsWith(Environment.NewLine, StringComparison.Ordinal))
		{
			string_2 = string_2.Trim();
			if (!string_2.smethod_8('.'))
			{
				string_2 += ".";
			}
			string_2 += " ";
		}
		string_2 += "Path '{0}'".smethod_1(CultureInfo.InvariantCulture, string_1);
		if (interface1_0 != null && interface1_0!.imethod_0())
		{
			string_2 += ", line {0}, position {1}".smethod_2(CultureInfo.InvariantCulture, interface1_0!.LineNumber, interface1_0!.LinePosition);
		}
		string_2 += ".";
		return string_2;
	}
}
