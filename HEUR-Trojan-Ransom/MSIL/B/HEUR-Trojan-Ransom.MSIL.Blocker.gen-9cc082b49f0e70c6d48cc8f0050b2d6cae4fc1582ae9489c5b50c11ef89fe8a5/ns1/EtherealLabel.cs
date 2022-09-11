using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace ns1;

public class EtherealLabel : Control
{
	public enum Style
	{
		SemiBlack,
		DarkPink,
		LightPink
	}

	private Style style_0 = Style.DarkPink;

	public Style ColorStyle
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

	public EtherealLabel()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		((Control)this).SetStyle((ControlStyles)133122, true);
		((Control)this).set_DoubleBuffered(true);
		((Control)this).set_Font(new Font(" ", 10f, (FontStyle)1));
	}

	protected override void vmethod_0(PaintEventArgs paintEventArgs_0)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		((Control)this).OnPaint(paintEventArgs_0);
		new Rectangle(0, 0, 22, 22);
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		try
		{
			val2.set_TextRenderingHint((TextRenderingHint)4);
			switch (ColorStyle)
			{
			case Style.SemiBlack:
				val2.DrawString(((Control)this).get_Text(), ((Control)this).get_Font(), (Brush)(object)HelperMethods.smethod_10(" "), (RectangleF)((Control)this).get_ClientRectangle());
				break;
			case Style.DarkPink:
				val2.DrawString(((Control)this).get_Text(), ((Control)this).get_Font(), (Brush)(object)HelperMethods.smethod_10(" "), (RectangleF)((Control)this).get_ClientRectangle());
				break;
			case Style.LightPink:
				val2.DrawString(((Control)this).get_Text(), ((Control)this).get_Font(), (Brush)(object)HelperMethods.smethod_10(" "), (RectangleF)((Control)this).get_ClientRectangle());
				break;
			}
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
