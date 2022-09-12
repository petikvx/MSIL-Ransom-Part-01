using System;
using Newtonsoft.Json;
using ns0;
using ns12;
using ns18;

namespace ns15;

internal abstract class Class13<T> : Class9
{
	public override bool CanWrite => false;

	public override void vmethod_0(Class38 class38_0, object? object_0, Class34 class34_0)
	{
		throw new NotSupportedException("CustomCreationConverter should only be used while deserializing.");
	}

	public override object? vmethod_1(Class29 class29_0, Type type_0, object? object_0, Class34 class34_0)
	{
		if (class29_0.TokenType == JsonToken.Null)
		{
			return null;
		}
		T val = vmethod_3(type_0);
		if (val == null)
		{
			throw new JsonSerializationException("No object created.");
		}
		class34_0.method_1(class29_0, val);
		return val;
	}

	public abstract T vmethod_3(Type type_0);

	public override bool vmethod_2(Type type_0)
	{
		return typeof(T).IsAssignableFrom(type_0);
	}
}
