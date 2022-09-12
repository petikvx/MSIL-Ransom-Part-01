using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Drawing;

namespace MetroFramework.Controls;

[Designer("MetroFramework.Design.MetroButtonDesigner, MetroFramework.Design, Version=1.2.0.3, Culture=neutral, PublicKeyToken=5f91a84759bf584a")]
[ToolboxBitmap(typeof(Button))]
[DefaultEvent("Click")]
public class MetroButton : MetroButtonBase
{
	private bool highlight;

	private bool isHovered;

	private bool isPressed;

	private bool isFocused;

	[DefaultValue(false)]
	public bool Highlight
	{
		get
		{
			return highlight;
		}
		set
		{
			highlight = value;
		}
	}

	public MetroButton()
	{
		((Control)this).SetStyle((ControlStyles)139282, true);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		Color color;
		Color color2;
		Color color3;
		if (isHovered && !isPressed && ((Control)this).get_Enabled())
		{
			color = MetroPaint.BackColor.Button.Hover(base.Theme);
			color2 = MetroPaint.BorderColor.Button.Hover(base.Theme);
			color3 = MetroPaint.ForeColor.Button.Hover(base.Theme);
		}
		else if (isHovered && isPressed && ((Control)this).get_Enabled())
		{
			color = MetroPaint.BackColor.Button.Press(base.Theme);
			color2 = MetroPaint.BorderColor.Button.Press(base.Theme);
			color3 = MetroPaint.ForeColor.Button.Press(base.Theme);
		}
		else if (!((Control)this).get_Enabled())
		{
			color = MetroPaint.BackColor.Button.Disabled(base.Theme);
			color2 = MetroPaint.BorderColor.Button.Disabled(base.Theme);
			color3 = MetroPaint.ForeColor.Button.Disabled(base.Theme);
		}
		else
		{
			color = MetroPaint.BackColor.Button.Normal(base.Theme);
			color2 = MetroPaint.BorderColor.Button.Normal(base.Theme);
			color3 = MetroPaint.ForeColor.Button.Normal(base.Theme);
		}
		e.get_Graphics().Clear(color);
		Pen val = new Pen(color2);
		try
		{
			Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			e.get_Graphics().DrawRectangle(val, rectangle);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		if (Highlight && !isHovered && !isPressed && ((Control)this).get_Enabled())
		{
			Pen stylePen = MetroPaint.GetStylePen(base.Style);
			try
			{
				Rectangle rectangle2 = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
				e.get_Graphics().DrawRectangle(stylePen, rectangle2);
				rectangle2 = new Rectangle(1, 1, ((Control)this).get_Width() - 3, ((Control)this).get_Height() - 3);
				e.get_Graphics().DrawRectangle(stylePen, rectangle2);
			}
			finally
			{
				((IDisposable)stylePen)?.Dispose();
			}
		}
		TextRenderer.DrawText((IDeviceContext)(object)e.get_Graphics(), ((Control)this).get_Text(), MetroFonts.Button, ((Control)this).get_ClientRectangle(), color3, color, MetroPaint.GetTextFormatFlags(((ButtonBase)this).get_TextAlign()));
	}

	protected override void OnGotFocus(EventArgs e)
	{
		isFocused = true;
		((Control)this).Invalidate();
		((ButtonBase)this).OnGotFocus(e);
	}

	protected override void OnLostFocus(EventArgs e)
	{
		isFocused = false;
		isHovered = false;
		isPressed = false;
		((Control)this).Invalidate();
		((ButtonBase)this).OnLostFocus(e);
	}

	protected override void OnEnter(EventArgs e)
	{
		isFocused = true;
		((Control)this).Invalidate();
		((Control)this).OnEnter(e);
	}

	protected override void OnLeave(EventArgs e)
	{
		isFocused = false;
		isHovered = false;
		isPressed = false;
		((Control)this).Invalidate();
		((Control)this).OnLeave(e);
	}

	protected override void OnKeyDown(KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)e.get_KeyCode() == 32)
		{
			isHovered = true;
			isPressed = true;
			((Control)this).Invalidate();
		}
		((ButtonBase)this).OnKeyDown(e);
	}

	protected override void OnKeyUp(KeyEventArgs e)
	{
		isHovered = false;
		isPressed = false;
		((Control)this).Invalidate();
		((ButtonBase)this).OnKeyUp(e);
	}

	protected override void OnMouseEnter(EventArgs e)
	{
		isHovered = true;
		((Control)this).Invalidate();
		((Button)this).OnMouseEnter(e);
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() == 1048576)
		{
			isPressed = true;
			((Control)this).Invalidate();
		}
		((ButtonBase)this).OnMouseDown(e);
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		isPressed = false;
		((Control)this).Invalidate();
		((Button)this).OnMouseUp(e);
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		isHovered = false;
		((Control)this).Invalidate();
		((Button)this).OnMouseLeave(e);
	}

	protected override void OnEnabledChanged(EventArgs e)
	{
		((ButtonBase)this).OnEnabledChanged(e);
		((Control)this).Invalidate();
	}
}
