using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.DirectX.Direct3D;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

public class D3DSettingsForm : Form
{
	[AccessedThroughProperty("multisampleLabel")]
	private Label _multisampleLabel;

	[AccessedThroughProperty("vertexProcLabel")]
	private Label _vertexProcLabel;

	[AccessedThroughProperty("depthStencilBufferComboBox")]
	private ComboBox _depthStencilBufferComboBox;

	[AccessedThroughProperty("depthStencilBufferLabel")]
	private Label _depthStencilBufferLabel;

	[AccessedThroughProperty("vertexProcComboBox")]
	private ComboBox _vertexProcComboBox;

	[AccessedThroughProperty("backBufferFormatComboBox")]
	private ComboBox _backBufferFormatComboBox;

	[AccessedThroughProperty("backBufferFormatLabel")]
	private Label _backBufferFormatLabel;

	[AccessedThroughProperty("otherSettingsGroupBox")]
	private GroupBox _otherSettingsGroupBox;

	[AccessedThroughProperty("refreshRateComboBox")]
	private ComboBox _refreshRateComboBox;

	[AccessedThroughProperty("presentIntervalLabel")]
	private Label _presentIntervalLabel;

	[AccessedThroughProperty("refreshRateLabel")]
	private Label _refreshRateLabel;

	[AccessedThroughProperty("resolutionComboBox")]
	private ComboBox _resolutionComboBox;

	[AccessedThroughProperty("resolutionLabel")]
	private Label _resolutionLabel;

	[AccessedThroughProperty("adapterFormatComboBox")]
	private ComboBox _adapterFormatComboBox;

	[AccessedThroughProperty("adapterFormatLabel")]
	private Label _adapterFormatLabel;

	[AccessedThroughProperty("fullscreenRadioButton")]
	private RadioButton _fullscreenRadioButton;

	[AccessedThroughProperty("windowedRadioButton")]
	private RadioButton _windowedRadioButton;

	[AccessedThroughProperty("modeSettingsGroupBox")]
	private GroupBox _modeSettingsGroupBox;

	[AccessedThroughProperty("deviceComboBox")]
	private ComboBox _deviceComboBox;

	[AccessedThroughProperty("deviceLabel")]
	private Label _deviceLabel;

	[AccessedThroughProperty("adapterComboBox")]
	private ComboBox _adapterComboBox;

	[AccessedThroughProperty("displayAdapterLabel")]
	private Label _displayAdapterLabel;

	[AccessedThroughProperty("adapterDeviceGroupBox")]
	private GroupBox _adapterDeviceGroupBox;

	[AccessedThroughProperty("presentIntervalComboBox")]
	private ComboBox _presentIntervalComboBox;

	[AccessedThroughProperty("okButton")]
	private Button _okButton;

	[AccessedThroughProperty("multisampleQualityLabel")]
	private Label _multisampleQualityLabel;

	[AccessedThroughProperty("multisampleQualityComboBox")]
	private ComboBox _multisampleQualityComboBox;

	[AccessedThroughProperty("btnCancel")]
	private Button _btnCancel;

	[AccessedThroughProperty("multisampleComboBox")]
	private ComboBox _multisampleComboBox;

	private D3DEnumeration enumeration;

	public D3DSettings settings;

	private Container components;

	private virtual Label vertexProcLabel
	{
		get
		{
			return _vertexProcLabel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_vertexProcLabel == null)
			{
			}
			_vertexProcLabel = value;
			if (_vertexProcLabel != null)
			{
			}
		}
	}

	private virtual ComboBox vertexProcComboBox
	{
		get
		{
			return _vertexProcComboBox;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_vertexProcComboBox != null)
			{
				_vertexProcComboBox.remove_SelectedIndexChanged((EventHandler)VertexProcessingChanged);
			}
			_vertexProcComboBox = value;
			if (_vertexProcComboBox != null)
			{
				_vertexProcComboBox.add_SelectedIndexChanged((EventHandler)VertexProcessingChanged);
			}
		}
	}

	private virtual Label presentIntervalLabel
	{
		get
		{
			return _presentIntervalLabel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_presentIntervalLabel == null)
			{
			}
			_presentIntervalLabel = value;
			if (_presentIntervalLabel != null)
			{
			}
		}
	}

	private virtual ComboBox presentIntervalComboBox
	{
		get
		{
			return _presentIntervalComboBox;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_presentIntervalComboBox != null)
			{
				((ListControl)_presentIntervalComboBox).remove_SelectedValueChanged((EventHandler)PresentIntervalChanged);
			}
			_presentIntervalComboBox = value;
			if (_presentIntervalComboBox != null)
			{
				((ListControl)_presentIntervalComboBox).add_SelectedValueChanged((EventHandler)PresentIntervalChanged);
			}
		}
	}

	private virtual Button okButton
	{
		get
		{
			return _okButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_okButton == null)
			{
			}
			_okButton = value;
			if (_okButton != null)
			{
			}
		}
	}

	private virtual Button btnCancel
	{
		get
		{
			return _btnCancel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_btnCancel == null)
			{
			}
			_btnCancel = value;
			if (_btnCancel != null)
			{
			}
		}
	}

	private virtual ComboBox multisampleQualityComboBox
	{
		get
		{
			return _multisampleQualityComboBox;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_multisampleQualityComboBox != null)
			{
				_multisampleQualityComboBox.remove_SelectedIndexChanged((EventHandler)MultisampleQualityChanged);
			}
			_multisampleQualityComboBox = value;
			if (_multisampleQualityComboBox != null)
			{
				_multisampleQualityComboBox.add_SelectedIndexChanged((EventHandler)MultisampleQualityChanged);
			}
		}
	}

	private virtual Label multisampleQualityLabel
	{
		get
		{
			return _multisampleQualityLabel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_multisampleQualityLabel == null)
			{
			}
			_multisampleQualityLabel = value;
			if (_multisampleQualityLabel != null)
			{
			}
		}
	}

	private virtual GroupBox adapterDeviceGroupBox
	{
		get
		{
			return _adapterDeviceGroupBox;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_adapterDeviceGroupBox == null)
			{
			}
			_adapterDeviceGroupBox = value;
			if (_adapterDeviceGroupBox != null)
			{
			}
		}
	}

	private virtual Label displayAdapterLabel
	{
		get
		{
			return _displayAdapterLabel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_displayAdapterLabel == null)
			{
			}
			_displayAdapterLabel = value;
			if (_displayAdapterLabel != null)
			{
			}
		}
	}

	private virtual ComboBox adapterComboBox
	{
		get
		{
			return _adapterComboBox;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_adapterComboBox != null)
			{
				_adapterComboBox.remove_SelectedIndexChanged((EventHandler)AdapterChanged);
			}
			_adapterComboBox = value;
			if (_adapterComboBox != null)
			{
				_adapterComboBox.add_SelectedIndexChanged((EventHandler)AdapterChanged);
			}
		}
	}

	private virtual Label deviceLabel
	{
		get
		{
			return _deviceLabel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_deviceLabel == null)
			{
			}
			_deviceLabel = value;
			if (_deviceLabel != null)
			{
			}
		}
	}

	private virtual ComboBox deviceComboBox
	{
		get
		{
			return _deviceComboBox;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_deviceComboBox != null)
			{
				_deviceComboBox.remove_SelectedIndexChanged((EventHandler)DeviceChanged);
			}
			_deviceComboBox = value;
			if (_deviceComboBox != null)
			{
				_deviceComboBox.add_SelectedIndexChanged((EventHandler)DeviceChanged);
			}
		}
	}

	private virtual GroupBox modeSettingsGroupBox
	{
		get
		{
			return _modeSettingsGroupBox;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_modeSettingsGroupBox == null)
			{
			}
			_modeSettingsGroupBox = value;
			if (_modeSettingsGroupBox != null)
			{
			}
		}
	}

	private virtual RadioButton windowedRadioButton
	{
		get
		{
			return _windowedRadioButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_windowedRadioButton != null)
			{
				_windowedRadioButton.remove_CheckedChanged((EventHandler)WindowedFullscreenChanged);
			}
			_windowedRadioButton = value;
			if (_windowedRadioButton != null)
			{
				_windowedRadioButton.add_CheckedChanged((EventHandler)WindowedFullscreenChanged);
			}
		}
	}

	private virtual RadioButton fullscreenRadioButton
	{
		get
		{
			return _fullscreenRadioButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_fullscreenRadioButton == null)
			{
			}
			_fullscreenRadioButton = value;
			if (_fullscreenRadioButton != null)
			{
			}
		}
	}

	private virtual Label adapterFormatLabel
	{
		get
		{
			return _adapterFormatLabel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_adapterFormatLabel == null)
			{
			}
			_adapterFormatLabel = value;
			if (_adapterFormatLabel != null)
			{
			}
		}
	}

	private virtual ComboBox adapterFormatComboBox
	{
		get
		{
			return _adapterFormatComboBox;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_adapterFormatComboBox != null)
			{
				((ListControl)_adapterFormatComboBox).remove_SelectedValueChanged((EventHandler)AdapterFormatChanged);
			}
			_adapterFormatComboBox = value;
			if (_adapterFormatComboBox != null)
			{
				((ListControl)_adapterFormatComboBox).add_SelectedValueChanged((EventHandler)AdapterFormatChanged);
			}
		}
	}

	private virtual Label resolutionLabel
	{
		get
		{
			return _resolutionLabel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_resolutionLabel == null)
			{
			}
			_resolutionLabel = value;
			if (_resolutionLabel != null)
			{
			}
		}
	}

	private virtual ComboBox resolutionComboBox
	{
		get
		{
			return _resolutionComboBox;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_resolutionComboBox != null)
			{
				_resolutionComboBox.remove_SelectedIndexChanged((EventHandler)ResolutionChanged);
			}
			_resolutionComboBox = value;
			if (_resolutionComboBox != null)
			{
				_resolutionComboBox.add_SelectedIndexChanged((EventHandler)ResolutionChanged);
			}
		}
	}

	private virtual Label refreshRateLabel
	{
		get
		{
			return _refreshRateLabel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_refreshRateLabel == null)
			{
			}
			_refreshRateLabel = value;
			if (_refreshRateLabel != null)
			{
			}
		}
	}

	private virtual ComboBox refreshRateComboBox
	{
		get
		{
			return _refreshRateComboBox;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_refreshRateComboBox != null)
			{
				_refreshRateComboBox.remove_SelectedIndexChanged((EventHandler)RefreshRateChanged);
			}
			_refreshRateComboBox = value;
			if (_refreshRateComboBox != null)
			{
				_refreshRateComboBox.add_SelectedIndexChanged((EventHandler)RefreshRateChanged);
			}
		}
	}

	private virtual GroupBox otherSettingsGroupBox
	{
		get
		{
			return _otherSettingsGroupBox;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_otherSettingsGroupBox == null)
			{
			}
			_otherSettingsGroupBox = value;
			if (_otherSettingsGroupBox != null)
			{
			}
		}
	}

	private virtual Label backBufferFormatLabel
	{
		get
		{
			return _backBufferFormatLabel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_backBufferFormatLabel == null)
			{
			}
			_backBufferFormatLabel = value;
			if (_backBufferFormatLabel != null)
			{
			}
		}
	}

	private virtual ComboBox backBufferFormatComboBox
	{
		get
		{
			return _backBufferFormatComboBox;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_backBufferFormatComboBox != null)
			{
				_backBufferFormatComboBox.remove_SelectedIndexChanged((EventHandler)BackBufferFormatChanged);
			}
			_backBufferFormatComboBox = value;
			if (_backBufferFormatComboBox != null)
			{
				_backBufferFormatComboBox.add_SelectedIndexChanged((EventHandler)BackBufferFormatChanged);
			}
		}
	}

	private virtual Label depthStencilBufferLabel
	{
		get
		{
			return _depthStencilBufferLabel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_depthStencilBufferLabel == null)
			{
			}
			_depthStencilBufferLabel = value;
			if (_depthStencilBufferLabel != null)
			{
			}
		}
	}

	private virtual ComboBox depthStencilBufferComboBox
	{
		get
		{
			return _depthStencilBufferComboBox;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_depthStencilBufferComboBox != null)
			{
				_depthStencilBufferComboBox.remove_SelectedIndexChanged((EventHandler)DepthStencilBufferFormatChanged);
			}
			_depthStencilBufferComboBox = value;
			if (_depthStencilBufferComboBox != null)
			{
				_depthStencilBufferComboBox.add_SelectedIndexChanged((EventHandler)DepthStencilBufferFormatChanged);
			}
		}
	}

	private virtual Label multisampleLabel
	{
		get
		{
			return _multisampleLabel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_multisampleLabel == null)
			{
			}
			_multisampleLabel = value;
			if (_multisampleLabel != null)
			{
			}
		}
	}

	private virtual ComboBox multisampleComboBox
	{
		get
		{
			return _multisampleComboBox;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_multisampleComboBox != null)
			{
				_multisampleComboBox.remove_SelectedIndexChanged((EventHandler)MultisampleTypeChanged);
			}
			_multisampleComboBox = value;
			if (_multisampleComboBox != null)
			{
				_multisampleComboBox.add_SelectedIndexChanged((EventHandler)MultisampleTypeChanged);
			}
		}
	}

	public D3DSettingsForm(D3DEnumeration enumerationParam, D3DSettings settingsParam)
	{
		components = null;
		enumeration = enumerationParam;
		settings = settingsParam.Clone();
		InitializeComponent();
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = enumeration.AdapterInfoList.GetEnumerator();
			while (enumerator.MoveNext())
			{
				GraphicsAdapterInfo graphicsAdapterInfo = (GraphicsAdapterInfo)enumerator.Current;
				adapterComboBox.get_Items().Add((object)graphicsAdapterInfo);
				if (graphicsAdapterInfo.AdapterOrdinal == settings.AdapterOrdinal)
				{
					adapterComboBox.set_SelectedItem((object)graphicsAdapterInfo);
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				((IDisposable)enumerator).Dispose();
			}
		}
		if ((adapterComboBox.get_SelectedItem() == null) & (adapterComboBox.get_Items().get_Count() > 0))
		{
			adapterComboBox.set_SelectedIndex(0);
		}
	}

	protected void Dispose()
	{
		((Form)this).Dispose(((Control)this).get_Disposing());
		if (components != null)
		{
			components.Dispose();
		}
	}

	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		adapterDeviceGroupBox = new GroupBox();
		deviceComboBox = new ComboBox();
		deviceLabel = new Label();
		adapterComboBox = new ComboBox();
		displayAdapterLabel = new Label();
		fullscreenRadioButton = new RadioButton();
		btnCancel = new Button();
		otherSettingsGroupBox = new GroupBox();
		multisampleQualityComboBox = new ComboBox();
		multisampleQualityLabel = new Label();
		multisampleComboBox = new ComboBox();
		backBufferFormatComboBox = new ComboBox();
		multisampleLabel = new Label();
		depthStencilBufferLabel = new Label();
		backBufferFormatLabel = new Label();
		depthStencilBufferComboBox = new ComboBox();
		vertexProcComboBox = new ComboBox();
		vertexProcLabel = new Label();
		presentIntervalComboBox = new ComboBox();
		presentIntervalLabel = new Label();
		resolutionComboBox = new ComboBox();
		windowedRadioButton = new RadioButton();
		resolutionLabel = new Label();
		refreshRateComboBox = new ComboBox();
		adapterFormatLabel = new Label();
		refreshRateLabel = new Label();
		okButton = new Button();
		modeSettingsGroupBox = new GroupBox();
		adapterFormatComboBox = new ComboBox();
		((Control)adapterDeviceGroupBox).SuspendLayout();
		((Control)otherSettingsGroupBox).SuspendLayout();
		((Control)modeSettingsGroupBox).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)adapterDeviceGroupBox).get_Controls().AddRange((Control[])(object)new Control[4]
		{
			(Control)deviceComboBox,
			(Control)deviceLabel,
			(Control)adapterComboBox,
			(Control)displayAdapterLabel
		});
		GroupBox obj = adapterDeviceGroupBox;
		Point location = new Point(16, 8);
		((Control)obj).set_Location(location);
		((Control)adapterDeviceGroupBox).set_Name("adapterDeviceGroupBox");
		GroupBox obj2 = adapterDeviceGroupBox;
		Size size = new Size(400, 80);
		((Control)obj2).set_Size(size);
		((Control)adapterDeviceGroupBox).set_TabIndex(0);
		adapterDeviceGroupBox.set_TabStop(false);
		adapterDeviceGroupBox.set_Text("Adapter and device");
		deviceComboBox.set_DropDownStyle((ComboBoxStyle)2);
		deviceComboBox.set_DropDownWidth(121);
		ComboBox obj3 = deviceComboBox;
		location = new Point(160, 48);
		((Control)obj3).set_Location(location);
		((Control)deviceComboBox).set_Name("deviceComboBox");
		ComboBox obj4 = deviceComboBox;
		size = new Size(232, 21);
		((Control)obj4).set_Size(size);
		((Control)deviceComboBox).set_TabIndex(3);
		Label obj5 = deviceLabel;
		location = new Point(8, 48);
		((Control)obj5).set_Location(location);
		((Control)deviceLabel).set_Name("deviceLabel");
		Label obj6 = deviceLabel;
		size = new Size(152, 23);
		((Control)obj6).set_Size(size);
		((Control)deviceLabel).set_TabIndex(2);
		((Control)deviceLabel).set_Text("Render &Device:");
		adapterComboBox.set_DropDownStyle((ComboBoxStyle)2);
		adapterComboBox.set_DropDownWidth(121);
		ComboBox obj7 = adapterComboBox;
		location = new Point(160, 24);
		((Control)obj7).set_Location(location);
		((Control)adapterComboBox).set_Name("adapterComboBox");
		ComboBox obj8 = adapterComboBox;
		size = new Size(232, 21);
		((Control)obj8).set_Size(size);
		((Control)adapterComboBox).set_TabIndex(1);
		Label obj9 = displayAdapterLabel;
		location = new Point(8, 24);
		((Control)obj9).set_Location(location);
		((Control)displayAdapterLabel).set_Name("displayAdapterLabel");
		Label obj10 = displayAdapterLabel;
		size = new Size(152, 23);
		((Control)obj10).set_Size(size);
		((Control)displayAdapterLabel).set_TabIndex(0);
		((Control)displayAdapterLabel).set_Text("Display &Adapter:");
		RadioButton obj11 = fullscreenRadioButton;
		location = new Point(9, 38);
		((Control)obj11).set_Location(location);
		((Control)fullscreenRadioButton).set_Name("fullscreenRadioButton");
		RadioButton obj12 = fullscreenRadioButton;
		size = new Size(152, 24);
		((Control)obj12).set_Size(size);
		((Control)fullscreenRadioButton).set_TabIndex(1);
		((Control)fullscreenRadioButton).set_Text("&Fullscreen");
		btnCancel.set_DialogResult((DialogResult)2);
		Button obj13 = btnCancel;
		location = new Point(248, 464);
		((Control)obj13).set_Location(location);
		((Control)btnCancel).set_Name("btnCancel");
		((Control)btnCancel).set_TabIndex(4);
		((Control)btnCancel).set_Text("Cancel");
		((Control)otherSettingsGroupBox).get_Controls().AddRange((Control[])(object)new Control[12]
		{
			(Control)multisampleQualityComboBox,
			(Control)multisampleQualityLabel,
			(Control)multisampleComboBox,
			(Control)backBufferFormatComboBox,
			(Control)multisampleLabel,
			(Control)depthStencilBufferLabel,
			(Control)backBufferFormatLabel,
			(Control)depthStencilBufferComboBox,
			(Control)vertexProcComboBox,
			(Control)vertexProcLabel,
			(Control)presentIntervalComboBox,
			(Control)presentIntervalLabel
		});
		GroupBox obj14 = otherSettingsGroupBox;
		location = new Point(16, 264);
		((Control)obj14).set_Location(location);
		((Control)otherSettingsGroupBox).set_Name("otherSettingsGroupBox");
		GroupBox obj15 = otherSettingsGroupBox;
		size = new Size(400, 176);
		((Control)obj15).set_Size(size);
		((Control)otherSettingsGroupBox).set_TabIndex(2);
		otherSettingsGroupBox.set_TabStop(false);
		otherSettingsGroupBox.set_Text("Device settings");
		multisampleQualityComboBox.set_DropDownStyle((ComboBoxStyle)2);
		multisampleQualityComboBox.set_DropDownWidth(144);
		ComboBox obj16 = multisampleQualityComboBox;
		location = new Point(160, 96);
		((Control)obj16).set_Location(location);
		((Control)multisampleQualityComboBox).set_Name("multisampleQualityComboBox");
		ComboBox obj17 = multisampleQualityComboBox;
		size = new Size(232, 21);
		((Control)obj17).set_Size(size);
		((Control)multisampleQualityComboBox).set_TabIndex(7);
		Label obj18 = multisampleQualityLabel;
		location = new Point(8, 96);
		((Control)obj18).set_Location(location);
		((Control)multisampleQualityLabel).set_Name("multisampleQualityLabel");
		Label obj19 = multisampleQualityLabel;
		size = new Size(152, 23);
		((Control)obj19).set_Size(size);
		((Control)multisampleQualityLabel).set_TabIndex(6);
		((Control)multisampleQualityLabel).set_Text("Multisample &Quality:");
		multisampleComboBox.set_DropDownStyle((ComboBoxStyle)2);
		multisampleComboBox.set_DropDownWidth(144);
		ComboBox obj20 = multisampleComboBox;
		location = new Point(160, 72);
		((Control)obj20).set_Location(location);
		((Control)multisampleComboBox).set_Name("multisampleComboBox");
		ComboBox obj21 = multisampleComboBox;
		size = new Size(232, 21);
		((Control)obj21).set_Size(size);
		((Control)multisampleComboBox).set_TabIndex(5);
		backBufferFormatComboBox.set_DropDownStyle((ComboBoxStyle)2);
		backBufferFormatComboBox.set_DropDownWidth(144);
		ComboBox obj22 = backBufferFormatComboBox;
		location = new Point(160, 24);
		((Control)obj22).set_Location(location);
		((Control)backBufferFormatComboBox).set_Name("backBufferFormatComboBox");
		ComboBox obj23 = backBufferFormatComboBox;
		size = new Size(232, 21);
		((Control)obj23).set_Size(size);
		((Control)backBufferFormatComboBox).set_TabIndex(1);
		Label obj24 = multisampleLabel;
		location = new Point(8, 72);
		((Control)obj24).set_Location(location);
		((Control)multisampleLabel).set_Name("multisampleLabel");
		Label obj25 = multisampleLabel;
		size = new Size(152, 23);
		((Control)obj25).set_Size(size);
		((Control)multisampleLabel).set_TabIndex(4);
		((Control)multisampleLabel).set_Text("&Multisample Type:");
		Label obj26 = depthStencilBufferLabel;
		location = new Point(8, 48);
		((Control)obj26).set_Location(location);
		((Control)depthStencilBufferLabel).set_Name("depthStencilBufferLabel");
		Label obj27 = depthStencilBufferLabel;
		size = new Size(152, 23);
		((Control)obj27).set_Size(size);
		((Control)depthStencilBufferLabel).set_TabIndex(2);
		((Control)depthStencilBufferLabel).set_Text("De&pth/Stencil Buffer Format:");
		Label obj28 = backBufferFormatLabel;
		location = new Point(8, 24);
		((Control)obj28).set_Location(location);
		((Control)backBufferFormatLabel).set_Name("backBufferFormatLabel");
		Label obj29 = backBufferFormatLabel;
		size = new Size(152, 23);
		((Control)obj29).set_Size(size);
		((Control)backBufferFormatLabel).set_TabIndex(0);
		((Control)backBufferFormatLabel).set_Text("&Back Buffer Format:");
		depthStencilBufferComboBox.set_DropDownStyle((ComboBoxStyle)2);
		depthStencilBufferComboBox.set_DropDownWidth(144);
		ComboBox obj30 = depthStencilBufferComboBox;
		location = new Point(160, 48);
		((Control)obj30).set_Location(location);
		((Control)depthStencilBufferComboBox).set_Name("depthStencilBufferComboBox");
		ComboBox obj31 = depthStencilBufferComboBox;
		size = new Size(232, 21);
		((Control)obj31).set_Size(size);
		((Control)depthStencilBufferComboBox).set_TabIndex(3);
		vertexProcComboBox.set_DropDownStyle((ComboBoxStyle)2);
		vertexProcComboBox.set_DropDownWidth(121);
		ComboBox obj32 = vertexProcComboBox;
		location = new Point(160, 120);
		((Control)obj32).set_Location(location);
		((Control)vertexProcComboBox).set_Name("vertexProcComboBox");
		ComboBox obj33 = vertexProcComboBox;
		size = new Size(232, 21);
		((Control)obj33).set_Size(size);
		((Control)vertexProcComboBox).set_TabIndex(9);
		Label obj34 = vertexProcLabel;
		location = new Point(8, 120);
		((Control)obj34).set_Location(location);
		((Control)vertexProcLabel).set_Name("vertexProcLabel");
		Label obj35 = vertexProcLabel;
		size = new Size(152, 23);
		((Control)obj35).set_Size(size);
		((Control)vertexProcLabel).set_TabIndex(8);
		((Control)vertexProcLabel).set_Text("&Vertex Processing:");
		presentIntervalComboBox.set_DropDownStyle((ComboBoxStyle)2);
		presentIntervalComboBox.set_DropDownWidth(121);
		ComboBox obj36 = presentIntervalComboBox;
		location = new Point(160, 144);
		((Control)obj36).set_Location(location);
		((Control)presentIntervalComboBox).set_Name("presentIntervalComboBox");
		ComboBox obj37 = presentIntervalComboBox;
		size = new Size(232, 21);
		((Control)obj37).set_Size(size);
		((Control)presentIntervalComboBox).set_TabIndex(11);
		Label obj38 = presentIntervalLabel;
		location = new Point(8, 144);
		((Control)obj38).set_Location(location);
		((Control)presentIntervalLabel).set_Name("presentIntervalLabel");
		Label obj39 = presentIntervalLabel;
		size = new Size(152, 23);
		((Control)obj39).set_Size(size);
		((Control)presentIntervalLabel).set_TabIndex(10);
		((Control)presentIntervalLabel).set_Text("Present &Interval:");
		resolutionComboBox.set_DropDownStyle((ComboBoxStyle)2);
		resolutionComboBox.set_DropDownWidth(144);
		ComboBox obj40 = resolutionComboBox;
		location = new Point(161, 94);
		((Control)obj40).set_Location(location);
		resolutionComboBox.set_MaxDropDownItems(14);
		((Control)resolutionComboBox).set_Name("resolutionComboBox");
		ComboBox obj41 = resolutionComboBox;
		size = new Size(232, 21);
		((Control)obj41).set_Size(size);
		((Control)resolutionComboBox).set_TabIndex(5);
		RadioButton obj42 = windowedRadioButton;
		location = new Point(9, 14);
		((Control)obj42).set_Location(location);
		((Control)windowedRadioButton).set_Name("windowedRadioButton");
		RadioButton obj43 = windowedRadioButton;
		size = new Size(152, 24);
		((Control)obj43).set_Size(size);
		((Control)windowedRadioButton).set_TabIndex(0);
		((Control)windowedRadioButton).set_Text("&Windowed");
		Label obj44 = resolutionLabel;
		location = new Point(8, 94);
		((Control)obj44).set_Location(location);
		((Control)resolutionLabel).set_Name("resolutionLabel");
		Label obj45 = resolutionLabel;
		size = new Size(152, 23);
		((Control)obj45).set_Size(size);
		((Control)resolutionLabel).set_TabIndex(4);
		((Control)resolutionLabel).set_Text("&Resolution:");
		refreshRateComboBox.set_DropDownStyle((ComboBoxStyle)2);
		refreshRateComboBox.set_DropDownWidth(144);
		ComboBox obj46 = refreshRateComboBox;
		location = new Point(161, 118);
		((Control)obj46).set_Location(location);
		refreshRateComboBox.set_MaxDropDownItems(14);
		((Control)refreshRateComboBox).set_Name("refreshRateComboBox");
		ComboBox obj47 = refreshRateComboBox;
		size = new Size(232, 21);
		((Control)obj47).set_Size(size);
		((Control)refreshRateComboBox).set_TabIndex(7);
		Label obj48 = adapterFormatLabel;
		location = new Point(8, 72);
		((Control)obj48).set_Location(location);
		((Control)adapterFormatLabel).set_Name("adapterFormatLabel");
		Label obj49 = adapterFormatLabel;
		size = new Size(152, 23);
		((Control)obj49).set_Size(size);
		((Control)adapterFormatLabel).set_TabIndex(2);
		((Control)adapterFormatLabel).set_Text("Adapter F&ormat:");
		Label obj50 = refreshRateLabel;
		location = new Point(8, 118);
		((Control)obj50).set_Location(location);
		((Control)refreshRateLabel).set_Name("refreshRateLabel");
		Label obj51 = refreshRateLabel;
		size = new Size(152, 23);
		((Control)obj51).set_Size(size);
		((Control)refreshRateLabel).set_TabIndex(6);
		((Control)refreshRateLabel).set_Text("R&efresh Rate:");
		okButton.set_DialogResult((DialogResult)1);
		Button obj52 = okButton;
		location = new Point(112, 464);
		((Control)obj52).set_Location(location);
		((Control)okButton).set_Name("okButton");
		((Control)okButton).set_TabIndex(3);
		((Control)okButton).set_Text("OK");
		((Control)modeSettingsGroupBox).get_Controls().AddRange((Control[])(object)new Control[8]
		{
			(Control)adapterFormatLabel,
			(Control)refreshRateLabel,
			(Control)resolutionComboBox,
			(Control)adapterFormatComboBox,
			(Control)resolutionLabel,
			(Control)refreshRateComboBox,
			(Control)windowedRadioButton,
			(Control)fullscreenRadioButton
		});
		GroupBox obj53 = modeSettingsGroupBox;
		location = new Point(16, 96);
		((Control)obj53).set_Location(location);
		((Control)modeSettingsGroupBox).set_Name("modeSettingsGroupBox");
		GroupBox obj54 = modeSettingsGroupBox;
		size = new Size(400, 160);
		((Control)obj54).set_Size(size);
		((Control)modeSettingsGroupBox).set_TabIndex(1);
		modeSettingsGroupBox.set_TabStop(false);
		modeSettingsGroupBox.set_Text("Display mode settings");
		adapterFormatComboBox.set_DropDownStyle((ComboBoxStyle)2);
		adapterFormatComboBox.set_DropDownWidth(121);
		ComboBox obj55 = adapterFormatComboBox;
		location = new Point(161, 70);
		((Control)obj55).set_Location(location);
		adapterFormatComboBox.set_MaxDropDownItems(14);
		((Control)adapterFormatComboBox).set_Name("adapterFormatComboBox");
		ComboBox obj56 = adapterFormatComboBox;
		size = new Size(232, 21);
		((Control)obj56).set_Size(size);
		((Control)adapterFormatComboBox).set_TabIndex(3);
		((Form)this).set_AcceptButton((IButtonControl)(object)okButton);
		size = new Size(5, 13);
		((Form)this).set_AutoScaleBaseSize(size);
		((Form)this).set_CancelButton((IButtonControl)(object)btnCancel);
		size = new Size(438, 512);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().AddRange((Control[])(object)new Control[5]
		{
			(Control)btnCancel,
			(Control)okButton,
			(Control)adapterDeviceGroupBox,
			(Control)modeSettingsGroupBox,
			(Control)otherSettingsGroupBox
		});
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("D3DSettingsForm");
		((Control)this).set_Text("Direct3D Settings");
		((Control)adapterDeviceGroupBox).ResumeLayout(false);
		((Control)otherSettingsGroupBox).ResumeLayout(false);
		((Control)modeSettingsGroupBox).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	private void AdapterChanged(object sender, EventArgs e)
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		GraphicsAdapterInfo graphicsAdapterInfo = (GraphicsAdapterInfo)adapterComboBox.get_SelectedItem();
		settings.AdapterInfo = graphicsAdapterInfo;
		deviceComboBox.get_Items().Clear();
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = graphicsAdapterInfo.DeviceInfoList.GetEnumerator();
			while (enumerator.MoveNext())
			{
				GraphicsDeviceInfo graphicsDeviceInfo = (GraphicsDeviceInfo)enumerator.Current;
				deviceComboBox.get_Items().Add((object)graphicsDeviceInfo);
				if (graphicsDeviceInfo.DevType == settings.DevType)
				{
					deviceComboBox.set_SelectedItem((object)graphicsDeviceInfo);
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				((IDisposable)enumerator).Dispose();
			}
		}
		if ((deviceComboBox.get_SelectedItem() == null) & (deviceComboBox.get_Items().get_Count() > 0))
		{
			deviceComboBox.set_SelectedIndex(0);
		}
	}

	private void DeviceChanged(object sender, EventArgs e)
	{
		_ = (GraphicsAdapterInfo)adapterComboBox.get_SelectedItem();
		GraphicsDeviceInfo graphicsDeviceInfo = (GraphicsDeviceInfo)deviceComboBox.get_SelectedItem();
		settings.DeviceInfo = graphicsDeviceInfo;
		bool flag = false;
		bool enabled = false;
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = graphicsDeviceInfo.DeviceComboList.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DeviceCombo deviceCombo = (DeviceCombo)enumerator.Current;
				if (deviceCombo.IsWindowed)
				{
					flag = true;
				}
				else
				{
					enabled = true;
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				((IDisposable)enumerator).Dispose();
			}
		}
		((Control)windowedRadioButton).set_Enabled(flag);
		((Control)fullscreenRadioButton).set_Enabled(enabled);
		if (settings.IsWindowed && flag)
		{
			windowedRadioButton.set_Checked(true);
		}
		else
		{
			fullscreenRadioButton.set_Checked(true);
		}
		WindowedFullscreenChanged(null, null);
	}

	private void WindowedFullscreenChanged(object sender, EventArgs e)
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		GraphicsAdapterInfo graphicsAdapterInfo = (GraphicsAdapterInfo)adapterComboBox.get_SelectedItem();
		GraphicsDeviceInfo graphicsDeviceInfo = (GraphicsDeviceInfo)deviceComboBox.get_SelectedItem();
		if (windowedRadioButton.get_Checked())
		{
			settings.IsWindowed = true;
			settings.WindowedAdapterInfo = graphicsAdapterInfo;
			settings.WindowedDeviceInfo = graphicsDeviceInfo;
			adapterFormatComboBox.get_Items().Clear();
			adapterFormatComboBox.get_Items().Add((object)((DisplayMode)(ref settings.WindowedDisplayMode)).get_Format());
			adapterFormatComboBox.set_SelectedIndex(0);
			((Control)adapterFormatComboBox).set_Enabled(false);
			resolutionComboBox.get_Items().Clear();
			resolutionComboBox.get_Items().Add((object)FormatResolution(((DisplayMode)(ref settings.WindowedDisplayMode)).get_Width(), ((DisplayMode)(ref settings.WindowedDisplayMode)).get_Height()));
			resolutionComboBox.set_SelectedIndex(0);
			((Control)resolutionComboBox).set_Enabled(false);
			refreshRateComboBox.get_Items().Clear();
			refreshRateComboBox.get_Items().Add((object)FormatRefreshRate(((DisplayMode)(ref settings.WindowedDisplayMode)).get_RefreshRate()));
			refreshRateComboBox.set_SelectedIndex(0);
			((Control)refreshRateComboBox).set_Enabled(false);
			return;
		}
		settings.IsWindowed = false;
		settings.FullscreenAdapterInfo = graphicsAdapterInfo;
		settings.FullscreenDeviceInfo = graphicsDeviceInfo;
		adapterFormatComboBox.get_Items().Clear();
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = graphicsDeviceInfo.DeviceComboList.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DeviceCombo deviceCombo = (DeviceCombo)enumerator.Current;
				if (!deviceCombo.IsWindowed && !adapterFormatComboBox.get_Items().Contains((object)deviceCombo.AdapterFormat))
				{
					adapterFormatComboBox.get_Items().Add((object)deviceCombo.AdapterFormat);
					if (ObjectType.ObjTst((object)deviceCombo.AdapterFormat, Interaction.IIf(settings.IsWindowed, (object)((DisplayMode)(ref settings.WindowedDisplayMode)).get_Format(), (object)((DisplayMode)(ref settings.FullscreenDisplayMode)).get_Format()), false) == 0)
					{
						adapterFormatComboBox.set_SelectedItem((object)deviceCombo.AdapterFormat);
					}
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				((IDisposable)enumerator).Dispose();
			}
		}
		if ((adapterFormatComboBox.get_SelectedItem() == null) & (adapterFormatComboBox.get_Items().get_Count() > 0))
		{
			adapterFormatComboBox.set_SelectedIndex(0);
		}
		((Control)adapterFormatComboBox).set_Enabled(true);
		((Control)resolutionComboBox).set_Enabled(true);
		((Control)refreshRateComboBox).set_Enabled(true);
	}

	private string FormatResolution(int width, int height)
	{
		StringBuilder stringBuilder = new StringBuilder(20);
		stringBuilder.AppendFormat("{0} by {1}", width, height);
		return stringBuilder.ToString();
	}

	private string FormatRefreshRate(int refreshRate)
	{
		if (refreshRate == 0)
		{
			return "Default Rate";
		}
		StringBuilder stringBuilder = new StringBuilder(20);
		stringBuilder.AppendFormat("{0} Hz", refreshRate);
		return stringBuilder.ToString();
	}

	private void AdapterFormatChanged(object sender, EventArgs e)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		if (!windowedRadioButton.get_Checked())
		{
			GraphicsAdapterInfo graphicsAdapterInfo = (GraphicsAdapterInfo)adapterComboBox.get_SelectedItem();
			Format val = (Format)IntegerType.FromObject(adapterFormatComboBox.get_SelectedItem());
			((DisplayMode)(ref settings.FullscreenDisplayMode)).set_Format(val);
			new StringBuilder(20);
			resolutionComboBox.get_Items().Clear();
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = graphicsAdapterInfo.DisplayModeList.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DisplayMode val2 = (DisplayMode)(enumerator.Current ?? Activator.CreateInstance(typeof(DisplayMode)));
					if (((DisplayMode)(ref val2)).get_Format() != val)
					{
						continue;
					}
					string text = FormatResolution(((DisplayMode)(ref val2)).get_Width(), ((DisplayMode)(ref val2)).get_Height());
					if (!resolutionComboBox.get_Items().Contains((object)text))
					{
						resolutionComboBox.get_Items().Add((object)text);
						if ((((DisplayMode)(ref settings.FullscreenDisplayMode)).get_Width() == ((DisplayMode)(ref val2)).get_Width()) & (((DisplayMode)(ref settings.FullscreenDisplayMode)).get_Height() == ((DisplayMode)(ref val2)).get_Height()))
						{
							resolutionComboBox.set_SelectedItem((object)text);
						}
					}
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					((IDisposable)enumerator).Dispose();
				}
			}
			if ((resolutionComboBox.get_SelectedItem() == null) & (resolutionComboBox.get_Items().get_Count() > 0))
			{
				resolutionComboBox.set_SelectedIndex(0);
			}
		}
		GraphicsDeviceInfo graphicsDeviceInfo = (GraphicsDeviceInfo)deviceComboBox.get_SelectedItem();
		backBufferFormatComboBox.get_Items().Clear();
		IEnumerator enumerator2 = default(IEnumerator);
		try
		{
			enumerator2 = graphicsDeviceInfo.DeviceComboList.GetEnumerator();
			while (enumerator2.MoveNext())
			{
				DeviceCombo deviceCombo = (DeviceCombo)enumerator2.Current;
				bool num = deviceCombo.IsWindowed == settings.IsWindowed;
				Format adapterFormat = deviceCombo.AdapterFormat;
				DisplayMode displayMode = settings.DisplayMode;
				if ((num & (adapterFormat == ((DisplayMode)(ref displayMode)).get_Format())) && !backBufferFormatComboBox.get_Items().Contains((object)deviceCombo.BackBufferFormat))
				{
					backBufferFormatComboBox.get_Items().Add((object)deviceCombo.BackBufferFormat);
					if (deviceCombo.BackBufferFormat == settings.BackBufferFormat)
					{
						backBufferFormatComboBox.set_SelectedItem((object)deviceCombo.BackBufferFormat);
					}
				}
			}
		}
		finally
		{
			if (enumerator2 is IDisposable)
			{
				((IDisposable)enumerator2).Dispose();
			}
		}
		if ((backBufferFormatComboBox.get_SelectedItem() == null) & (backBufferFormatComboBox.get_Items().get_Count() > 0))
		{
			backBufferFormatComboBox.set_SelectedIndex(0);
		}
	}

	private void ResolutionChanged(object sender, EventArgs e)
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		if (settings.IsWindowed)
		{
			return;
		}
		GraphicsAdapterInfo graphicsAdapterInfo = (GraphicsAdapterInfo)adapterComboBox.get_SelectedItem();
		string text = StringType.FromObject(resolutionComboBox.get_SelectedItem());
		string[] array = text.Split();
		int num = int.Parse(array[0]);
		int num2 = int.Parse(array[2]);
		((DisplayMode)(ref settings.FullscreenDisplayMode)).set_Width(num);
		((DisplayMode)(ref settings.FullscreenDisplayMode)).set_Height(num2);
		Format val = (Format)IntegerType.FromObject(adapterFormatComboBox.get_SelectedItem());
		refreshRateComboBox.get_Items().Clear();
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = graphicsAdapterInfo.DisplayModeList.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DisplayMode val2 = (DisplayMode)(enumerator.Current ?? Activator.CreateInstance(typeof(DisplayMode)));
				if (!((((DisplayMode)(ref val2)).get_Format() == val) & (((DisplayMode)(ref val2)).get_Width() == num) & (((DisplayMode)(ref val2)).get_Height() == num2)))
				{
					continue;
				}
				string text2 = FormatRefreshRate(((DisplayMode)(ref val2)).get_RefreshRate());
				if (!refreshRateComboBox.get_Items().Contains((object)text2))
				{
					refreshRateComboBox.get_Items().Add((object)text2);
					if (((DisplayMode)(ref settings.FullscreenDisplayMode)).get_RefreshRate() == ((DisplayMode)(ref val2)).get_RefreshRate())
					{
						refreshRateComboBox.set_SelectedItem((object)text2);
					}
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				((IDisposable)enumerator).Dispose();
			}
		}
		if ((refreshRateComboBox.get_SelectedItem() == null) & (refreshRateComboBox.get_Items().get_Count() > 0))
		{
			refreshRateComboBox.set_SelectedIndex(refreshRateComboBox.get_Items().get_Count() - 1);
		}
	}

	private void RefreshRateChanged(object sender, EventArgs e)
	{
		if (!settings.IsWindowed)
		{
			string text = StringType.FromObject(refreshRateComboBox.get_SelectedItem());
			int refreshRate = 0;
			if (StringType.StrCmp(text, "Default Rate", false) != 0)
			{
				string[] array = text.Split();
				refreshRate = int.Parse(array[0]);
			}
			((DisplayMode)(ref settings.FullscreenDisplayMode)).set_RefreshRate(refreshRate);
		}
	}

	private void BackBufferFormatChanged(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		GraphicsDeviceInfo graphicsDeviceInfo = (GraphicsDeviceInfo)deviceComboBox.get_SelectedItem();
		Format val = (Format)IntegerType.FromObject(adapterFormatComboBox.get_SelectedItem());
		Format val2 = (Format)IntegerType.FromObject(backBufferFormatComboBox.get_SelectedItem());
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = graphicsDeviceInfo.DeviceComboList.GetEnumerator();
			DeviceCombo deviceCombo;
			do
			{
				if (enumerator.MoveNext())
				{
					deviceCombo = (DeviceCombo)enumerator.Current;
					continue;
				}
				return;
			}
			while (!((deviceCombo.IsWindowed == settings.IsWindowed) & (deviceCombo.AdapterFormat == val) & (deviceCombo.BackBufferFormat == val2)));
			deviceCombo.BackBufferFormat = val2;
			settings.DeviceCombo = deviceCombo;
			depthStencilBufferComboBox.get_Items().Clear();
			if (enumeration.AppUsesDepthBuffer)
			{
				IEnumerator enumerator2 = default(IEnumerator);
				try
				{
					enumerator2 = deviceCombo.DepthStencilFormatList.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						DepthFormat val3 = (DepthFormat)IntegerType.FromObject(enumerator2.Current);
						depthStencilBufferComboBox.get_Items().Add((object)val3);
						if (val3 == settings.DepthStencilBufferFormat)
						{
							depthStencilBufferComboBox.set_SelectedItem((object)val3);
						}
					}
				}
				finally
				{
					if (enumerator2 is IDisposable)
					{
						((IDisposable)enumerator2).Dispose();
					}
				}
				if ((depthStencilBufferComboBox.get_SelectedItem() == null) & (depthStencilBufferComboBox.get_Items().get_Count() > 0))
				{
					depthStencilBufferComboBox.set_SelectedIndex(0);
				}
			}
			else
			{
				((Control)depthStencilBufferComboBox).set_Enabled(false);
				depthStencilBufferComboBox.get_Items().Add((object)"(not used)");
				depthStencilBufferComboBox.set_SelectedIndex(0);
			}
			vertexProcComboBox.get_Items().Clear();
			IEnumerator enumerator3 = default(IEnumerator);
			try
			{
				enumerator3 = deviceCombo.VertexProcessingTypeList.GetEnumerator();
				while (enumerator3.MoveNext())
				{
					VertexProcessingType vertexProcessingType = (VertexProcessingType)IntegerType.FromObject(enumerator3.Current);
					vertexProcComboBox.get_Items().Add((object)vertexProcessingType);
					if (vertexProcessingType == settings.VertexProcessingType)
					{
						vertexProcComboBox.set_SelectedItem((object)vertexProcessingType);
					}
				}
			}
			finally
			{
				if (enumerator3 is IDisposable)
				{
					((IDisposable)enumerator3).Dispose();
				}
			}
			if ((vertexProcComboBox.get_SelectedItem() == null) & (vertexProcComboBox.get_Items().get_Count() > 0))
			{
				vertexProcComboBox.set_SelectedIndex(0);
			}
			presentIntervalComboBox.get_Items().Clear();
			IEnumerator enumerator4 = default(IEnumerator);
			try
			{
				enumerator4 = deviceCombo.PresentIntervalList.GetEnumerator();
				while (enumerator4.MoveNext())
				{
					PresentInterval val4 = (PresentInterval)IntegerType.FromObject(enumerator4.Current);
					presentIntervalComboBox.get_Items().Add((object)val4);
					if (val4 == settings.PresentInterval)
					{
						presentIntervalComboBox.set_SelectedItem((object)val4);
					}
				}
			}
			finally
			{
				if (enumerator4 is IDisposable)
				{
					((IDisposable)enumerator4).Dispose();
				}
			}
			if ((presentIntervalComboBox.get_SelectedItem() == null) & (presentIntervalComboBox.get_Items().get_Count() > 0))
			{
				presentIntervalComboBox.set_SelectedIndex(0);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				((IDisposable)enumerator).Dispose();
			}
		}
	}

	private void DepthStencilBufferFormatChanged(object sender, EventArgs e)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		if (enumeration.AppUsesDepthBuffer)
		{
			settings.DepthStencilBufferFormat = (DepthFormat)IntegerType.FromObject(depthStencilBufferComboBox.get_SelectedItem());
		}
		multisampleComboBox.get_Items().Clear();
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = settings.DeviceCombo.MultiSampleTypeList.GetEnumerator();
			IEnumerator enumerator2 = default(IEnumerator);
			while (enumerator.MoveNext())
			{
				MultiSampleType val = (MultiSampleType)IntegerType.FromObject(enumerator.Current);
				bool flag = false;
				try
				{
					enumerator2 = settings.DeviceCombo.DepthStencilMultiSampleConflictList.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						DepthStencilMultiSampleConflict depthStencilMultiSampleConflict = (DepthStencilMultiSampleConflict)enumerator2.Current;
						if ((depthStencilMultiSampleConflict.DepthStencilFormat == settings.DepthStencilBufferFormat) & (depthStencilMultiSampleConflict.MultiSampleType == val))
						{
							flag = true;
							break;
						}
					}
				}
				finally
				{
					if (enumerator2 is IDisposable)
					{
						((IDisposable)enumerator2).Dispose();
					}
				}
				if (!flag)
				{
					multisampleComboBox.get_Items().Add((object)val);
					if (val == settings.MultisampleType)
					{
						multisampleComboBox.set_SelectedItem((object)val);
					}
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				((IDisposable)enumerator).Dispose();
			}
		}
		if ((multisampleComboBox.get_SelectedItem() == null) & (multisampleComboBox.get_Items().get_Count() > 0))
		{
			multisampleComboBox.set_SelectedIndex(0);
		}
	}

	private void MultisampleTypeChanged(object sender, EventArgs e)
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Invalid comparison between I4 and Unknown
		settings.MultisampleType = (MultiSampleType)IntegerType.FromObject(multisampleComboBox.get_SelectedItem());
		int num = 0;
		DeviceCombo deviceCombo = settings.DeviceCombo;
		int num2 = deviceCombo.MultiSampleQualityList.Count - 1;
		for (int i = 0; i <= num2; i++)
		{
			if (IntegerType.FromObject(deviceCombo.MultiSampleTypeList[i]) == (int)settings.MultisampleType)
			{
				num = IntegerType.FromObject(deviceCombo.MultiSampleQualityList[i]);
				break;
			}
		}
		multisampleQualityComboBox.get_Items().Clear();
		int num3 = num - 1;
		for (int j = 0; j <= num3; j++)
		{
			multisampleQualityComboBox.get_Items().Add((object)j);
			if (settings.MultisampleQuality == j)
			{
				multisampleQualityComboBox.set_SelectedItem((object)j);
			}
		}
		if ((multisampleQualityComboBox.get_SelectedItem() == null) & (multisampleQualityComboBox.get_Items().get_Count() > 0))
		{
			multisampleQualityComboBox.set_SelectedIndex(0);
		}
	}

	private void MultisampleQualityChanged(object sender, EventArgs e)
	{
		settings.MultisampleQuality = IntegerType.FromObject(multisampleQualityComboBox.get_SelectedItem());
	}

	private void VertexProcessingChanged(object sender, EventArgs e)
	{
		settings.VertexProcessingType = (VertexProcessingType)IntegerType.FromObject(vertexProcComboBox.get_SelectedItem());
	}

	private void PresentIntervalChanged(object sender, EventArgs e)
	{
		settings.PresentInterval = (PresentInterval)IntegerType.FromObject(presentIntervalComboBox.get_SelectedItem());
	}
}
