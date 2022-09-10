using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

internal sealed class Class8
{
	[StructLayout(LayoutKind.Auto)]
	internal struct Struct19
	{
		internal Rectangle rectangle_0;
	}

	internal static byte[] smethod_0()
	{
		_ = 8;
		/*Error: Unexpected end of block*/;
	}

	public extern Class8();

	internal static extern Font smethod_1<T>(T gparam_0, short short_0, int int_0) where T : Control;

	internal static extern Size smethod_2(ref Rectangle rectangle_0, char char_0, short short_0);

	unsafe static void smethod_3(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Ref
		do
		{
			_003F val = /*Error near IL_0001: Stack underflow*/& /*Error near IL_0001: Stack underflow*/;
			_003F val2 = /*Error near IL_0002: Stack underflow*/>> (int)val;
			_003F val3 = /*Error near IL_0004: Stack underflow*/* val2;
			_003F val4 = /*Error near IL_0005: Stack underflow*/>> (int)val3;
			checked
			{
				_ = (double)(short)unchecked((int)((uint[])/*Error near IL_0006: Stack underflow*/)[val4]);
				/*Error near IL_0008: stloc 3 (out-of-bounds)*/;
			}
		}
		while ((nint)(*(IntPtr*)(nint)/*Error near IL_000a: Stack underflow*/) <= (nint)((Array)(&array_0)).LongLength);
		((float[])/*Error near IL_0014: Stack underflow*/)[/*Error near IL_0014: Stack underflow*/] = (float)/*Error near IL_0014: Stack underflow*/;
		/*Error: Unexpected end of block*/;
	}

	static extern Font smethod_4(Control control_0);
}
