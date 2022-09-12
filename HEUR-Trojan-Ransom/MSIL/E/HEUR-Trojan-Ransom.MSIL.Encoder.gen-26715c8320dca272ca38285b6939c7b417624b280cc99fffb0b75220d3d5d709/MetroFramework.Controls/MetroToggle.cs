using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Drawing;
using MetroFramework.Localization;

namespace MetroFramework.Controls;

[ToolboxBitmap(typeof(CheckBox))]
public class MetroToggle : MetroCheckBoxBase
{
	private MetroLocalize metroLocalize;

	private bool useStyleColors;

	private MetroLinkSize metroLinkSize;

	private MetroLinkWeight metroLinkWeight = MetroLinkWeight.Regular;

	private bool displayStatus = true;

	private bool useCustomBackground;

	private bool isHovered;

	private bool isPressed;

	private bool isFocused;

	[Category("Metro Appearance")]
	[DefaultValue(false)]
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

	[Category("Metro Appearance")]
	[DefaultValue(MetroLinkWeight.Regular)]
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

	[DefaultValue(true)]
	[Category("Metro Appearance")]
	public bool DisplayStatus
	{
		get
		{
			return displayStatus;
		}
		set
		{
			displayStatus = value;
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

	[Browsable(false)]
	public override Color ForeColor
	{
		get
		{
			return ((Control)this).get_ForeColor();
		}
		set
		{
			((Control)this).set_ForeColor(value);
		}
	}

	[Browsable(false)]
	public override string Text
	{
		get
		{
			if (((CheckBox)this).get_Checked())
			{
				return metroLocalize.translate("StatusOn");
			}
			return metroLocalize.translate("StatusOff");
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

	public MetroToggle()
	{
		((Control)this).SetStyle((ControlStyles)141330, true);
		((Control)this).set_Name("MetroToggle");
		metroLocalize = new MetroLocalize((Control)(object)this);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected O, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected O, but got Unknown
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected O, but got Unknown
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		Color color = ((!useCustomBackground) ? MetroPaint.BackColor.Form(base.Theme) : ((Control)this).get_BackColor());
		Color color2;
		Color color3;
		if (isHovered && !isPressed && ((Control)this).get_Enabled())
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
			Rectangle rectangle = new Rectangle(DisplayStatus ? 30 : 0, 0, ((Control)this).get_ClientRectangle().Width - ((!DisplayStatus) ? 1 : 31), ((Control)this).get_ClientRectangle().Height - 1);
			e.get_Graphics().DrawRectangle(val, rectangle);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		Color color4 = (((CheckBox)this).get_Checked() ? MetroPaint.GetStyleColor(base.Style) : MetroPaint.BorderColor.CheckBox.Normal(base.Theme));
		SolidBrush val2 = new SolidBrush(color4);
		try
		{
			Rectangle rectangle2 = new Rectangle(DisplayStatus ? 32 : 2, 2, ((Control)this).get_ClientRectangle().Width - (DisplayStatus ? 34 : 4), ((Control)this).get_ClientRectangle().Height - 4);
			e.get_Graphics().FillRectangle((Brush)(object)val2, rectangle2);
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
		SolidBrush val3 = new SolidBrush(color);
		try
		{
			int x = (((CheckBox)this).get_Checked() ? (((Control)this).get_Width() - 11) : (DisplayStatus ? 30 : 0));
			Rectangle rectangle3 = new Rectangle(x, 0, 11, ((Control)this).get_ClientRectangle().Height);
			e.get_Graphics().FillRectangle((Brush)(object)val3, rectangle3);
		}
		finally
		{
			((IDisposable)val3)?.Dispose();
		}
		SolidBrush val4 = new SolidBrush(MetroPaint.BorderColor.CheckBox.Hover(base.Theme));
		try
		{
			int x2 = (((CheckBox)this).get_Checked() ? (((Control)this).get_Width() - 10) : (DisplayStatus ? 30 : 0));
			Rectangle rectangle4 = new Rectangle(x2, 0, 10, ((Control)this).get_ClientRectangle().Height);
			e.get_Graphics().FillRectangle((Brush)(object)val4, rectangle4);
		}
		finally
		{
			((IDisposable)val4)?.Dispose();
		}
		if (DisplayStatus)
		{
			Rectangle rectangle5 = new Rectangle(0, 0, 30, ((Control)this).get_ClientRectangle().Height);
			TextRenderer.DrawText((IDeviceContext)(object)e.get_Graphics(), ((Control)this).get_Text(), MetroFonts.Link(metroLinkSize, metroLinkWeight), rectangle5, color2, color, MetroPaint.GetTextFormatFlags(((ButtonBase)this).get_TextAlign()));
		}
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
		Size preferredSize = ((ButtonBase)this).GetPreferredSize(proposedSize);
		preferredSize.Width = (DisplayStatus ? 80 : 50);
		return preferredSize;
	}
}
