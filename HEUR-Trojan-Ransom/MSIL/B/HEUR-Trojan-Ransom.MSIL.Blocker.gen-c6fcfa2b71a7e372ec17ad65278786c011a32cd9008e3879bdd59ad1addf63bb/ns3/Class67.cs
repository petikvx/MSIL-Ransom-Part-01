using System;
using System.Globalization;
using System.Reflection;
using ns5;
using ns7;

namespace ns3;

internal abstract class Class67
{
	public Func<T, object?> method_0<T>(MemberInfo memberInfo_0)
	{
		if (memberInfo_0 is PropertyInfo propertyInfo)
		{
			if (propertyInfo.PropertyType.IsByRef)
			{
				throw new InvalidOperationException("Could not create getter for {0}. ByRef return values are not supported.".smethod_1(CultureInfo.InvariantCulture, propertyInfo));
			}
			return vmethod_3<T>(propertyInfo);
		}
		if (!(memberInfo_0 is FieldInfo fieldInfo_))
		{
			throw new Exception("Could not create getter for {0}.".smethod_1(CultureInfo.InvariantCulture, memberInfo_0));
		}
		return vmethod_4<T>(fieldInfo_);
	}

	public Action<T, object?> method_1<T>(MemberInfo memberInfo_0)
	{
		if (memberInfo_0 is PropertyInfo propertyInfo_)
		{
			return vmethod_6<T>(propertyInfo_);
		}
		if (!(memberInfo_0 is FieldInfo fieldInfo_))
		{
			throw new Exception("Could not create setter for {0}.".smethod_1(CultureInfo.InvariantCulture, memberInfo_0));
		}
		return vmethod_5<T>(fieldInfo_);
	}

	public abstract Delegate1<T, object?> vmethod_0<T>(MethodBase methodBase_0);

	public abstract Delegate7<object> vmethod_1(MethodBase methodBase_0);

	public abstract Func<T> vmethod_2<T>(Type type_0);

	public abstract Func<T, object?> vmethod_3<T>(PropertyInfo propertyInfo_0);

	public abstract Func<T, object?> vmethod_4<T>(FieldInfo fieldInfo_0);

	public abstract Action<T, object?> vmethod_5<T>(FieldInfo fieldInfo_0);

	public abstract Action<T, object?> vmethod_6<T>(PropertyInfo propertyInfo_0);
}
