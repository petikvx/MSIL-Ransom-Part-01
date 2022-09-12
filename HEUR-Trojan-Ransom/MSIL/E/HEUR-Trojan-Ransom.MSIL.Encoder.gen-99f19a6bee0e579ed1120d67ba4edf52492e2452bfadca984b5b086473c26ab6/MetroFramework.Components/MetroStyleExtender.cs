using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Drawing;
using MetroFramework.Interfaces;

namespace MetroFramework.Components;

[ProvideProperty("ApplyMetroTheme", typeof(Control))]
public sealed class MetroStyleExtender : Component, IDisposable, IExtenderProvider, IMetroComponent, IMetroStyledComponent
{
	private MetroStyleManager _styleManager;

	private readonly List<Control> _extendedControls = new List<Control>();

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	MetroStyleManager IMetroStyledComponent.InternalStyleManager
	{
		get
		{
			return _styleManager;
		}
		set
		{
			((IMetroStyledComponent)_styleManager).InternalStyleManager = value;
		}
	}

	public override ISite Site
	{
		get
		{
			return base.Site;
		}
		set
		{
			ISite site3 = (base.Site = (_styleManager.Site = value));
		}
	}

	public MetroStyleExtender()
	{
		_styleManager = new MetroStyleManager();
		_styleManager.MetroStyleChanged += OnMetroStyleChanged;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			_styleManager.Dispose();
		}
		base.Dispose(disposing);
	}

	private void OnMetroStyleChanged(object sender, EventArgs e)
	{
		UpdateTheme();
	}

	public MetroStyleExtender(IContainer parent)
		: this()
	{
		parent?.Add(this);
	}

	private void UpdateTheme()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		if (_extendedControls.Count == 0)
		{
			return;
		}
		Control val = _extendedControls[0];
		if (val.get_InvokeRequired())
		{
			val.Invoke((Delegate)new MethodInvoker(UpdateTheme));
			return;
		}
		Color color = MetroPaint.BackColor.Form(_styleManager.Theme);
		Color color2 = MetroPaint.ForeColor.Label.Normal(_styleManager.Theme);
		foreach (Control extendedControl in _extendedControls)
		{
			try
			{
				if (extendedControl.get_BackColor() != color)
				{
					extendedControl.set_BackColor(color);
				}
			}
			catch
			{
			}
			try
			{
				if (extendedControl.get_ForeColor() != color2)
				{
					extendedControl.set_ForeColor(color2);
				}
			}
			catch
			{
			}
		}
	}

	private void UpdateTheme(Control ctrl)
	{
		Color color = MetroPaint.BackColor.Form(_styleManager.Theme);
		Color color2 = MetroPaint.ForeColor.Label.Normal(_styleManager.Theme);
		try
		{
			if (ctrl.get_BackColor() != color)
			{
				ctrl.set_BackColor(color);
			}
		}
		catch
		{
		}
		try
		{
			if (ctrl.get_ForeColor() != color2)
			{
				ctrl.set_ForeColor(color2);
			}
		}
		catch
		{
		}
	}

	bool IExtenderProvider.CanExtend(object target)
	{
		if (target is Control)
		{
			if (!(target is IMetroControl))
			{
				return !(target is IMetroForm);
			}
			return false;
		}
		return false;
	}

	[Description("Apply Metro Theme BackColor and ForeColor.")]
	[DefaultValue(false)]
	[Category("Metro Appearance")]
	public bool GetApplyMetroTheme(Control control)
	{
		if (control != null)
		{
			return _extendedControls.Contains(control);
		}
		return false;
	}

	public void SetApplyMetroTheme(Control control, bool value)
	{
		if (control == null)
		{
			return;
		}
		if (_extendedControls.Contains(control))
		{
			if (!value)
			{
				_extendedControls.Remove(control);
			}
		}
		else if (value)
		{
			_extendedControls.Add(control);
			UpdateTheme(control);
		}
	}
}
