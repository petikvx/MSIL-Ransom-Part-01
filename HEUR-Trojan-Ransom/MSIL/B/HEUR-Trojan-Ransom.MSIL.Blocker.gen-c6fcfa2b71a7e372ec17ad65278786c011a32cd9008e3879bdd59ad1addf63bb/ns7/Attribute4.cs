using System;
using System.Runtime.CompilerServices;

namespace ns7;

[AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
internal class Attribute4 : Attribute
{
	[CompilerGenerated]
	private readonly bool bool_0;

	public bool ParameterValue
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
	}

	public Attribute4(bool bool_1)
	{
		bool_0 = bool_1;
	}
}
