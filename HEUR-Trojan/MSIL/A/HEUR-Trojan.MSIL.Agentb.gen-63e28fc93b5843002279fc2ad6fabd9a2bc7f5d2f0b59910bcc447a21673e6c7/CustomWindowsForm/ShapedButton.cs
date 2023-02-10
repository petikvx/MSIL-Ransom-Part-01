using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CustomWindowsForm;

public class ShapedButton : Button
{
	public enum ButtonsShapes
	{
		RoundRect,
		Circle
	}

	private Color clr1;

	private Color clr2;

	private Color color1 = Color.DodgerBlue;

	private Color color2 = Color.MidnightBlue;

	private Color m_hovercolor1 = Color.Turquoise;

	private Color m_hovercolor2 = Color.DarkSlateGray;

	private int color1Transparent = 250;

	private int color2Transparent = 250;

	private Color clickcolor1 = Color.Yellow;

	private Color clickcolor2 = Color.Red;

	private int angle = 90;

	private int textX = 100;

	private int textY = 25;

	private string text = "";

	public Color buttonborder = Color.FromArgb(220, 220, 220);

	public bool showButtonText = true;

	public int borderWidth = 2;

	public Color borderColor = Color.Transparent;

	private ButtonsShapes buttonShape;

	public ButtonsShapes ButtonShape
	{
		get
		{
			return buttonShape;
		}
		set
		{
			buttonShape = value;
			((Control)this).Invalidate();
		}
	}

	public string ButtonText
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

	public int BorderWidth
	{
		get
		{
			return borderWidth;
		}
		set
		{
			borderWidth = value;
			((Control)this).Invalidate();
		}
	}

	public Color BorderColor
	{
		get
		{
			return borderColor;
		}
		set
		{
			borderColor = value;
			if (borderColor == Color.Transparent)
			{
				buttonborder = Color.FromArgb(220, 220, 220);
			}
			else
			{
				SetBorderColor(borderColor);
			}
		}
	}

	public Color StartColor
	{
		get
		{
			return color1;
		}
		set
		{
			color1 = value;
			((Control)this).Invalidate();
		}
	}

	public Color EndColor
	{
		get
		{
			return color2;
		}
		set
		{
			color2 = value;
			((Control)this).Invalidate();
		}
	}

	public Color MouseHoverColor1
	{
		get
		{
			return m_hovercolor1;
		}
		set
		{
			m_hovercolor1 = value;
			((Control)this).Invalidate();
		}
	}

	public Color MouseHoverColor2
	{
		get
		{
			return m_hovercolor2;
		}
		set
		{
			m_hovercolor2 = value;
			((Control)this).Invalidate();
		}
	}

	public Color MouseClickColor1
	{
		get
		{
			return clickcolor1;
		}
		set
		{
			clickcolor1 = value;
			((Control)this).Invalidate();
		}
	}

	public Color MouseClickColor2
	{
		get
		{
			return clickcolor2;
		}
		set
		{
			clickcolor2 = value;
			((Control)this).Invalidate();
		}
	}

	public int Transparent1
	{
		get
		{
			return color1Transparent;
		}
		set
		{
			color1Transparent = value;
			if (color1Transparent > 255)
			{
				color1Transparent = 255;
				((Control)this).Invalidate();
			}
			else
			{
				((Control)this).Invalidate();
			}
		}
	}

	public int Transparent2
	{
		get
		{
			return color2Transparent;
		}
		set
		{
			color2Transparent = value;
			if (color2Transparent > 255)
			{
				color2Transparent = 255;
				((Control)this).Invalidate();
			}
			else
			{
				((Control)this).Invalidate();
			}
		}
	}

	public int GradientAngle
	{
		get
		{
			return angle;
		}
		set
		{
			angle = value;
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

	public bool ShowButtontext
	{
		get
		{
			return showButtonText;
		}
		set
		{
			showButtonText = value;
			((Control)this).Invalidate();
		}
	}

	private void SetBorderColor(Color bdrColor)
	{
		int num = bdrColor.R - 40;
		int num2 = bdrColor.G - 40;
		int num3 = bdrColor.B - 40;
		if (num < 0)
		{
			num = 0;
		}
		if (num2 < 0)
		{
			num2 = 0;
		}
		if (num3 < 0)
		{
			num3 = 0;
		}
		buttonborder = Color.FromArgb(num, num2, num3);
	}

	public ShapedButton()
	{
		((Control)this).set_Size(new Size(100, 40));
		((Control)this).set_BackColor(Color.Transparent);
		((ButtonBase)this).set_FlatStyle((FlatStyle)0);
		((ButtonBase)this).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)this).get_FlatAppearance().set_MouseOverBackColor(Color.Transparent);
		((ButtonBase)this).get_FlatAppearance().set_MouseDownBackColor(Color.Transparent);
		text = ((Control)this).get_Text();
	}

	protected override void OnMouseEnter(EventArgs e)
	{
		((Button)this).OnMouseEnter(e);
		clr1 = color1;
		clr2 = color2;
		color1 = m_hovercolor1;
		color2 = m_hovercolor2;
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		((Button)this).OnMouseLeave(e);
		color1 = clr1;
		color2 = clr2;
		SetBorderColor(borderColor);
	}

	protected override void OnMouseDown(MouseEventArgs mevent)
	{
		((ButtonBase)this).OnMouseDown(mevent);
		color1 = clickcolor1;
		color2 = clickcolor2;
		buttonborder = borderColor;
		SetBorderColor(borderColor);
		((Control)this).Invalidate();
	}

	protected override void OnMouseUp(MouseEventArgs mevent)
	{
		((Button)this).OnMouseUp(mevent);
		((Control)this).OnMouseLeave((EventArgs)(object)mevent);
		color1 = clr1;
		color2 = clr2;
		SetBorderColor(borderColor);
		((Control)this).Invalidate();
	}

	protected override void OnLostFocus(EventArgs e)
	{
		((ButtonBase)this).OnLostFocus(e);
		color1 = clr1;
		color2 = clr2;
		((Control)this).Invalidate();
	}

	protected override void OnResize(EventArgs e)
	{
		((Control)this).OnResize(e);
		textX = ((Control)this).get_Width() / 3 - 1;
		textY = ((Control)this).get_Height() / 3 + 5;
	}

	private void DrawCircularButton(Graphics g)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		Color color = Color.FromArgb(color1Transparent, color1);
		Color color2 = Color.FromArgb(color2Transparent, this.color2);
		Brush val = (Brush)new LinearGradientBrush(((Control)this).get_ClientRectangle(), color, color2, (float)angle);
		g.FillEllipse(val, 5, 5, ((Control)this).get_Width() - 10, ((Control)this).get_Height() - 10);
		for (int i = 0; i < borderWidth; i++)
		{
			g.DrawEllipse(new Pen((Brush)new SolidBrush(buttonborder)), 5 + i, 5, ((Control)this).get_Width() - 10, ((Control)this).get_Height() - 10);
		}
		if (showButtonText)
		{
			Point point = new Point(textX, textY);
			SolidBrush val2 = new SolidBrush(((Control)this).get_ForeColor());
			g.DrawString(text, ((Control)this).get_Font(), (Brush)(object)val2, (PointF)point);
		}
		val.Dispose();
	}

	private void DrawRoundRectangularButton(Graphics g)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected O, but got Unknown
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected O, but got Unknown
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected O, but got Unknown
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected O, but got Unknown
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected O, but got Unknown
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected O, but got Unknown
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Expected O, but got Unknown
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Expected O, but got Unknown
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected O, but got Unknown
		Color color = Color.FromArgb(color1Transparent, color1);
		Color color2 = Color.FromArgb(color2Transparent, this.color2);
		Brush val = (Brush)new LinearGradientBrush(((Control)this).get_ClientRectangle(), color, color2, (float)angle);
		Region val2 = new Region(new Rectangle(5, 5, ((Control)this).get_Width(), ((Control)this).get_Height()));
		GraphicsPath val3 = new GraphicsPath();
		val3.AddArc(5, 5, 40, 40, 180f, 90f);
		val3.AddLine(25, 5, ((Control)this).get_Width() - 25, 5);
		val3.AddArc(((Control)this).get_Width() - 45, 5, 40, 40, 270f, 90f);
		val3.AddLine(((Control)this).get_Width() - 5, 25, ((Control)this).get_Width() - 5, ((Control)this).get_Height() - 25);
		val3.AddArc(((Control)this).get_Width() - 45, ((Control)this).get_Height() - 45, 40, 40, 0f, 90f);
		val3.AddLine(25, ((Control)this).get_Height() - 5, ((Control)this).get_Width() - 25, ((Control)this).get_Height() - 5);
		val3.AddArc(5, ((Control)this).get_Height() - 45, 40, 40, 90f, 90f);
		val3.AddLine(5, 25, 5, ((Control)this).get_Height() - 25);
		val2.Intersect(val3);
		g.FillRegion(val, val2);
		for (int i = 0; i < borderWidth; i++)
		{
			g.DrawArc(new Pen(buttonborder), 5 + i, 5 + i, 40, 40, 180, 90);
			g.DrawLine(new Pen(buttonborder), 25, 5 + i, ((Control)this).get_Width() - 25, 5 + i);
			g.DrawArc(new Pen(buttonborder), ((Control)this).get_Width() - 45 - i, 5 + i, 40, 40, 270, 90);
			g.DrawLine(new Pen(buttonborder), 5 + i, 25, 5 + i, ((Control)this).get_Height() - 25);
			g.DrawLine(new Pen(buttonborder), ((Control)this).get_Width() - 5 - i, 25, ((Control)this).get_Width() - 5 - i, ((Control)this).get_Height() - 25);
			g.DrawArc(new Pen(buttonborder), ((Control)this).get_Width() - 45 - i, ((Control)this).get_Height() - 45 - i, 40, 40, 0, 90);
			g.DrawLine(new Pen(buttonborder), 25, ((Control)this).get_Height() - 5 - i, ((Control)this).get_Width() - 25, ((Control)this).get_Height() - 5 - i);
			g.DrawArc(new Pen(buttonborder), 5 + i, ((Control)this).get_Height() - 45 - i, 40, 40, 90, 90);
		}
		if (showButtonText)
		{
			Point point = new Point(textX, textY);
			SolidBrush val4 = new SolidBrush(((Control)this).get_ForeColor());
			g.DrawString(text, ((Control)this).get_Font(), (Brush)(object)val4, (PointF)point);
		}
		val.Dispose();
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		((ButtonBase)this).OnPaint(e);
		switch (buttonShape)
		{
		case ButtonsShapes.Circle:
			DrawCircularButton(e.get_Graphics());
			break;
		case ButtonsShapes.RoundRect:
			DrawRoundRectangularButton(e.get_Graphics());
			break;
		}
	}
}
