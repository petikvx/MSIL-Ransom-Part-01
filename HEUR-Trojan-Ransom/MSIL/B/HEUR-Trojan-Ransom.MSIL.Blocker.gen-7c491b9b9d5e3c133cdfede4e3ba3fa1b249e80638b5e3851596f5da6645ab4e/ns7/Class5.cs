using System;
using System.Linq.Expressions;
using System.Reflection;
using ns6;

namespace ns7;

internal sealed class Class5
{
	internal static Func<Type[], Type> smethod_0(TypeInfo typeInfo_0, out Delegate delegate_0, out Type type_0, out string string_0)
	{
		int num = ((typeInfo_0.GetMethod("r") == typeof(void)) ? 1 : 0);
		type_0 = typeof(Class4.Delegate0);
		string_0 = "r";
		Func<Type[], Type> result = ((num == 0) ? new Func<Type[], Type>(Expression.GetFuncType) : new Func<Type[], Type>(Expression.GetActionType));
		if (num != 0)
		{
			delegate_0 = Delegate.CreateDelegate(type_0, typeInfo_0, string_0);
		}
		delegate_0 = null;
		return result;
	}
}
