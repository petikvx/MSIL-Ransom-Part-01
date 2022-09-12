using System;
using System.Windows.Forms;

internal static class Class5
{
	[STAThread]
	private static extern void Main();

	static void smethod_0()
	{
		while (true)
		{
			if (checked((int)/*Error near IL_0001: Stack underflow*/) != 0)
			{
				/*Error: Could not find block for branch target IL_0007*/;
			}
		}
	}

	unsafe static void smethod_1(bool bool_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected F4, but got I8
		//IL_001f: Invalid comparison between Unknown and I8
		//IL_0026: Expected F4, but got I8
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			_003F val = /*Error near IL_0001: Stack underflow*// /*Error near IL_0001: Stack underflow*/;
			if (/*Error near IL_0006: Stack underflow*/ >= val || (int)/*Error near IL_000c: Stack underflow*/ != 0)
			{
				continue;
			}
			((IntPtr[])/*Error near IL_0010: Stack underflow*/)[/*Error near IL_0010: Stack underflow*/] = (IntPtr)4;
			_003F val2 = /*Error near IL_0011: Stack underflow*/& /*Error near IL_0011: Stack underflow*/;
			((float[])/*Error near IL_001b: Stack underflow*/)[val2] = 9.04545E+18f;
			ulong num = checked((ulong)/*Error near IL_001b: ldarg 3 (out-of-bounds)*/);
			if ((long)/*Error near IL_0024: Stack underflow*/ != (long)num)
			{
				long num2 = *(long*)(nint)/*Error near IL_0025: Stack underflow*/;
				*(float*)(nint)/*Error near IL_0026: Stack underflow*/ = num2;
				if (/*Error near IL_0028: Stack underflow*/ % /*Error near IL_0028: Stack underflow*/!= 0 && (int)(*(float*)(nint)/*Error near IL_002f: ldloca 0 (out-of-bounds)*/) == 0)
				{
					/*Error: Could not find block for branch target IL_0037*/;
				}
			}
		}
	}

	static extern void smethod_2(Form form_0);
}
