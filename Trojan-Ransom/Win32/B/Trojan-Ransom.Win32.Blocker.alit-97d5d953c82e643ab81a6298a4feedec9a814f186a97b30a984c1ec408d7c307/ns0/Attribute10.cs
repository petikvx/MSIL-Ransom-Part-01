using System;

namespace ns0;

[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method)]
internal sealed class Attribute10 : Attribute
{
	public Attribute10()
	{
	}

	public Attribute10(string featureName)
	{
	}
}
