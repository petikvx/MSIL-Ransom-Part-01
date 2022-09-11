using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ns1;

public class EtherealMinimize : Control
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 22)]
	private struct Struct2
	{
	}

	private HelperMethods.MouseMode mouseMode_0;

	private Color color_0;

	private static readonly Array array_0;

	private static readonly object object_0 = new char[11];

	private static readonly Array array_1;

	internal static byte byte_0/* Not supported: data(00) */;

	internal Color color_1;

	internal Color color_2;

	internal Color color_3;

	public Color NormalColor
	{
		get
		{
			return color_1;
		}
		set
		{
			Color color = (color_1 = value);
			((Control)this).Invalidate();
		}
	}

	public Color PushedColor
	{
		get
		{
			return color_0;
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
			return color_2;
		}
		set
		{
			Color color = (color_2 = value);
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
			Color color = (color_3 = value);
			((Control)this).Invalidate();
		}
	}

	public EtherealMinimize()
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		Color color = (color_1 = HelperMethods.smethod_11(" "));
		Color color2 = (color_2 = HelperMethods.smethod_11(" "));
		color_0 = HelperMethods.smethod_11(" ");
		Color color3 = (color_3 = Color.White);
		((Control)this)._002Ector();
		((Control)this).SetStyle((ControlStyles)141330, true);
		((Control)this).set_DoubleBuffered(true);
		((Control)this).UpdateStyles();
		((Control)this).set_BackColor(Color.Transparent);
		((Control)this).set_Font(new Font(" ", 9f));
		((Control)this).set_Size(new Size(21, 21));
	}

	protected override void vmethod_0(PaintEventArgs paintEventArgs_0)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected O, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		((Control)this).OnPaint(paintEventArgs_0);
		new Rectangle(0, 0, 22, 22);
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		try
		{
			val2.Clear(HelperMethods.smethod_11(" "));
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
			val2.DrawString(" ", ((Control)this).get_Font(), (Brush)new SolidBrush(TextColor), (RectangleF)new Rectangle(Convert.ToInt32(4.5), Convert.ToInt32(2.6), 18, 18));
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
		((Control)this).set_Size(new Size(22, 22));
	}

	protected override void vmethod_2(EventArgs eventArgs_0)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).OnClick(eventArgs_0);
		if ((int)((Control)this).FindForm().get_WindowState() == 0)
		{
			((Control)this).FindForm().set_WindowState((FormWindowState)1);
		}
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

	static EtherealMinimize()
	{
		char[] array = new char[8];
		array[6] = '㕜';
		array[2] = 'ⴍ';
		array[4] = 'ၦ';
		array[7] = 'ᖬ';
		array[0] = '㺯';
		array[5] = 'ᄯ';
		array[1] = '㠼';
		array[3] = 'ջ';
		array_1 = new string[2];
		array_0 = array;
	}
}
