using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[ComVisible(true)]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[Guid("74F668E6-8EF2-4D01-84D8-DA2FE619C062")]
public sealed class GClass14 : GClass10
{
	[CompilerGenerated]
	private GClass8 gclass8_0;

	public GClass8 GClass8_0
	{
		[CompilerGenerated]
		get
		{
			return gclass8_0;
		}
		[CompilerGenerated]
		private set
		{
			gclass8_0 = value;
		}
	}

	internal GClass14()
	{
		Delegate267.smethod_0(this, Delegate257.smethod_0());
	}

	internal void method_2(GEventArgs7 geventArgs7_0)
	{
		Delegate262.smethod_0(Delegate268.smethod_0(this), geventArgs7_0);
	}
}
