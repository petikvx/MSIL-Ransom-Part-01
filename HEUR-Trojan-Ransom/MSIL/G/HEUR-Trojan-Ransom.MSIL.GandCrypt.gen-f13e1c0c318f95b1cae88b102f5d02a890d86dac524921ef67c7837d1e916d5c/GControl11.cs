using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public class GControl11 : Control
{
	public delegate void GDelegate3(object sender);

	[StructLayout(LayoutKind.Auto)]
	internal struct Struct6
	{
		internal Color color_0;
	}

	internal sealed class Class12
	{
		internal Enum0 enum0_0;

		internal bool bool_0;

		internal Color color_0;

		internal Class12()
		{
			while ((int)/*Error near IL_0001: ldloc 0 (out-of-bounds)*/ == 0)
			{
			}
			/*Error: Unexpected end of block*/;
		}
	}

	private static bool bool_0;

	[CompilerGenerated]
	private GDelegate3 gdelegate3_0;

	private GControl18.Struct7 struct7_0;

	public bool Boolean_0
	{
		get
		{
			/*OpCode not supported: Ckfinite*/;
			/*Error: Unexpected end of block*/;
		}
		set; }

	public extern Color Color_0 { get; set; }

	public extern Color Color_1 { get; set; }

	public extern event GDelegate3 Event_0;

	public extern GControl11();

	protected override extern void vmethod_0(PaintEventArgs paintEventArgs_0);

	protected override extern void vmethod_1(EventArgs eventArgs_0);

	protected override extern void vmethod_2(EventArgs eventArgs_0);
}
