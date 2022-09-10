using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class GClass3 : ComboBox
{
	private int int_0;

	public GClass3()
	{
		if (1 == 0)
		{
		}
		((ComboBox)this)._002Ector();
		((Control)this).add_TextChanged((EventHandler)GClass3_TextChanged);
		((ComboBox)this).add_DropDownClosed((EventHandler)GClass3_DropDownClosed);
		((Control)this).SetStyle((ControlStyles)73746, true);
		((ComboBox)this).set_DrawMode((DrawMode)1);
		((ComboBox)this).set_ItemHeight(20);
		((Control)this).set_BackColor(Color.FromArgb(30, 30, 30));
		((ComboBox)this).set_DropDownStyle((ComboBoxStyle)2);
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
				int_0 = e.get_X();
				num = 1;
				break;
			default:
				return;
			}
		}
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		((ComboBox)this).OnMouseLeave(e);
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
				int_0 = -1;
				num = 1;
				break;
			default:
				return;
			}
		}
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected O, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected O, but got Unknown
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected O, but got Unknown
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Invalid comparison between Unknown and I4
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Invalid comparison between Unknown and I4
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Expected O, but got Unknown
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected O, but got Unknown
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Expected O, but got Unknown
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Expected O, but got Unknown
		//IL_0421: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Expected O, but got Unknown
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_045a: Expected O, but got Unknown
		bool flag = (int)((ComboBox)this).get_DropDownStyle() == 2;
		int num = 0;
		Bitmap val2 = default(Bitmap);
		Graphics val = default(Graphics);
		int num2 = default(int);
		SizeF sizeF = default(SizeF);
		HatchBrush val4 = default(HatchBrush);
		LinearGradientBrush val3 = default(LinearGradientBrush);
		while (true)
		{
			switch (num)
			{
			case 29:
				((Image)val2).Dispose();
				num = 30;
				break;
			case 28:
				val.Dispose();
				num = 29;
				break;
			case 27:
				e.get_Graphics().DrawImage((Image)(object)val2, 0, 0);
				num = 28;
				break;
			case 26:
				val.FillPolygon(Brushes.get_White(), method_0(new Point(((Control)this).get_Width() - 15, ((Control)this).get_Height() / 2 - 1), new Size(5, 3)));
				num = 27;
				break;
			case 25:
				val.FillPolygon(Brushes.get_Black(), method_0(new Point(((Control)this).get_Width() - 14, ((Control)this).get_Height() / 2), new Size(5, 3)));
				num = 26;
				break;
			case 24:
				val.DrawLine(new Pen(Color.FromArgb(90, 90, 90)), ((Control)this).get_Width() - 23, 1, ((Control)this).get_Width() - 23, ((Control)this).get_Height() - 3);
				num = 25;
				break;
			case 23:
				val.DrawLine(Pens.get_Black(), ((Control)this).get_Width() - 24, 0, ((Control)this).get_Width() - 24, ((Control)this).get_Height());
				num = 24;
				break;
			case 22:
				val.DrawLine(new Pen(Color.FromArgb(90, 90, 90)), ((Control)this).get_Width() - 25, 1, ((Control)this).get_Width() - 25, ((Control)this).get_Height() - 3);
				num = 23;
				break;
			case 21:
				val.DrawRectangle(new Pen(Color.FromArgb(90, 90, 90)), 1, 1, ((Control)this).get_Width() - 3, ((Control)this).get_Height() - 3);
				num = 22;
				break;
			case 18:
			case 20:
				val.DrawRectangle(Pens.get_Black(), 0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
				num = 21;
				break;
			case 19:
				if (!flag)
				{
					val.FillRectangle((Brush)new SolidBrush(Color.FromArgb(7, Color.White)), 2, 1, ((Control)this).get_Width() - 27, ((Control)this).get_Height() - 3);
					num = 20;
					break;
				}
				goto case 18;
			case 17:
				if (!flag)
				{
					val.FillRectangle((Brush)new SolidBrush(Color.FromArgb(7, Color.White)), ((Control)this).get_Width() - 25, 1, ((Control)this).get_Width() - 25, ((Control)this).get_Height() - 3);
					num = 18;
				}
				else
				{
					flag = !(((int)Control.get_MouseButtons() == 0) & (int_0 < ((Control)this).get_Width() - 25) & (int_0 >= 0));
					num = 19;
				}
				break;
			case 13:
			case 15:
			case 16:
				flag = !(((int)Control.get_MouseButtons() == 0) & (int_0 > ((Control)this).get_Width() - 25));
				num = 17;
				break;
			case 14:
				if (!flag)
				{
					val.DrawString(((ComboBox)this).get_Items().get_Item(0).ToString(), ((Control)this).get_Font(), (Brush)new SolidBrush(Color.White), 4f, (float)(((Control)this).get_Height() / 2 - num2 / 2));
					num = 15;
				}
				else
				{
					val.DrawString("...", ((Control)this).get_Font(), (Brush)new SolidBrush(Color.White), 4f, (float)(((Control)this).get_Height() / 2 - num2 / 2));
					num = 16;
				}
				break;
			case 12:
				if (!flag)
				{
					val.DrawString(((ComboBox)this).get_Items().get_Item(((ListControl)this).get_SelectedIndex()).ToString(), ((Control)this).get_Font(), (Brush)new SolidBrush(Color.White), 4f, (float)(((Control)this).get_Height() / 2 - num2 / 2));
					num = 13;
				}
				else
				{
					flag = !((((ComboBox)this).get_Items() != null) & (((ComboBox)this).get_Items().get_Count() > 0));
					num = 14;
				}
				break;
			case 11:
				flag = ((ListControl)this).get_SelectedIndex() == -1;
				num = 12;
				break;
			case 10:
				num2 = (int)sizeF.Height;
				num = 11;
				break;
			case 9:
				sizeF = val.MeasureString("...", ((Control)this).get_Font());
				num = 10;
				break;
			case 8:
				val.FillRectangle((Brush)(object)val4, 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
				num = 9;
				break;
			case 7:
				val4 = new HatchBrush((HatchStyle)20, Color.FromArgb(20, Color.Black), Color.FromArgb(0, Color.Gray));
				num = 8;
				break;
			case 6:
				val4 = null;
				num = 7;
				break;
			case 5:
				val.FillRectangle((Brush)(object)val3, new Rectangle(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height() / 5 * 2));
				num = 6;
				break;
			case 4:
				val3 = new LinearGradientBrush(new Rectangle(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height() / 5 * 2), Color.FromArgb(20, 0, 0, 0), Color.FromArgb(15, Color.White), 90f);
				num = 5;
				break;
			case 3:
				val.Clear(Color.FromArgb(50, 50, 50));
				num = 4;
				break;
			case 2:
				val = Graphics.FromImage((Image)(object)val2);
				num = 3;
				break;
			case 1:
				val2 = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
				num = 2;
				break;
			case 0:
				if (!flag)
				{
					((ComboBox)this).set_DropDownStyle((ComboBoxStyle)2);
					num = 1;
					break;
				}
				goto case 1;
			default:
				return;
			}
		}
	}

	protected override void OnDrawItem(DrawItemEventArgs e)
	{
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected O, but got Unknown
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected O, but got Unknown
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Invalid comparison between Unknown and I4
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Invalid comparison between Unknown and I4
		bool flag = e.get_Index() >= 0;
		int num = 0;
		LinearGradientBrush val = default(LinearGradientBrush);
		HatchBrush val2 = default(HatchBrush);
		Rectangle rectangle2 = default(Rectangle);
		Rectangle rectangle3 = default(Rectangle);
		Rectangle rectangle = default(Rectangle);
		while (true)
		{
			switch (num)
			{
			case 18:
			case 20:
				((ComboBox)this).OnDrawItem(e);
				num = 21;
				break;
			case 19:
				e.get_Graphics().DrawString(" " + ((ComboBox)this).get_Items().get_Item(e.get_Index()).ToString(), ((Control)this).get_Font(), Brushes.get_White(), (float)e.get_Bounds().X, (float)(e.get_Bounds().Y + 2));
				num = 20;
				break;
			case 17:
				e.get_Graphics().DrawString(" " + ((ComboBox)this).get_Items().get_Item(e.get_Index()).ToString(), ((Control)this).get_Font(), Brushes.get_White(), (float)e.get_Bounds().X, (float)(e.get_Bounds().Y + 2));
				num = 18;
				break;
			case 16:
				((Brush)val).Dispose();
				num = 17;
				break;
			case 15:
				e.get_Graphics().FillRectangle((Brush)(object)val2, rectangle2);
				num = 16;
				break;
			case 14:
				e.get_Graphics().FillRectangle((Brush)new SolidBrush(Color.FromArgb(25, Color.White)), rectangle3);
				num = 15;
				break;
			case 13:
				((Brush)val).Dispose();
				num = 14;
				break;
			case 12:
				e.get_Graphics().FillRectangle((Brush)(object)val, rectangle2);
				num = 13;
				break;
			case 11:
				val2 = new HatchBrush((HatchStyle)20, Color.FromArgb(15, Color.Black), Color.Transparent);
				num = 12;
				break;
			case 10:
				val = new LinearGradientBrush(new Point(rectangle2.X, rectangle2.Y), new Point(rectangle2.X, rectangle2.Y + rectangle2.Height), Color.FromArgb(60, 60, 60), Color.FromArgb(50, 50, 50));
				num = 11;
				break;
			case 9:
				rectangle3 = new Rectangle(rectangle2.Location, new Size(rectangle2.Width, rectangle2.Height / 2 - 1));
				num = 10;
				break;
			case 8:
				rectangle2 = new Rectangle(e.get_Bounds().Location, new Size(e.get_Bounds().Width - 1, e.get_Bounds().Height));
				num = 9;
				break;
			case 7:
				if (!flag)
				{
					e.get_Graphics().FillRectangle(Brushes.get_Black(), e.get_Bounds());
					num = 8;
				}
				else
				{
					e.get_Graphics().FillRectangle((Brush)new SolidBrush(((Control)this).get_BackColor()), e.get_Bounds());
					num = 19;
				}
				break;
			case 6:
				flag = !(((int)e.get_State() == 785) | ((int)e.get_State() == 17));
				num = 7;
				break;
			case 5:
				e.DrawBackground();
				num = 6;
				break;
			case 4:
				rectangle.Height = e.get_Bounds().Height - 1;
				num = 5;
				break;
			case 3:
				rectangle.Width = e.get_Bounds().Width - 1;
				num = 4;
				break;
			case 2:
				rectangle.Y = e.get_Bounds().Y;
				num = 3;
				break;
			case 1:
				rectangle.X = e.get_Bounds().X;
				num = 2;
				break;
			case 0:
				if (flag)
				{
					rectangle = default(Rectangle);
					num = 1;
					break;
				}
				return;
			default:
				return;
			}
		}
	}

	public Point[] method_0(Point point_0, Size size_0)
	{
		Point[] array = new Point[4];
		int num = 0;
		Point[] result = default(Point[]);
		while (true)
		{
			switch (num)
			{
			case 4:
				result = array;
				num = 5;
				break;
			case 3:
				array[3] = point_0;
				num = 4;
				break;
			case 2:
			{
				ref Point reference2 = ref array[2];
				reference2 = new Point(point_0.X + size_0.Width / 2, point_0.Y + size_0.Height);
				num = 3;
				break;
			}
			case 1:
			{
				ref Point reference = ref array[1];
				reference = new Point(point_0.X + size_0.Width, point_0.Y);
				num = 2;
				break;
			}
			case 0:
				array[0] = point_0;
				num = 1;
				break;
			default:
				return result;
			}
		}
	}

	private void GClass3_DropDownClosed(object sender, EventArgs e)
	{
		((ComboBox)this).set_DropDownStyle((ComboBoxStyle)0);
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 1:
				((ComboBox)this).set_DropDownStyle((ComboBoxStyle)2);
				num = 2;
				break;
			case 0:
				Application.DoEvents();
				num = 1;
				break;
			default:
				return;
			}
		}
	}

	private void GClass3_TextChanged(object sender, EventArgs e)
	{
		((Control)this).Invalidate();
	}
}
