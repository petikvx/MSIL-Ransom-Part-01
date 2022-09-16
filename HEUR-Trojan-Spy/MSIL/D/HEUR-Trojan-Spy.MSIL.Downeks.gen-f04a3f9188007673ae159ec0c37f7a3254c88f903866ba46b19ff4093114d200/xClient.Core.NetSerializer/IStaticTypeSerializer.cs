using System;
using System.Reflection;

namespace xClient.Core.NetSerializer;

public interface IStaticTypeSerializer : ITypeSerializer
{
	void GetStaticMethods(Type type, out MethodInfo writer, out MethodInfo reader);
}
