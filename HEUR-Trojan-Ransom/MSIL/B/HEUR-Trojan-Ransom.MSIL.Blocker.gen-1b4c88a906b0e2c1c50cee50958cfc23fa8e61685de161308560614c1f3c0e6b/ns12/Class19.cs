using System;
using System.Globalization;
using Newtonsoft.Json;
using ns0;
using ns10;
using ns18;
using ns3;
using ns9;

namespace ns12;

internal class Class19 : Class16
{
	internal static readonly DateTime dateTime_0 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

	public override void vmethod_0(Class38 class38_0, object? object_0, Class34 class34_0)
	{
		long num;
		if (object_0 is DateTime dateTime)
		{
			num = (long)(dateTime.ToUniversalTime() - dateTime_0).TotalSeconds;
		}
		else
		{
			if (!(object_0 is DateTimeOffset dateTimeOffset))
			{
				throw new JsonSerializationException("Expected date object value.");
			}
			num = (long)(dateTimeOffset.ToUniversalTime() - dateTime_0).TotalSeconds;
		}
		if (num < 0L)
		{
			throw new JsonSerializationException("Cannot convert date value that is before Unix epoch of 00:00:00 UTC on 1 January 1970.");
		}
		class38_0.vmethod_24(num);
	}

	public override object? vmethod_1(Class29 class29_0, Type type_0, object? object_0, Class34 class34_0)
	{
		bool flag = Class7.smethod_213(type_0);
		if (class29_0.TokenType == JsonToken.Null)
		{
			if (!flag)
			{
				throw Class7.smethod_161(class29_0, "Cannot convert null value to {0}.".smethod_1(CultureInfo.InvariantCulture, type_0));
			}
			return null;
		}
		long result;
		if (class29_0.TokenType == JsonToken.Integer)
		{
			result = (long)class29_0.Value;
		}
		else
		{
			if (class29_0.TokenType != JsonToken.String)
			{
				throw Class7.smethod_161(class29_0, "Unexpected token parsing date. Expected Integer or String, got {0}.".smethod_1(CultureInfo.InvariantCulture, class29_0.TokenType));
			}
			if (!long.TryParse((string)class29_0.Value, out result))
			{
				throw Class7.smethod_161(class29_0, "Cannot convert invalid value to {0}.".smethod_1(CultureInfo.InvariantCulture, type_0));
			}
		}
		if (result >= 0L)
		{
			DateTime dateTime = dateTime_0;
			DateTime dateTime2 = dateTime.AddSeconds(result);
			if ((flag ? Nullable.GetUnderlyingType(type_0) : type_0) == typeof(DateTimeOffset))
			{
				return new DateTimeOffset(dateTime2, TimeSpan.Zero);
			}
			return dateTime2;
		}
		throw Class7.smethod_161(class29_0, "Cannot convert value that is before Unix epoch of 00:00:00 UTC on 1 January 1970 to {0}.".smethod_1(CultureInfo.InvariantCulture, type_0));
	}
}
