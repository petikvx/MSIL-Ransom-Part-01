using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[ComVisible(true)]
[Guid("DFCA88E2-6A47-4290-AD66-A39C5682D610")]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
public sealed class GEventArgs5 : GEventArgs4
{
	[CompilerGenerated]
	private GClass3 gclass3_0;

	internal const string string_1 = "chmod";

	public GClass3 GClass3_0
	{
		[CompilerGenerated]
		get
		{
			return gclass3_0;
		}
		[CompilerGenerated]
		private set
		{
			gclass3_0 = value;
		}
	}

	private GEventArgs5()
	{
	}

	internal static GEventArgs5 smethod_2(Class27 class27_0)
	{
		GEventArgs5 gEventArgs = Delegate34.smethod_0();
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
				else if (Delegate36.smethod_0(@class, "permissions", ref text) || 1 == 0)
				{
					Delegate39.smethod_0(gEventArgs, Delegate38.smethod_0(text));
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
