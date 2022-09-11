using System;
using System.Runtime.InteropServices;

[Guid("62FB0733-C24F-4DC2-8452-560148931927")]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public sealed class GEventArgs6 : GEventArgs4
{
	internal const string string_1 = "rm";

	private GEventArgs6()
	{
	}

	internal static GEventArgs6 smethod_2(Class27 class27_0)
	{
		GEventArgs6 gEventArgs = Delegate252.smethod_0();
		Class28 @class = Delegate35.smethod_0(class27_0);
		try
		{
			string text = default(string);
			while (Delegate43.smethod_0(@class, (Enum10)0) ? true : false)
			{
				if (Delegate36.smethod_0(@class, "filename", ref text) || 1 == 0)
				{
					Delegate37.smethod_0(gEventArgs, text);
				}
				else if (Delegate40.smethod_0(@class) || 1 == 0)
				{
					Delegate42.smethod_0(gEventArgs, Delegate41.smethod_0(@class));
				}
			}
			return gEventArgs;
		}
		finally
		{
			if (@class != null || 1 == 0)
			{
				((IDisposable)@class).Dispose();
			}
		}
	}
}
