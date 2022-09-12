using System;
using System.Runtime.Serialization;

namespace ns8;

internal class Class160 : Interface6
{
	public readonly SerializationBinder serializationBinder_0;

	public Class160(SerializationBinder serializationBinder_1)
	{
		serializationBinder_0 = serializationBinder_1;
	}

	public Type BindToType(string? assemblyName, string typeName)
	{
		return serializationBinder_0.BindToType(assemblyName, typeName);
	}

	public void BindToName(Type serializedType, out string? assemblyName, out string? typeName)
	{
		serializationBinder_0.BindToName(serializedType, out assemblyName, out typeName);
	}
}
