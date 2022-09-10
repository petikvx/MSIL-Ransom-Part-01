using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class GControl3 : GControl2
{
	private bool bool_6;

	private Color color_0;

	private int int_2;

	public bool Boolean_3
	{
		get
		{
			if (1 == 0)
			{
			}
			return bool_6;
		}
		set
		{
			bool_6 = value;
		}
	}

	public Color Color_0
	{
		get
		{
			if (1 == 0)
			{
			}
			return color_0;
		}
		set
		{
			color_0 = value;
		}
	}

	public GControl3()
	{
		if (1 == 0)
		{
		}
		bool_6 = true;
		int_2 = 0;
		base._002Ector();
		base.Boolean_2 = true;
	}

	protected override void vmethod_0()
	{
	}

	protected override void vmethod_3()
	{
		base.vmethod_3();
		int num = 0;
		bool flag = default(bool);
		GEnum0 gEnum = default(GEnum0);
		while (true)
		{
			switch (num)
			{
			case 9:
				Application.DoEvents();
				num = 10;
				break;
			case 8:
				if (!flag)
				{
					int_2 = 0;
				}
				((Control)this).Invalidate();
				num = 9;
				break;
			case 7:
				flag = int_2 >= 0;
				num = 8;
				break;
			case 6:
				if (!flag)
				{
					int_2 -= 5;
					num = 7;
					break;
				}
				return;
			case 4:
				Application.DoEvents();
				num = 5;
				break;
			case 3:
				((Control)this).Invalidate();
				num = 4;
				break;
			case 2:
				if (!flag)
				{
					int_2 += 5;
					num = 3;
					break;
				}
				return;
			case 1:
				switch (gEnum)
				{
				default:
					return;
				case GEnum0.const_0:
					flag = int_2 <= 0;
					num = 6;
					break;
				case GEnum0.const_1:
					flag = int_2 >= 20;
					num = 2;
					break;
				}
				break;
			case 0:
				gEnum = genum0_0;
				num = 1;
				break;
			default:
				return;
			}
		}
	}

	protected override void OnTextChanged(EventArgs e)
	{
		((Control)this).OnTextChanged(e);
		int num = 0;
		Graphics val = default(Graphics);
		while (true)
		{
			switch (num)
			{
			case 2:
				val.DrawString(((Control)this).get_Text(), ((Control)this).get_Font(), Brushes.get_White(), new RectangleF(0f, 0f, ((Control)this).get_Width(), ((Control)this).get_Height()));
				num = 3;
				break;
			case 1:
				((Control)this).CreateGraphics().MeasureString(((Control)this).get_Text(), ((Control)this).get_Font());
				num = 2;
				break;
			case 0:
				val = ((Control)this).CreateGraphics();
				num = 1;
				break;
			default:
				return;
			}
		}
	}

	protected override void vmethod_1()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Expected O, but got Unknown
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Expected O, but got Unknown
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c6: Expected O, but got Unknown
		graphics_0.Clear(color_0);
		int num = 0;
		StringFormat val2 = default(StringFormat);
		HatchBrush val3 = default(HatchBrush);
		bool flag = default(bool);
		ColorBlend val = default(ColorBlend);
		while (true)
		{
			switch (num)
			{
			case 42:
				method_32(new Pen(Color.FromArgb(90, 90, 90)), 1);
				num = 43;
				break;
			case 41:
				method_35(Pens.get_Black());
				num = 42;
				break;
			case 40:
				graphics_0.DrawString(((Control)this).get_Text(), ((Control)this).get_Font(), Brushes.get_White(), new RectangleF(2f, 2f, ((Control)this).get_Width() - 5, ((Control)this).get_Height() - 4), val2);
				num = 41;
				break;
			case 39:
				val2.set_Alignment((StringAlignment)1);
				num = 40;
				break;
			case 38:
				val2.set_LineAlignment((StringAlignment)1);
				num = 39;
				break;
			case 37:
				val2 = new StringFormat();
				num = 38;
				break;
			case 36:
				((Control)this).CreateGraphics().MeasureString(((Control)this).get_Text(), ((Control)this).get_Font(), ((Control)this).get_Width() - 4);
				num = 37;
				break;
			case 35:
				graphics_0.FillRectangle((Brush)(object)val3, 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
				num = 36;
				break;
			case 34:
				val3 = new HatchBrush((HatchStyle)20, Color.FromArgb(25, Color.Black), Color.FromArgb(0, Color.Gray));
				num = 35;
				break;
			case 33:
				val3 = null;
				num = 34;
				break;
			case 11:
			case 22:
			case 32:
				graphics_0.FillRectangle((Brush)new SolidBrush(Color.FromArgb(int_2, Color.White)), 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
				num = 33;
				break;
			case 31:
				if (!flag)
				{
					method_50(val, new Rectangle(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height() / 5 * 2));
					num = 32;
					break;
				}
				goto case 11;
			case 30:
				flag = !bool_6;
				num = 31;
				break;
			case 29:
			{
				ref Color reference12 = ref val.get_Colors()[1];
				reference12 = Color.FromArgb(40, Color.White);
				num = 30;
				break;
			}
			case 28:
			{
				ref Color reference11 = ref val.get_Colors()[0];
				reference11 = Color.FromArgb(0, 0, 0, 0);
				num = 29;
				break;
			}
			case 27:
				method_50(val, new Rectangle(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height()));
				num = 28;
				break;
			case 26:
				val.get_Positions()[1] = 1f;
				num = 27;
				break;
			case 25:
				val.get_Positions()[0] = 0f;
				num = 26;
				break;
			case 24:
			{
				ref Color reference10 = ref val.get_Colors()[1];
				reference10 = Color.FromArgb(200, 50, 50, 50);
				num = 25;
				break;
			}
			case 23:
			{
				ref Color reference9 = ref val.get_Colors()[0];
				reference9 = Color.FromArgb(200, 30, 30, 30);
				num = 24;
				break;
			}
			case 21:
				if (!flag)
				{
					method_50(val, new Rectangle(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height() / 5 * 2));
					num = 22;
					break;
				}
				goto case 11;
			case 20:
				flag = !bool_6;
				num = 21;
				break;
			case 19:
			{
				ref Color reference8 = ref val.get_Colors()[1];
				reference8 = Color.FromArgb(40, Color.White);
				num = 20;
				break;
			}
			case 18:
			{
				ref Color reference7 = ref val.get_Colors()[0];
				reference7 = Color.FromArgb(0, 0, 0, 0);
				num = 19;
				break;
			}
			case 17:
				method_50(val, new Rectangle(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height()));
				num = 18;
				break;
			case 16:
				val.get_Positions()[1] = 1f;
				num = 17;
				break;
			case 15:
				val.get_Positions()[0] = 0f;
				num = 16;
				break;
			case 14:
			{
				ref Color reference6 = ref val.get_Colors()[1];
				reference6 = Color.FromArgb(200, 70, 70, 70);
				num = 15;
				break;
			}
			case 13:
			{
				ref Color reference5 = ref val.get_Colors()[0];
				reference5 = Color.FromArgb(200, 50, 50, 50);
				num = 14;
				break;
			}
			case 12:
				if (!flag)
				{
					val = new ColorBlend(2);
					num = 13;
				}
				else
				{
					val = new ColorBlend(2);
					num = 23;
				}
				break;
			case 10:
				if (!flag)
				{
					method_50(val, new Rectangle(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height() / 5 * 2));
					num = 11;
					break;
				}
				goto case 11;
			case 9:
				flag = !bool_6;
				num = 10;
				break;
			case 8:
			{
				ref Color reference4 = ref val.get_Colors()[1];
				reference4 = Color.FromArgb(40, Color.White);
				num = 9;
				break;
			}
			case 7:
			{
				ref Color reference3 = ref val.get_Colors()[0];
				reference3 = Color.FromArgb(0, 0, 0, 0);
				num = 8;
				break;
			}
			case 6:
				method_50(val, new Rectangle(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height()));
				num = 7;
				break;
			case 5:
				val.get_Positions()[1] = 1f;
				num = 6;
				break;
			case 4:
				val.get_Positions()[0] = 0f;
				num = 5;
				break;
			case 3:
			{
				ref Color reference2 = ref val.get_Colors()[1];
				reference2 = Color.FromArgb(200, 70, 70, 70);
				num = 4;
				break;
			}
			case 2:
			{
				ref Color reference = ref val.get_Colors()[0];
				reference = Color.FromArgb(200, 50, 50, 50);
				num = 3;
				break;
			}
			case 1:
				if (!flag)
				{
					val = new ColorBlend(2);
					num = 2;
				}
				else
				{
					flag = genum0_0 != GEnum0.const_0;
					num = 12;
				}
				break;
			case 0:
				flag = genum0_0 != GEnum0.const_1;
				num = 1;
				break;
			default:
				return;
			}
		}
	}
}
