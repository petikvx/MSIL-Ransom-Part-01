using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public class GControl6 : Control
{
	public delegate void GDelegate1(object sender);

	[CompilerGenerated]
	private GDelegate1 gdelegate1_0;

	private GControl11.Class12 class12_0;

	public extern bool Boolean_0 { get; set; }

	public Color Color_0
	{
		get
		{
			while (true)
			{
				_003F val = /*Error: Stack underflow*/;
				if (((byte[])/*Error near IL_0002: Stack underflow*/)[val] != 0)
				{
					/*Error: Could not find block for branch target IL_0008*/;
				}
			}
		}
		set; }

	public extern event GDelegate1 Event_0;

	protected override extern void vmethod_0(EventArgs eventArgs_0);

	protected override extern void vmethod_1(MouseEventArgs mouseEventArgs_0);

	protected override extern void vmethod_2(EventArgs eventArgs_0);

	protected unsafe override void vmethod_3(MouseEventArgs mouseEventArgs_0)
	{
		//Discarded unreachable code: IL_000a, IL_000f, IL_0014, IL_001f, IL_0026, IL_002c
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got I
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected I4, but got Unknown
		checked
		{
			nuint num = (nuint)(*unchecked((uint*)(nint)/*Error near IL_0001: Stack underflow*/));
			_ = (nint)unchecked((int)(*(byte*)(nint)checked(/*Error near IL_0003: Stack underflow*/ * num)));
			/*Error near IL_0005: Invalid metadata token*/;
		}
	}

	protected override extern void vmethod_4(EventArgs eventArgs_0);

	protected override extern void vmethod_5(EventArgs eventArgs_0);

	protected override extern void vmethod_6(EventArgs eventArgs_0);

	public extern GControl6();

	protected override extern void vmethod_7(PaintEventArgs paintEventArgs_0);
}
