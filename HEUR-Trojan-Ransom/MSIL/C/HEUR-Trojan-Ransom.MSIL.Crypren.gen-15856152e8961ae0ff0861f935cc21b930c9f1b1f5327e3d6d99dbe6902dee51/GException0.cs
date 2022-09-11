using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[Guid("91109A4F-D81A-4326-BEC5-1AB26EBF89A6")]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class GException0 : Exception
{
	[CompilerGenerated]
	private GClass16 gclass16_0;

	public GClass16 GClass16_0
	{
		[CompilerGenerated]
		get
		{
			return gclass16_0;
		}
		[CompilerGenerated]
		private set
		{
			gclass16_0 = value;
		}
	}

	internal GException0(GClass16 gclass16_1, string string_0)
		: this(gclass16_1, string_0, null)
	{
	}

	internal GException0(GClass16 gclass16_1, string string_0, Exception exception_0)
		: base(string_0, exception_0)
	{
		Delegate527.smethod_0(this, gclass16_1);
		Delegate45.smethod_0(Delegate51.smethod_0(gclass16_1), "Exception: {0}", new object[1] { this });
	}
}
