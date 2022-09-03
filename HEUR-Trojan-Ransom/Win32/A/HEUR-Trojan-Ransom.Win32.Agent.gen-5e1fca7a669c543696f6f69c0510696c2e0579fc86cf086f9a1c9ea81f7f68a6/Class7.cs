using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

internal sealed class Class7 : Panel
{
	private Color color_0;

	private Color color_1;

	private Color color_2;

	private float float_0;

	public Class7()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		((Control)this).add_Paint(new PaintEventHandler(Class7_Paint));
	}

	private void Class7_Paint(object sender, PaintEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		if (((Control)sender).get_Name() == ((Control)this).get_Name() && !e.get_ClipRectangle().IsEmpty)
		{
			if (!method_4().IsEmpty)
			{
				Pen val = new Pen(method_4());
				e.get_Graphics().DrawRectangle(val, ((Control)this).get_ClientRectangle().Left, ((Control)this).get_ClientRectangle().Top, ((Control)this).get_ClientRectangle().Width - 1, ((Control)this).get_ClientRectangle().Height - 1);
			}
			if (!method_0().IsEmpty && !method_0().IsEmpty)
			{
				LinearGradientBrush val2 = new LinearGradientBrush(((Control)this).get_ClientRectangle(), method_0(), method_2(), method_6());
				e.get_Graphics().FillRegion((Brush)(object)val2, new Region(((Control)this).get_ClientRectangle()));
			}
		}
	}

	public Color method_0()
	{
		return color_0;
	}

	public void method_1(Color color_3)
	{
		color_0 = color_3;
	}

	public Color method_2()
	{
		return color_1;
	}

	public void method_3(Color color_3)
	{
		color_1 = color_3;
	}

	public Color method_4()
	{
		return color_2;
	}

	public void method_5(Color color_3)
	{
		color_2 = color_3;
	}

	public float method_6()
	{
		return float_0;
	}

	public void method_7(float float_1)
	{
		float_0 = float_1;
	}
}
