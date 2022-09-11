using System;

namespace ns1;

[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method)]
internal sealed class Attribute6 : Attribute
{
	public Attribute6()
	{
	}

	public Attribute6(string featureName)
	{
	}
}
