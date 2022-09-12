using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

public sealed class GForm2 : Form
{
	private sealed class Class1
	{
		public Class1()
		{
			//Discarded unreachable code: IL_0005, IL_000c, IL_000e, IL_0014, IL_0019, IL_001e, IL_0029, IL_002f
			//IL_0007: Expected I4, but got F8
			//IL_0010: Expected O, but got I4
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Incompatible stack heights: 0 vs 1
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Unsupported input type for neg.
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			/*Error: Invalid metadata token*/;
		}

		internal static extern Assembly smethod_0();
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Assembly assembly_0;

	private IContainer icontainer_0;

	public extern GForm2();

	internal extern Assembly method_0();

	internal extern void method_1(Assembly assembly_1);

	protected override extern void Dispose(bool disposing);

	private void method_2()
	{
		//Discarded unreachable code: IL_0017, IL_001e
		//IL_0005: Invalid comparison between Unknown and I4
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Incompatible stack heights: 0 vs 1
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			uint num = checked((uint)(float)/*Error near IL_0001: Stack underflow*/);
			ushort num2 = ((ushort[])/*Error near IL_0005: Stack underflow*/)[num];
			if ((int)/*Error near IL_000a: Stack underflow*/ < (int)num2)
			{
				_003F val = /*Error near IL_000b: Stack underflow*// /*Error near IL_000b: Stack underflow*/;
				if (/*Error near IL_0010: Stack underflow*/ <= val)
				{
					_ = (int)/*Error near IL_0011: Stack underflow*/;
				}
			}
		}
	}
}
