using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class GControl1 : GControl0
{
	private bool bool_16;

	public bool Boolean_9
	{
		get
		{
			if (1 == 0)
			{
			}
			return bool_16;
		}
		set
		{
			bool_16 = value;
			for (int num = 0; num == 0; num = 1)
			{
				((Control)this).Invalidate();
			}
		}
	}

	public GControl1()
	{
		if (1 == 0)
		{
		}
		base._002Ector();
		base.Color_0 = Color.Fuchsia;
	}

	protected override void vmethod_0()
	{
	}

	protected override void vmethod_1()
	{
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Expected O, but got Unknown
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_0437: Expected O, but got Unknown
		//IL_046f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0475: Expected O, but got Unknown
		//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f3: Expected O, but got Unknown
		//IL_053b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0567: Expected O, but got Unknown
		//IL_05a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bf: Expected O, but got Unknown
		//IL_0708: Unknown result type (might be due to invalid IL or missing references)
		//IL_070e: Expected O, but got Unknown
		//IL_07fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0801: Expected O, but got Unknown
		graphics_0.Clear(Color.DimGray);
		int num = 0;
		bool flag = default(bool);
		ColorBlend val3 = default(ColorBlend);
		HatchBrush val2 = default(HatchBrush);
		ColorBlend val = default(ColorBlend);
		while (true)
		{
			switch (num)
			{
			case 61:
				graphics_0.DrawString(((Control)this).get_Text(), ((Control)this).get_Font(), Brushes.get_White(), (PointF)new Point(28, 6));
				num = 62;
				break;
			case 59:
				if (!flag)
				{
					graphics_0.DrawString(((Control)this).get_Text(), ((Control)this).get_Font(), Brushes.get_White(), (PointF)new Point(6, 6));
					num = 60;
				}
				else
				{
					graphics_0.DrawIcon(((Control)this).FindForm().get_Icon(), new Rectangle(new Point(9, 5), new Size(16, 16)));
					num = 61;
				}
				break;
			case 58:
				flag = bool_16;
				num = 59;
				break;
			case 57:
				method_54(val3, 8, ((Control)this).get_Height() - 24, ((Control)this).get_Width() - 14, 17, 90f);
				num = 58;
				break;
			case 56:
			{
				ref Color reference14 = ref val3.get_Colors()[1];
				reference14 = Color.FromArgb(35, Color.Black);
				num = 57;
				break;
			}
			case 55:
			{
				ref Color reference13 = ref val3.get_Colors()[0];
				reference13 = Color.FromArgb(0, 0, 0, 0);
				num = 56;
				break;
			}
			case 54:
				method_54(val3, 7, 25, ((Control)this).get_Width() - 14, 17, 90f);
				num = 55;
				break;
			case 53:
			{
				ref Color reference12 = ref val3.get_Colors()[0];
				reference12 = Color.FromArgb(35, Color.Black);
				num = 54;
				break;
			}
			case 52:
			{
				ref Color reference11 = ref val3.get_Colors()[1];
				reference11 = Color.FromArgb(0, 0, 0, 0);
				num = 53;
				break;
			}
			case 51:
				method_54(val3, ((Control)this).get_Width() - 24, 25, 17, ((Control)this).get_Height() - 6 - 24, 0f);
				num = 52;
				break;
			case 50:
			{
				ref Color reference10 = ref val3.get_Colors()[1];
				reference10 = Color.FromArgb(35, Color.Black);
				num = 51;
				break;
			}
			case 49:
			{
				ref Color reference9 = ref val3.get_Colors()[0];
				reference9 = Color.FromArgb(0, 0, 0, 0);
				num = 50;
				break;
			}
			case 48:
				method_54(val3, 7, 25, 15, ((Control)this).get_Height() - 6 - 24, 0f);
				num = 49;
				break;
			case 47:
				val3.get_Positions()[1] = 1f;
				num = 48;
				break;
			case 46:
				val3.get_Positions()[0] = 0f;
				num = 47;
				break;
			case 45:
			{
				ref Color reference8 = ref val3.get_Colors()[1];
				reference8 = Color.FromArgb(0, 0, 0, 0);
				num = 46;
				break;
			}
			case 44:
			{
				ref Color reference7 = ref val3.get_Colors()[0];
				reference7 = Color.FromArgb(35, Color.Black);
				num = 45;
				break;
			}
			case 43:
				val3 = new ColorBlend(2);
				num = 44;
				break;
			case 42:
				method_30(Color.Black, ((Control)this).get_Width() - 2, ((Control)this).get_Height() - 2);
				num = 43;
				break;
			case 41:
				method_36(Color.Fuchsia, ((Control)this).get_Width() - 2, ((Control)this).get_Height() - 1, 1, 1);
				num = 42;
				break;
			case 40:
				method_36(Color.Fuchsia, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 2, 1, 1);
				num = 41;
				break;
			case 39:
				method_30(Color.Black, 1, ((Control)this).get_Height() - 2);
				num = 40;
				break;
			case 38:
				method_36(Color.Fuchsia, ((Control)this).get_Width() - 2, 0, 1, 1);
				num = 39;
				break;
			case 37:
				method_36(Color.Fuchsia, ((Control)this).get_Width() - 1, 1, 1, 1);
				num = 38;
				break;
			case 36:
				method_30(Color.Black, ((Control)this).get_Width() - 2, 1);
				num = 37;
				break;
			case 35:
				method_36(Color.Fuchsia, 1, ((Control)this).get_Height() - 1, 1, 1);
				num = 36;
				break;
			case 34:
				method_36(Color.Fuchsia, 0, ((Control)this).get_Height() - 2, 1, 1);
				num = 35;
				break;
			case 33:
				method_30(Color.Black, 1, 1);
				num = 34;
				break;
			case 32:
				method_36(Color.Fuchsia, 1, 0, 1, 1);
				num = 33;
				break;
			case 31:
				method_36(Color.Fuchsia, 0, 1, 1, 1);
				num = 32;
				break;
			case 30:
				method_34(Color.Fuchsia);
				num = 31;
				break;
			case 29:
				graphics_0.FillRectangle((Brush)new SolidBrush(Color.FromArgb(230, 20, 20, 20)), 7, 25, ((Control)this).get_Width() - 14, ((Control)this).get_Height() - 24 - 8);
				num = 30;
				break;
			case 28:
				graphics_0.FillRectangle((Brush)(object)val2, 7, 25, ((Control)this).get_Width() - 14, ((Control)this).get_Height() - 24 - 8);
				num = 29;
				break;
			case 27:
				val2 = new HatchBrush((HatchStyle)18, Color.DimGray);
				num = 28;
				break;
			case 26:
				method_40(Pens.get_Black());
				num = 27;
				break;
			case 25:
				graphics_0.FillRectangle((Brush)(object)val2, 1, ((Control)this).get_Height() - 6, ((Control)this).get_Width() - 2, ((Control)this).get_Height() - 1);
				num = 26;
				break;
			case 24:
				graphics_0.FillRectangle((Brush)new SolidBrush(Color.FromArgb(60, 60, 60)), new Rectangle(1, ((Control)this).get_Height() - 6, ((Control)this).get_Width() - 2, ((Control)this).get_Height() - 1));
				num = 25;
				break;
			case 23:
				graphics_0.FillRectangle((Brush)(object)val2, ((Control)this).get_Width() - 6, 24, ((Control)this).get_Width() - 2, ((Control)this).get_Height() - 6 - 24);
				num = 24;
				break;
			case 22:
				graphics_0.FillRectangle((Brush)new SolidBrush(Color.FromArgb(60, 60, 60)), new Rectangle(((Control)this).get_Width() - 6, 24, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 6 - 24));
				num = 23;
				break;
			case 21:
				graphics_0.FillRectangle((Brush)(object)val2, 1, 24, 5, ((Control)this).get_Height() - 6 - 24);
				num = 22;
				break;
			case 20:
				graphics_0.FillRectangle((Brush)new SolidBrush(Color.FromArgb(60, 60, 60)), new Rectangle(1, 24, 5, ((Control)this).get_Height() - 6 - 24));
				num = 21;
				break;
			case 19:
				graphics_0.DrawLine(Pens.get_Black(), ((Control)this).get_Width() - 7, 24, ((Control)this).get_Width() - 7, ((Control)this).get_Height() - 7);
				num = 20;
				break;
			case 18:
				graphics_0.DrawLine(Pens.get_Black(), 6, ((Control)this).get_Height() - 7, ((Control)this).get_Width() - 7, ((Control)this).get_Height() - 7);
				num = 19;
				break;
			case 17:
				graphics_0.DrawLine(Pens.get_Black(), 6, 24, 6, ((Control)this).get_Height() - 7);
				num = 18;
				break;
			case 16:
				graphics_0.DrawLine(Pens.get_Black(), 6, 24, ((Control)this).get_Width() - 7, 24);
				num = 17;
				break;
			case 15:
				graphics_0.FillRectangle((Brush)(object)val2, 0, 0, ((Control)this).get_Width(), 24);
				num = 16;
				break;
			case 14:
				method_55(val, new Rectangle(0, 0, ((Control)this).get_Width(), 30));
				num = 15;
				break;
			case 13:
			{
				ref Color reference6 = ref val.get_Colors()[1];
				reference6 = Color.FromArgb(0, Color.Black);
				num = 14;
				break;
			}
			case 12:
			{
				ref Color reference5 = ref val.get_Colors()[0];
				reference5 = Color.FromArgb(120, Color.Black);
				num = 13;
				break;
			}
			case 11:
				val2 = new HatchBrush((HatchStyle)20, Color.FromArgb(15, Color.Black), Color.FromArgb(0, Color.Gray));
				num = 12;
				break;
			case 10:
				val2 = null;
				num = 11;
				break;
			case 9:
				method_55(val, new Rectangle(0, 0, ((Control)this).get_Width(), 12));
				num = 10;
				break;
			case 8:
			{
				ref Color reference4 = ref val.get_Colors()[1];
				reference4 = Color.DimGray;
				num = 9;
				break;
			}
			case 7:
			{
				ref Color reference3 = ref val.get_Colors()[0];
				reference3 = Color.FromArgb(100, 100, 100);
				num = 8;
				break;
			}
			case 6:
				method_55(val, new Rectangle(0, 0, ((Control)this).get_Width(), 24));
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
				reference2 = Color.FromArgb(60, 60, 60);
				num = 4;
				break;
			}
			case 2:
			{
				ref Color reference = ref val.get_Colors()[0];
				reference = Color.DimGray;
				num = 3;
				break;
			}
			case 1:
				method_37(Pens.get_Gray(), 1);
				num = 2;
				break;
			case 0:
				val = new ColorBlend(2);
				num = 1;
				break;
			default:
				return;
			}
		}
	}
}
