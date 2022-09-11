using System;

namespace ns2;

[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method)]
internal sealed class Attribute5 : Attribute
{
	public Attribute5()
	{
	}

	public Attribute5(string featureName)
	{
	}
}
