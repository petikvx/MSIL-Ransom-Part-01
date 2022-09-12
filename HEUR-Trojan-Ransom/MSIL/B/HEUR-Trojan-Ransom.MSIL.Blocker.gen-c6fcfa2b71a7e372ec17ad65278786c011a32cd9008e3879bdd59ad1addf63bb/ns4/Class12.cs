using System;
using Newtonsoft.Json;
using ns1;
using ns13;
using ns3;
using ns9;

namespace ns4;

internal abstract class Class12<T> : Class8
{
	public override bool CanWrite => false;

	public override void vmethod_0(Class37 class37_0, object? object_0, Class33 class33_0)
	{
		throw new NotSupportedException("CustomCreationConverter should only be used while deserializing.");
	}

	public override object? vmethod_1(Class28 class28_0, Type type_0, object? object_0, Class33 class33_0)
	{
		if (class28_0.TokenType == JsonToken.Null)
		{
			return null;
		}
		T val = vmethod_3(type_0);
		if (val == null)
		{
			throw new JsonSerializationException("No object created.");
		}
		class33_0.method_1(class28_0, val);
		return val;
	}

	public abstract T vmethod_3(Type type_0);

	public override bool vmethod_2(Type type_0)
	{
		return typeof(T).IsAssignableFrom(type_0);
	}
}
