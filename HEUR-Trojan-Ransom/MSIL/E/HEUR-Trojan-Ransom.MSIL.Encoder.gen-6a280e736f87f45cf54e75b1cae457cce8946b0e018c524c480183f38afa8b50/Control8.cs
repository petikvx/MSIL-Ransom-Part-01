using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

internal class Control8 : Control3
{
	private Orientation orientation_0;

	[SpecialName]
	public Orientation method_77()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		return orientation_0;
	}

	[SpecialName]
	public void method_78(Orientation orientation_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		orientation_0 = orientation_1;
		if ((int)orientation_1 == 1)
		{
			method_15(0);
			method_13(14);
		}
		else
		{
			method_15(14);
			method_13(0);
		}
		((Control)this).Invalidate();
	}

	public Control8()
	{
		Class14.vPNVHkezq0oMI();
		base._002Ector();
		method_6(bool_5: true);
		BackColor = Color.Transparent;
		method_15(10);
	}

	protected override void ColorHook()
	{
	}

	protected override void PaintHook()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Invalid comparison between Unknown and I4
		graphics_0.Clear(BackColor);
		ColorBlend val = new ColorBlend();
		ColorBlend val2 = new ColorBlend();
		val.set_Positions(new float[4] { 0f, 0.15f, 0.85f, 1f });
		val2.set_Positions(new float[5] { 0f, 0.15f, 0.5f, 0.85f, 1f });
		val.set_Colors(new Color[4]
		{
			Color.Transparent,
			Color.Black,
			Color.Black,
			Color.Transparent
		});
		val2.set_Colors(new Color[5]
		{
			Color.Transparent,
			Color.FromArgb(35, 35, 35),
			Color.FromArgb(45, 45, 45),
			Color.FromArgb(35, 35, 35),
			Color.Transparent
		});
		if ((int)orientation_0 == 1)
		{
			method_58(val2, 6, 0, 1, ((Control)this).get_Height());
			method_58(val, 7, 0, 1, ((Control)this).get_Height());
		}
		else
		{
			method_59(val2, 0, 6, ((Control)this).get_Width(), 1, 0f);
			method_59(val, 0, 7, ((Control)this).get_Width(), 1, 0f);
		}
	}
}
