using System;

namespace ns12;

[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method)]
internal class Attribute8 : Attribute
{
	public Attribute8()
	{
	}

	public Attribute8(string featureName)
	{
	}
}
