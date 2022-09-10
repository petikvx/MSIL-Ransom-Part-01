using System.Drawing;
using System.Windows.Forms;

namespace ns0;

internal sealed class Class1
{
	private int int_0;

	private Rectangle rectangle_0;

	private Rectangle rectangle_1;

	internal Form form_0;

	internal Delegate0 delegate0_0;

	internal Rectangle rectangle_2;

	internal Rectangle rectangle_3;

	internal Rectangle rectangle_4;

	internal Rectangle rectangle_5;

	internal Rectangle rectangle_6;

	public Rectangle Rectangle_0 => rectangle_0;

	public Rectangle Rectangle_1 => rectangle_2;

	public Rectangle Rectangle_2 => rectangle_3;

	public int Int32_0 => int_0;

	public Rectangle Rectangle_3 => rectangle_1;

	public Rectangle Rectangle_4 => rectangle_4;

	public Rectangle Rectangle_5 => rectangle_5;

	public bool Boolean_0 => form_0.get_ControlBox();

	public bool Boolean_1 => method_0();

	public bool Boolean_2 => method_1();

	public Rectangle Rectangle_6 => rectangle_6;

	public Class1(Form form_1, Delegate0 delegate0_1)
	{
		Form val = (form_0 = form_1);
		Delegate0 @delegate = (delegate0_0 = delegate0_1);
	}

	private bool method_0()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Invalid comparison between Unknown and I4
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Invalid comparison between Unknown and I4
		if (form_0.get_ControlBox() && form_0.get_ShowIcon())
		{
			if ((int)form_0.get_FormBorderStyle() == 5)
			{
				return false;
			}
			return (int)form_0.get_FormBorderStyle() != 6;
		}
		return false;
	}

	private bool method_1()
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Invalid comparison between Unknown and I4
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Invalid comparison between Unknown and I4
		if (form_0.get_ControlBox() && (form_0.get_MinimizeBox() || form_0.get_MaximizeBox()))
		{
			if ((int)form_0.get_FormBorderStyle() == 5)
			{
				return false;
			}
			return (int)form_0.get_FormBorderStyle() != 6;
		}
		return false;
	}

	public void method_2()
	{
	}
}
