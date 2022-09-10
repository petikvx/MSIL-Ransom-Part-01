using System;

namespace ns9;

[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method)]
internal sealed class Attribute9 : Attribute
{
	public Attribute9()
	{
	}

	public Attribute9(string featureName)
	{
	}
}
