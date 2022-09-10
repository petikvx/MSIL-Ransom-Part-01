using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class GClass2 : ListBox
{
	public GClass2()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		if (1 == 0)
		{
		}
		((ListBox)this)._002Ector();
		((Control)this).SetStyle((ControlStyles)65536, true);
		((Control)this).set_Font(new Font("Microsoft Sans Serif", 9f));
		((ListBox)this).set_BorderStyle((BorderStyle)0);
		((ListBox)this).set_DrawMode((DrawMode)1);
		((ListBox)this).set_ItemHeight(20);
		((Control)this).set_ForeColor(Color.DeepSkyBlue);
		((Control)this).set_BackColor(Color.FromArgb(7, 7, 7));
		((ListBox)this).set_IntegralHeight(false);
	}

	protected override void WndProc(ref Message m)
	{
		((ListBox)this).WndProc(ref m);
		int num = 0;
		bool flag = default(bool);
		while (true)
		{
			switch (num)
			{
			case 1:
				if (!flag)
				{
					method_0();
					num = 2;
					break;
				}
				return;
			case 0:
				flag = ((Message)(ref m)).get_Msg() != 15;
				num = 1;
				break;
			default:
				return;
			}
		}
	}

	protected override void OnDrawItem(DrawItemEventArgs e)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected O, but got Unknown
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected O, but got Unknown
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			bool flag = e.get_Index() >= 0;
			int num = 0;
			LinearGradientBrush val = default(LinearGradientBrush);
			HatchBrush val2 = default(HatchBrush);
			Rectangle rectangle2 = default(Rectangle);
			Rectangle rectangle3 = default(Rectangle);
			while (true)
			{
				switch (num)
				{
				case 18:
					((ListBox)this).OnDrawItem(e);
					num = 19;
					break;
				case 17:
					e.get_Graphics().DrawRectangle(new Pen(Color.FromArgb(90, 90, 90)), new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1));
					num = 18;
					break;
				case 15:
				case 16:
					e.get_Graphics().DrawRectangle(new Pen(Color.FromArgb(0, 0, 0)), new Rectangle(1, 1, ((Control)this).get_Width() - 3, ((Control)this).get_Height() - 3));
					num = 17;
					break;
				case 14:
					e.get_Graphics().DrawString(" " + ((ListBox)this).get_Items().get_Item(e.get_Index()).ToString(), ((Control)this).get_Font(), Brushes.get_White(), (float)e.get_Bounds().X, (float)(e.get_Bounds().Y + 1));
					num = 15;
					break;
				case 13:
					((Brush)val).Dispose();
					num = 14;
					break;
				case 12:
					e.get_Graphics().FillRectangle((Brush)(object)val2, rectangle2);
					num = 13;
					break;
				case 11:
					e.get_Graphics().FillRectangle((Brush)new SolidBrush(Color.FromArgb(25, Color.White)), rectangle3);
					num = 12;
					break;
				case 10:
					((Brush)val).Dispose();
					num = 11;
					break;
				case 9:
					e.get_Graphics().FillRectangle((Brush)(object)val, rectangle2);
					num = 10;
					break;
				case 8:
					val2 = new HatchBrush((HatchStyle)20, Color.FromArgb(15, Color.Black), Color.Transparent);
					num = 9;
					break;
				case 7:
					val = new LinearGradientBrush(new Point(rectangle2.X, rectangle2.Y), new Point(rectangle2.X, rectangle2.Y + rectangle2.Height), Color.FromArgb(60, 60, 60), Color.FromArgb(50, 50, 50));
					num = 8;
					break;
				case 6:
					rectangle3 = new Rectangle(rectangle2.Location, new Size(rectangle2.Width, rectangle2.Height / 2));
					num = 7;
					break;
				case 5:
					rectangle2 = new Rectangle(e.get_Bounds().Location, new Size(e.get_Bounds().Width - 1, e.get_Bounds().Height));
					num = 6;
					break;
				case 4:
					if (!flag)
					{
						e.get_Graphics().FillRectangle(Brushes.get_Black(), e.get_Bounds());
						num = 5;
					}
					else
					{
						e.get_Graphics().DrawString(" " + ((ListBox)this).get_Items().get_Item(e.get_Index()).ToString(), ((Control)this).get_Font(), Brushes.get_White(), (float)e.get_Bounds().X, (float)(e.get_Bounds().Y + 1));
						num = 16;
					}
					break;
				case 3:
					flag = !((object)e.get_State()).ToString()!.Contains("Selected");
					num = 4;
					break;
				case 2:
					e.DrawFocusRectangle();
					num = 3;
					break;
				case 1:
				{
					Rectangle rectangle = new Rectangle(new Point(e.get_Bounds().Left, e.get_Bounds().Top + 2), new Size(((Control)this).get_Bounds().Width, 16));
					num = 2;
					break;
				}
				case 0:
					if (flag)
					{
						e.DrawBackground();
						num = 1;
						break;
					}
					return;
				default:
					return;
				}
			}
		}
		catch
		{
		}
	}

	public void method_0()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		((Control)this).CreateGraphics().DrawRectangle(new Pen(Color.FromArgb(0, 0, 0)), new Rectangle(1, 1, ((Control)this).get_Width() - 3, ((Control)this).get_Height() - 3));
		for (int num = 0; num == 0; num = 1)
		{
			((Control)this).CreateGraphics().DrawRectangle(new Pen(Color.FromArgb(90, 90, 90)), new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1));
		}
	}
}
