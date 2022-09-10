using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class GControl4 : GControl2
{
	private int int_2;

	private int int_3;

	private int int_4;

	private int int_5;

	public int Int32_2
	{
		get
		{
			if (1 == 0)
			{
			}
			return int_2;
		}
		set
		{
			bool flag = value >= 1;
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 2:
					((Control)this).Invalidate();
					num = 3;
					break;
				case 1:
					if (!flag)
					{
						int_3 = value;
					}
					int_2 = value;
					num = 2;
					break;
				case 0:
					if (!flag)
					{
						value = 1;
					}
					flag = value >= int_3;
					num = 1;
					break;
				default:
					return;
				}
			}
		}
	}

	public int Int32_3
	{
		get
		{
			if (1 == 0)
			{
			}
			return int_3;
		}
		set
		{
			bool flag = value <= int_2;
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 1:
					((Control)this).Invalidate();
					num = 2;
					break;
				case 0:
					if (!flag)
					{
						value = Int32_2;
					}
					int_3 = value;
					num = 1;
					break;
				default:
					return;
				}
			}
		}
	}

	public bool Boolean_3
	{
		get
		{
			if (1 == 0)
			{
			}
			return base.Boolean_2;
		}
		set
		{
			base.Boolean_2 = value;
			for (int num = 0; num == 0; num = 1)
			{
				((Control)this).Invalidate();
			}
		}
	}

	public GControl4()
	{
		if (1 == 0)
		{
		}
		int_2 = 100;
		int_4 = 0;
		base._002Ector();
		int_2 = 100;
		base.Boolean_2 = true;
	}

	protected override void vmethod_0()
	{
	}

	protected override void vmethod_3()
	{
		int_4--;
		bool flag = default(bool);
		for (int num = 0; num == 0; num = 1)
		{
			flag = int_4 != 7;
		}
		if (!flag)
		{
			int_4 = 0;
		}
	}

	protected override void vmethod_1()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected O, but got Unknown
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Expected O, but got Unknown
		//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Expected O, but got Unknown
		HatchBrush val = new HatchBrush((HatchStyle)20, Color.FromArgb(60, Color.Black));
		int num = 0;
		bool flag = default(bool);
		ColorBlend val3 = default(ColorBlend);
		ColorBlend val2 = default(ColorBlend);
		while (true)
		{
			switch (num)
			{
			case 24:
				if (!flag)
				{
					graphics_0.FillRectangle((Brush)new SolidBrush(Color.FromArgb(5, 5, 5)), Convert.ToInt32(((Control)this).get_Width() / int_2 * int_3) - 1, 2, ((Control)this).get_Width() - Convert.ToInt32(((Control)this).get_Width() / int_2 * int_3) - 1, ((Control)this).get_Height() - 4);
					num = 25;
					break;
				}
				return;
			case 23:
				flag = Int32_3 <= 0;
				num = 24;
				break;
			case 22:
				val3.set_Positions(new float[3] { 0f, 0.5f, 1f });
				num = 23;
				break;
			case 21:
			{
				ref Color reference6 = ref val3.get_Colors()[2];
				reference6 = Color.FromArgb(0, Color.Gray);
				num = 22;
				break;
			}
			case 20:
			{
				ref Color reference5 = ref val3.get_Colors()[1];
				reference5 = Color.FromArgb(80, Color.DimGray);
				num = 21;
				break;
			}
			case 19:
			{
				ref Color reference4 = ref val3.get_Colors()[0];
				reference4 = Color.FromArgb(0, Color.Gray);
				num = 20;
				break;
			}
			case 18:
				val3 = new ColorBlend(3);
				num = 19;
				break;
			case 17:
				int_5 = Convert.ToInt32(((Control)this).get_Width() / int_2 * int_3);
				num = 18;
				break;
			case 16:
				graphics_0.DrawLine(Pens.get_Black(), Convert.ToInt32(((Control)this).get_Width() / int_2 * int_3 - 2) + 1, 2, Convert.ToInt32(((Control)this).get_Width() / int_2 * int_3 - 2) + 1, ((Control)this).get_Height() - 3);
				num = 17;
				break;
			case 15:
				graphics_0.DrawLine(new Pen(Color.FromArgb(200, 90, 90, 90)), Convert.ToInt32(((Control)this).get_Width() / int_2 * int_3 - 2), 1, Convert.ToInt32(((Control)this).get_Width() / int_2 * int_3 - 2), ((Control)this).get_Height() - 2);
				num = 16;
				break;
			case 14:
				method_29(Color.Black);
				num = 15;
				break;
			case 13:
				method_32(new Pen(Color.FromArgb(90, 90, 90)), 1);
				num = 14;
				break;
			case 12:
				method_35(Pens.get_Black());
				num = 13;
				break;
			case 11:
				graphics_0.FillRectangle((Brush)(object)val, 0, 0, Convert.ToInt32(((Control)this).get_Width() / int_2 * int_3 - 2), ((Control)this).get_Height() - 2);
				num = 12;
				break;
			case 10:
				val = new HatchBrush((HatchStyle)2, Color.FromArgb(40, Color.Black), Color.FromArgb(0, Color.Gray));
				num = 11;
				break;
			case 9:
				graphics_0.set_RenderingOrigin(new Point(int_4, 0));
				num = 10;
				break;
			case 8:
				method_50(val2, new Rectangle(0, 0, Convert.ToInt32(((Control)this).get_Width() / int_2 * int_3 - 2), ((Control)this).get_Height() / 5 * 2));
				num = 9;
				break;
			case 7:
			{
				ref Color reference3 = ref val2.get_Colors()[1];
				reference3 = Color.FromArgb(80, 80, 80);
				num = 8;
				break;
			}
			case 6:
				method_50(val2, new Rectangle(0, 0, Convert.ToInt32(((Control)this).get_Width() / int_2 * int_3 - 2), ((Control)this).get_Height() - 2));
				num = 7;
				break;
			case 5:
				val2.get_Positions()[1] = 1f;
				num = 6;
				break;
			case 4:
				val2.get_Positions()[0] = 0f;
				num = 5;
				break;
			case 3:
			{
				ref Color reference2 = ref val2.get_Colors()[1];
				reference2 = Color.FromArgb(70, 70, 70);
				num = 4;
				break;
			}
			case 2:
			{
				ref Color reference = ref val2.get_Colors()[0];
				reference = Color.FromArgb(50, 50, 50);
				num = 3;
				break;
			}
			case 1:
				val2 = new ColorBlend(2);
				num = 2;
				break;
			case 0:
				graphics_0.Clear(Color.FromArgb(0, 30, 30, 30));
				num = 1;
				break;
			default:
				return;
			}
		}
	}
}
