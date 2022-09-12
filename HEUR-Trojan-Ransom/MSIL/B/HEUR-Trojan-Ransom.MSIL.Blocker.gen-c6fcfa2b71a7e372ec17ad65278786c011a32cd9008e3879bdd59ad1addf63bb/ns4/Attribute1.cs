using System;
using System.Runtime.CompilerServices;

namespace ns4;

[AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false)]
internal sealed class Attribute1 : Attribute
{
	[CompilerGenerated]
	private readonly bool bool_0;

	public bool ReturnValue
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
	}

	public Attribute1(bool bool_1)
	{
		bool_0 = bool_1;
	}
}
