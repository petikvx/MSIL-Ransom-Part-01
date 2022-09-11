using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace ns1;

public class EtherealTabControl : TabControl
{
	public struct MouseState
	{
		public bool Hover;

		public Point Coordinates;
	}

	private MouseState mouseState_0;

	private Color color_0;

	private Color color_1;

	private Color color_2;

	private Color color_3;

	private Color color_4;

	internal Color color_5;

	internal Color color_6;

	internal Color color_7;

	internal Color color_8;

	public Color TabsColor
	{
		get
		{
			return color_5;
		}
		set
		{
			Color color = (color_5 = value);
			((Control)this).Invalidate();
		}
	}

	public Color SeletedTabTriangleColor
	{
		get
		{
			return color_0;
		}
		set
		{
			color_0 = value;
			((Control)this).Invalidate();
		}
	}

	public Color LeftColor
	{
		get
		{
			return color_6;
		}
		set
		{
			Color color = (color_6 = value);
			((Control)this).Invalidate();
		}
	}

	public Color RightColor
	{
		get
		{
			return color_7;
		}
		set
		{
			Color color = (color_7 = value);
			((Control)this).Invalidate();
		}
	}

	public Color LineColor
	{
		get
		{
			return color_1;
		}
		set
		{
			color_1 = value;
			((Control)this).Invalidate();
		}
	}

	public Color NoneSelectedTabColors
	{
		get
		{
			return color_2;
		}
		set
		{
			color_2 = value;
			((Control)this).Invalidate();
		}
	}

	public Color HoverColor
	{
		get
		{
			return color_8;
		}
		set
		{
			Color color = (color_8 = value);
			((Control)this).Invalidate();
		}
	}

	public Color TextColor
	{
		get
		{
			return color_3;
		}
		set
		{
			color_3 = value;
			((Control)this).Invalidate();
		}
	}

	public Color TabPageColor
	{
		get
		{
			return color_4;
		}
		set
		{
			color_4 = value;
			((Control)this).Invalidate();
		}
	}

	public EtherealTabControl()
	{
		Color color = (color_5 = HelperMethods.smethod_11(" "));
		color_0 = Color.White;
		Color color2 = (color_6 = HelperMethods.smethod_11(" "));
		Color color3 = (color_7 = Color.White);
		color_1 = HelperMethods.smethod_11(" ");
		color_2 = HelperMethods.smethod_11(" ");
		Color color4 = (color_8 = HelperMethods.smethod_11(" "));
		color_3 = Color.White;
		color_4 = Color.White;
		((TabControl)this)._002Ector();
		((Control)this).SetStyle((ControlStyles)141314, true);
		((Control)this).set_DoubleBuffered(true);
		((TabControl)this).set_SizeMode((TabSizeMode)2);
		((Control)this).set_Dock((DockStyle)0);
		((TabControl)this).set_ItemSize(new Size(40, 150));
		((TabControl)this).set_Alignment((TabAlignment)2);
	}

	protected override void vmethod_0(EventArgs eventArgs_0)
	{
		mouseState_0.Hover = true;
		((Control)this).OnMouseEnter(eventArgs_0);
	}

	protected override void vmethod_1(EventArgs eventArgs_0)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		mouseState_0.Hover = false;
		foreach (TabPage tabPage in ((TabControl)this).get_TabPages())
		{
			if (((Control)tabPage).get_DisplayRectangle().Contains(mouseState_0.Coordinates))
			{
				((Control)this).Invalidate();
				break;
			}
		}
		((Control)this).OnMouseLeave(eventArgs_0);
	}

	protected override void vmethod_2(MouseEventArgs mouseEventArgs_0)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		mouseState_0.Coordinates = mouseEventArgs_0.get_Location();
		foreach (TabPage tabPage in ((TabControl)this).get_TabPages())
		{
			if (((Control)tabPage).get_DisplayRectangle().Contains(mouseEventArgs_0.get_Location()))
			{
				((Control)this).Invalidate();
				break;
			}
		}
		((Control)this).OnMouseMove(mouseEventArgs_0);
	}

	protected override void vmethod_3()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).OnCreateControl();
		foreach (TabPage tabPage in ((TabControl)this).get_TabPages())
		{
			((Control)tabPage).set_BackColor(TabPageColor);
		}
	}

	protected override void vmethod_4(PaintEventArgs paintEventArgs_0)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected O, but got Unknown
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected O, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected O, but got Unknown
		//IL_0201: Expected O, but got Unknown
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected O, but got Unknown
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Expected O, but got Unknown
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected O, but got Unknown
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Expected O, but got Unknown
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		try
		{
			val2.set_InterpolationMode((InterpolationMode)7);
			val2.set_TextRenderingHint((TextRenderingHint)4);
			HelperMethods.smethod_18(val2, (Brush)new SolidBrush(LeftColor), new Rectangle(0, 1, 150, ((Control)this).get_Height()));
			for (int i = 0; i <= ((TabControl)this).get_TabPages().get_Count() - 1; i++)
			{
				Rectangle tabRect = ((TabControl)this).GetTabRect(i);
				HelperMethods.smethod_18(val2, (Brush)new SolidBrush(NoneSelectedTabColors), new Rectangle(tabRect.X - 1, tabRect.Y - 1, tabRect.Width - 3, tabRect.Height));
				if (i == ((TabControl)this).get_SelectedIndex())
				{
					val2.set_SmoothingMode((SmoothingMode)4);
					Point point = new Point(((TabControl)this).get_ItemSize().Height - 12, tabRect.Location.Y + 20);
					Point point2 = new Point(((TabControl)this).get_ItemSize().Height + 2, tabRect.Location.Y + 10);
					Point point3 = new Point(((TabControl)this).get_ItemSize().Height + 2, tabRect.Location.Y + 30);
					val2.FillPolygon((Brush)new SolidBrush(SeletedTabTriangleColor), new Point[3] { point, point2, point3 });
				}
				else if (mouseState_0.Hover & tabRect.Contains(mouseState_0.Coordinates))
				{
					((Control)this).set_Cursor(Cursors.get_Hand());
					HelperMethods.smethod_18(val2, (Brush)new SolidBrush(HoverColor), new Rectangle(tabRect.X, tabRect.Y, tabRect.Width - 3, tabRect.Height));
				}
				val2.DrawString(((Control)((TabControl)this).get_TabPages().get_Item(i)).get_Text(), new Font(" ", 8f, (FontStyle)1), (Brush)new SolidBrush(TextColor), (float)(tabRect.X + 28), (float)(tabRect.Y + 13));
				if (((TabControl)this).get_ImageList() != null)
				{
					val2.DrawImage(((TabControl)this).get_ImageList().get_Images().get_Item(i), new Rectangle(tabRect.X + 6, tabRect.Y + 11, 16, 16));
				}
				val2.set_SmoothingMode((SmoothingMode)0);
				val2.DrawLine(new Pen(LineColor, 1f), new Point(tabRect.X - 1, tabRect.Bottom - 2), new Point(tabRect.Width - 2, tabRect.Bottom - 2));
			}
			val2.FillRectangle((Brush)new SolidBrush(RightColor), new Rectangle(150, Convert.ToInt32(1.3), ((Control)this).get_Width(), ((Control)this).get_Height() - 2));
			val2.DrawRectangle(new Pen(LineColor, 1f), new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1));
			paintEventArgs_0.get_Graphics().DrawImage((Image)((Image)val).Clone(), 0, 0);
			val2.Dispose();
			((Image)val).Dispose();
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
	}
}
