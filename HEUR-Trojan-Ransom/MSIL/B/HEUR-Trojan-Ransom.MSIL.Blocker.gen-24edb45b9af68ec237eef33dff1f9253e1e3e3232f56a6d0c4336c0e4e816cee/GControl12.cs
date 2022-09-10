using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class GControl12 : TabControl
{
	private Color color_0;

	public override Color ForeColor
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

	public GControl12()
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		if (1 == 0)
		{
		}
		color_0 = Color.White;
		((TabControl)this)._002Ector();
		((Control)this).SetStyle((ControlStyles)73746, true);
		((Control)this).set_DoubleBuffered(true);
		foreach (TabPage tabPage in ((TabControl)this).get_TabPages())
		{
			TabPage val = tabPage;
			try
			{
				((Control)val).set_BackColor(Color.Black);
				((Control)val).set_BackColor(Color.Transparent);
			}
			catch
			{
			}
		}
	}

	protected override void CreateHandle()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		((TabControl)this).CreateHandle();
		for (int num = 0; num == 0; num = 1)
		{
			((TabControl)this).set_Alignment((TabAlignment)0);
		}
		IEnumerator enumerator = ((TabControl)this).get_TabPages().GetEnumerator();
		bool flag = default(bool);
		try
		{
			TabPage val = default(TabPage);
			while (true)
			{
				flag = enumerator.MoveNext();
				int num2 = 1;
				while (num2 != 0)
				{
					if (flag)
					{
						val = (TabPage)enumerator.Current;
						num2 = 0;
						continue;
					}
					return;
				}
				try
				{
					((Control)val).set_BackColor(Color.Black);
					for (int num3 = 0; num3 == 0; num3 = 1)
					{
						((Control)val).set_BackColor(Color.Transparent);
					}
				}
				catch
				{
				}
			}
		}
		finally
		{
			IDisposable disposable = enumerator as IDisposable;
			int num4 = 0;
			while (true)
			{
				switch (num4)
				{
				case 1:
					if (!flag)
					{
						disposable.Dispose();
						num4 = 2;
						continue;
					}
					break;
				case 0:
					flag = disposable == null;
					num4 = 1;
					continue;
				}
				break;
			}
		}
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00c3: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected O, but got Unknown
		//IL_0112: Expected O, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected O, but got Unknown
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected O, but got Unknown
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected O, but got Unknown
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Expected O, but got Unknown
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Expected O, but got Unknown
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Expected O, but got Unknown
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_0448: Expected O, but got Unknown
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b0: Expected O, but got Unknown
		//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d6: Expected O, but got Unknown
		//IL_059e: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c9: Expected O, but got Unknown
		//IL_0641: Unknown result type (might be due to invalid IL or missing references)
		//IL_0659: Expected O, but got Unknown
		//IL_067e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0684: Expected O, but got Unknown
		//IL_0693: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b0: Expected O, but got Unknown
		//IL_06cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d2: Expected O, but got Unknown
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		int num = 0;
		Graphics val2 = default(Graphics);
		bool flag = default(bool);
		int num2 = default(int);
		Rectangle rectangle = default(Rectangle);
		Rectangle tabRect = default(Rectangle);
		LinearGradientBrush val6 = default(LinearGradientBrush);
		HatchBrush val3 = default(HatchBrush);
		while (true)
		{
			switch (num)
			{
			case 33:
				((Image)val).Dispose();
				num = 34;
				break;
			case 32:
				val2.Dispose();
				num = 33;
				break;
			case 31:
				if (!flag)
				{
					e.get_Graphics().DrawImage((Image)(object)val, 0, 0);
					num = 32;
				}
				else
				{
					flag = num2 != ((TabControl)this).get_SelectedIndex();
					num = 13;
				}
				break;
			case 28:
			case 30:
				num2++;
				goto case 12;
			case 12:
				flag = num2 <= ((TabControl)this).get_TabCount() - 1;
				num = 31;
				break;
			case 29:
			{
				Graphics obj12 = val2;
				string text2 = ((Control)((TabControl)this).get_TabPages().get_Item(num2)).get_Text();
				Font font2 = ((Control)this).get_Font();
				SolidBrush val13 = new SolidBrush(color_0);
				RectangleF rectangleF2 = rectangle;
				StringFormat val14 = new StringFormat();
				val14.set_LineAlignment((StringAlignment)1);
				val14.set_Alignment((StringAlignment)1);
				obj12.DrawString(text2, font2, (Brush)val13, rectangleF2, val14);
				num = 30;
				break;
			}
			case 27:
			{
				Graphics obj11 = val2;
				string text = ((Control)((TabControl)this).get_TabPages().get_Item(num2)).get_Text();
				Font font = ((Control)this).get_Font();
				SolidBrush val11 = new SolidBrush(color_0);
				RectangleF rectangleF = rectangle;
				StringFormat val12 = new StringFormat();
				val12.set_LineAlignment((StringAlignment)1);
				val12.set_Alignment((StringAlignment)1);
				obj11.DrawString(text, font, (Brush)val11, rectangleF, val12);
				num = 28;
				break;
			}
			case 26:
			{
				Graphics obj10 = val2;
				Pen val10 = new Pen(Color.FromArgb(90, 90, 90));
				Point point4 = new Point(((TabControl)this).GetTabRect(num2).Right, ((TabControl)this).GetTabRect(num2).Height + 3);
				int x10 = ((Control)this).get_Width() - 2;
				tabRect = ((TabControl)this).GetTabRect(num2);
				obj10.DrawLine(val10, point4, new Point(x10, tabRect.Height + 3));
				num = 27;
				break;
			}
			case 25:
			{
				Graphics obj9 = val2;
				Pen val9 = new Pen(Color.FromArgb(90, 90, 90));
				Point point3 = new Point(1, ((TabControl)this).GetTabRect(num2).Height + 3);
				int x9 = ((TabControl)this).GetTabRect(num2).X;
				tabRect = ((TabControl)this).GetTabRect(num2);
				obj9.DrawLine(val9, point3, new Point(x9, tabRect.Height + 3));
				num = 26;
				break;
			}
			case 24:
				if (!flag)
				{
					Graphics obj8 = val2;
					Pen val8 = new Pen(Color.FromArgb(90, 90, 90));
					Point point2 = new Point(((TabControl)this).GetTabRect(num2).X, 4);
					int x8 = ((TabControl)this).GetTabRect(num2).X;
					tabRect = ((TabControl)this).GetTabRect(num2);
					obj8.DrawLine(val8, point2, new Point(x8, tabRect.Height + 3));
					num = 25;
					break;
				}
				goto case 26;
			case 23:
				flag = ((TabControl)this).get_SelectedIndex() == 0;
				num = 24;
				break;
			case 22:
			{
				Graphics obj7 = val2;
				Pen val7 = new Pen(Color.FromArgb(90, 90, 90));
				Point point = new Point(((TabControl)this).GetTabRect(num2).Right, 4);
				int right = ((TabControl)this).GetTabRect(num2).Right;
				tabRect = ((TabControl)this).GetTabRect(num2);
				obj7.DrawLine(val7, point, new Point(right, tabRect.Height + 3));
				num = 23;
				break;
			}
			case 21:
			{
				Graphics obj5 = val2;
				LinearGradientBrush obj6 = val6;
				int x7 = ((TabControl)this).GetTabRect(num2).X;
				int y7 = ((TabControl)this).GetTabRect(num2).Y + 2;
				int width7 = ((TabControl)this).GetTabRect(num2).Width + 2;
				tabRect = ((TabControl)this).GetTabRect(num2);
				obj5.FillRectangle((Brush)(object)obj6, new Rectangle(x7, y7, width7, tabRect.Height - 1));
				num = 22;
				break;
			}
			case 20:
			{
				int x6 = tabRect.X;
				int y6 = ((TabControl)this).GetTabRect(num2).Y + 2;
				int width6 = ((TabControl)this).GetTabRect(num2).Width + 2;
				tabRect = ((TabControl)this).GetTabRect(num2);
				val6 = new LinearGradientBrush(new Rectangle(x6, y6, width6, tabRect.Height - 1), Color.FromArgb(15, Color.White), Color.Transparent, 90f);
				num = 21;
				break;
			}
			case 19:
				tabRect = ((TabControl)this).GetTabRect(num2);
				num = 20;
				break;
			case 18:
			{
				Graphics obj4 = val2;
				SolidBrush val5 = new SolidBrush(Color.FromArgb(230, 20, 20, 20));
				int x5 = ((TabControl)this).GetTabRect(num2).X;
				int y5 = ((TabControl)this).GetTabRect(num2).Y + 3;
				int width5 = ((TabControl)this).GetTabRect(num2).Width + 1;
				tabRect = ((TabControl)this).GetTabRect(num2);
				obj4.FillRectangle((Brush)val5, new Rectangle(x5, y5, width5, tabRect.Height - 2));
				num = 19;
				break;
			}
			case 17:
			{
				Graphics obj2 = val2;
				HatchBrush obj3 = val3;
				int x4 = ((TabControl)this).GetTabRect(num2).X;
				int y4 = ((TabControl)this).GetTabRect(num2).Y + 3;
				int width4 = ((TabControl)this).GetTabRect(num2).Width + 1;
				tabRect = ((TabControl)this).GetTabRect(num2);
				obj2.FillRectangle((Brush)(object)obj3, new Rectangle(x4, y4, width4, tabRect.Height - 2));
				num = 18;
				break;
			}
			case 16:
				val3 = new HatchBrush((HatchStyle)18, Color.DimGray);
				num = 17;
				break;
			case 15:
			{
				Graphics obj = val2;
				SolidBrush val4 = new SolidBrush(Color.FromArgb(60, 60, 60));
				int x3 = ((TabControl)this).GetTabRect(num2).X;
				int y3 = ((TabControl)this).GetTabRect(num2).Y + 3;
				int width3 = ((TabControl)this).GetTabRect(num2).Width + 1;
				tabRect = ((TabControl)this).GetTabRect(num2);
				obj.FillRectangle((Brush)val4, new Rectangle(x3, y3, width3, tabRect.Height - 2));
				num = 16;
				break;
			}
			case 14:
				val3 = new HatchBrush((HatchStyle)20, Color.FromArgb(35, Color.Black), Color.FromArgb(0, Color.Gray));
				num = 15;
				break;
			case 13:
				if (!flag)
				{
					int x = ((TabControl)this).GetTabRect(num2).X;
					int y = ((TabControl)this).GetTabRect(num2).Y + 2;
					int width = ((TabControl)this).GetTabRect(num2).Width + 2;
					tabRect = ((TabControl)this).GetTabRect(num2);
					rectangle = new Rectangle(x, y, width, tabRect.Height - 1);
					num = 14;
				}
				else
				{
					int x2 = ((TabControl)this).GetTabRect(num2).X;
					int y2 = ((TabControl)this).GetTabRect(num2).Y + 2;
					int width2 = ((TabControl)this).GetTabRect(num2).Width + 2;
					tabRect = ((TabControl)this).GetTabRect(num2);
					rectangle = new Rectangle(x2, y2, width2, tabRect.Height - 1);
					num = 29;
				}
				break;
			case 11:
				num2 = 0;
				num = 12;
				break;
			case 10:
				val2.DrawRectangle(new Pen(Color.FromArgb(90, 90, 90)), new Rectangle(new Point(1, 4), new Size(((Control)this).get_Width() - 3, ((Control)this).get_Height() - 6)));
				num = 11;
				break;
			case 9:
				val2.DrawRectangle(Pens.get_Black(), new Rectangle(new Point(0, 3), new Size(((Control)this).get_Width() - 1, ((Control)this).get_Height() - 4)));
				num = 10;
				break;
			case 8:
				val2.FillRectangle(Brushes.get_Black(), new Rectangle(new Point(0, 4), new Size(((Control)this).get_Width() - 2, 20)));
				num = 9;
				break;
			case 7:
				val2.FillRectangle((Brush)new SolidBrush(Color.FromArgb(230, 20, 20, 20)), 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
				num = 8;
				break;
			case 6:
				val2.FillRectangle((Brush)(object)val3, 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
				num = 7;
				break;
			case 5:
				val3 = new HatchBrush((HatchStyle)18, Color.DimGray);
				num = 6;
				break;
			case 4:
				val2.FillRectangle((Brush)new SolidBrush(Color.FromArgb(60, 60, 60)), new Rectangle(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height()));
				num = 5;
				break;
			case 3:
				val3 = new HatchBrush((HatchStyle)20, Color.FromArgb(35, Color.Black), Color.FromArgb(0, Color.Gray));
				num = 4;
				break;
			case 2:
				val3 = null;
				num = 3;
				break;
			case 1:
				val2.Clear(Color.FromArgb(60, 60, 60));
				num = 2;
				break;
			case 0:
				val2 = Graphics.FromImage((Image)(object)val);
				num = 1;
				break;
			default:
				return;
			}
		}
	}
}
