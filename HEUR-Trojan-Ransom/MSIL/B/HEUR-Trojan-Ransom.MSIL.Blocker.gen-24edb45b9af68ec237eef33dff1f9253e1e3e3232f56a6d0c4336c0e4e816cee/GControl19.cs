using System;
using System.Drawing;
using System.Windows.Forms;

public class GControl19 : GControl17
{
	private Color color_1;

	private Color color_2;

	private Color color_3;

	private Color color_4;

	private Color color_5;

	private Color color_6;

	private Color color_7;

	private Color color_8;

	public GControl19()
	{
		if (1 == 0)
		{
		}
		base._002Ector();
		BackColor = Color.FromArgb(33, 33, 33);
		Size size = new Size(20, 20);
		((Control)this).set_Size(size);
		Int32_1 = 20;
		Int32_0 = 20;
		method_3("BackColor", Color.FromArgb(47, 47, 47));
		method_3("BorderColor", Color.FromArgb(70, 70, 70));
		method_3("InsetBorderColor2", Color.FromArgb(72, 72, 72));
		method_3("InsetBorderColor", Color.Black);
		method_3("TopGloss", Color.FromArgb(62, Color.White));
		method_3("BottomGloss", Color.FromArgb(30, Color.White));
		method_3("TopInset", Color.FromArgb(45, 45, 45));
		method_3("ButtonClickColor", Color.FromArgb(44, 44, 44));
	}

	protected override void vmethod_1()
	{
		color_1 = method_2("BackColor");
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 6:
				color_8 = method_2("ButtonClickColor");
				num = 7;
				break;
			case 5:
				color_7 = method_2("TopInset");
				num = 6;
				break;
			case 4:
				color_6 = method_2("InsetBorderColor");
				num = 5;
				break;
			case 3:
				color_5 = method_2("BorderColor");
				num = 4;
				break;
			case 2:
				color_4 = method_2("BottomGloss");
				num = 3;
				break;
			case 1:
				color_3 = method_2("TopGloss");
				num = 2;
				break;
			case 0:
				color_2 = method_2("InsetBorderColor2");
				num = 1;
				break;
			default:
				return;
			}
		}
	}

	protected override void vmethod_2()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected O, but got Unknown
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected O, but got Unknown
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected O, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected O, but got Unknown
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected O, but got Unknown
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected O, but got Unknown
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Expected O, but got Unknown
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Expected O, but got Unknown
		graphics_0.Clear(BackColor);
		int num = 0;
		checked
		{
			while (true)
			{
				switch (num)
				{
				case 12:
				{
					Color backColor = BackColor;
					Rectangle rectangle = new Rectangle(1, 1, ((Control)this).get_Width() - 2, ((Control)this).get_Height() - 2);
					method_18(backColor, rectangle);
					num = 13;
					break;
				}
				case 11:
					graphics_0.DrawLine(new Pen((Brush)new SolidBrush(color_7)), ((Control)this).get_Width() - 1, unchecked(((Control)this).get_Height() / 2), ((Control)this).get_Width() - 1, ((Control)this).get_Height());
					num = 12;
					break;
				case 10:
					graphics_0.DrawLine(new Pen((Brush)new SolidBrush(color_7)), 0, unchecked(((Control)this).get_Height() / 2), 0, ((Control)this).get_Height());
					num = 11;
					break;
				case 9:
					method_24(new Pen((Brush)new SolidBrush(color_5)));
					num = 10;
					break;
				case 8:
				{
					Color color5 = color_4;
					Color color6 = color_4;
					Rectangle rectangle = new Rectangle(1, 1, ((Control)this).get_Width() - 2, (int)Math.Round((double)((Control)this).get_Height() / 2.0 - 2.0));
					method_43(color5, color6, rectangle, 90f);
					goto case 3;
				}
				case 3:
				case 6:
					method_21(new Pen((Brush)new SolidBrush(color_6)), 1);
					num = 9;
					break;
				case 7:
					method_21(new Pen((Brush)new SolidBrush(color_2)), 2);
					num = 8;
					break;
				case 5:
				{
					Color color3 = color_3;
					Color color4 = color_4;
					Rectangle rectangle = new Rectangle(1, 1, ((Control)this).get_Width() - 2, (int)Math.Round((double)((Control)this).get_Height() / 2.0 - 2.0));
					method_43(color3, color4, rectangle, 90f);
					num = 6;
					break;
				}
				case 4:
					method_21(new Pen((Brush)new SolidBrush(color_2)), 2);
					num = 5;
					break;
				case 2:
				{
					Color color = color_3;
					Color color2 = color_4;
					Rectangle rectangle = new Rectangle(1, 1, ((Control)this).get_Width() - 2, (int)Math.Round((double)((Control)this).get_Height() / 2.0 - 2.0));
					method_43(color, color2, rectangle, 90f);
					num = 3;
					break;
				}
				case 1:
					method_21(new Pen((Brush)new SolidBrush(color_2)), 2);
					num = 2;
					break;
				case 0:
					switch (genum1_0)
					{
					case GEnum1.const_0:
					{
						Graphics obj3 = graphics_0;
						SolidBrush val3 = new SolidBrush(color_1);
						Rectangle rectangle = new Rectangle(1, 1, ((Control)this).get_Width() - 2, ((Control)this).get_Height() - 2);
						obj3.FillRectangle((Brush)val3, rectangle);
						num = 1;
						goto end_IL_02e5;
					}
					case GEnum1.const_1:
					{
						Graphics obj2 = graphics_0;
						SolidBrush val2 = new SolidBrush(color_1);
						Rectangle rectangle = new Rectangle(1, 1, ((Control)this).get_Width() - 2, ((Control)this).get_Height() - 2);
						obj2.FillRectangle((Brush)val2, rectangle);
						num = 4;
						goto end_IL_02e5;
					}
					case GEnum1.const_2:
					{
						Graphics obj = graphics_0;
						SolidBrush val = new SolidBrush(color_8);
						Rectangle rectangle = new Rectangle(1, 1, ((Control)this).get_Width() - 2, ((Control)this).get_Height() - 2);
						obj.FillRectangle((Brush)val, rectangle);
						num = 7;
						goto end_IL_02e5;
					}
					}
					goto case 3;
				default:
					return;
					end_IL_02e5:
					break;
				}
			}
		}
	}
}
