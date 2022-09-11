using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public class GControl14 : Control
{
	public delegate void GDelegate5(object sender);

	protected bool bool_0;

	protected GClass1.GEnum3 genum3_0;

	[CompilerGenerated]
	private GDelegate5 gdelegate5_0;

	private Color color_0;

	public extern bool Boolean_0 { get; set; }

	public extern Color Color_0 { get; set; }

	public event GDelegate5 Event_0
	{
		[CompilerGenerated]
		add
		{
			while (true)
			{
				if (/*Error near IL_0005: Stack underflow*/ == /*Error near IL_0005: Stack underflow*/)
				{
					/*Error: Could not find block for branch target IL_0005*/;
				}
			}
		}
		[CompilerGenerated]
		remove;
	}

	protected override void vmethod_0(EventArgs eventArgs_0)
	{
	}

	protected override extern void vmethod_1(PaintEventArgs paintEventArgs_0);

	public extern GControl14();

	protected override extern void vmethod_2(EventArgs eventArgs_0);

	protected override extern void vmethod_3();

	protected override extern void vmethod_4(EventArgs eventArgs_0);

	protected override extern void vmethod_5(EventArgs eventArgs_0);

	protected override void vmethod_6(EventArgs eventArgs_0)
	{
		//Discarded unreachable code: IL_000a
		/*Error: ldarg 2 (out-of-bounds)*/;
		/*Error near IL_0005: Invalid metadata token*/;
	}

	protected override extern void vmethod_7(EventArgs eventArgs_0);
}
