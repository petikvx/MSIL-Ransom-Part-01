using System;
using System.Globalization;
using System.Reflection;
using Newtonsoft.Json;
using ns10;
using ns13;
using ns14;
using ns9;

namespace ns5;

internal class Class159 : Interface8
{
	private readonly MemberInfo memberInfo_0;

	public Class159(MemberInfo memberInfo_1)
	{
		Class113.smethod_0(memberInfo_1, "memberInfo");
		memberInfo_0 = memberInfo_1;
	}

	public void imethod_0(object object_0, object? object_1)
	{
		try
		{
			Class7.smethod_541(object_0, memberInfo_0, object_1);
		}
		catch (Exception innerException)
		{
			throw new JsonSerializationException("Error setting value to '{0}' on '{1}'.".smethod_2(CultureInfo.InvariantCulture, memberInfo_0.Name, object_0.GetType()), innerException);
		}
	}

	public object? imethod_1(object object_0)
	{
		try
		{
			if (memberInfo_0 is PropertyInfo propertyInfo && propertyInfo.PropertyType.IsByRef)
			{
				throw new InvalidOperationException("Could not create getter for {0}. ByRef return values are not supported.".smethod_1(CultureInfo.InvariantCulture, propertyInfo));
			}
			return Class7.smethod_251(memberInfo_0, object_0);
		}
		catch (Exception innerException)
		{
			throw new JsonSerializationException("Error getting value from '{0}' on '{1}'.".smethod_2(CultureInfo.InvariantCulture, memberInfo_0.Name, object_0.GetType()), innerException);
		}
	}
}
