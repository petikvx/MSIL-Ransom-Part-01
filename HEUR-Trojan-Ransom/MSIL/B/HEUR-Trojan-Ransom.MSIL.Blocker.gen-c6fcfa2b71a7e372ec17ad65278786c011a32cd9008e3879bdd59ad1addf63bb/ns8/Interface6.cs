using System;

namespace ns8;

internal interface Interface6
{
	Type BindToType(string? assemblyName, string typeName);

	void BindToName(Type serializedType, out string? assemblyName, out string? typeName);
}
