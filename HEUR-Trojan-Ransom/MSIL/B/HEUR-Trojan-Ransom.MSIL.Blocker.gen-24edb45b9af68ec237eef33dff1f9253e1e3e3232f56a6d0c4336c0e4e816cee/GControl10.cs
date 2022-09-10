using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class GControl10 : GControl2
{
	private int int_2;

	private Color color_0;

	private Color color_1;

	private Pen pen_0;

	public GControl10()
	{
		if (1 == 0)
		{
		}
		base._002Ector();
		method_6("Background", Color.FromArgb(64, 64, 64));
		method_6("Edge color", Color.Black);
		method_6("Button edge color", Color.FromArgb(90, 90, 90));
		((Control)this).set_Size(new Size(71, 19));
		((Control)this).set_Anchor((AnchorStyles)9);
	}

	protected override void vmethod_0()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		color_0 = method_5("Background");
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 1:
				pen_0 = new Pen(method_5("Button edge color"));
				num = 2;
				break;
			case 0:
				color_1 = method_5("Edge color");
				num = 1;
				break;
			default:
				return;
			}
		}
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		((Control)this).OnMouseMove(e);
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
				int_2 = e.get_X();
				num = 1;
				break;
			default:
				return;
			}
		}
	}

	protected override void OnClick(EventArgs e)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Invalid comparison between Unknown and I4
		((Control)this).OnClick(e);
		int num = 0;
		bool flag = default(bool);
		while (true)
		{
			switch (num)
			{
			case 7:
				if (!flag)
				{
					((Control)this).FindForm().Close();
					num = 8;
					break;
				}
				return;
			case 4:
				if (!flag)
				{
					((Control)this).FindForm().set_WindowState((FormWindowState)2);
					num = 5;
				}
				else
				{
					((Control)this).FindForm().set_WindowState((FormWindowState)0);
					num = 6;
				}
				break;
			case 3:
				if (!flag)
				{
					flag = (int)((Control)this).FindForm().get_WindowState() == 2;
					num = 4;
				}
				else
				{
					flag = int_2 <= 44;
					num = 7;
				}
				break;
			case 1:
				if (!flag)
				{
					((Control)this).FindForm().set_WindowState((FormWindowState)1);
					num = 2;
				}
				else
				{
					flag = !((int_2 > 22) & (int_2 <= 44));
					num = 3;
				}
				break;
			case 0:
				flag = int_2 > 22;
				num = 1;
				break;
			default:
				return;
			}
		}
	}

	protected override void vmethod_1()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected O, but got Unknown
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Expected O, but got Unknown
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Expected O, but got Unknown
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e6: Expected O, but got Unknown
		//IL_0401: Unknown result type (might be due to invalid IL or missing references)
		//IL_041d: Expected O, but got Unknown
		//IL_0429: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Invalid comparison between Unknown and I4
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0468: Expected O, but got Unknown
		//IL_04d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d8: Expected O, but got Unknown
		graphics_0.Clear(color_1);
		int num = 0;
		bool flag = default(bool);
		GEnum0 gEnum = default(GEnum0);
		ColorBlend val2 = default(ColorBlend);
		LinearGradientBrush val = default(LinearGradientBrush);
		while (true)
		{
			switch (num)
			{
			case 26:
				if (!flag)
				{
					graphics_0.FillRectangle((Brush)new SolidBrush(Color.FromArgb(20, Color.Black)), new Rectangle(new Point(45, 1), new Size(25, ((Control)this).get_Height() - 2)));
					num = 27;
					break;
				}
				return;
			case 24:
				if (!flag)
				{
					graphics_0.FillRectangle((Brush)new SolidBrush(Color.FromArgb(20, Color.Black)), new Rectangle(new Point(23, 1), new Size(21, ((Control)this).get_Height() - 2)));
					num = 25;
				}
				else
				{
					flag = int_2 <= 44;
					num = 26;
				}
				break;
			case 22:
				if (!flag)
				{
					graphics_0.FillRectangle((Brush)new SolidBrush(Color.FromArgb(20, Color.Black)), new Rectangle(new Point(1, 1), new Size(21, ((Control)this).get_Height() - 2)));
					num = 23;
				}
				else
				{
					flag = !((int_2 > 22) & (int_2 <= 44));
					num = 24;
				}
				break;
			case 20:
				if (!flag)
				{
					graphics_0.FillRectangle((Brush)new SolidBrush(Color.FromArgb(20, Color.White)), new Rectangle(new Point(45, 1), new Size(25, ((Control)this).get_Height() - 2)));
					num = 21;
					break;
				}
				return;
			case 18:
				if (!flag)
				{
					graphics_0.FillRectangle((Brush)new SolidBrush(Color.FromArgb(20, Color.White)), new Rectangle(new Point(23, 1), new Size(21, ((Control)this).get_Height() - 2)));
					num = 19;
				}
				else
				{
					flag = int_2 <= 44;
					num = 20;
				}
				break;
			case 16:
				if (!flag)
				{
					graphics_0.FillRectangle((Brush)new SolidBrush(Color.FromArgb(20, Color.White)), new Rectangle(new Point(1, 1), new Size(21, ((Control)this).get_Height() - 2)));
					num = 17;
				}
				else
				{
					flag = !((int_2 > 22) & (int_2 <= 44));
					num = 18;
				}
				break;
			case 15:
				switch (gEnum)
				{
				default:
					return;
				case GEnum0.const_1:
					flag = int_2 > 22;
					num = 16;
					break;
				case GEnum0.const_2:
					flag = int_2 > 22;
					num = 22;
					break;
				}
				break;
			case 14:
				gEnum = genum0_0;
				num = 15;
				break;
			case 13:
				graphics_0.DrawRectangle(pen_0, new Rectangle(new Point(45, 1), new Size(24, 16)));
				num = 14;
				break;
			case 12:
				graphics_0.DrawRectangle(pen_0, new Rectangle(new Point(23, 1), new Size(20, 16)));
				num = 13;
				break;
			case 11:
				graphics_0.DrawRectangle(pen_0, new Rectangle(new Point(1, 1), new Size(20, 16)));
				num = 12;
				break;
			case 10:
				method_51(val2, new Rectangle(new Point(1, 8), new Size(68, 8)), 90f);
				num = 11;
				break;
			case 9:
				val2.set_Positions(new float[2] { 0f, 1f });
				num = 10;
				break;
			case 8:
				val2.set_Colors(new Color[2]
				{
					Color.FromArgb(100, Color.Black),
					Color.Transparent
				});
				num = 9;
				break;
			case 7:
				val2 = new ColorBlend(2);
				num = 8;
				break;
			case 5:
			case 6:
				graphics_0.DrawString("r", new Font("Marlett", 10f), Brushes.get_White(), (PointF)new Point(49, 3));
				num = 7;
				break;
			case 4:
				if (!flag)
				{
					graphics_0.DrawString("1", new Font("Marlett", 8.25f), Brushes.get_White(), (PointF)new Point(27, 4));
					num = 5;
				}
				else
				{
					graphics_0.DrawString("2", new Font("Marlett", 8.25f), Brushes.get_White(), (PointF)new Point(27, 4));
					num = 6;
				}
				break;
			case 3:
				flag = (int)((Control)this).FindForm().get_WindowState() == 2;
				num = 4;
				break;
			case 2:
				graphics_0.DrawString("0", new Font("Marlett", 8.25f), Brushes.get_White(), (PointF)new Point(5, 5));
				num = 3;
				break;
			case 1:
				graphics_0.FillRectangle((Brush)(object)val, new Rectangle(new Point(1, 1), new Size(((Control)this).get_Width() - 2, ((Control)this).get_Height() - 2)));
				num = 2;
				break;
			case 0:
				val = new LinearGradientBrush(new Rectangle(new Point(1, 1), new Size(((Control)this).get_Width() - 2, ((Control)this).get_Height() - 2)), color_0, Color.FromArgb(30, 30, 30), 90f);
				num = 1;
				break;
			default:
				return;
			}
		}
	}
}
