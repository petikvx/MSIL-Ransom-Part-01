using System;
using System.ComponentModel;
using System.Windows.Forms;
using MetroFramework.Interfaces;

namespace MetroFramework.Components;

[EditorBrowsable(EditorBrowsableState.Advanced)]
public abstract class MetroToolTipBase : ToolTip, IDisposable, IMetroComponent, IMetroStyledComponent
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
			return ((Component)this).Site;
		}
		set
		{
			ISite site3 = (((Component)this).Site = (_styleManager.Site = value));
		}
	}

	[DefaultValue(MetroThemeStyle.Default)]
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

	protected MetroToolTipBase()
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
		((ToolTip)this).Dispose(disposing);
	}

	protected abstract void OnMetroStyleChanged(object sender, EventArgs e);
}
