using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
[Guid("B4CC583A-B64E-4797-9967-0FCB2F07C977")]
public class GClass10
{
	[CompilerGenerated]
	private GClass6 gclass6_0;

	public GClass6 GClass6_0
	{
		[CompilerGenerated]
		get
		{
			return gclass6_0;
		}
		[CompilerGenerated]
		private set
		{
			gclass6_0 = value;
		}
	}

	public bool Boolean_0 => Delegate308.smethod_0(Delegate307.smethod_0(this)) == 0;

	internal GClass10()
	{
		Delegate310.smethod_0(this, Delegate309.smethod_0());
	}

	public void method_0()
	{
		if (!Delegate311.smethod_0(this) && 0 == 0)
		{
			throw Delegate312.smethod_0(Delegate307.smethod_0(this), 0);
		}
	}

	internal void method_1(GException2 gexception2_0)
	{
		Delegate313.smethod_0(Delegate307.smethod_0(this), gexception2_0);
	}
}
