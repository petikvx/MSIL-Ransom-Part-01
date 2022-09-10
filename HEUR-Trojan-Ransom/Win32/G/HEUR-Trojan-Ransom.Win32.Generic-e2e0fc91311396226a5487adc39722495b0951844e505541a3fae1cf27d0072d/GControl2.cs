using System;
using System.Drawing;
using System.Windows.Forms;

public abstract class GControl2 : TabControl
{
	public Rectangle rectangle_0;

	public Rectangle rectangle_1;

	public static int int_0;

	private static int int_1;

	public extern bool Boolean_0 { get; }

	public int Int32_0
	{
		get; set
		{
			//Discarded unreachable code: IL_000e, IL_0014, IL_001a
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Incompatible stack heights: 0 vs 1
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			while (true)
			{
				_003F val = /*Error near IL_0001: Stack underflow*/% /*Error near IL_0001: Stack underflow*/;
				checked
				{
					if (/*Error near IL_0006: Stack underflow*/ <= val)
					{
						_ = (byte)(/*Error near IL_0007: Stack underflow*/ << unchecked((int)/*Error near IL_0007: Stack underflow*/));
					}
				}
			}
		}
	}

	protected override extern void OnCreateControl();

	protected override extern void OnControlAdded(ControlEventArgs e);

	protected GControl2()
	{
		//IL_0003: Expected O, but got I4
		_ = -1;
		_ = 1;
		/*Error near IL_0002: Invalid metadata token*/;
	}

	protected unsafe override void OnMouseMove(MouseEventArgs e)
	{
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		throw checked((nuint)/*Error near IL_0002: Stack underflow*/);
	}

	protected override extern void OnMouseLeave(EventArgs e);

	static extern Font smethod_0(string string_0, float float_0);

	static extern void smethod_1(Control control_0, Font font_0);

	static extern int smethod_2(TabPageCollection tabPageCollection_0);
}
