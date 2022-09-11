using System;
using System.Globalization;
using System.Runtime.InteropServices;

[ComVisible(true)]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[Guid("59B362D6-7FD3-4EF0-A3B6-E3244F793778")]
public sealed class GException1 : GException0
{
	internal GException1(GClass16 gclass16_1, string string_0)
		: base(gclass16_1, string_0)
	{
	}

	internal GException1(GClass16 gclass16_1, string string_0, Exception exception_0)
		: base(gclass16_1, string_0, exception_0)
	{
	}

	internal static GException1 smethod_0(GClass16 gclass16_1, string string_0)
	{
		return Delegate57.smethod_0(gclass16_1, string.Format(CultureInfo.CurrentCulture, "Element \"{0}\" not found in the log file", new object[1] { string_0 }));
	}
}
