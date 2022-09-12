using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using MetroFramework.Interfaces;

namespace MetroFramework.Components;

[Designer("MetroFramework.Design.MetroStyleManagerDesigner, MetroFramework.Design, Version=1.2.0.3, Culture=neutral, PublicKeyToken=5f91a84759bf584a")]
public sealed class MetroStyleManager : Component, IDisposable, ISupportInitialize, IMetroComponent, IMetroStyledComponent
{
	internal const string STYLE_PROPERTY_NAME = "Style";

	internal const string THEME_PROPERTY_NAME = "Theme";

	public static readonly MetroStyleManager Default = new MetroStyleManager();

	private MetroColorStyle _metroStyle = MetroColorStyle.Default;

	private MetroThemeStyle _metroTheme = MetroThemeStyle.Default;

	private MetroStyleManager _styleManager;

	private readonly IContainer _parentContainer;

	private bool isInitializing;

	private IMetroContainerControl _owner;

	[DefaultValue(MetroColorStyle.Default)]
	[Category("Metro Appearance")]
	public MetroColorStyle Style
	{
		get
		{
			if (!base.DesignMode && _metroStyle == MetroColorStyle.Default)
			{
				return _styleManager.Style;
			}
			return _metroStyle;
		}
		set
		{
			if (_styleManager == null && value == MetroColorStyle.Default)
			{
				value = MetroColorStyle.Blue;
			}
			bool flag = Style != value;
			_metroStyle = value;
			if (flag)
			{
				OnMetroStyleChanged(this, new EventArgs());
			}
		}
	}

	[DefaultValue(MetroThemeStyle.Default)]
	[Category("Metro Appearance")]
	public MetroThemeStyle Theme
	{
		get
		{
			if (!base.DesignMode && _metroTheme == MetroThemeStyle.Default)
			{
				return _styleManager.Theme;
			}
			return _metroTheme;
		}
		set
		{
			if (_styleManager == null && value == MetroThemeStyle.Default)
			{
				value = MetroThemeStyle.Light;
			}
			bool flag = Theme != value;
			_metroTheme = value;
			if (flag)
			{
				OnMetroStyleChanged(this, new EventArgs());
			}
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	MetroStyleManager IMetroStyledComponent.InternalStyleManager
	{
		get
		{
			return _styleManager;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException();
			}
			if (value == this)
			{
				throw new ArgumentException();
			}
			bool flag = value.Theme != Theme || value.Style != Style;
			if (_styleManager != null)
			{
				_styleManager.MetroStyleChanged -= OnMetroStyleChanged;
			}
			_styleManager = value;
			_styleManager.MetroStyleChanged += OnMetroStyleChanged;
			if (flag)
			{
				OnMetroStyleChanged(this, new EventArgs());
			}
		}
	}

	[ImmutableObject(true)]
	public IMetroContainerControl Owner
	{
		get
		{
			return _owner;
		}
		set
		{
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Expected O, but got Unknown
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Expected O, but got Unknown
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Expected O, but got Unknown
			if (_owner != null)
			{
				if (_owner.StyleManager == this)
				{
					_owner.StyleManager = null;
				}
				IMetroContainerControl owner = _owner;
				ContainerControl val = (ContainerControl)((owner is ContainerControl) ? owner : null);
				if (val != null)
				{
					((Control)val).remove_ControlAdded(new ControlEventHandler(ControlAdded));
				}
			}
			_owner = value;
			if (value != null)
			{
				value.StyleManager = this;
				IMetroContainerControl owner2 = _owner;
				ContainerControl val2 = (ContainerControl)((owner2 is ContainerControl) ? owner2 : null);
				if (val2 != null)
				{
					((Control)val2).add_ControlAdded(new ControlEventHandler(ControlAdded));
				}
				if (!isInitializing)
				{
					UpdateControl((Control)value);
				}
			}
		}
	}

	public event EventHandler MetroStyleChanged;

	private void OnMetroStyleChanged(object sender, EventArgs e)
	{
		if (!isInitializing)
		{
			Update();
			this.MetroStyleChanged?.Invoke(this, e);
		}
	}

	public MetroStyleManager()
	{
		_styleManager = Default;
		if (_styleManager != null)
		{
			_styleManager.MetroStyleChanged += OnMetroStyleChanged;
			return;
		}
		_metroTheme = MetroThemeStyle.Light;
		_metroStyle = MetroColorStyle.Blue;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && _styleManager != null)
		{
			_styleManager.MetroStyleChanged -= OnMetroStyleChanged;
		}
		base.Dispose(disposing);
	}

	public MetroStyleManager(IContainer parentContainer)
		: this()
	{
		if (parentContainer != null)
		{
			_parentContainer = parentContainer;
			_parentContainer.Add(this);
		}
	}

	void ISupportInitialize.BeginInit()
	{
		isInitializing = true;
	}

	void ISupportInitialize.EndInit()
	{
		isInitializing = false;
		Update();
	}

	private void ControlAdded(object sender, ControlEventArgs e)
	{
		if (!isInitializing)
		{
			UpdateControl(e.get_Control());
		}
	}

	public void Update()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		if (_owner != null)
		{
			UpdateControl((Control)_owner);
		}
		if (_parentContainer == null || _parentContainer.Components == null)
		{
			return;
		}
		foreach (object component in _parentContainer.Components)
		{
			if (!object.ReferenceEquals(component, this) && component is IMetroStyledComponent metroStyledComponent)
			{
				metroStyledComponent.InternalStyleManager = this;
			}
		}
	}

	private void UpdateControl(Control control)
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		if (control == null)
		{
			return;
		}
		if (control is IMetroContainerControl metroContainerControl && metroContainerControl.StyleManager != null && !object.ReferenceEquals(this, metroContainerControl.StyleManager))
		{
			((IMetroStyledComponent)metroContainerControl.StyleManager).InternalStyleManager = this;
			return;
		}
		if (control is IMetroStyledComponent metroStyledComponent)
		{
			metroStyledComponent.InternalStyleManager = this;
		}
		if (control.get_ContextMenuStrip() != null)
		{
			UpdateControl((Control)(object)control.get_ContextMenuStrip());
		}
		TabControl val = (TabControl)(object)((control is TabControl) ? control : null);
		if (val != null)
		{
			foreach (TabPage tabPage in val.get_TabPages())
			{
				TabPage control2 = tabPage;
				UpdateControl((Control)(object)control2);
			}
		}
		if (control.get_Controls() == null)
		{
			return;
		}
		foreach (Control item in (ArrangedElementCollection)control.get_Controls())
		{
			Control control3 = item;
			UpdateControl(control3);
		}
	}
}
