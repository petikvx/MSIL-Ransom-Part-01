using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Drawing;

namespace MetroFramework.Controls;

[ToolboxBitmap(typeof(LinkLabel))]
[Designer("MetroFramework.Design.MetroLinkDesigner, MetroFramework.Design, Version=1.2.0.3, Culture=neutral, PublicKeyToken=5f91a84759bf584a")]
[DefaultEvent("Click")]
public class MetroLink : MetroButtonBase
{
	private bool useStyleColors;

	private MetroLinkSize metroLinkSize;

	private MetroLinkWeight metroLinkWeight = MetroLinkWeight.Bold;

	private bool useCustomBackground;

	private bool useCustomForeColor;

	private bool isHovered;

	private bool isPressed;

	private bool isFocused;

	[DefaultValue(false)]
	[Category("Metro Appearance")]
	public bool UseStyleColors
	{
		get
		{
			return useStyleColors;
		}
		set
		{
			useStyleColors = value;
		}
	}

	[DefaultValue(MetroLinkSize.Small)]
	[Category("Metro Appearance")]
	public MetroLinkSize FontSize
	{
		get
		{
			return metroLinkSize;
		}
		set
		{
			metroLinkSize = value;
		}
	}

	[DefaultValue(MetroLinkWeight.Bold)]
	[Category("Metro Appearance")]
	public MetroLinkWeight FontWeight
	{
		get
		{
			return metroLinkWeight;
		}
		set
		{
			metroLinkWeight = value;
		}
	}

	[Browsable(false)]
	public override Font Font
	{
		get
		{
			return ((Control)this).get_Font();
		}
		set
		{
			((Control)this).set_Font(value);
		}
	}

	[DefaultValue(false)]
	[Category("Metro Appearance")]
	public bool CustomBackground
	{
		get
		{
			return useCustomBackground;
		}
		set
		{
			useCustomBackground = value;
		}
	}

	[DefaultValue(false)]
	[Category("Metro Appearance")]
	public bool CustomForeColor
	{
		get
		{
			return useCustomForeColor;
		}
		set
		{
			useCustomForeColor = value;
		}
	}

	public MetroLink()
	{
		((Control)this).SetStyle((ControlStyles)141330, true);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		Color color = ((!useCustomBackground) ? MetroPaint.BackColor.Form(base.Theme) : ((Control)this).get_BackColor());
		Color color2 = (useCustomForeColor ? ((Control)this).get_ForeColor() : ((isHovered && !isPressed && ((Control)this).get_Enabled()) ? MetroPaint.ForeColor.Link.Hover(base.Theme) : ((isHovered && isPressed && ((Control)this).get_Enabled()) ? MetroPaint.ForeColor.Link.Press(base.Theme) : (((Control)this).get_Enabled() ? ((!useStyleColors) ? MetroPaint.ForeColor.Link.Normal(base.Theme) : MetroPaint.GetStyleColor(base.Style)) : MetroPaint.ForeColor.Link.Disabled(base.Theme)))));
		e.get_Graphics().Clear(color);
		TextRenderer.DrawText((IDeviceContext)(object)e.get_Graphics(), ((Control)this).get_Text(), MetroFonts.Link(metroLinkSize, metroLinkWeight), ((Control)this).get_ClientRectangle(), color2, color, MetroPaint.GetTextFormatFlags(((ButtonBase)this).get_TextAlign()));
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
