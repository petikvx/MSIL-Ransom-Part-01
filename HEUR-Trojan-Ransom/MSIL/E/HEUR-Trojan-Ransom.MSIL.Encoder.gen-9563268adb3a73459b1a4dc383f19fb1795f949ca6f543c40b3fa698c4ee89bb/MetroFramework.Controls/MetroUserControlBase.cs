using System;
using System.ComponentModel;
using System.Windows.Forms;
using MetroFramework.Components;
using MetroFramework.Interfaces;

namespace MetroFramework.Controls;

[EditorBrowsable(EditorBrowsableState.Advanced)]
public abstract class MetroUserControlBase : UserControl, IDisposable, IContainerControl, IMetroControl, IMetroComponent, IMetroStyledComponent, IMetroContainerControl
{
	private readonly MetroStyleManager _styleManager;

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
			return ((Control)this).get_Site();
		}
		set
		{
			ISite site2 = (_styleManager.Site = value);
			((Control)this).set_Site(site2);
		}
	}

	[DefaultValue(MetroThemeStyle.Default)]
	[AmbientValue(MetroThemeStyle.Default)]
	[Category("Metro Appearance")]
	public MetroThemeStyle Theme
	{
		get
		{
			return _styleManager.Theme;
		}
		set
		{
			_styleManager.Theme = value;
		}
	}

	[AmbientValue(MetroColorStyle.Default)]
	[DefaultValue(MetroColorStyle.Default)]
	[Category("Metro Appearance")]
	public MetroColorStyle Style
	{
		get
		{
			return _styleManager.Style;
		}
		set
		{
			_styleManager.Style = value;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public MetroStyleManager StyleManager { get; set; }

	protected MetroUserControlBase()
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
		((ContainerControl)this).Dispose(disposing);
	}

	private void OnMetroStyleChanged(object sender, EventArgs e)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		if (((Control)this).get_InvokeRequired())
		{
			((Control)this).Invoke((Delegate)new MethodInvoker(((Control)this).Invalidate));
		}
		else
		{
			((Control)this).Invalidate();
		}
	}
}
