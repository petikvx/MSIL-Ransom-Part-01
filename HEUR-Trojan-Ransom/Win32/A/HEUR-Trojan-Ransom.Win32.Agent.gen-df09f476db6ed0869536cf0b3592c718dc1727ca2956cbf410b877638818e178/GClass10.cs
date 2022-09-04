using System.Runtime.CompilerServices;

public class GClass10 : GClass9
{
	private bool bool_0;

	public override GEnum2 vmethod_0(GClass17 gclass17_0)
	{
		if (gclass17_0.method_0() == "thrdev" && gclass17_0.method_2() == "testing1234")
		{
			return (GEnum2)0;
		}
		return (GEnum2)255;
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

	public GClass10()
	{
		Class51.smethod_0();
		base._002Ector();
	}
}
