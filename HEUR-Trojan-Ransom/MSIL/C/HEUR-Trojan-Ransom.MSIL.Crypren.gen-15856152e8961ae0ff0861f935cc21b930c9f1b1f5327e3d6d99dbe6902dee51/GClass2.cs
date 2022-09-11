using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
[Guid("FBE2FACF-F1D5-493D-9E41-4B9B7243A676")]
public sealed class GClass2
{
	[CompilerGenerated]
	private GClass4 gclass4_0;

	public GClass4 GClass4_0
	{
		[CompilerGenerated]
		get
		{
			return gclass4_0;
		}
		[CompilerGenerated]
		private set
		{
			gclass4_0 = value;
		}
	}

	internal GClass2()
	{
		Delegate178.smethod_0(this, Delegate177.smethod_0());
	}

	internal void method_0(GClass15 gclass15_0)
	{
		Delegate180.smethod_0(Delegate179.smethod_0(this), gclass15_0);
	}
}
