using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using MetroFramework.Drawing;
using MetroFramework.Interfaces;

namespace MetroFramework.Components;

[ToolboxItemFilter("System.Windows.Forms")]
[ToolboxBitmap(typeof(ToolTip))]
public class MetroToolTip : MetroToolTipBase
{
	[Browsable(false)]
	[DefaultValue(true)]
	public bool ShowAlways
	{
		get
		{
			return ((ToolTip)this).get_ShowAlways();
		}
		set
		{
			((ToolTip)this).set_ShowAlways(true);
		}
	}

	[DefaultValue(true)]
	[Browsable(false)]
	public bool OwnerDraw
	{
		get
		{
			return ((ToolTip)this).get_OwnerDraw();
		}
		set
		{
			((ToolTip)this).set_OwnerDraw(true);
		}
	}

	[Browsable(false)]
	public bool IsBalloon
	{
		get
		{
			return ((ToolTip)this).get_IsBalloon();
		}
		set
		{
			((ToolTip)this).set_IsBalloon(false);
		}
	}

	[Browsable(false)]
	public Color BackColor
	{
		get
		{
			return ((ToolTip)this).get_BackColor();
		}
		set
		{
			((ToolTip)this).set_BackColor(value);
		}
	}

	[Browsable(false)]
	public Color ForeColor
	{
		get
		{
			return ((ToolTip)this).get_ForeColor();
		}
		set
		{
			((ToolTip)this).set_ForeColor(value);
		}
	}

	[Browsable(false)]
	public string ToolTipTitle
	{
		get
		{
			return ((ToolTip)this).get_ToolTipTitle();
		}
		set
		{
			((ToolTip)this).set_ToolTipTitle("");
		}
	}

	[Browsable(false)]
	public ToolTipIcon ToolTipIcon
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return ((ToolTip)this).get_ToolTipIcon();
		}
		set
		{
			((ToolTip)this).set_ToolTipIcon((ToolTipIcon)0);
		}
	}

	protected override void OnMetroStyleChanged(object sender, EventArgs e)
	{
	}

	public MetroToolTip()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		OwnerDraw = true;
		ShowAlways = true;
		((ToolTip)this).add_Draw(new DrawToolTipEventHandler(MetroToolTip_Draw));
		((ToolTip)this).add_Popup(new PopupEventHandler(MetroToolTip_Popup));
	}

	public void SetToolTip(Control control, string caption)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		((ToolTip)this).SetToolTip(control, caption);
		if (!(control is IMetroControl))
		{
			return;
		}
		foreach (Control item in (ArrangedElementCollection)control.get_Controls())
		{
			Control control2 = item;
			SetToolTip(control2, caption);
		}
	}

	private void MetroToolTip_Popup(object sender, PopupEventArgs e)
	{
		if (e.get_AssociatedWindow() is IMetroContainerControl metroContainerControl && metroContainerControl.StyleManager == null)
		{
			((IMetroStyledComponent)this).InternalStyleManager = metroContainerControl.InternalStyleManager;
		}
		e.set_ToolTipSize(new Size(e.get_ToolTipSize().Width + 24, e.get_ToolTipSize().Height + 9));
	}

	private void MetroToolTip_Draw(object sender, DrawToolTipEventArgs e)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		MetroThemeStyle theme = ((base.Theme != MetroThemeStyle.Light) ? MetroThemeStyle.Light : MetroThemeStyle.Dark);
		Color color = MetroPaint.BackColor.Form(theme);
		Color color2 = MetroPaint.BorderColor.Button.Normal(theme);
		Color color3 = MetroPaint.ForeColor.Label.Normal(theme);
		SolidBrush val = new SolidBrush(color);
		try
		{
			e.get_Graphics().FillRectangle((Brush)(object)val, e.get_Bounds());
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		Pen val2 = new Pen(color2);
		try
		{
			e.get_Graphics().DrawRectangle(val2, new Rectangle(e.get_Bounds().X, e.get_Bounds().Y, e.get_Bounds().Width - 1, e.get_Bounds().Height - 1));
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
		Font val3 = MetroFonts.Default(13f);
		TextRenderer.DrawText((IDeviceContext)(object)e.get_Graphics(), e.get_ToolTipText(), val3, e.get_Bounds(), color3, (TextFormatFlags)5);
	}
}
