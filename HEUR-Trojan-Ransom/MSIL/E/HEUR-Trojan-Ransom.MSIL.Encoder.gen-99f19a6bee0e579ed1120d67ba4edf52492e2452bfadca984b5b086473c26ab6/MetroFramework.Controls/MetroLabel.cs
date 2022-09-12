using System;
using System.ComponentModel;
using System.Drawing;
using System.Security;
using System.Windows.Forms;
using MetroFramework.Drawing;
using MetroFramework.Native;

namespace MetroFramework.Controls;

[ToolboxBitmap(typeof(Label))]
[Designer("MetroFramework.Design.MetroLabelDesigner, MetroFramework.Design, Version=1.2.0.3, Culture=neutral, PublicKeyToken=5f91a84759bf584a")]
public class MetroLabel : MetroLabelBase
{
	private class DoubleBufferedTextBox : TextBox
	{
		public DoubleBufferedTextBox()
		{
			((Control)this).SetStyle((ControlStyles)139264, true);
		}
	}

	private DoubleBufferedTextBox baseTextBox;

	private bool useStyleColors;

	private MetroLabelSize metroLabelSize = MetroLabelSize.Medium;

	private MetroLabelWeight metroLabelWeight;

	private MetroLabelMode labelMode;

	private bool useCustomBackground;

	private bool useCustomForeColor;

	private bool firstInitialization = true;

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
			((Control)this).Refresh();
		}
	}

	[DefaultValue(MetroLabelSize.Medium)]
	[Category("Metro Appearance")]
	public MetroLabelSize FontSize
	{
		get
		{
			return metroLabelSize;
		}
		set
		{
			metroLabelSize = value;
			((Control)this).Refresh();
		}
	}

	[DefaultValue(MetroLabelWeight.Light)]
	[Category("Metro Appearance")]
	public MetroLabelWeight FontWeight
	{
		get
		{
			return metroLabelWeight;
		}
		set
		{
			metroLabelWeight = value;
			((Control)this).Refresh();
		}
	}

	[DefaultValue(MetroLabelMode.Default)]
	[Category("Metro Appearance")]
	public MetroLabelMode LabelMode
	{
		get
		{
			return labelMode;
		}
		set
		{
			labelMode = value;
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

	public MetroLabel()
	{
		((Control)this).SetStyle((ControlStyles)141330, true);
		baseTextBox = new DoubleBufferedTextBox();
		((Control)baseTextBox).set_Visible(false);
		((Control)this).get_Controls().Add((Control)(object)baseTextBox);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		Color color;
		if (useCustomBackground)
		{
			color = ((Control)this).get_BackColor();
		}
		else
		{
			color = MetroPaint.BackColor.Form(base.Theme);
			if (((Control)this).get_Parent() is MetroTile)
			{
				color = MetroPaint.GetStyleColor(base.Style);
			}
		}
		Color color2 = (useCustomForeColor ? ((Control)this).get_ForeColor() : ((!((Control)this).get_Enabled()) ? ((((Control)this).get_Parent() == null) ? MetroPaint.ForeColor.Label.Disabled(base.Theme) : ((!(((Control)this).get_Parent() is MetroTile)) ? MetroPaint.ForeColor.Label.Normal(base.Theme) : MetroPaint.ForeColor.Tile.Disabled(base.Theme))) : ((((Control)this).get_Parent() != null) ? ((((Control)this).get_Parent() is MetroTile) ? MetroPaint.ForeColor.Tile.Normal(base.Theme) : ((!useStyleColors) ? MetroPaint.ForeColor.Label.Normal(base.Theme) : MetroPaint.GetStyleColor(base.Style))) : ((!useStyleColors) ? MetroPaint.ForeColor.Label.Normal(base.Theme) : MetroPaint.GetStyleColor(base.Style)))));
		e.get_Graphics().Clear(color);
		if (LabelMode == MetroLabelMode.Selectable)
		{
			CreateBaseTextBox();
			UpdateBaseTextBox();
			if (!((Control)baseTextBox).get_Visible())
			{
				TextRenderer.DrawText((IDeviceContext)(object)e.get_Graphics(), ((Control)this).get_Text(), MetroFonts.Label(metroLabelSize, metroLabelWeight), ((Control)this).get_ClientRectangle(), color2, color, MetroPaint.GetTextFormatFlags(((Label)this).get_TextAlign()));
			}
		}
		else
		{
			DestroyBaseTextbox();
			TextRenderer.DrawText((IDeviceContext)(object)e.get_Graphics(), ((Control)this).get_Text(), MetroFonts.Label(metroLabelSize, metroLabelWeight), ((Control)this).get_ClientRectangle(), color2, color, MetroPaint.GetTextFormatFlags(((Label)this).get_TextAlign()));
		}
	}

	public override void Refresh()
	{
		if (LabelMode == MetroLabelMode.Selectable)
		{
			UpdateBaseTextBox();
		}
		((Control)this).Refresh();
	}

	public override Size GetPreferredSize(Size proposedSize)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		((Label)this).GetPreferredSize(proposedSize);
		Graphics val = ((Control)this).CreateGraphics();
		try
		{
			proposedSize = new Size(int.MaxValue, int.MaxValue);
			return TextRenderer.MeasureText((IDeviceContext)(object)val, ((Control)this).get_Text(), MetroFonts.Label(metroLabelSize, metroLabelWeight), proposedSize, MetroPaint.GetTextFormatFlags(((Label)this).get_TextAlign()));
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	protected override void OnEnabledChanged(EventArgs e)
	{
		((Label)this).OnEnabledChanged(e);
		((Control)this).Invalidate();
	}

	protected override void OnResize(EventArgs e)
	{
		if (LabelMode == MetroLabelMode.Selectable)
		{
			HideBaseTextBox();
		}
		((Control)this).OnResize(e);
	}

	protected override void OnSizeChanged(EventArgs e)
	{
		((Control)this).OnSizeChanged(e);
		if (LabelMode == MetroLabelMode.Selectable)
		{
			ShowBaseTextBox();
		}
	}

	private void CreateBaseTextBox()
	{
		if ((((Control)baseTextBox).get_Visible() && !firstInitialization) || !firstInitialization)
		{
			return;
		}
		firstInitialization = false;
		if (!((Component)(object)this).DesignMode)
		{
			Form val = ((Control)this).FindForm();
			if (val != null)
			{
				val.add_ResizeBegin((EventHandler)parentForm_ResizeBegin);
				val.add_ResizeEnd((EventHandler)parentForm_ResizeEnd);
			}
		}
		((Control)baseTextBox).set_Visible(true);
		((TextBoxBase)baseTextBox).set_BorderStyle((BorderStyle)0);
		((Control)baseTextBox).set_Font(MetroFonts.Label(metroLabelSize, metroLabelWeight));
		((Control)baseTextBox).set_Location(new Point(1, 0));
		((Control)baseTextBox).set_Text(((Control)this).get_Text());
		((TextBoxBase)baseTextBox).set_ReadOnly(true);
		((Control)baseTextBox).set_Size(((Control)this).GetPreferredSize(Size.Empty));
		((TextBoxBase)baseTextBox).set_Multiline(true);
		((Control)baseTextBox).add_DoubleClick((EventHandler)BaseTextBoxOnDoubleClick);
		((TextBoxBase)baseTextBox).add_Click((EventHandler)BaseTextBoxOnClick);
		((Control)this).get_Controls().Add((Control)(object)baseTextBox);
	}

	private void parentForm_ResizeEnd(object sender, EventArgs e)
	{
		if (LabelMode == MetroLabelMode.Selectable)
		{
			ShowBaseTextBox();
		}
	}

	private void parentForm_ResizeBegin(object sender, EventArgs e)
	{
		if (LabelMode == MetroLabelMode.Selectable)
		{
			HideBaseTextBox();
		}
	}

	private void DestroyBaseTextbox()
	{
		if (((Control)baseTextBox).get_Visible())
		{
			((Control)baseTextBox).remove_DoubleClick((EventHandler)BaseTextBoxOnDoubleClick);
			((TextBoxBase)baseTextBox).remove_Click((EventHandler)BaseTextBoxOnClick);
			((Control)baseTextBox).set_Visible(false);
		}
	}

	private void UpdateBaseTextBox()
	{
		if (!((Control)baseTextBox).get_Visible())
		{
			return;
		}
		((Control)this).SuspendLayout();
		((Control)baseTextBox).SuspendLayout();
		if (useCustomBackground)
		{
			((Control)baseTextBox).set_BackColor(((Control)this).get_BackColor());
		}
		else
		{
			((Control)baseTextBox).set_BackColor(MetroPaint.BackColor.Form(base.Theme));
		}
		if (!((Control)this).get_Enabled())
		{
			if (((Control)this).get_Parent() != null)
			{
				if (((Control)this).get_Parent() is MetroTile)
				{
					((Control)baseTextBox).set_ForeColor(MetroPaint.ForeColor.Tile.Disabled(base.Theme));
				}
				else if (useStyleColors)
				{
					((Control)baseTextBox).set_ForeColor(MetroPaint.GetStyleColor(base.Style));
				}
				else
				{
					((Control)baseTextBox).set_ForeColor(MetroPaint.ForeColor.Label.Disabled(base.Theme));
				}
			}
			else if (useStyleColors)
			{
				((Control)baseTextBox).set_ForeColor(MetroPaint.GetStyleColor(base.Style));
			}
			else
			{
				((Control)baseTextBox).set_ForeColor(MetroPaint.ForeColor.Label.Disabled(base.Theme));
			}
		}
		else if (((Control)this).get_Parent() != null)
		{
			if (((Control)this).get_Parent() is MetroTile)
			{
				((Control)baseTextBox).set_ForeColor(MetroPaint.ForeColor.Tile.Normal(base.Theme));
			}
			else if (useStyleColors)
			{
				((Control)baseTextBox).set_ForeColor(MetroPaint.GetStyleColor(base.Style));
			}
			else
			{
				((Control)baseTextBox).set_ForeColor(MetroPaint.ForeColor.Label.Normal(base.Theme));
			}
		}
		else if (useStyleColors)
		{
			((Control)baseTextBox).set_ForeColor(MetroPaint.GetStyleColor(base.Style));
		}
		else
		{
			((Control)baseTextBox).set_ForeColor(MetroPaint.ForeColor.Label.Normal(base.Theme));
		}
		((Control)baseTextBox).set_Font(MetroFonts.Label(metroLabelSize, metroLabelWeight));
		((Control)baseTextBox).set_Text(((Control)this).get_Text());
		((TextBoxBase)baseTextBox).set_BorderStyle((BorderStyle)0);
		((Control)this).set_Size(((Control)this).GetPreferredSize(Size.Empty));
		((Control)baseTextBox).ResumeLayout();
		((Control)this).ResumeLayout();
	}

	private void HideBaseTextBox()
	{
		((Control)baseTextBox).set_Visible(false);
	}

	private void ShowBaseTextBox()
	{
		((Control)baseTextBox).set_Visible(true);
	}

	[SecuritySafeCritical]
	private void BaseTextBoxOnClick(object sender, EventArgs e)
	{
		WinCaret.HideCaret(((Control)baseTextBox).get_Handle());
	}

	[SecuritySafeCritical]
	private void BaseTextBoxOnDoubleClick(object sender, EventArgs e)
	{
		((TextBoxBase)baseTextBox).SelectAll();
		WinCaret.HideCaret(((Control)baseTextBox).get_Handle());
	}
}
