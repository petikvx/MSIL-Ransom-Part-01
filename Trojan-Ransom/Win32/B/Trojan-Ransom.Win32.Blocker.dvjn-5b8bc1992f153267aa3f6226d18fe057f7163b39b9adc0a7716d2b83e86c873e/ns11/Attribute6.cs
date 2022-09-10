using System;

namespace ns11;

[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method)]
internal class Attribute6 : Attribute
{
	public Attribute6()
	{
	}

	public Attribute6(string featureName)
	{
	}
}
