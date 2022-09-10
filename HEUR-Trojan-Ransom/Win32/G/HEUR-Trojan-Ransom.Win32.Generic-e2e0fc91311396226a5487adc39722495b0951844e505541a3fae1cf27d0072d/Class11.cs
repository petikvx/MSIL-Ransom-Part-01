using System;
using System.Drawing;
using System.Windows.Forms;

internal sealed class Class11
{
	internal static extern byte[] smethod_0();

	public Class11()
	{
		//Discarded unreachable code: IL_0008, IL_0012, IL_001b, IL_0022, IL_0027, IL_002d
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		_ = /*Error near IL_0002: Stack underflow*/>> (int)/*Error near IL_0002: Stack underflow*/;
		/*Error near IL_0003: Invalid metadata token*/;
	}

	internal static extern AppDomain smethod_1(char char_0, int int_0);

	internal static extern string smethod_2<T>(T gparam_0, int int_0, char char_0) where T : Control;

	internal static extern Control smethod_3<T>(T gparam_0, short short_0, int int_0) where T : ControlEventArgs;

	internal static extern bool smethod_4(ref Rectangle rectangle_0, Point point_0, short short_0, short short_1);

	unsafe static void smethod_5(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0)
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

	static AppDomain smethod_6()
	{
		//Discarded unreachable code: IL_0006, IL_000c, IL_0013, IL_0018, IL_001e
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Invalid comparison between Unknown and I
		_ = ((int[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern string smethod_7(Control control_0);

	static extern Control smethod_8(ControlEventArgs controlEventArgs_0);
}
