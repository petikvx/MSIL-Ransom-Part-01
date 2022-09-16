using System;
using System.Collections.Generic;

namespace xClient.Core.NetSerializer;

public interface ITypeSerializer
{
	bool Handles(Type type);

	IEnumerable<Type> GetSubtypes(Type type);
}
