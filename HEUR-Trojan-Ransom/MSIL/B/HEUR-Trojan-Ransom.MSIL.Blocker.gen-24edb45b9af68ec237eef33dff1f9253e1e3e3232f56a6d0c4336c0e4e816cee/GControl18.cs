using System;
using System.Drawing;
using System.Windows.Forms;

public class GControl18 : GControl17
{
	private Color color_1;

	private Color color_2;

	private Color color_3;

	private Color color_4;

	private Color color_5;

	private Color color_6;

	private Color color_7;

	private Color color_8;

	private Color color_9;

	public GControl18()
	{
		if (1 == 0)
		{
		}
		base._002Ector();
		BackColor = Color.FromArgb(33, 33, 33);
		method_3("ButtonFillColor", Color.FromArgb(47, 47, 47));
		method_3("ButtonClickColor", Color.FromArgb(44, 44, 44));
		method_3("InsetBorderColor", Color.FromArgb(72, 72, 72));
		method_3("TopGloss", Color.FromArgb(62, Color.White));
		method_3("BottomGloss", Color.FromArgb(30, Color.White));
		method_3("TopInset", Color.FromArgb(45, 45, 45));
		method_3("BottomInset", Color.FromArgb(70, 70, 70));
		method_3("BorderColor", Color.Black);
		method_3("TextColor", Color.White);
	}

	protected override void vmethod_1()
	{
		color_1 = method_2("ButtonFillColor");
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 7:
				color_9 = method_2("ButtonClickColor");
				num = 8;
				break;
			case 6:
				color_8 = method_2("TextColor");
				num = 7;
				break;
			case 5:
				color_7 = method_2("BorderColor");
				num = 6;
				break;
			case 4:
				color_6 = method_2("BottomInset");
				num = 5;
				break;
			case 3:
				color_5 = method_2("TopInset");
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
				color_2 = method_2("InsetBorderColor");
				num = 1;
				break;
			default:
				return;
			}
		}
	}

	protected override void vmethod_2()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected O, but got Unknown
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected O, but got Unknown
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected O, but got Unknown
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected O, but got Unknown
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected O, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected O, but got Unknown
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected O, but got Unknown
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected O, but got Unknown
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Expected O, but got Unknown
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Expected O, but got Unknown
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Expected O, but got Unknown
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected O, but got Unknown
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Expected O, but got Unknown
		graphics_0.Clear(BackColor);
		int num = 0;
		checked
		{
			while (true)
			{
				switch (num)
				{
				case 15:
					method_26((Brush)new SolidBrush(color_8), (HorizontalAlignment)2, 0, 0);
					num = 16;
					break;
				case 14:
				{
					Color backColor = BackColor;
					Rectangle rectangle = new Rectangle(1, 1, ((Control)this).get_Width() - 2, ((Control)this).get_Height() - 2);
					method_18(backColor, rectangle);
					num = 15;
					break;
				}
				case 13:
					method_17(BackColor);
					num = 14;
					break;
				case 12:
					graphics_0.DrawLine(new Pen((Brush)new SolidBrush(color_6)), 0, ((Control)this).get_Height() - 1, ((Control)this).get_Width(), ((Control)this).get_Height() - 1);
					num = 13;
					break;
				case 11:
					graphics_0.DrawLine(new Pen((Brush)new SolidBrush(color_5)), ((Control)this).get_Width() - 1, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height());
					num = 12;
					break;
				case 10:
					graphics_0.DrawLine(new Pen((Brush)new SolidBrush(color_5)), 0, 0, 0, ((Control)this).get_Height());
					num = 11;
					break;
				case 9:
					graphics_0.DrawLine(new Pen((Brush)new SolidBrush(color_5)), 0, 0, ((Control)this).get_Width(), 0);
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
					method_21(new Pen((Brush)new SolidBrush(color_7)), 1);
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
						goto end_IL_034c;
					}
					case GEnum1.const_1:
					{
						Graphics obj2 = graphics_0;
						SolidBrush val2 = new SolidBrush(color_1);
						Rectangle rectangle = new Rectangle(1, 1, ((Control)this).get_Width() - 2, ((Control)this).get_Height() - 2);
						obj2.FillRectangle((Brush)val2, rectangle);
						num = 4;
						goto end_IL_034c;
					}
					case GEnum1.const_2:
					{
						Graphics obj = graphics_0;
						SolidBrush val = new SolidBrush(color_9);
						Rectangle rectangle = new Rectangle(1, 1, ((Control)this).get_Width() - 2, ((Control)this).get_Height() - 2);
						obj.FillRectangle((Brush)val, rectangle);
						num = 7;
						goto end_IL_034c;
					}
					}
					goto case 3;
				default:
					return;
					end_IL_034c:
					break;
				}
			}
		}
	}
}
