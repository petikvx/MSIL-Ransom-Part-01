using System;
using System.Globalization;
using System.Reflection;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Utilities;

internal abstract class ReflectionDelegateFactory
{
	public Func<T, object?> CreateGet<T>(MemberInfo memberInfo) where T : notnull
	{
		if (memberInfo is PropertyInfo propertyInfo)
		{
			if (propertyInfo.PropertyType.IsByRef)
			{
				throw new InvalidOperationException("Could not create getter for {0}. ByRef return values are not supported.".FormatWith(CultureInfo.InvariantCulture, propertyInfo));
			}
			return CreateGet<T>(propertyInfo);
		}
		if (!(memberInfo is FieldInfo fieldInfo))
		{
			throw new Exception("Could not create getter for {0}.".FormatWith(CultureInfo.InvariantCulture, memberInfo));
		}
		return CreateGet<T>(fieldInfo);
	}

	public Action<T, object?> CreateSet<T>(MemberInfo memberInfo) where T : notnull
	{
		if (memberInfo is PropertyInfo propertyInfo)
		{
			return CreateSet<T>(propertyInfo);
		}
		if (!(memberInfo is FieldInfo fieldInfo))
		{
			throw new Exception("Could not create setter for {0}.".FormatWith(CultureInfo.InvariantCulture, memberInfo));
		}
		return CreateSet<T>(fieldInfo);
	}

	public abstract MethodCall<T, object?> CreateMethodCall<T>(MethodBase method) where T : notnull;

	public abstract ObjectConstructor<object> CreateParameterizedConstructor(MethodBase method);

	public abstract Func<T> CreateDefaultConstructor<T>(Type type) where T : notnull;

	public abstract Func<T, object?> CreateGet<T>(PropertyInfo propertyInfo) where T : notnull;

	public abstract Func<T, object?> CreateGet<T>(FieldInfo fieldInfo) where T : notnull;

	public abstract Action<T, object?> CreateSet<T>(FieldInfo fieldInfo) where T : notnull;

	public abstract Action<T, object?> CreateSet<T>(PropertyInfo propertyInfo) where T : notnull;
}
