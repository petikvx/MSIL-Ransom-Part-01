using System;
using System.Reflection;

namespace Google.Protobuf.Compatibility;

internal static class TypeExtensions
{
	internal static bool IsAssignableFrom(this Type target, Type c)
	{
		return target.GetTypeInfo().IsAssignableFrom(c.GetTypeInfo());
	}

	internal static PropertyInfo GetProperty(this Type target, string name)
	{
		PropertyInfo declaredProperty;
		while (true)
		{
			if (target != null)
			{
				TypeInfo typeInfo = target.GetTypeInfo();
				declaredProperty = typeInfo.GetDeclaredProperty(name);
				if (declaredProperty != null && ((declaredProperty.CanRead && declaredProperty.GetMethod!.IsPublic) || (declaredProperty.CanWrite && declaredProperty.SetMethod!.IsPublic)))
				{
					break;
				}
				target = typeInfo.BaseType;
				continue;
			}
			return null;
		}
		return declaredProperty;
	}

	internal static MethodInfo GetMethod(this Type target, string name)
	{
		MethodInfo declaredMethod;
		while (true)
		{
			if (target != null)
			{
				TypeInfo typeInfo = target.GetTypeInfo();
				declaredMethod = typeInfo.GetDeclaredMethod(name);
				if (declaredMethod != null && declaredMethod.IsPublic)
				{
					break;
				}
				target = typeInfo.BaseType;
				continue;
			}
			return null;
		}
		return declaredMethod;
	}
}
