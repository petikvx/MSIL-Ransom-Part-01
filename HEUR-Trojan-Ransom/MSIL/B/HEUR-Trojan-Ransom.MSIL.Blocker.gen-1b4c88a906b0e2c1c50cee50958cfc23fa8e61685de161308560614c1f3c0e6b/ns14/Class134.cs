using System;
using System.Globalization;
using System.Reflection;
using Newtonsoft.Json;
using ns10;
using ns13;

namespace ns14;

internal class Class134 : Interface8
{
	private readonly MemberInfo memberInfo_0;

	private Func<object, object?>? func_0;

	private Action<object, object?>? action_0;

	public Class134(MemberInfo memberInfo_1)
	{
		Class113.smethod_0(memberInfo_1, "memberInfo");
		memberInfo_0 = memberInfo_1;
	}

	public void imethod_0(object object_0, object? object_1)
	{
		try
		{
			if (action_0 == null)
			{
				action_0 = Class69.Instance.method_1<object>(memberInfo_0);
			}
			action_0!(object_0, object_1);
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
			if (func_0 == null)
			{
				func_0 = Class69.Instance.method_0<object>(memberInfo_0);
			}
			return func_0!(object_0);
		}
		catch (Exception innerException)
		{
			throw new JsonSerializationException("Error getting value from '{0}' on '{1}'.".smethod_2(CultureInfo.InvariantCulture, memberInfo_0.Name, object_0.GetType()), innerException);
		}
	}
}
