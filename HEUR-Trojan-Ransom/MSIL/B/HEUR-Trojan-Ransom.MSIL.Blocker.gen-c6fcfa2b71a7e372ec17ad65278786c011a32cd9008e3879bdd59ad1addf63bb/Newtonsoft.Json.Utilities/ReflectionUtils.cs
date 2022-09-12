using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using ns13;
using ns17;
using ns3;

namespace Newtonsoft.Json.Utilities;

internal static class ReflectionUtils
{
	[CompilerGenerated]
	internal sealed class Class103
	{
		public MemberInfo memberInfo_0;

		internal bool method_0(MemberInfo memberInfo_1)
		{
			return memberInfo_1.DeclaringType == memberInfo_0.DeclaringType;
		}
	}

	[CompilerGenerated]
	internal sealed class Class104
	{
		public PropertyInfo propertyInfo_0;

		internal bool method_0(PropertyInfo propertyInfo_1)
		{
			return propertyInfo_1.Name == propertyInfo_0.Name;
		}

		internal bool method_1(PropertyInfo propertyInfo_1)
		{
			if (propertyInfo_1.Name == propertyInfo_0.Name)
			{
				return propertyInfo_1.DeclaringType == propertyInfo_0.DeclaringType;
			}
			return false;
		}
	}

	[CompilerGenerated]
	internal sealed class Class105
	{
		public Type type_0;

		public Class104 class104_0;

		internal bool method_0(PropertyInfo propertyInfo_0)
		{
			object obj;
			if (propertyInfo_0.Name == class104_0.propertyInfo_0.Name && propertyInfo_0.smethod_0())
			{
				MethodInfo? methodInfo = propertyInfo_0.smethod_1();
				if ((object)methodInfo == null)
				{
					obj = null;
				}
				else
				{
					obj = methodInfo!.DeclaringType;
					if (obj != null)
					{
						goto IL_0041;
					}
				}
				obj = propertyInfo_0.DeclaringType;
				goto IL_0041;
			}
			return false;
			IL_0041:
			return ((Type)obj).IsAssignableFrom(type_0);
		}
	}

	[CompilerGenerated]
	internal sealed class Class106
	{
		public string string_0;

		public Type type_0;

		internal bool method_0(MethodInfo methodInfo_0)
		{
			if (methodInfo_0.Name == string_0 && methodInfo_0.DeclaringType != type_0)
			{
				return methodInfo_0.GetBaseDefinition().DeclaringType == type_0;
			}
			return false;
		}
	}

	public static readonly Type[] type_0;

	static ReflectionUtils()
	{
		type_0 = Type.EmptyTypes;
	}

	public static bool smethod_0(this PropertyInfo propertyInfo_0)
	{
		Class112.smethod_0(propertyInfo_0, "propertyInfo");
		MethodInfo getMethod = propertyInfo_0.GetGetMethod(nonPublic: true);
		if (getMethod != null && getMethod.IsVirtual)
		{
			return true;
		}
		getMethod = propertyInfo_0.GetSetMethod(nonPublic: true);
		if (getMethod != null && getMethod.IsVirtual)
		{
			return true;
		}
		return false;
	}

	public static MethodInfo? smethod_1(this PropertyInfo propertyInfo_0)
	{
		Class112.smethod_0(propertyInfo_0, "propertyInfo");
		MethodInfo getMethod = propertyInfo_0.GetGetMethod(nonPublic: true);
		if (getMethod != null)
		{
			return getMethod.GetBaseDefinition();
		}
		return propertyInfo_0.GetSetMethod(nonPublic: true)?.GetBaseDefinition();
	}

	public static Type? smethod_2(object? object_0)
	{
		return object_0?.GetType();
	}

	public static void smethod_3(Type type_1, out Type? type_2, out Type? type_3)
	{
		Class112.smethod_0(type_1, "dictionaryType");
		if (Class131.smethod_618(type_1, typeof(IDictionary<, >), out Type type_4))
		{
			if (type_4.smethod_5())
			{
				throw new Exception("Type {0} is not a dictionary.".smethod_1(CultureInfo.InvariantCulture, type_1));
			}
			Type[] genericArguments = type_4.GetGenericArguments();
			type_2 = genericArguments[0];
			type_3 = genericArguments[1];
		}
		else
		{
			if (!typeof(IDictionary).IsAssignableFrom(type_1))
			{
				throw new Exception("Type {0} is not a dictionary.".smethod_1(CultureInfo.InvariantCulture, type_1));
			}
			type_2 = null;
			type_3 = null;
		}
	}

	public static T? smethod_4<T>(object object_0) where T : Attribute
	{
		return smethod_5<T>(object_0, bool_0: true);
	}

	public static T? smethod_5<T>(object object_0, bool bool_0) where T : Attribute
	{
		T[] array = smethod_6<T>(object_0, bool_0);
		if (array == null)
		{
			return null;
		}
		return array.FirstOrDefault();
	}

	public static T[] smethod_6<T>(object object_0, bool bool_0) where T : Attribute
	{
		Attribute[] array = Class131.smethod_403(object_0, typeof(T), bool_0);
		if (array is T[] result)
		{
			return result;
		}
		return array.Cast<T>().ToArray();
	}

	public static BindingFlags smethod_7(this BindingFlags bindingFlags_0, BindingFlags bindingFlags_1)
	{
		if ((bindingFlags_0 & bindingFlags_1) != bindingFlags_1)
		{
			return bindingFlags_0;
		}
		return bindingFlags_0 ^ bindingFlags_1;
	}
}
