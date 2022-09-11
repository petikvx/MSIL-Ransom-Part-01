using System;
using ns1;

namespace ns0;

internal sealed class Class0
{
	private delegate void Delegate0();

	private delegate void Delegate1(object sender, EventArgs e);

	private readonly IntPtr intptr_0;

	private readonly object object_0;

	private readonly bool bool_0;

	internal EventHandler EventHandler_0 => method_0;

	internal Class0(object object_1, IntPtr intptr_1, bool bool_1)
	{
		bool_0 = bool_1;
		object_0 = object_1;
		intptr_0 = intptr_1;
	}

	internal void method_0(object sender, EventArgs e)
	{
	}

	public static byte[] smethod_0(byte[] byte_0)
	{
		Class7.smethod_0(byte_0);
		return GStruct0.byte_0;
	}
}
