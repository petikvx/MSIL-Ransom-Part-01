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

	private Color color_0 = HelperMethods.smethod_11(" ");

	private int int_0 = 5;

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
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
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
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected O, but got Unknown
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Expected O, but got Unknown
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Expected O, but got Unknown
		//IL_0477: Unknown result type (might be due to invalid IL or missing references)
		//IL_0482: Expected O, but got Unknown
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
					color_0 = HelperMethods.smethod_11(" ");
					HelperMethods.smethod_5(val2, color_0, 1f, rectangle_, RoundRadius);
					HelperMethods.smethod_16(val2, ((Control)this).get_Text(), ((Control)this).get_Font(), (Brush)(object)HelperMethods.smethod_10(" "), rectangle_);
					break;
				case Style.DarkClear:
					color_0 = HelperMethods.smethod_11(" ");
					HelperMethods.smethod_5(val2, color_0, 1f, rectangle_, RoundRadius);
					HelperMethods.smethod_16(val2, ((Control)this).get_Text(), ((Control)this).get_Font(), (Brush)(object)HelperMethods.smethod_10(" "), rectangle_);
					break;
				case Style.SemiBlack:
					HelperMethods.smethod_3(val2, color_0, rectangle_, RoundRadius);
					HelperMethods.smethod_5(val2, HelperMethods.smethod_11(" "), 1f, rectangle_, RoundRadius);
					HelperMethods.smethod_16(val2, ((Control)this).get_Text(), ((Control)this).get_Font(), Brushes.get_White(), rectangle_);
					break;
				case Style.DarkPink:
					color_0 = HelperMethods.smethod_11(" ");
					HelperMethods.smethod_3(val2, color_0, rectangle_, RoundRadius);
					HelperMethods.smethod_5(val2, HelperMethods.smethod_11(" "), 1f, rectangle_, RoundRadius);
					HelperMethods.smethod_16(val2, ((Control)this).get_Text(), ((Control)this).get_Font(), Brushes.get_White(), rectangle_);
					break;
				case Style.LightPink:
					color_0 = HelperMethods.smethod_11(" ");
					HelperMethods.smethod_3(val2, color_0, rectangle_, RoundRadius);
					HelperMethods.smethod_5(val2, HelperMethods.smethod_11(" "), 1f, rectangle_, RoundRadius);
					HelperMethods.smethod_16(val2, ((Control)this).get_Text(), ((Control)this).get_Font(), Brushes.get_White(), rectangle_);
					break;
				}
				break;
			case HelperMethods.MouseMode.Hovered:
				color_0 = HelperMethods.smethod_11(" ");
				switch (ButtonStyle)
				{
				case Style.Clear:
					color_0 = HelperMethods.smethod_11(" ");
					HelperMethods.smethod_5(val2, color_0, 1f, rectangle_, RoundRadius);
					HelperMethods.smethod_16(val2, ((Control)this).get_Text(), ((Control)this).get_Font(), (Brush)(object)HelperMethods.smethod_10(" "), rectangle_);
					break;
				case Style.DarkClear:
					color_0 = HelperMethods.smethod_11(" ");
					HelperMethods.smethod_5(val2, color_0, 1f, rectangle_, RoundRadius);
					HelperMethods.smethod_16(val2, ((Control)this).get_Text(), ((Control)this).get_Font(), (Brush)(object)HelperMethods.smethod_10(" "), rectangle_);
					break;
				case Style.SemiBlack:
					color_0 = HelperMethods.smethod_11(" ");
					HelperMethods.smethod_18(val2, (Brush)new SolidBrush(Color.Transparent), rectangle_);
					HelperMethods.smethod_5(val2, color_0, 1f, rectangle_, RoundRadius);
					HelperMethods.smethod_16(val2, ((Control)this).get_Text(), ((Control)this).get_Font(), (Brush)(object)HelperMethods.smethod_10(" "), rectangle_);
					break;
				case Style.DarkPink:
					color_0 = HelperMethods.smethod_11(" ");
					HelperMethods.smethod_18(val2, (Brush)new SolidBrush(Color.Transparent), rectangle_);
					HelperMethods.smethod_5(val2, color_0, 1f, rectangle_, RoundRadius);
					HelperMethods.smethod_16(val2, ((Control)this).get_Text(), ((Control)this).get_Font(), (Brush)(object)HelperMethods.smethod_10(" "), rectangle_);
					break;
				case Style.LightPink:
					color_0 = HelperMethods.smethod_11(" ");
					HelperMethods.smethod_18(val2, (Brush)new SolidBrush(Color.Transparent), rectangle_);
					HelperMethods.smethod_5(val2, color_0, 1f, rectangle_, RoundRadius);
					HelperMethods.smethod_16(val2, ((Control)this).get_Text(), ((Control)this).get_Font(), (Brush)(object)HelperMethods.smethod_10(" "), rectangle_);
					break;
				}
				break;
			case HelperMethods.MouseMode.Pushed:
				switch (ButtonStyle)
				{
				case Style.SemiBlack:
				case Style.DarkPink:
				case Style.LightPink:
					color_0 = HelperMethods.smethod_11(" ");
					HelperMethods.smethod_5(val2, color_0, 1f, rectangle_, 5);
					HelperMethods.smethod_16(val2, ((Control)this).get_Text(), ((Control)this).get_Font(), (Brush)(object)HelperMethods.smethod_10(" "), rectangle_);
					break;
				case Style.Clear:
				case Style.DarkClear:
					color_0 = HelperMethods.smethod_11(" ");
					HelperMethods.smethod_18(val2, (Brush)new SolidBrush(Color.Transparent), rectangle_);
					HelperMethods.smethod_5(val2, color_0, 1f, rectangle_, 5);
					HelperMethods.smethod_16(val2, ((Control)this).get_Text(), ((Control)this).get_Font(), (Brush)(object)HelperMethods.smethod_10(" "), rectangle_);
					break;
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
