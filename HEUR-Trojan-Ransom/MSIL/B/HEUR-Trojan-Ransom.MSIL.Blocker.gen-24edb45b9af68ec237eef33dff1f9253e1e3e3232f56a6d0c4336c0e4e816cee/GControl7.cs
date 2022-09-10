using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class GControl7 : GControl2
{
	private ListBox listBox_0;

	private string[] string_1;

	public ListBox ListBox_0
	{
		get
		{
			if (1 == 0)
			{
			}
			return listBox_0;
		}
		set
		{
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected O, but got Unknown
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			bool flag = listBox_0 == null;
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 3:
					if (!flag)
					{
						listBox_0.add_DrawItem(new DrawItemEventHandler(listBox_0_DrawItem));
						num = 4;
						break;
					}
					return;
				case 2:
					flag = listBox_0 == null;
					num = 3;
					break;
				case 1:
					listBox_0 = value;
					num = 2;
					break;
				case 0:
					if (!flag)
					{
						listBox_0.remove_DrawItem(new DrawItemEventHandler(listBox_0_DrawItem));
						num = 1;
						break;
					}
					goto case 1;
				default:
					return;
				}
			}
		}
	}

	public string[] String_1
	{
		get
		{
			if (1 == 0)
			{
			}
			return string_1;
		}
		set
		{
			string_1 = value;
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 3:
					((Control)this).Invalidate();
					num = 4;
					break;
				case 2:
					ListBox_0.get_Items().AddRange((object[])value);
					num = 3;
					break;
				case 1:
					((Control)this).Invalidate();
					num = 2;
					break;
				case 0:
					ListBox_0.get_Items().Clear();
					num = 1;
					break;
				default:
					return;
				}
			}
		}
	}

	public string String_2
	{
		get
		{
			if (1 == 0)
			{
			}
			return ListBox_0.get_SelectedItem().ToString();
		}
	}

	public GControl7()
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		if (1 == 0)
		{
		}
		listBox_0 = new ListBox();
		string_1 = new string[1] { "" };
		base._002Ector();
		((Control)this).get_Controls().Add((Control)(object)ListBox_0);
		((Control)this).set_Size(new Size(131, 101));
		((Control)ListBox_0).set_BackColor(Color.FromArgb(0, 0, 0));
		ListBox_0.set_BorderStyle((BorderStyle)0);
		ListBox_0.set_DrawMode((DrawMode)2);
		((Control)ListBox_0).set_Location(new Point(3, 3));
		((Control)ListBox_0).set_ForeColor(Color.White);
		ListBox_0.set_ItemHeight(20);
		ListBox_0.get_Items().Clear();
		ListBox_0.set_IntegralHeight(false);
		((Control)this).Invalidate();
	}

	protected override void vmethod_0()
	{
	}

	protected override void OnResize(EventArgs e)
	{
		((Control)this).OnResize(e);
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 1:
				((Control)ListBox_0).set_Height(((Control)this).get_Height() - 4);
				num = 2;
				break;
			case 0:
				((Control)ListBox_0).set_Width(((Control)this).get_Width() - 4);
				num = 1;
				break;
			default:
				return;
			}
		}
	}

	protected override void vmethod_1()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		graphics_0.Clear(Color.Black);
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 2:
				((Control)ListBox_0).set_Size(new Size(((Control)this).get_Width() - 5, ((Control)this).get_Height() - 5));
				num = 3;
				break;
			case 1:
				graphics_0.DrawRectangle(new Pen(Color.FromArgb(90, 90, 90)), 1, 1, ((Control)this).get_Width() - 3, ((Control)this).get_Height() - 3);
				num = 2;
				break;
			case 0:
				graphics_0.DrawRectangle(Pens.get_Black(), 0, 0, ((Control)this).get_Width() - 2, ((Control)this).get_Height() - 2);
				num = 1;
				break;
			default:
				return;
			}
		}
	}

	public void listBox_0_DrawItem(object sender, DrawItemEventArgs e)
	{
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		bool flag = e.get_Index() >= 0;
		int num = 0;
		LinearGradientBrush val2 = default(LinearGradientBrush);
		HatchBrush val = default(HatchBrush);
		Rectangle rectangle = default(Rectangle);
		Rectangle rectangle2 = default(Rectangle);
		while (true)
		{
			switch (num)
			{
			case 13:
				e.get_Graphics().DrawString(" " + ListBox_0.get_Items().get_Item(e.get_Index()).ToString(), ((Control)this).get_Font(), Brushes.get_White(), (float)e.get_Bounds().X, (float)(e.get_Bounds().Y + 2));
				num = 14;
				break;
			case 12:
				((Brush)val2).Dispose();
				num = 13;
				break;
			case 11:
				e.get_Graphics().FillRectangle((Brush)(object)val, rectangle);
				num = 12;
				break;
			case 10:
				e.get_Graphics().FillRectangle((Brush)new SolidBrush(Color.FromArgb(25, Color.White)), rectangle2);
				num = 11;
				break;
			case 9:
				((Brush)val2).Dispose();
				num = 10;
				break;
			case 8:
				e.get_Graphics().FillRectangle((Brush)(object)val2, rectangle);
				num = 9;
				break;
			case 7:
				val = new HatchBrush((HatchStyle)20, Color.FromArgb(15, Color.Black), Color.Transparent);
				num = 8;
				break;
			case 6:
				val2 = new LinearGradientBrush(new Point(rectangle.X, rectangle.Y), new Point(rectangle.X, rectangle.Y + rectangle.Height), Color.FromArgb(60, 60, 60), Color.FromArgb(50, 50, 50));
				num = 7;
				break;
			case 5:
				rectangle2 = new Rectangle(rectangle.Location, new Size(rectangle.Width, rectangle.Height / 2 - 2));
				num = 6;
				break;
			case 4:
				rectangle = new Rectangle(e.get_Bounds().Location, new Size(e.get_Bounds().Width - 1, e.get_Bounds().Height));
				num = 5;
				break;
			case 3:
				if (!flag)
				{
					e.get_Graphics().FillRectangle(Brushes.get_Black(), e.get_Bounds());
					num = 4;
				}
				else
				{
					e.get_Graphics().DrawString(" " + ListBox_0.get_Items().get_Item(e.get_Index()).ToString(), ((Control)this).get_Font(), Brushes.get_White(), (float)e.get_Bounds().X, (float)(e.get_Bounds().Y + 2));
					num = 15;
				}
				break;
			case 2:
				flag = !((object)e.get_State()).ToString()!.Contains("Selected");
				num = 3;
				break;
			case 1:
				e.DrawFocusRectangle();
				num = 2;
				break;
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

	public void method_68(object[] object_0)
	{
		ListBox_0.get_Items().Remove((object)"");
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
				ListBox_0.get_Items().AddRange(object_0);
				num = 1;
				break;
			default:
				return;
			}
		}
	}

	public void method_69(object object_0)
	{
		ListBox_0.get_Items().Remove((object)"");
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
				ListBox_0.get_Items().Add(object_0);
				num = 1;
				break;
			default:
				return;
			}
		}
	}
}
