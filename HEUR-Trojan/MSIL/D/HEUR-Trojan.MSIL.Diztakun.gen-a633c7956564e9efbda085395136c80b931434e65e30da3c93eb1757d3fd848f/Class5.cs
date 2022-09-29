using System;
using System.Windows.Forms;

internal static class Class5
{
	[STAThread]
	private static void Main()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		_003F val = checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		throw /*Error near IL_0002: Stack underflow*/- val;
	}

	static extern void smethod_0();

	static extern void smethod_1(bool bool_0);

	static extern void smethod_2(Form form_0);
}
