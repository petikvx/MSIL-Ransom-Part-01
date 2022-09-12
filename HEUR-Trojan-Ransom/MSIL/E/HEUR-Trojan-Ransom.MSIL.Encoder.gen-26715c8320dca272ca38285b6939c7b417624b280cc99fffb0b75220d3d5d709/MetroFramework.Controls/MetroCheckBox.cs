using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Drawing;

namespace MetroFramework.Controls;

[ToolboxBitmap(typeof(CheckBox))]
public class MetroCheckBox : MetroCheckBoxBase
{
	private bool useStyleColors;

	private MetroLinkSize metroLinkSize;

	private MetroLinkWeight metroLinkWeight = MetroLinkWeight.Regular;

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

	[Category("Metro Appearance")]
	[DefaultValue(MetroLinkSize.Small)]
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

	[DefaultValue(MetroLinkWeight.Regular)]
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

	[Category("Metro Appearance")]
	[DefaultValue(false)]
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

	[Category("Metro Appearance")]
	[DefaultValue(false)]
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

	public MetroCheckBox()
	{
		((Control)this).SetStyle((ControlStyles)139282, true);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected O, but got Unknown
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Invalid comparison between Unknown and I4
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		Color color = ((!useCustomBackground) ? MetroPaint.BackColor.Form(base.Theme) : ((Control)this).get_BackColor());
		Color color2;
		Color color3;
		if (useCustomForeColor)
		{
			color2 = ((Control)this).get_ForeColor();
			color3 = ((isHovered && !isPressed && ((Control)this).get_Enabled()) ? MetroPaint.BorderColor.CheckBox.Hover(base.Theme) : ((isHovered && isPressed && ((Control)this).get_Enabled()) ? MetroPaint.BorderColor.CheckBox.Press(base.Theme) : (((Control)this).get_Enabled() ? MetroPaint.BorderColor.CheckBox.Normal(base.Theme) : MetroPaint.BorderColor.CheckBox.Disabled(base.Theme))));
		}
		else if (isHovered && !isPressed && ((Control)this).get_Enabled())
		{
			color2 = MetroPaint.ForeColor.CheckBox.Hover(base.Theme);
			color3 = MetroPaint.BorderColor.CheckBox.Hover(base.Theme);
		}
		else if (isHovered && isPressed && ((Control)this).get_Enabled())
		{
			color2 = MetroPaint.ForeColor.CheckBox.Press(base.Theme);
			color3 = MetroPaint.BorderColor.CheckBox.Press(base.Theme);
		}
		else if (!((Control)this).get_Enabled())
		{
			color2 = MetroPaint.ForeColor.CheckBox.Disabled(base.Theme);
			color3 = MetroPaint.BorderColor.CheckBox.Disabled(base.Theme);
		}
		else
		{
			color2 = ((!useStyleColors) ? MetroPaint.ForeColor.CheckBox.Normal(base.Theme) : MetroPaint.GetStyleColor(base.Style));
			color3 = MetroPaint.BorderColor.CheckBox.Normal(base.Theme);
		}
		e.get_Graphics().Clear(color);
		Pen val = new Pen(color3);
		try
		{
			Rectangle rectangle = new Rectangle(0, ((Control)this).get_Height() / 2 - 6, 12, 12);
			e.get_Graphics().DrawRectangle(val, rectangle);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		if (((CheckBox)this).get_Checked())
		{
			Color color4 = (((int)((CheckBox)this).get_CheckState() == 2) ? color3 : MetroPaint.GetStyleColor(base.Style));
			SolidBrush val2 = new SolidBrush(color4);
			try
			{
				Rectangle rectangle2 = new Rectangle(2, ((Control)this).get_Height() / 2 - 4, 9, 9);
				e.get_Graphics().FillRectangle((Brush)(object)val2, rectangle2);
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
		}
		Rectangle rectangle3 = new Rectangle(16, 0, ((Control)this).get_Width() - 16, ((Control)this).get_Height());
		TextRenderer.DrawText((IDeviceContext)(object)e.get_Graphics(), ((Control)this).get_Text(), MetroFonts.Link(metroLinkSize, metroLinkWeight), rectangle3, color2, color, MetroPaint.GetTextFormatFlags(((ButtonBase)this).get_TextAlign()));
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
		((CheckBox)this).OnKeyDown(e);
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
		((ButtonBase)this).OnMouseEnter(e);
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
		((CheckBox)this).OnMouseUp(e);
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		isHovered = false;
		((Control)this).Invalidate();
		((ButtonBase)this).OnMouseLeave(e);
	}

	protected override void OnEnabledChanged(EventArgs e)
	{
		((ButtonBase)this).OnEnabledChanged(e);
		((Control)this).Invalidate();
	}

	protected override void OnCheckedChanged(EventArgs e)
	{
		((CheckBox)this).OnCheckedChanged(e);
		((Control)this).Invalidate();
	}

	public override Size GetPreferredSize(Size proposedSize)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		((ButtonBase)this).GetPreferredSize(proposedSize);
		Graphics val = ((Control)this).CreateGraphics();
		try
		{
			proposedSize = new Size(int.MaxValue, int.MaxValue);
			Size result = TextRenderer.MeasureText((IDeviceContext)(object)val, ((Control)this).get_Text(), MetroFonts.Link(metroLinkSize, metroLinkWeight), proposedSize, MetroPaint.GetTextFormatFlags(((ButtonBase)this).get_TextAlign()));
			result.Width += 16;
			return result;
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}
}
