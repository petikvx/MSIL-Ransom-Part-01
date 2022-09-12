using System;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Utilities;
using ns13;
using ns3;
using ns6;
using ns9;

namespace ns2;

internal class Class16 : Class15
{
	private const string string_0 = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";

	private DateTimeStyles dateTimeStyles_0 = DateTimeStyles.RoundtripKind;

	private string? string_1;

	private CultureInfo? cultureInfo_0;

	public DateTimeStyles DateTimeStyles
	{
		get
		{
			return dateTimeStyles_0;
		}
		set
		{
			dateTimeStyles_0 = value;
		}
	}

	public string? DateTimeFormat
	{
		get
		{
			return string_1 ?? string.Empty;
		}
		set
		{
			string_1 = (Class108.smethod_0(value) ? null : value);
		}
	}

	public CultureInfo Culture
	{
		get
		{
			return cultureInfo_0 ?? CultureInfo.CurrentCulture;
		}
		set
		{
			cultureInfo_0 = value;
		}
	}

	public override void vmethod_0(Class37 class37_0, object? object_0, Class33 class33_0)
	{
		string text;
		if (object_0 is DateTime dateTime)
		{
			if ((dateTimeStyles_0 & DateTimeStyles.AdjustToUniversal) == DateTimeStyles.AdjustToUniversal || (dateTimeStyles_0 & DateTimeStyles.AssumeUniversal) == DateTimeStyles.AssumeUniversal)
			{
				dateTime = dateTime.ToUniversalTime();
			}
			text = dateTime.ToString(string_1 ?? "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK", Culture);
		}
		else
		{
			if (!(object_0 is DateTimeOffset dateTimeOffset))
			{
				throw new JsonSerializationException("Unexpected value when converting date. Expected DateTime or DateTimeOffset, got {0}.".smethod_1(CultureInfo.InvariantCulture, ReflectionUtils.smethod_2(object_0)));
			}
			if ((dateTimeStyles_0 & DateTimeStyles.AdjustToUniversal) == DateTimeStyles.AdjustToUniversal || (dateTimeStyles_0 & DateTimeStyles.AssumeUniversal) == DateTimeStyles.AssumeUniversal)
			{
				dateTimeOffset = dateTimeOffset.ToUniversalTime();
			}
			text = dateTimeOffset.ToString(string_1 ?? "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK", Culture);
		}
		class37_0.vmethod_21(text);
	}

	public override object? vmethod_1(Class28 class28_0, Type type_0, object? object_0, Class33 class33_0)
	{
		bool flag = Class131.smethod_175(type_0);
		if (class28_0.TokenType == JsonToken.Null)
		{
			if (!flag)
			{
				throw Class131.smethod_38(class28_0, "Cannot convert null value to {0}.".smethod_1(CultureInfo.InvariantCulture, type_0));
			}
			return null;
		}
		Type type = (flag ? Nullable.GetUnderlyingType(type_0) : type_0);
		if (class28_0.TokenType == JsonToken.Date)
		{
			if (type == typeof(DateTimeOffset))
			{
				if (!(class28_0.Value is DateTimeOffset))
				{
					return new DateTimeOffset((DateTime)class28_0.Value);
				}
				return class28_0.Value;
			}
			if (class28_0.Value is DateTimeOffset dateTimeOffset)
			{
				return dateTimeOffset.DateTime;
			}
			return class28_0.Value;
		}
		if (class28_0.TokenType != JsonToken.String)
		{
			throw Class131.smethod_38(class28_0, "Unexpected token parsing date. Expected String, got {0}.".smethod_1(CultureInfo.InvariantCulture, class28_0.TokenType));
		}
		string text = class28_0.Value?.ToString();
		if (Class108.smethod_0(text) && flag)
		{
			return null;
		}
		if (type == typeof(DateTimeOffset))
		{
			if (!Class108.smethod_0(string_1))
			{
				return DateTimeOffset.ParseExact(text, string_1, Culture, dateTimeStyles_0);
			}
			return DateTimeOffset.Parse(text, Culture, dateTimeStyles_0);
		}
		if (!Class108.smethod_0(string_1))
		{
			return DateTime.ParseExact(text, string_1, Culture, dateTimeStyles_0);
		}
		return DateTime.Parse(text, Culture, dateTimeStyles_0);
	}
}
