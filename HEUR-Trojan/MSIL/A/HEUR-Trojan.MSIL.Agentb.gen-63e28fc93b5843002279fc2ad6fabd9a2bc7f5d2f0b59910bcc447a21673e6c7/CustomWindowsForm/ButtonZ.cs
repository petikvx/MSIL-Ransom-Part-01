using System;
using System.Drawing;
using System.Windows.Forms;

namespace CustomWindowsForm;

public class ButtonZ : Button
{
	private Color clr1;

	private Color color = Color.Teal;

	private Color m_hovercolor = Color.FromArgb(0, 0, 140);

	private Color clickcolor = Color.FromArgb(160, 180, 200);

	private int textX = 6;

	private int textY = -20;

	private string text = "_";

	public string DisplayText
	{
		get
		{
			return text;
		}
		set
		{
			text = value;
			((Control)this).Invalidate();
		}
	}

	public Color BZBackColor
	{
		get
		{
			return color;
		}
		set
		{
			color = value;
			((Control)this).Invalidate();
		}
	}

	public Color MouseHoverColor
	{
		get
		{
			return m_hovercolor;
		}
		set
		{
			m_hovercolor = value;
			((Control)this).Invalidate();
		}
	}

	public Color MouseClickColor1
	{
		get
		{
			return clickcolor;
		}
		set
		{
			clickcolor = value;
			((Control)this).Invalidate();
		}
	}

	public int TextLocation_X
	{
		get
		{
			return textX;
		}
		set
		{
			textX = value;
			((Control)this).Invalidate();
		}
	}

	public int TextLocation_Y
	{
		get
		{
			return textY;
		}
		set
		{
			textY = value;
			((Control)this).Invalidate();
		}
	}

	public ButtonZ()
	{
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		((Control)this).set_Size(new Size(31, 24));
		((Control)this).set_ForeColor(Color.White);
		((ButtonBase)this).set_FlatStyle((FlatStyle)0);
		((Control)this).set_Font(new Font("Microsoft YaHei UI", 20.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)this).set_Text("_");
		text = ((Control)this).get_Text();
	}

	protected override void OnMouseEnter(EventArgs e)
	{
		((Button)this).OnMouseEnter(e);
		clr1 = color;
		color = m_hovercolor;
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		((Button)this).OnMouseLeave(e);
		color = clr1;
	}

	protected override void OnMouseDown(MouseEventArgs mevent)
	{
		((ButtonBase)this).OnMouseDown(mevent);
		color = clickcolor;
	}

	protected override void OnMouseUp(MouseEventArgs mevent)
	{
		((Button)this).OnMouseUp(mevent);
		color = clr1;
	}

	protected override void OnPaint(PaintEventArgs pe)
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		((ButtonBase)this).OnPaint(pe);
		text = ((Control)this).get_Text();
		if (textX == 100 && textY == 25)
		{
			textX = ((Control)this).get_Width() / 3 + 10;
			textY = ((Control)this).get_Height() / 2 - 1;
		}
		Point point = new Point(textX, textY);
		pe.get_Graphics().FillRectangle((Brush)new SolidBrush(color), ((Control)this).get_ClientRectangle());
		pe.get_Graphics().DrawString(text, ((Control)this).get_Font(), (Brush)new SolidBrush(((Control)this).get_ForeColor()), (PointF)point);
	}
}
