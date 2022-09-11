using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace ns1;

public class EtherealButton : Control
{
	public enum Style
	{
		Clear,
		DarkClear,
		SemiBlack,
		DarkPink,
		LightPink
	}

	private HelperMethods.MouseMode mouseMode_0;

	private Style style_0;

	private int int_0;

	internal Color color_0;

	public int RoundRadius
	{
		get
		{
			return int_0;
		}
		set
		{
			int_0 = value;
			((Control)this).Invalidate();
		}
	}

	public Style ButtonStyle
	{
		get
		{
			return style_0;
		}
		set
		{
			style_0 = value;
			((Control)this).Invalidate();
		}
	}

	public EtherealButton()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		Color color = (color_0 = HelperMethods.smethod_10(" "));
		int_0 = 5;
		((Control)this)._002Ector();
		((Control)this).SetStyle((ControlStyles)76306, true);
		((Control)this).set_DoubleBuffered(true);
		((Control)this).set_BackColor(Color.Transparent);
		((Control)this).set_Font(new Font(" ", 9f, (FontStyle)1));
	}

	protected override void vmethod_0(EventArgs eventArgs_0)
	{
		((Control)this).OnMouseEnter(eventArgs_0);
		mouseMode_0 = HelperMethods.MouseMode.Hovered;
		((Control)this).Invalidate();
	}

	protected override void vmethod_1(MouseEventArgs mouseEventArgs_0)
	{
		((Control)this).OnMouseUp(mouseEventArgs_0);
		mouseMode_0 = HelperMethods.MouseMode.Hovered;
		((Control)this).Invalidate();
	}

	protected override void vmethod_2(MouseEventArgs mouseEventArgs_0)
	{
		((Control)this).OnMouseDown(mouseEventArgs_0);
		mouseMode_0 = HelperMethods.MouseMode.Pushed;
		((Control)this).Invalidate();
	}

	protected override void vmethod_3(EventArgs eventArgs_0)
	{
		((Control)this).OnMouseLeave(eventArgs_0);
		mouseMode_0 = HelperMethods.MouseMode.NormalMode;
		((Control)this).Invalidate();
	}

	protected override void vmethod_4(PaintEventArgs paintEventArgs_0)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Expected O, but got Unknown
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0397: Expected O, but got Unknown
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f6: Expected O, but got Unknown
		//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Expected O, but got Unknown
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		try
		{
			Rectangle rectangle_ = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			HelperMethods.smethod_1(rectangle_, RoundRadius);
			val2.set_TextRenderingHint((TextRenderingHint)4);
			val2.set_SmoothingMode((SmoothingMode)2);
			switch (mouseMode_0)
			{
			case HelperMethods.MouseMode.NormalMode:
				switch (ButtonStyle)
				{
				case Style.Clear:
				{
					Color color12 = (color_0 = HelperMethods.smethod_10(" "));
					HelperMethods.smethod_4(val2, color_0, 1f, rectangle_, RoundRadius);
					HelperMethods.smethod_15(val2, ((Control)this).get_Text(), ((Control)this).get_Font(), (Brush)(object)HelperMethods.smethod_9(" "), rectangle_);
					break;
				}
				case Style.DarkClear:
				{
					Color color11 = (color_0 = HelperMethods.smethod_10(" "));
					HelperMethods.smethod_4(val2, color_0, 1f, rectangle_, RoundRadius);
					HelperMethods.smethod_15(val2, ((Control)this).get_Text(), ((Control)this).get_Font(), (Brush)(object)HelperMethods.smethod_9(" "), rectangle_);
					break;
				}
				case Style.SemiBlack:
					HelperMethods.smethod_2(val2, color_0, rectangle_, RoundRadius);
					HelperMethods.smethod_4(val2, HelperMethods.smethod_10(" "), 1f, rectangle_, RoundRadius);
					HelperMethods.smethod_15(val2, ((Control)this).get_Text(), ((Control)this).get_Font(), Brushes.get_White(), rectangle_);
					break;
				case Style.DarkPink:
				{
					Color color10 = (color_0 = HelperMethods.smethod_10(" "));
					HelperMethods.smethod_2(val2, color_0, rectangle_, RoundRadius);
					HelperMethods.smethod_4(val2, HelperMethods.smethod_10(" "), 1f, rectangle_, RoundRadius);
					HelperMethods.smethod_15(val2, ((Control)this).get_Text(), ((Control)this).get_Font(), Brushes.get_White(), rectangle_);
					break;
				}
				case Style.LightPink:
				{
					Color color9 = (color_0 = HelperMethods.smethod_10(" "));
					HelperMethods.smethod_2(val2, color_0, rectangle_, RoundRadius);
					HelperMethods.smethod_4(val2, HelperMethods.smethod_10(" "), 1f, rectangle_, RoundRadius);
					HelperMethods.smethod_15(val2, ((Control)this).get_Text(), ((Control)this).get_Font(), Brushes.get_White(), rectangle_);
					break;
				}
				}
				break;
			case HelperMethods.MouseMode.Hovered:
			{
				Color color3 = (color_0 = HelperMethods.smethod_10(" "));
				switch (ButtonStyle)
				{
				case Style.Clear:
				{
					Color color8 = (color_0 = HelperMethods.smethod_10(" "));
					HelperMethods.smethod_4(val2, color_0, 1f, rectangle_, RoundRadius);
					HelperMethods.smethod_15(val2, ((Control)this).get_Text(), ((Control)this).get_Font(), (Brush)(object)HelperMethods.smethod_9(" "), rectangle_);
					break;
				}
				case Style.DarkClear:
				{
					Color color7 = (color_0 = HelperMethods.smethod_10(" "));
					HelperMethods.smethod_4(val2, color_0, 1f, rectangle_, RoundRadius);
					HelperMethods.smethod_15(val2, ((Control)this).get_Text(), ((Control)this).get_Font(), (Brush)(object)HelperMethods.smethod_9(" "), rectangle_);
					break;
				}
				case Style.SemiBlack:
				{
					Color color6 = (color_0 = HelperMethods.smethod_10(" "));
					HelperMethods.smethod_17(val2, (Brush)new SolidBrush(Color.Transparent), rectangle_);
					HelperMethods.smethod_4(val2, color_0, 1f, rectangle_, RoundRadius);
					HelperMethods.smethod_15(val2, ((Control)this).get_Text(), ((Control)this).get_Font(), (Brush)(object)HelperMethods.smethod_9(" "), rectangle_);
					break;
				}
				case Style.DarkPink:
				{
					Color color5 = (color_0 = HelperMethods.smethod_10(" "));
					HelperMethods.smethod_17(val2, (Brush)new SolidBrush(Color.Transparent), rectangle_);
					HelperMethods.smethod_4(val2, color_0, 1f, rectangle_, RoundRadius);
					HelperMethods.smethod_15(val2, ((Control)this).get_Text(), ((Control)this).get_Font(), (Brush)(object)HelperMethods.smethod_9(" "), rectangle_);
					break;
				}
				case Style.LightPink:
				{
					Color color4 = (color_0 = HelperMethods.smethod_10(" "));
					HelperMethods.smethod_17(val2, (Brush)new SolidBrush(Color.Transparent), rectangle_);
					HelperMethods.smethod_4(val2, color_0, 1f, rectangle_, RoundRadius);
					HelperMethods.smethod_15(val2, ((Control)this).get_Text(), ((Control)this).get_Font(), (Brush)(object)HelperMethods.smethod_9(" "), rectangle_);
					break;
				}
				}
				break;
			}
			case HelperMethods.MouseMode.Pushed:
				switch (ButtonStyle)
				{
				case Style.SemiBlack:
				case Style.DarkPink:
				case Style.LightPink:
				{
					Color color2 = (color_0 = HelperMethods.smethod_10(" "));
					HelperMethods.smethod_4(val2, color_0, 1f, rectangle_, 5);
					HelperMethods.smethod_15(val2, ((Control)this).get_Text(), ((Control)this).get_Font(), (Brush)(object)HelperMethods.smethod_9(" "), rectangle_);
					break;
				}
				case Style.Clear:
				case Style.DarkClear:
				{
					Color color = (color_0 = HelperMethods.smethod_10(" "));
					HelperMethods.smethod_17(val2, (Brush)new SolidBrush(Color.Transparent), rectangle_);
					HelperMethods.smethod_4(val2, color_0, 1f, rectangle_, 5);
					HelperMethods.smethod_15(val2, ((Control)this).get_Text(), ((Control)this).get_Font(), (Brush)(object)HelperMethods.smethod_9(" "), rectangle_);
					break;
				}
				}
				break;
			}
			paintEventArgs_0.get_Graphics().DrawImage((Image)(object)val, 0, 0);
			val2.Dispose();
			((Image)val).Dispose();
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
	}
}
