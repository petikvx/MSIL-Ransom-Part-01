using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

internal sealed class Class15
{
	public static extern void smethod_0();

	private static extern Assembly smethod_1(object object_0, ResolveEventArgs resolveEventArgs_0);

	public Class15()
	{
		//Discarded unreachable code: IL_0005, IL_000e, IL_0016
		//IL_0009: Invalid comparison between Unknown and I
		/*Error: Invalid metadata token*/;
	}

	internal static extern RightToLeft smethod_2<T>(T gparam_0, short short_0, short short_1) where T : Control;

	internal static extern void smethod_3<T>(T gparam_0, Size size_0, short short_0, short short_1) where T : TabControl;

	internal static extern TabPageCollection smethod_4<T>(T gparam_0, short short_0, int int_0) where T : TabControl;

	static extern void smethod_5(AppDomain appDomain_0, ResolveEventHandler resolveEventHandler_0);

	static extern Type smethod_6(RuntimeTypeHandle runtimeTypeHandle_0);

	static RightToLeft smethod_7(Control control_0)
	{
		checked
		{
			_ = (sbyte)(nint)((IntPtr[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
			_ = -41;
			/*Error: Unexpected end of block*/;
		}
	}

	static void smethod_8(TabControl tabControl_0, Size size_0)
	{
		_ = checked((sbyte)/*Error near IL_0002: Stack underflow*/) << (int)/*Error near IL_0002: ldarg 2 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	static extern TabPageCollection smethod_9(TabControl tabControl_0);
}
