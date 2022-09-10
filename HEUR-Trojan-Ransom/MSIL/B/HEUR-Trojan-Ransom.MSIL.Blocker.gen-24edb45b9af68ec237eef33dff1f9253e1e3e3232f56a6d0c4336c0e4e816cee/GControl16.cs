using System.Drawing;
using System.Windows.Forms;

public class GControl16 : GControl14
{
	private Color color_2;

	private Color color_3;

	private Color color_4;

	private Color color_5;

	private Color color_6;

	private Color color_7;

	public GControl16()
	{
		if (1 == 0)
		{
		}
		base._002Ector();
		Boolean_2 = true;
		((Control)this).set_Dock((DockStyle)0);
		Size size = new Size(180, 200);
		((Control)this).set_Size(size);
		BackColor = Color.FromArgb(37, 37, 37);
		method_5("BackColor", Color.FromArgb(37, 37, 37));
		method_5("HeaderColor", Color.FromArgb(32, 32, 32));
		method_5("TextColor", Color.White);
		method_5("BorderColor", Color.Black);
		method_5("TopInset", Color.FromArgb(45, 45, 45));
		method_5("BottomInset", Color.FromArgb(70, 70, 70));
	}

	protected override void vmethod_1()
	{
		color_2 = method_4("BackColor");
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 4:
				color_7 = method_4("BottomInset");
				num = 5;
				break;
			case 3:
				color_6 = method_4("TopInset");
				num = 4;
				break;
			case 2:
				color_5 = method_4("BorderColor");
				num = 3;
				break;
			case 1:
				color_4 = method_4("TextColor");
				num = 2;
				break;
			case 0:
				color_3 = method_4("HeaderColor");
				num = 1;
				break;
			default:
				return;
			}
		}
	}

	protected override void vmethod_2()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected O, but got Unknown
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected O, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected O, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected O, but got Unknown
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected O, but got Unknown
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected O, but got Unknown
		graphics_0.Clear(Color.FromArgb(37, 37, 37));
		int num = 0;
		checked
		{
			while (true)
			{
				switch (num)
				{
				case 11:
					method_28((Brush)new SolidBrush(color_4), (HorizontalAlignment)2, 0, 0);
					num = 12;
					break;
				case 10:
				{
					Color backColor = BackColor;
					Rectangle rectangle = new Rectangle(1, 1, ((Control)this).get_Width() - 2, ((Control)this).get_Height() - 2);
					method_20(backColor, rectangle);
					num = 11;
					break;
				}
				case 9:
					method_19(BackColor);
					num = 10;
					break;
				case 8:
					graphics_0.DrawLine(new Pen((Brush)new SolidBrush(color_6)), ((Control)this).get_Width() - 1, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height());
					num = 9;
					break;
				case 7:
					graphics_0.DrawLine(new Pen((Brush)new SolidBrush(color_6)), 0, 0, 0, ((Control)this).get_Height());
					num = 8;
					break;
				case 6:
					graphics_0.DrawLine(new Pen((Brush)new SolidBrush(color_6)), 0, 0, ((Control)this).get_Width(), 0);
					num = 7;
					break;
				case 5:
					method_26(new Pen((Brush)new SolidBrush(color_7)));
					num = 6;
					break;
				case 4:
					method_23(new Pen((Brush)new SolidBrush(color_5)), 1);
					num = 5;
					break;
				case 3:
					graphics_0.DrawLine(new Pen((Brush)new SolidBrush(color_6)), 0, 22, ((Control)this).get_Width(), 22);
					num = 4;
					break;
				case 2:
					graphics_0.DrawLine(Pens.get_Black(), 0, 21, ((Control)this).get_Width(), 21);
					num = 3;
					break;
				case 1:
				{
					Graphics obj2 = graphics_0;
					SolidBrush val2 = new SolidBrush(color_3);
					Rectangle rectangle = new Rectangle(1, 1, ((Control)this).get_Width() - 2, 20);
					obj2.FillRectangle((Brush)val2, rectangle);
					num = 2;
					break;
				}
				case 0:
				{
					Graphics obj = graphics_0;
					SolidBrush val = new SolidBrush(color_2);
					Rectangle rectangle = new Rectangle(1, 1, ((Control)this).get_Width() - 2, ((Control)this).get_Height() - 2);
					obj.FillRectangle((Brush)val, rectangle);
					num = 1;
					break;
				}
				default:
					return;
				}
			}
		}
	}
}
