using System;
using System.Windows.Forms;

internal static class Class5
{
	[STAThread]
	private static extern void Main();

	static void smethod_0()
	{
		//Discarded unreachable code: IL_000a, IL_000e, IL_0013, IL_001b
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got I4
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			ulong num = (ulong)/*Error near IL_0001: Stack underflow*/;
			_ = (uint)(/*Error near IL_0003: Stack underflow*/ * num);
			_ = 3;
			/*Error near IL_0005: Invalid metadata token*/;
		}
	}

	static extern void smethod_1(bool bool_0);

	static extern void smethod_2(Form form_0);
}
