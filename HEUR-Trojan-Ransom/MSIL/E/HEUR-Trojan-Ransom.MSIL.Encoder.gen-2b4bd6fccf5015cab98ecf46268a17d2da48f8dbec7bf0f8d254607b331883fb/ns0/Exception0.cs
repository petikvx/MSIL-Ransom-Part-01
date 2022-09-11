using System;

namespace ns0;

internal sealed class Exception0 : Exception
{
	private Class1.Enum0 enum0_0;

	public Class1.Enum0 Enum0_0 => enum0_0;

	public Exception0(string string_0, Class1.Enum0 enum0_1)
		: base(string_0)
	{
		enum0_0 = enum0_1;
	}
}
