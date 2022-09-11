using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[ComVisible(true)]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[Guid("772FACCC-0786-42E1-B1C8-F08D13C9CD07")]
public sealed class GEventArgs7 : GEventArgs4
{
	[CompilerGenerated]
	private string string_1;

	[CompilerGenerated]
	private GEventArgs8 geventArgs8_0;

	[CompilerGenerated]
	private GEventArgs5 geventArgs5_0;

	[CompilerGenerated]
	private GEventArgs6 geventArgs6_0;

	internal const string string_2 = "upload";

	internal const string string_3 = "download";

	internal const string string_4 = "mkdir";

	public string String_1
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
		[CompilerGenerated]
		private set
		{
			string_1 = value;
		}
	}

	public GEventArgs8 GEventArgs8_0
	{
		[CompilerGenerated]
		get
		{
			return geventArgs8_0;
		}
		[CompilerGenerated]
		internal set
		{
			geventArgs8_0 = value;
		}
	}

	public GEventArgs5 GEventArgs5_0
	{
		[CompilerGenerated]
		get
		{
			return geventArgs5_0;
		}
		[CompilerGenerated]
		internal set
		{
			geventArgs5_0 = value;
		}
	}

	public GEventArgs6 GEventArgs6_0
	{
		[CompilerGenerated]
		get
		{
			return geventArgs6_0;
		}
		[CompilerGenerated]
		internal set
		{
			geventArgs6_0 = value;
		}
	}

	internal GEventArgs7()
	{
	}

	internal static GEventArgs7 smethod_2(Class27 class27_0)
	{
		GEventArgs7 gEventArgs = Delegate265.smethod_0();
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
				else if (Delegate36.smethod_0(@class, "destination", ref text) || 1 == 0)
				{
					Delegate266.smethod_0(gEventArgs, text);
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
