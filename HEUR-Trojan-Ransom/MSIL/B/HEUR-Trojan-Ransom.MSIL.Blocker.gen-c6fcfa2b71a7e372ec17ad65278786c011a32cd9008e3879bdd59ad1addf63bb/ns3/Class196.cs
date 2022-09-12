using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace ns3;

internal class Class196 : IEqualityComparer<JToken>
{
	bool IEqualityComparer<JToken>.Equals(JToken x, JToken y)
	{
		return JToken.smethod_0(x, y);
	}

	int IEqualityComparer<JToken>.GetHashCode(JToken obj)
	{
		return obj?.vmethod_6() ?? 0;
	}
}
