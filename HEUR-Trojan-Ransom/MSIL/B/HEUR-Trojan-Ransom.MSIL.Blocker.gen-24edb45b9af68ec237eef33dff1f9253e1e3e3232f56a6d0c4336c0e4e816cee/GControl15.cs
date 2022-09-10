using System.Drawing;
using System.Windows.Forms;

public class GControl15 : GControl14
{
	private Color color_2;

	private Color color_3;

	private Color color_4;

	private Color color_5;

	private Color color_6;

	private Color color_7;

	private bool bool_9;

	private Icon icon_0;

	public bool Boolean_5
	{
		get
		{
			return bool_9;
		}
		set
		{
			bool_9 = value;
			for (int num = 0; num == 0; num = 1)
			{
				((Control)this).Invalidate();
			}
		}
	}

	public Icon Icon_0
	{
		get
		{
			return icon_0;
		}
		set
		{
			icon_0 = value;
			for (int num = 0; num == 0; num = 1)
			{
				((Control)this).Invalidate();
			}
		}
	}

	public GControl15()
	{
		if (1 == 0)
		{
		}
		base._002Ector();
		Color_0 = Color.Fuchsia;
		method_5("BackColor", Color.FromArgb(33, 33, 33));
		method_5("BorderColor", Color.Black);
		method_5("InsetBorderColor", Color.FromArgb(72, 72, 72));
		method_5("TextColor", Color.White);
		method_5("TopGloss", Color.FromArgb(62, Color.White));
		method_5("BottomGloss", Color.FromArgb(30, Color.White));
		BackColor = Color.FromArgb(33, 33, 33);
		ForeColor = Color.White;
		Boolean_1 = false;
		bool_9 = false;
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
				color_7 = method_4("BottomGloss");
				num = 5;
				break;
			case 3:
				color_6 = method_4("TopGloss");
				num = 4;
				break;
			case 2:
				color_5 = method_4("TextColor");
				num = 3;
				break;
			case 1:
				color_4 = method_4("InsetBorderColor");
				num = 2;
				break;
			case 0:
				color_3 = method_4("BorderColor");
				num = 1;
				break;
			default:
				return;
			}
		}
	}

	protected override void vmethod_2()
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected O, but got Unknown
		graphics_0.Clear(Color.FromArgb(33, 33, 33));
		int num = 0;
		checked
		{
			while (true)
			{
				switch (num)
				{
				case 5:
					switch (bool_9)
					{
					default:
						return;
					case true:
						if (icon_0 != null)
						{
							Graphics obj2 = graphics_0;
							Icon obj3 = icon_0;
							Rectangle rectangle = new Rectangle(8, 6, 12, 12);
							obj2.DrawIcon(obj3, rectangle);
						}
						method_28((Brush)new SolidBrush(color_5), (HorizontalAlignment)0, 24, 0);
						num = 6;
						break;
					case false:
						method_28((Brush)new SolidBrush(color_5), (HorizontalAlignment)0, 8, 0);
						return;
					}
					break;
				case 4:
					method_19(Color_0);
					num = 5;
					break;
				case 3:
					method_26(new Pen((Brush)new SolidBrush(color_3)));
					num = 4;
					break;
				case 2:
				{
					Color color = color_6;
					Color color2 = color_7;
					Rectangle rectangle = new Rectangle(1, 1, ((Control)this).get_Width() - 2, 13);
					method_45(color, color2, rectangle, 90f);
					num = 3;
					break;
				}
				case 1:
					method_23(new Pen((Brush)new SolidBrush(color_4)), 1);
					num = 2;
					break;
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
