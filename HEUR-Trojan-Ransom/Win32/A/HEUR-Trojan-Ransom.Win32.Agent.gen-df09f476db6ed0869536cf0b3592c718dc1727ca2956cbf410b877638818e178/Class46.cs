using System.Net;
using System.Runtime.CompilerServices;

internal class Class46 : GClass4
{
	private bool bool_0;

	public override bool vmethod_0(GClass19 gclass19_0, IPEndPoint ipendPoint_0)
	{
		return true;
	}

	[SpecialName]
	public override bool imethod_0()
	{
		return bool_0;
	}

	[SpecialName]
	public override void imethod_1(bool bool_1)
	{
		bool_0 = bool_1;
	}

	public Class46()
	{
		Class51.smethod_0();
		bool_0 = true;
		base._002Ector();
	}
}
