using System;
using ns2;
using ns4;

namespace ns5;

internal sealed class Exception1 : ApplicationException
{
	[NonSerialized]
	internal static Delegate0 delegate0_0;

	public Exception1()
		: base(delegate0_0(207))
	{
	}

	static Exception1()
	{
		Class12.smethod_0(typeof(Exception1));
	}
}
