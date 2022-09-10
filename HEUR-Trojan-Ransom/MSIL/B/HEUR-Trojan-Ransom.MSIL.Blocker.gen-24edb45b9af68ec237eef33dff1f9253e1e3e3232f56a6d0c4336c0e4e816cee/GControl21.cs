using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

[DefaultEvent("CheckedChanged")]
public class GControl21 : GControl17
{
	public delegate void GDelegate4(object sender);

	private Color color_1;

	private Color color_2;

	private Color color_3;

	private Color color_4;

	private Color color_5;

	private Color color_6;

	private Color color_7;

	private Color color_8;

	private Color color_9;

	private Color color_10;

	private Color color_11;

	private Color color_12;

	private bool bool_2;

	private GDelegate4 gdelegate4_0;

	public bool Boolean_2
	{
		get
		{
			return bool_2;
		}
		set
		{
			bool_2 = value;
			for (int num = 0; num == 0; num = 1)
			{
				((Control)this).Invalidate();
			}
		}
	}

	public event GDelegate4 Event_0
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			if (1 == 0)
			{
			}
			gdelegate4_0 = (GDelegate4)Delegate.Combine(gdelegate4_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			if (1 == 0)
			{
			}
			gdelegate4_0 = (GDelegate4)Delegate.Remove(gdelegate4_0, value);
		}
	}

	public GControl21()
	{
		if (1 == 0)
		{
		}
		base._002Ector();
		BackColor = Color.FromArgb(37, 37, 37);
		Int32_0 = 50;
		Int32_1 = 20;
		Boolean_2 = false;
		method_3("OnGradientA", Color.FromArgb(63, 83, 100));
		method_3("OnGradientB", Color.FromArgb(87, 127, 151));
		method_3("OffGradientA", Color.FromArgb(23, 23, 23));
		method_3("OffGradientB", Color.FromArgb(33, 33, 33));
		method_3("SwitchColor", Color.FromArgb(25, 25, 25));
		method_3("TopGloss", Color.FromArgb(62, Color.White));
		method_3("BottomGloss", Color.FromArgb(30, Color.White));
		method_3("SwitchBorder", Color.Black);
		method_3("SwitchInsetBorder", Color.FromArgb(47, 47, 47));
		method_3("BorderColor", Color.Black);
		method_3("TopInset", Color.FromArgb(45, 45, 45));
		method_3("BottomInset", Color.FromArgb(70, 70, 70));
	}

	protected override void vmethod_1()
	{
		color_1 = method_2("OnGradientA");
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 10:
				color_12 = method_2("BottomInset");
				num = 11;
				break;
			case 9:
				color_11 = method_2("TopInset");
				num = 10;
				break;
			case 8:
				color_10 = method_2("BorderColor");
				num = 9;
				break;
			case 7:
				color_9 = method_2("SwitchInsetBorder");
				num = 8;
				break;
			case 6:
				color_8 = method_2("SwitchBorder");
				num = 7;
				break;
			case 5:
				color_7 = method_2("BottomGloss");
				num = 6;
				break;
			case 4:
				color_6 = method_2("TopGloss");
				num = 5;
				break;
			case 3:
				color_5 = method_2("SwitchColor");
				num = 4;
				break;
			case 2:
				color_4 = method_2("OffGradientB");
				num = 3;
				break;
			case 1:
				color_3 = method_2("OffGradientA");
				num = 2;
				break;
			case 0:
				color_2 = method_2("OnGradientB");
				num = 1;
				break;
			default:
				return;
			}
		}
	}

	protected override void vmethod_2()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected O, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected O, but got Unknown
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected O, but got Unknown
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected O, but got Unknown
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected O, but got Unknown
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Expected O, but got Unknown
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected O, but got Unknown
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Expected O, but got Unknown
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected O, but got Unknown
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Expected O, but got Unknown
		graphics_0.Clear(BackColor);
		int num = 0;
		checked
		{
			while (true)
			{
				switch (num)
				{
				case 17:
					method_17(BackColor);
					num = 18;
					break;
				case 16:
					method_21(new Pen((Brush)new SolidBrush(color_10)), 1);
					num = 17;
					break;
				case 15:
					graphics_0.DrawLine(new Pen((Brush)new SolidBrush(color_12)), 0, ((Control)this).get_Height() - 1, ((Control)this).get_Width(), ((Control)this).get_Height() - 1);
					num = 16;
					break;
				case 14:
					graphics_0.DrawLine(new Pen((Brush)new SolidBrush(color_11)), ((Control)this).get_Width() - 1, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height());
					num = 15;
					break;
				case 13:
					graphics_0.DrawLine(new Pen((Brush)new SolidBrush(color_11)), 0, 0, 0, ((Control)this).get_Height());
					num = 14;
					break;
				case 12:
					graphics_0.DrawLine(new Pen((Brush)new SolidBrush(color_11)), 0, 0, ((Control)this).get_Width(), 0);
					num = 13;
					break;
				case 11:
					graphics_0.DrawString("OFF", Font, Brushes.get_White(), 22f, 3f);
					goto case 6;
				case 6:
				{
					Color backColor = BackColor;
					Rectangle rectangle = new Rectangle(1, 2, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 4);
					method_18(backColor, rectangle);
					num = 12;
					break;
				}
				case 10:
				{
					Color color3 = color_6;
					Color color4 = color_7;
					Rectangle rectangle = new Rectangle(1, 1, 19, (int)Math.Round((double)((Control)this).get_Height() / 2.0 - 2.0));
					method_43(color3, color4, rectangle, 90f);
					num = 11;
					break;
				}
				case 9:
				{
					Graphics obj6 = graphics_0;
					Pen val6 = new Pen((Brush)new SolidBrush(color_9));
					Rectangle rectangle = new Rectangle(2, 2, 17, ((Control)this).get_Height() - 5);
					obj6.DrawRectangle(val6, rectangle);
					num = 10;
					break;
				}
				case 8:
				{
					Graphics obj5 = graphics_0;
					Pen val5 = new Pen((Brush)new SolidBrush(color_8));
					Rectangle rectangle = new Rectangle(0, 0, 20, ((Control)this).get_Height() - 1);
					obj5.DrawRectangle(val5, rectangle);
					num = 9;
					break;
				}
				case 7:
				{
					Graphics obj4 = graphics_0;
					SolidBrush val4 = new SolidBrush(color_5);
					Rectangle rectangle = new Rectangle(1, 1, 20, ((Control)this).get_Height() - 1);
					obj4.FillRectangle((Brush)val4, rectangle);
					num = 8;
					break;
				}
				case 5:
					graphics_0.DrawString("ON", Font, Brushes.get_White(), 6f, 3f);
					num = 6;
					break;
				case 4:
				{
					Color color = color_6;
					Color color2 = color_7;
					Rectangle rectangle = new Rectangle(((Control)this).get_Width() - 19, 2, 17, (int)Math.Round((double)((Control)this).get_Height() / 2.0 - 2.0));
					method_43(color, color2, rectangle, 90f);
					num = 5;
					break;
				}
				case 3:
				{
					Graphics obj3 = graphics_0;
					Pen val3 = new Pen((Brush)new SolidBrush(color_9));
					Rectangle rectangle = new Rectangle(((Control)this).get_Width() - 19, 1, 16, ((Control)this).get_Height() - 4);
					obj3.DrawRectangle(val3, rectangle);
					num = 4;
					break;
				}
				case 2:
				{
					Graphics obj2 = graphics_0;
					Pen val2 = new Pen((Brush)new SolidBrush(color_8));
					Rectangle rectangle = new Rectangle(((Control)this).get_Width() - 20, 0, 20, ((Control)this).get_Height() - 1);
					obj2.DrawRectangle(val2, rectangle);
					num = 3;
					break;
				}
				case 1:
				{
					Graphics obj = graphics_0;
					SolidBrush val = new SolidBrush(color_5);
					Rectangle rectangle = new Rectangle(((Control)this).get_Width() - 19, 1, 17, ((Control)this).get_Height() - 4);
					obj.FillRectangle((Brush)val, rectangle);
					num = 2;
					break;
				}
				case 0:
					switch (Boolean_2)
					{
					case false:
						method_43(color_3, color_4, ((Control)this).get_ClientRectangle(), 90f);
						num = 7;
						goto end_IL_03cb;
					case true:
						method_43(color_1, color_2, ((Control)this).get_ClientRectangle(), 90f);
						num = 1;
						goto end_IL_03cb;
					}
					goto case 6;
				default:
					return;
					end_IL_03cb:
					break;
				}
			}
		}
	}

	protected override void OnClick(EventArgs e)
	{
		bool_2 = !bool_2;
		int num = 0;
		GDelegate4 gDelegate = default(GDelegate4);
		while (true)
		{
			switch (num)
			{
			case 1:
				gDelegate?.Invoke(this);
				((Control)this).OnClick(e);
				num = 2;
				break;
			case 0:
				gDelegate = gdelegate4_0;
				num = 1;
				break;
			default:
				return;
			}
		}
	}
}
