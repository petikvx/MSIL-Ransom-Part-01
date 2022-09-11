using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace ns1;

public class EtherealClose : Control
{
	private HelperMethods.MouseMode mouseMode_0;

	private Color color_0;

	private Color color_1;

	internal Color color_2;

	internal Color color_3;

	public Color NormalColor
	{
		get
		{
			return color_2;
		}
		set
		{
			Color color = (color_2 = value);
			((Control)this).Invalidate();
		}
	}

	public Color PushedColor
	{
		get
		{
			return color_3;
		}
		set
		{
			PushedColor = value;
			((Control)this).Invalidate();
		}
	}

	public Color HoverColor
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

	public Color TextColor
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

	public EtherealClose()
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		Color color = (color_2 = HelperMethods.smethod_11(" "));
		color_0 = HelperMethods.smethod_11(" ");
		Color color2 = (color_3 = HelperMethods.smethod_11(" "));
		color_1 = Color.White;
		((Control)this)._002Ector();
		((Control)this).SetStyle((ControlStyles)141330, true);
		((Control)this).set_DoubleBuffered(true);
		((Control)this).UpdateStyles();
		((Control)this).set_BackColor(Color.Transparent);
		((Control)this).set_Font(new Font(" ", 8f));
		((Control)this).set_Size(new Size(20, 20));
	}

	protected override void vmethod_0(PaintEventArgs paintEventArgs_0)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected O, but got Unknown
		((Control)this).OnPaint(paintEventArgs_0);
		new Rectangle(0, 0, 22, 22);
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		try
		{
			val2.set_SmoothingMode((SmoothingMode)2);
			val2.set_TextRenderingHint((TextRenderingHint)4);
			val2.set_PixelOffsetMode((PixelOffsetMode)2);
			switch (mouseMode_0)
			{
			case HelperMethods.MouseMode.NormalMode:
				val2.FillEllipse((Brush)new SolidBrush(NormalColor), 1, 1, 19, 19);
				break;
			case HelperMethods.MouseMode.Hovered:
				((Control)this).set_Cursor(Cursors.get_Hand());
				val2.FillEllipse((Brush)new SolidBrush(NormalColor), 1, 1, 19, 19);
				val2.DrawEllipse(new Pen(HoverColor, 2f), 1, 1, 18, 18);
				break;
			case HelperMethods.MouseMode.Pushed:
				val2.FillEllipse((Brush)new SolidBrush(PushedColor), 1, 1, 19, 19);
				break;
			}
			val2.DrawString(" ", ((Control)this).get_Font(), (Brush)new SolidBrush(TextColor), (RectangleF)new Rectangle(4, 6, 18, 18));
			paintEventArgs_0.get_Graphics().DrawImage((Image)((Image)val).Clone(), 0, 0);
			val2.Dispose();
			((Image)val).Dispose();
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
	}

	protected override void vmethod_1(EventArgs eventArgs_0)
	{
		((Control)this).OnResize(eventArgs_0);
		((Control)this).set_Size(new Size(20, 20));
	}

	protected override void vmethod_2(EventArgs eventArgs_0)
	{
		((Control)this).OnClick(eventArgs_0);
		Environment.Exit(0);
		Application.Exit();
	}

	protected override void vmethod_3(EventArgs eventArgs_0)
	{
		((Control)this).OnMouseEnter(eventArgs_0);
		mouseMode_0 = HelperMethods.MouseMode.Hovered;
		((Control)this).Invalidate();
	}

	protected override void vmethod_4(MouseEventArgs mouseEventArgs_0)
	{
		((Control)this).OnMouseUp(mouseEventArgs_0);
		mouseMode_0 = HelperMethods.MouseMode.Hovered;
		((Control)this).Invalidate();
	}

	protected override void vmethod_5(MouseEventArgs mouseEventArgs_0)
	{
		((Control)this).OnMouseDown(mouseEventArgs_0);
		mouseMode_0 = HelperMethods.MouseMode.Pushed;
		((Control)this).Invalidate();
	}

	protected override void vmethod_6(EventArgs eventArgs_0)
	{
		((Control)this).OnMouseLeave(eventArgs_0);
		mouseMode_0 = HelperMethods.MouseMode.NormalMode;
		((Control)this).Invalidate();
	}
}
