using System;
using ns4;

namespace ns9;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false)]
internal sealed class Attribute7 : Attribute5
{
	public Attribute7()
	{
	}

	public Attribute7(string string_3)
		: base(string_3)
	{
	}
}
