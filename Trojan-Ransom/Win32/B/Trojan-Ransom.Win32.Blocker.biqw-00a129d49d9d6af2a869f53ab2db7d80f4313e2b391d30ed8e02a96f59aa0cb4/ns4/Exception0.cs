using System;
using ns2;

namespace ns4;

internal sealed class Exception0 : ApplicationException
{
	[NonSerialized]
	internal static Delegate0 delegate0_0;

	public Exception0()
		: base(delegate0_0(189))
	{
	}

	static Exception0()
	{
		Class12.smethod_0(typeof(Exception0));
	}
}
