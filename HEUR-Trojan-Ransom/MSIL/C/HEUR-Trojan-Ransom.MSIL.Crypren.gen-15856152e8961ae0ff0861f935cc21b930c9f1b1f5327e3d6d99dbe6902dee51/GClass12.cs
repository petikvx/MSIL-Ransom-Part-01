using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[Guid("3BCB18EC-6D98-4BFB-A9C2-893CBD13CDAB")]
[ComVisible(true)]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
public sealed class GClass12 : GClass10
{
	[CompilerGenerated]
	private GClass5 gclass5_0;

	public GClass5 GClass5_0
	{
		[CompilerGenerated]
		get
		{
			return gclass5_0;
		}
		[CompilerGenerated]
		private set
		{
			gclass5_0 = value;
		}
	}

	internal GClass12()
	{
		Delegate254.smethod_0(this, Delegate253.smethod_0());
	}

	internal void method_2(GEventArgs6 geventArgs6_0)
	{
		Delegate256.smethod_0(Delegate255.smethod_0(this), geventArgs6_0);
	}
}
