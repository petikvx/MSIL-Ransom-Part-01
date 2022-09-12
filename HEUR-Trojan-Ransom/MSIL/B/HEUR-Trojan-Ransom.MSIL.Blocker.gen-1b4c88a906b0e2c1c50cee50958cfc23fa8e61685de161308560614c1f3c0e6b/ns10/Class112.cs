using System;
using System.Collections.Generic;
using System.Reflection;
using ns4;

namespace ns10;

internal static class Class112
{
	public static MethodInfo smethod_0(this Delegate delegate_0)
	{
		return delegate_0.Method;
	}

	public static MemberTypes smethod_1(this MemberInfo memberInfo_0)
	{
		return memberInfo_0.MemberType;
	}

	public static bool smethod_2(this Type type_0)
	{
		return type_0.ContainsGenericParameters;
	}

	public static bool smethod_3(this Type type_0)
	{
		return type_0.IsInterface;
	}

	public static bool smethod_4(this Type type_0)
	{
		return type_0.IsGenericType;
	}

	public static bool smethod_5(this Type type_0)
	{
		return type_0.IsGenericTypeDefinition;
	}

	public static Type smethod_6(this Type type_0)
	{
		return type_0.BaseType;
	}

	public static Assembly smethod_7(this Type type_0)
	{
		return type_0.Assembly;
	}

	public static bool smethod_8(this Type type_0)
	{
		return type_0.IsEnum;
	}

	public static bool smethod_9(this Type type_0)
	{
		return type_0.IsClass;
	}

	public static bool smethod_10(this Type type_0)
	{
		return type_0.IsSealed;
	}

	public static bool smethod_11(this Type type_0)
	{
		return type_0.IsAbstract;
	}

	public static bool smethod_12(this Type type_0)
	{
		return type_0.IsVisible;
	}

	public static bool smethod_13(this Type type_0)
	{
		return type_0.IsValueType;
	}

	public static bool smethod_14(this Type type_0)
	{
		return type_0.IsPrimitive;
	}

	public static bool smethod_15(this Type type_0, string string_0, bool bool_0, [Attribute1(true)] out Type? type_1)
	{
		Type type = type_0;
		while (true)
		{
			if (type != null)
			{
				if (string.Equals(type.FullName, string_0, StringComparison.Ordinal))
				{
					break;
				}
				type = type.smethod_6();
				continue;
			}
			if (bool_0)
			{
				Type[] interfaces = type_0.GetInterfaces();
				for (int i = 0; i < interfaces.Length; i++)
				{
					if (string.Equals(interfaces[i].Name, string_0, StringComparison.Ordinal))
					{
						type_1 = type_0;
						return true;
					}
				}
			}
			type_1 = null;
			return false;
		}
		type_1 = type;
		return true;
	}

	public static bool smethod_16(this Type type_0, string string_0, bool bool_0)
	{
		Type type_;
		return type_0.smethod_15(string_0, bool_0, out type_);
	}

	public static bool smethod_17(this Type type_0, Type type_1)
	{
		Type type = type_0;
		while (type != null)
		{
			foreach (Type item in (IEnumerable<Type>)type.GetInterfaces())
			{
				if (item == type_1 || (item != null && item.smethod_17(type_1)))
				{
					return true;
				}
			}
			type = type.smethod_6();
		}
		return false;
	}
}
