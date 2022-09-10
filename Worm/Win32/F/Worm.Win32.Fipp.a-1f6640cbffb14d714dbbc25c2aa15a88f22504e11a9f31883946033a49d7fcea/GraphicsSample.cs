using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.DirectX.Direct3D;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

public class GraphicsSample : Form
{
	[AccessedThroughProperty("mnuExit")]
	private MenuItem _mnuExit;

	[AccessedThroughProperty("mnuChange")]
	private MenuItem _mnuChange;

	[AccessedThroughProperty("mnuSingle")]
	private MenuItem _mnuSingle;

	[AccessedThroughProperty("mnuGo")]
	private MenuItem _mnuGo;

	protected MainMenu mnuMain;

	protected MenuItem mnuFile;

	private MenuItem mnuBreak1;

	private MenuItem mnuBreak2;

	private Control ourRenderTarget;

	protected bool isUsingMenus;

	protected D3DEnumeration enumerationSettings;

	protected D3DSettings graphicsSettings;

	private bool isMaximized;

	private bool isHandlingSizeChanges;

	private bool isClosing;

	private bool isChangingFormStyle;

	private bool isWindowActive;

	private float lastTime;

	private int frames;

	private int appPausedCount;

	protected bool windowed;

	protected bool active;

	protected bool ready;

	protected bool hasFocus;

	protected bool isMultiThreaded;

	protected bool frameMoving;

	protected bool isSingleStep;

	protected PresentParameters presentParams;

	protected Device device;

	protected RenderStates renderState;

	protected SamplerStates sampleState;

	protected TextureStates textureStates;

	private Caps graphicsCaps;

	private CreateFlags behavior;

	protected float appTime;

	protected float elapsedTime;

	protected float framePerSecond;

	protected string deviceStats;

	protected string frameStats;

	private bool deviceLost;

	protected bool constantFrameTime;

	private int MinimumDepthBits;

	private int minimumStencilBits;

	protected bool showCursorWhenFullscreen;

	protected bool clipCursorWhenFullscreen;

	protected bool startFullscreen;

	private Size storedSize;

	private Point storedLocation;

	protected Caps Caps => graphicsCaps;

	protected Control RenderTarget
	{
		get
		{
			return ourRenderTarget;
		}
		set
		{
			ourRenderTarget = value;
		}
	}

	protected BehaviorFlags BehaviorFlags
	{
		get
		{
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			BehaviorFlags result = default(BehaviorFlags);
			((BehaviorFlags)(ref result))._002Ector(behavior);
			return result;
		}
	}

	private virtual MenuItem mnuGo
	{
		get
		{
			return _mnuGo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_mnuGo != null)
			{
				_mnuGo.remove_Click((EventHandler)ToggleStart);
			}
			_mnuGo = value;
			if (_mnuGo != null)
			{
				_mnuGo.add_Click((EventHandler)ToggleStart);
			}
		}
	}

	private virtual MenuItem mnuSingle
	{
		get
		{
			return _mnuSingle;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_mnuSingle != null)
			{
				_mnuSingle.remove_Click((EventHandler)SingleStep);
			}
			_mnuSingle = value;
			if (_mnuSingle != null)
			{
				_mnuSingle.add_Click((EventHandler)SingleStep);
			}
		}
	}

	protected int MinDepthBits
	{
		get
		{
			return MinimumDepthBits;
		}
		set
		{
			MinimumDepthBits = value;
			enumerationSettings.AppMinDepthBits = value;
		}
	}

	private virtual MenuItem mnuChange
	{
		get
		{
			return _mnuChange;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_mnuChange != null)
			{
				_mnuChange.remove_Click((EventHandler)UserSelectNewDevice);
			}
			_mnuChange = value;
			if (_mnuChange != null)
			{
				_mnuChange.add_Click((EventHandler)UserSelectNewDevice);
			}
		}
	}

	protected virtual MenuItem mnuExit
	{
		get
		{
			return _mnuExit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_mnuExit != null)
			{
				_mnuExit.remove_Click((EventHandler)ExitSample);
			}
			_mnuExit = value;
			if (_mnuExit != null)
			{
				_mnuExit.add_Click((EventHandler)ExitSample);
			}
		}
	}

	protected int MinStencilBits
	{
		get
		{
			return minimumStencilBits;
		}
		set
		{
			minimumStencilBits = value;
			enumerationSettings.AppMinStencilBits = value;
		}
	}

	protected virtual bool ConfirmDevice(Caps caps, VertexProcessingType vertexProcessingType, Format adapterFormat, Format backBufferFormat)
	{
		return true;
	}

	protected virtual void OneTimeSceneInitialization()
	{
	}

	protected virtual void InitializeDeviceObjects()
	{
	}

	protected virtual void RestoreDeviceObjects(object sender, EventArgs e)
	{
	}

	protected virtual void FrameMove()
	{
	}

	protected virtual void Render()
	{
	}

	protected virtual void InvalidateDeviceObjects(object sender, EventArgs e)
	{
	}

	protected virtual void DeleteDeviceObjects(object sender, EventArgs e)
	{
	}

	public GraphicsSample()
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		isUsingMenus = true;
		enumerationSettings = new D3DEnumeration();
		graphicsSettings = new D3DSettings();
		isMaximized = false;
		isHandlingSizeChanges = true;
		isClosing = false;
		isChangingFormStyle = false;
		isWindowActive = true;
		lastTime = 0f;
		frames = 0;
		appPausedCount = 0;
		isMultiThreaded = false;
		presentParams = new PresentParameters();
		deviceLost = false;
		device = null;
		active = false;
		ready = false;
		hasFocus = false;
		behavior = (CreateFlags)0;
		ourRenderTarget = (Control)(object)this;
		frameMoving = true;
		isSingleStep = false;
		framePerSecond = 0f;
		deviceStats = null;
		frameStats = null;
		((Control)this).set_Text("D3D9 Sample");
		Size clientSize = new Size(400, 300);
		((Form)this).set_ClientSize(clientSize);
		((Form)this).set_KeyPreview(true);
		constantFrameTime = false;
		MinDepthBits = 16;
		MinStencilBits = 0;
		showCursorWhenFullscreen = false;
		startFullscreen = false;
		clipCursorWhenFullscreen = true;
		InitializeComponent();
	}

	public bool CreateGraphicsSample()
	{
		enumerationSettings.ConfirmDeviceCallback = ConfirmDevice;
		enumerationSettings.Enumerate();
		if (ourRenderTarget.get_Cursor() == null)
		{
			ourRenderTarget.set_Cursor(Cursors.get_Default());
		}
		if ((ourRenderTarget == this) & isUsingMenus)
		{
			((Form)this).set_Menu(mnuMain);
		}
		try
		{
			ChooseInitialSettings();
			DXUtil.Timer(DirectXTimer.Start);
			OneTimeSceneInitialization();
			InitializeEnvironment();
		}
		catch (SampleException ex)
		{
			ProjectData.SetProjectError((Exception)ex);
			SampleException e = ex;
			HandleSampleException(e, ApplicationMessage.ApplicationMustExit);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			HandleSampleException(new SampleException(), ApplicationMessage.ApplicationMustExit);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
		ready = true;
		return true;
	}

	public bool FindBestWindowedMode(bool doesRequireHardware, bool doesRequireReference)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Invalid comparison between Unknown and I4
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Invalid comparison between Unknown and I4
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Invalid comparison between Unknown and I4
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Invalid comparison between Unknown and I4
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Invalid comparison between Unknown and I4
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Invalid comparison between Unknown and I4
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Invalid comparison between Unknown and I4
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		DisplayMode currentDisplayMode = Manager.get_Adapters().get_Item(0).get_CurrentDisplayMode();
		GraphicsAdapterInfo windowedAdapterInfo = null;
		GraphicsDeviceInfo windowedDeviceInfo = null;
		DeviceCombo deviceCombo = null;
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = enumerationSettings.AdapterInfoList.GetEnumerator();
			IEnumerator enumerator2 = default(IEnumerator);
			IEnumerator enumerator3 = default(IEnumerator);
			while (enumerator.MoveNext())
			{
				GraphicsAdapterInfo graphicsAdapterInfo = (GraphicsAdapterInfo)enumerator.Current;
				try
				{
					enumerator2 = graphicsAdapterInfo.DeviceInfoList.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						GraphicsDeviceInfo graphicsDeviceInfo = (GraphicsDeviceInfo)enumerator2.Current;
						if ((doesRequireHardware & ((int)graphicsDeviceInfo.DevType != 1)) || (doesRequireReference & ((int)graphicsDeviceInfo.DevType != 2)))
						{
							continue;
						}
						try
						{
							enumerator3 = graphicsDeviceInfo.DeviceComboList.GetEnumerator();
							while (enumerator3.MoveNext())
							{
								DeviceCombo deviceCombo2 = (DeviceCombo)enumerator3.Current;
								bool flag = deviceCombo2.BackBufferFormat == deviceCombo2.AdapterFormat;
								if (!deviceCombo2.IsWindowed || deviceCombo2.AdapterFormat != ((DisplayMode)(ref currentDisplayMode)).get_Format())
								{
									continue;
								}
								if (deviceCombo == null)
								{
									windowedAdapterInfo = graphicsAdapterInfo;
									windowedDeviceInfo = graphicsDeviceInfo;
									deviceCombo = deviceCombo2;
									if ((int)graphicsDeviceInfo.DevType == 1 && flag)
									{
										goto end_IL_0176;
									}
								}
								else if ((((int)deviceCombo.DevType != 1) & ((int)graphicsDeviceInfo.DevType == 1)) | ((int)deviceCombo2.DevType == 1 && flag))
								{
									windowedAdapterInfo = graphicsAdapterInfo;
									windowedDeviceInfo = graphicsDeviceInfo;
									deviceCombo = deviceCombo2;
									if ((int)graphicsDeviceInfo.DevType == 1 && flag)
									{
										goto end_IL_0176;
									}
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
					}
				}
				finally
				{
					if (enumerator2 is IDisposable)
					{
						((IDisposable)enumerator2).Dispose();
					}
				}
				continue;
				end_IL_0176:
				break;
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				((IDisposable)enumerator).Dispose();
			}
		}
		if (deviceCombo == null)
		{
			return false;
		}
		graphicsSettings.WindowedAdapterInfo = windowedAdapterInfo;
		graphicsSettings.WindowedDeviceInfo = windowedDeviceInfo;
		graphicsSettings.WindowedDeviceCombo = deviceCombo;
		graphicsSettings.IsWindowed = true;
		graphicsSettings.WindowedDisplayMode = currentDisplayMode;
		graphicsSettings.WindowedWidth = ourRenderTarget.get_ClientRectangle().Right - ourRenderTarget.get_ClientRectangle().Left;
		graphicsSettings.WindowedHeight = ourRenderTarget.get_ClientRectangle().Bottom - ourRenderTarget.get_ClientRectangle().Top;
		if (enumerationSettings.AppUsesDepthBuffer)
		{
			graphicsSettings.WindowedDepthStencilBufferFormat = (DepthFormat)IntegerType.FromObject(deviceCombo.DepthStencilFormatList[0]);
		}
		graphicsSettings.WindowedMultisampleType = (MultiSampleType)IntegerType.FromObject(deviceCombo.MultiSampleTypeList[0]);
		graphicsSettings.WindowedMultisampleQuality = 0;
		graphicsSettings.WindowedVertexProcessingType = (VertexProcessingType)IntegerType.FromObject(deviceCombo.VertexProcessingTypeList[0]);
		graphicsSettings.WindowedPresentInterval = (PresentInterval)IntegerType.FromObject(deviceCombo.PresentIntervalList[0]);
		return true;
	}

	public bool FindBestFullscreenMode(bool doesRequireHardware, bool doesRequireReference)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Invalid comparison between Unknown and I4
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Invalid comparison between Unknown and I4
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Invalid comparison between Unknown and I4
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Invalid comparison between Unknown and I4
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Invalid comparison between Unknown and I4
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Invalid comparison between Unknown and I4
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Invalid comparison between Unknown and I4
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Invalid comparison between Unknown and I4
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		DisplayMode val = default(DisplayMode);
		DisplayMode val2 = default(DisplayMode);
		DisplayMode fullscreenDisplayMode = default(DisplayMode);
		((DisplayMode)(ref val2)).set_Width(0);
		((DisplayMode)(ref val2)).set_Height(0);
		((DisplayMode)(ref val2)).set_Format((Format)0);
		((DisplayMode)(ref val2)).set_RefreshRate(0);
		GraphicsAdapterInfo graphicsAdapterInfo = null;
		GraphicsDeviceInfo fullscreenDeviceInfo = null;
		DeviceCombo deviceCombo = null;
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = enumerationSettings.AdapterInfoList.GetEnumerator();
			IEnumerator enumerator2 = default(IEnumerator);
			IEnumerator enumerator3 = default(IEnumerator);
			while (enumerator.MoveNext())
			{
				GraphicsAdapterInfo graphicsAdapterInfo2 = (GraphicsAdapterInfo)enumerator.Current;
				val = Manager.get_Adapters().get_Item(graphicsAdapterInfo2.AdapterOrdinal).get_CurrentDisplayMode();
				try
				{
					enumerator2 = graphicsAdapterInfo2.DeviceInfoList.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						GraphicsDeviceInfo graphicsDeviceInfo = (GraphicsDeviceInfo)enumerator2.Current;
						if ((doesRequireHardware & ((int)graphicsDeviceInfo.DevType != 1)) || (doesRequireReference & ((int)graphicsDeviceInfo.DevType != 2)))
						{
							continue;
						}
						try
						{
							enumerator3 = graphicsDeviceInfo.DeviceComboList.GetEnumerator();
							while (enumerator3.MoveNext())
							{
								DeviceCombo deviceCombo2 = (DeviceCombo)enumerator3.Current;
								bool flag = deviceCombo2.BackBufferFormat == deviceCombo2.AdapterFormat;
								bool flag2 = deviceCombo2.AdapterFormat == ((DisplayMode)(ref val)).get_Format();
								if (deviceCombo2.IsWindowed)
								{
									continue;
								}
								if (deviceCombo == null)
								{
									val2 = val;
									graphicsAdapterInfo = graphicsAdapterInfo2;
									fullscreenDeviceInfo = graphicsDeviceInfo;
									deviceCombo = deviceCombo2;
									if ((int)graphicsDeviceInfo.DevType == 1 && flag2 && flag)
									{
										goto end_IL_01ee;
									}
								}
								else if ((((int)deviceCombo.DevType != 1) & ((int)graphicsDeviceInfo.DevType == 1)) | ((((int)deviceCombo.DevType == 1) & (deviceCombo.AdapterFormat != ((DisplayMode)(ref val)).get_Format())) && flag2) | ((int)deviceCombo.DevType == 1 && flag2 && flag))
								{
									val2 = val;
									graphicsAdapterInfo = graphicsAdapterInfo2;
									fullscreenDeviceInfo = graphicsDeviceInfo;
									deviceCombo = deviceCombo2;
									if ((int)graphicsDeviceInfo.DevType == 1 && flag2 && flag)
									{
										goto end_IL_01ee;
									}
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
					}
				}
				finally
				{
					if (enumerator2 is IDisposable)
					{
						((IDisposable)enumerator2).Dispose();
					}
				}
				continue;
				end_IL_01ee:
				break;
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				((IDisposable)enumerator).Dispose();
			}
		}
		if (deviceCombo == null)
		{
			return false;
		}
		((DisplayMode)(ref fullscreenDisplayMode)).set_Width(0);
		((DisplayMode)(ref fullscreenDisplayMode)).set_Height(0);
		((DisplayMode)(ref fullscreenDisplayMode)).set_Format((Format)0);
		((DisplayMode)(ref fullscreenDisplayMode)).set_RefreshRate(0);
		IEnumerator enumerator4 = default(IEnumerator);
		try
		{
			enumerator4 = graphicsAdapterInfo.DisplayModeList.GetEnumerator();
			while (enumerator4.MoveNext())
			{
				DisplayMode val3 = (DisplayMode)(enumerator4.Current ?? Activator.CreateInstance(typeof(DisplayMode)));
				if (((DisplayMode)(ref val3)).get_Format() == deviceCombo.AdapterFormat)
				{
					if ((((DisplayMode)(ref val3)).get_Width() == ((DisplayMode)(ref val2)).get_Width()) & (((DisplayMode)(ref val3)).get_Height() == ((DisplayMode)(ref val2)).get_Height()) & (((DisplayMode)(ref val3)).get_RefreshRate() == ((DisplayMode)(ref val2)).get_RefreshRate()))
					{
						fullscreenDisplayMode = val3;
						break;
					}
					if ((((DisplayMode)(ref val3)).get_Width() == ((DisplayMode)(ref val2)).get_Width()) & (((DisplayMode)(ref val3)).get_Height() == ((DisplayMode)(ref val2)).get_Height()) & (((DisplayMode)(ref val3)).get_RefreshRate() > ((DisplayMode)(ref fullscreenDisplayMode)).get_RefreshRate()))
					{
						fullscreenDisplayMode = val3;
					}
					else if (((DisplayMode)(ref fullscreenDisplayMode)).get_Width() == ((DisplayMode)(ref val2)).get_Width())
					{
						fullscreenDisplayMode = val3;
					}
					else if (((DisplayMode)(ref fullscreenDisplayMode)).get_Width() == 0)
					{
						fullscreenDisplayMode = val3;
					}
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
		graphicsSettings.FullscreenAdapterInfo = graphicsAdapterInfo;
		graphicsSettings.FullscreenDeviceInfo = fullscreenDeviceInfo;
		graphicsSettings.FullscreenDeviceCombo = deviceCombo;
		graphicsSettings.IsWindowed = false;
		graphicsSettings.FullscreenDisplayMode = fullscreenDisplayMode;
		if (enumerationSettings.AppUsesDepthBuffer)
		{
			graphicsSettings.FullscreenDepthStencilBufferFormat = (DepthFormat)IntegerType.FromObject(deviceCombo.DepthStencilFormatList[0]);
		}
		graphicsSettings.FullscreenMultisampleType = (MultiSampleType)IntegerType.FromObject(deviceCombo.MultiSampleTypeList[0]);
		graphicsSettings.FullscreenMultisampleQuality = 0;
		graphicsSettings.FullscreenVertexProcessingType = (VertexProcessingType)IntegerType.FromObject(deviceCombo.VertexProcessingTypeList[0]);
		graphicsSettings.FullscreenPresentInterval = (PresentInterval)0;
		return true;
	}

	public bool ChooseInitialSettings()
	{
		bool flag = FindBestFullscreenMode(doesRequireHardware: false, doesRequireReference: false);
		bool flag2 = FindBestWindowedMode(doesRequireHardware: false, doesRequireReference: false);
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		string[] array = commandLineArgs;
		IEnumerator enumerator = default(IEnumerator);
		IEnumerator enumerator2 = default(IEnumerator);
		foreach (string text in array)
		{
			if (StringType.StrCmp(text, "-constantframetime", false) == 0)
			{
				constantFrameTime = true;
			}
			if (StringType.StrCmp(text, "-fullscreen", false) == 0)
			{
				startFullscreen = true;
			}
			if (StringType.StrCmp(text, "-ref", false) == 0)
			{
				flag = FindBestFullscreenMode(doesRequireHardware: false, doesRequireReference: true);
				flag2 = FindBestWindowedMode(doesRequireHardware: false, doesRequireReference: true);
			}
			if (StringType.StrCmp(text, "-hal", false) == 0)
			{
				flag = FindBestFullscreenMode(doesRequireHardware: true, doesRequireReference: false);
				flag2 = FindBestWindowedMode(doesRequireHardware: true, doesRequireReference: false);
			}
			if (StringType.StrCmp(text, "-nopurehwvp", false) == 0)
			{
				try
				{
					enumerator = graphicsSettings.DeviceCombo.VertexProcessingTypeList.GetEnumerator();
					while (enumerator.MoveNext())
					{
						VertexProcessingType vertexProcessingType = (VertexProcessingType)IntegerType.FromObject(enumerator.Current);
						if (vertexProcessingType != VertexProcessingType.PureHardware)
						{
							graphicsSettings.VertexProcessingType = vertexProcessingType;
							break;
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
			}
			if (StringType.StrCmp(text, "-nohwvp", false) != 0)
			{
				continue;
			}
			try
			{
				enumerator2 = graphicsSettings.DeviceCombo.VertexProcessingTypeList.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					VertexProcessingType vertexProcessingType2 = (VertexProcessingType)IntegerType.FromObject(enumerator2.Current);
					if (vertexProcessingType2 == VertexProcessingType.Software)
					{
						graphicsSettings.VertexProcessingType = vertexProcessingType2;
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
		}
		if (startFullscreen && flag)
		{
			graphicsSettings.IsWindowed = false;
		}
		if (!flag && !flag2)
		{
			throw new NoCompatibleDevicesException();
		}
		return flag || flag2;
	}

	public void BuildPresentParamsFromSettings()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		presentParams.set_Windowed(graphicsSettings.IsWindowed);
		presentParams.set_BackBufferCount(1);
		presentParams.set_MultiSample(graphicsSettings.MultisampleType);
		presentParams.set_MultiSampleQuality(graphicsSettings.MultisampleQuality);
		presentParams.set_SwapEffect((SwapEffect)1);
		presentParams.set_EnableAutoDepthStencil(enumerationSettings.AppUsesDepthBuffer);
		presentParams.set_AutoDepthStencilFormat(graphicsSettings.DepthStencilBufferFormat);
		presentParams.set_PresentFlag((PresentFlag)0);
		if (windowed)
		{
			presentParams.set_BackBufferWidth(ourRenderTarget.get_ClientRectangle().Right - ourRenderTarget.get_ClientRectangle().Left);
			presentParams.set_BackBufferHeight(ourRenderTarget.get_ClientRectangle().Bottom - ourRenderTarget.get_ClientRectangle().Top);
			presentParams.set_BackBufferFormat(graphicsSettings.DeviceCombo.BackBufferFormat);
			presentParams.set_FullScreenRefreshRateInHz(0);
			presentParams.set_PresentationInterval((PresentInterval)int.MinValue);
			presentParams.set_DeviceWindow(ourRenderTarget);
			return;
		}
		PresentParameters obj = presentParams;
		DisplayMode displayMode = graphicsSettings.DisplayMode;
		obj.set_BackBufferWidth(((DisplayMode)(ref displayMode)).get_Width());
		PresentParameters obj2 = presentParams;
		displayMode = graphicsSettings.DisplayMode;
		obj2.set_BackBufferHeight(((DisplayMode)(ref displayMode)).get_Height());
		presentParams.set_BackBufferFormat(graphicsSettings.DeviceCombo.BackBufferFormat);
		PresentParameters obj3 = presentParams;
		displayMode = graphicsSettings.DisplayMode;
		obj3.set_FullScreenRefreshRateInHz(((DisplayMode)(ref displayMode)).get_RefreshRate());
		presentParams.set_PresentationInterval(graphicsSettings.PresentInterval);
		presentParams.set_DeviceWindow((Control)(object)this);
	}

	public void InitializeEnvironment()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Invalid comparison between Unknown and I4
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Invalid comparison between Unknown and I4
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Invalid comparison between Unknown and I4
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Invalid comparison between Unknown and I4
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Invalid comparison between Unknown and I4
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Invalid comparison between Unknown and I4
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Invalid comparison between Unknown and I4
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f6: Invalid comparison between Unknown and I4
		GraphicsAdapterInfo adapterInfo = graphicsSettings.AdapterInfo;
		GraphicsDeviceInfo deviceInfo = graphicsSettings.DeviceInfo;
		windowed = graphicsSettings.IsWindowed;
		BuildPresentParamsFromSettings();
		MiscCaps primitiveMiscCaps = ((Caps)(ref deviceInfo.Caps)).get_PrimitiveMiscCaps();
		if (((MiscCaps)(ref primitiveMiscCaps)).get_IsNullReference())
		{
			HandleSampleException(new NullReferenceDeviceException(), ApplicationMessage.None);
		}
		CreateFlags val = default(CreateFlags);
		if (graphicsSettings.VertexProcessingType == VertexProcessingType.Software)
		{
			val = (CreateFlags)32;
		}
		else if (graphicsSettings.VertexProcessingType == VertexProcessingType.Mixed)
		{
			val = (CreateFlags)128;
		}
		else if (graphicsSettings.VertexProcessingType == VertexProcessingType.Hardware)
		{
			val = (CreateFlags)64;
		}
		else
		{
			if (graphicsSettings.VertexProcessingType != VertexProcessingType.PureHardware)
			{
				throw new ApplicationException();
			}
			val = (CreateFlags)80;
		}
		if (isMultiThreaded)
		{
			val = (CreateFlags)(val | 4);
		}
		try
		{
			device = new Device(graphicsSettings.AdapterOrdinal, graphicsSettings.DevType, (Control)Interaction.IIf(windowed, (object)ourRenderTarget, (object)this), val, presentParams);
			renderState = device.get_RenderState();
			sampleState = device.get_SamplerState();
			textureStates = device.get_TextureState();
			if (windowed)
			{
				Size clientSize = ((Form)this).get_ClientSize();
				((Form)this).set_Size(((Form)this).get_ClientSize());
				((Control)this).SendToBack();
				((Control)this).BringToFront();
				((Form)this).set_ClientSize(clientSize);
			}
			graphicsCaps = device.get_DeviceCaps();
			behavior = val;
			if ((int)deviceInfo.DevType == 2)
			{
				deviceStats = "REF";
			}
			else if ((int)deviceInfo.DevType == 1)
			{
				deviceStats = "HAL";
			}
			else if ((int)deviceInfo.DevType == 3)
			{
				deviceStats = "SW";
			}
			BehaviorFlags val2 = default(BehaviorFlags);
			((BehaviorFlags)(ref val2))._002Ector(val);
			if (((BehaviorFlags)(ref val2)).get_HardwareVertexProcessing() & ((BehaviorFlags)(ref val2)).get_PureDevice())
			{
				if ((int)deviceInfo.DevType == 1)
				{
					deviceStats += " (pure hw vp)";
				}
				else
				{
					deviceStats += " (simulated pure hw vp)";
				}
			}
			else if (((BehaviorFlags)(ref val2)).get_HardwareVertexProcessing())
			{
				if ((int)deviceInfo.DevType == 1)
				{
					deviceStats += " (hw vp)";
				}
				else
				{
					deviceStats += " (simulated hw vp)";
				}
			}
			else if (((BehaviorFlags)(ref val2)).get_MixedVertexProcessing())
			{
				if ((int)deviceInfo.DevType == 1)
				{
					deviceStats += " (mixed vp)";
				}
				else
				{
					deviceStats += " (simulated mixed vp)";
				}
			}
			else if (((BehaviorFlags)(ref val2)).get_SoftwareVertexProcessing())
			{
				deviceStats += " (sw vp)";
			}
			if ((int)deviceInfo.DevType == 1)
			{
				deviceStats += ": ";
				deviceStats += ((AdapterDetails)(ref adapterInfo.AdapterDetails)).get_Description();
			}
			if (showCursorWhenFullscreen & !windowed)
			{
				Cursor cursor = ((Control)this).get_Cursor();
				device.SetCursor(cursor, true);
				device.ShowCursor(true);
			}
			if (clipCursorWhenFullscreen && !windowed)
			{
				((Control)this).get_ClientRectangle();
			}
			device.add_DeviceLost((EventHandler)InvalidateDeviceObjects);
			device.add_DeviceReset((EventHandler)RestoreDeviceObjects);
			device.add_Disposing((EventHandler)DeleteDeviceObjects);
			device.add_DeviceResizing((CancelEventHandler)EnvironmentResized);
			try
			{
				InitializeDeviceObjects();
				RestoreDeviceObjects(null, null);
				active = true;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				InvalidateDeviceObjects(null, null);
				DeleteDeviceObjects(null, null);
				device.Dispose();
				device = null;
				if (((Control)this).get_Disposing())
				{
					ProjectData.ClearProjectError();
				}
				else
				{
					ProjectData.ClearProjectError();
				}
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			if ((int)deviceInfo.DevType == 1 && FindBestWindowedMode(doesRequireHardware: false, doesRequireReference: true))
			{
				windowed = true;
				Size clientSize2 = ((Form)this).get_ClientSize();
				((Form)this).set_Size(((Form)this).get_ClientSize());
				((Control)this).SendToBack();
				((Control)this).BringToFront();
				((Form)this).set_ClientSize(clientSize2);
				HandleSampleException(null, ApplicationMessage.WarnSwitchToRef);
				InitializeEnvironment();
			}
			ProjectData.ClearProjectError();
		}
	}

	public void HandleSampleException(SampleException e, ApplicationMessage Type)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		string text = string.Empty;
		if (e != null)
		{
			text = e.Message;
		}
		if (ApplicationMessage.ApplicationMustExit == Type)
		{
			text += "\n\nThis sample will now exit.";
			MessageBox.Show(text, ((Control)this).get_Text(), (MessageBoxButtons)0, (MessageBoxIcon)16);
			if (((Control)this).get_IsHandleCreated())
			{
				((Form)this).Close();
			}
			return;
		}
		if (ApplicationMessage.WarnSwitchToRef == Type)
		{
			text = "\n\nSwitching to the reference rasterizer,\n";
		}
		text += "a software device that implements the entire\n";
		text += "Direct3D feature set, but runs very slowly.";
		MessageBox.Show(text, ((Control)this).get_Text(), (MessageBoxButtons)0, (MessageBoxIcon)64);
	}

	public void EnvironmentResized(object sender, CancelEventArgs e)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Invalid comparison between Unknown and I4
		if (isClosing | isChangingFormStyle)
		{
			e.Cancel = true;
			return;
		}
		if ((ourRenderTarget != this) & ((int)((Form)this).get_WindowState() == 1))
		{
			e.Cancel = true;
		}
		if (!isWindowActive)
		{
			e.Cancel = true;
		}
		if (showCursorWhenFullscreen & !windowed)
		{
			Cursor cursor = ((Control)this).get_Cursor();
			device.SetCursor(cursor, true);
			device.ShowCursor(true);
		}
		if (!frameMoving)
		{
			isSingleStep = true;
			DXUtil.Timer(DirectXTimer.Start);
			DXUtil.Timer(DirectXTimer.Stop);
		}
	}

	public void ToggleFullscreen()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		int adapterOrdinal = graphicsSettings.AdapterOrdinal;
		DeviceType devType = graphicsSettings.DevType;
		isHandlingSizeChanges = false;
		ready = false;
		windowed = !windowed;
		if (!windowed & isMaximized)
		{
			((Form)this).set_WindowState((FormWindowState)0);
		}
		graphicsSettings.IsWindowed = windowed;
		if ((graphicsSettings.AdapterOrdinal == adapterOrdinal) & (graphicsSettings.DevType == devType))
		{
			try
			{
				BuildPresentParamsFromSettings();
				device.Reset(presentParams);
				EnvironmentResized(device, new CancelEventArgs());
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (!windowed)
				{
					throw new Exception();
				}
				ForceWindowed();
				ProjectData.ClearProjectError();
			}
		}
		else
		{
			device.Dispose();
			device = null;
			InitializeEnvironment();
		}
		if (windowed)
		{
			isChangingFormStyle = true;
			if ((ourRenderTarget == this) & isUsingMenus)
			{
				((Form)this).set_Menu(mnuMain);
			}
			((Form)this).set_FormBorderStyle((FormBorderStyle)4);
			isChangingFormStyle = false;
			if (isMaximized)
			{
				((Form)this).set_WindowState((FormWindowState)2);
			}
			((Control)this).SendToBack();
			((Control)this).BringToFront();
			((Form)this).set_ClientSize(storedSize);
			((Control)this).set_Location(storedLocation);
		}
		else
		{
			isChangingFormStyle = true;
			if (((Form)this).get_Menu() != null)
			{
				((Form)this).set_Menu((MainMenu)null);
			}
			((Form)this).set_FormBorderStyle((FormBorderStyle)0);
			isChangingFormStyle = false;
		}
		isHandlingSizeChanges = true;
		ready = true;
	}

	public void ForceWindowed()
	{
		if (!windowed && FindBestWindowedMode(doesRequireHardware: false, doesRequireReference: false))
		{
			windowed = true;
			ready = false;
			device.Dispose();
			device = null;
			try
			{
				InitializeEnvironment();
			}
			catch (SampleException ex)
			{
				ProjectData.SetProjectError((Exception)ex);
				SampleException e = ex;
				HandleSampleException(e, ApplicationMessage.ApplicationMustExit);
				ProjectData.ClearProjectError();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				HandleSampleException(new SampleException(), ApplicationMessage.ApplicationMustExit);
				ProjectData.ClearProjectError();
			}
			ready = true;
		}
	}

	private void FullRender()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		if (!(active & ready))
		{
			return;
		}
		try
		{
			if (deviceLost | (Form.get_ActiveForm() != this))
			{
				Thread.Sleep(100);
			}
			if (active)
			{
				Render3DEnvironment();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show("An exception has occurred.  This sample must exit.\r\n\r\n" + ex2.ToString(), "Exception", (MessageBoxButtons)0, (MessageBoxIcon)64);
			((Form)this).Close();
			ProjectData.ClearProjectError();
		}
	}

	public void Run()
	{
		Control val = (Control)(object)this;
		if ((ourRenderTarget != this) & ((object)((object)ourRenderTarget).GetType() == typeof(Form)))
		{
			val = ourRenderTarget;
		}
		val.Show();
		while (val.get_Created())
		{
			FullRender();
			Application.DoEvents();
		}
	}

	public void Render3DEnvironment()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Expected O, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_0046: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected O, but got Unknown
		//IL_0163: Expected O, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		if (deviceLost)
		{
			try
			{
				device.TestCooperativeLevel();
			}
			catch (DeviceLostException val)
			{
				ProjectData.SetProjectError((Exception)val);
				_ = val;
				isHandlingSizeChanges = false;
				isWindowActive = false;
				ProjectData.ClearProjectError();
				return;
			}
			catch (DeviceNotResetException val2)
			{
				ProjectData.SetProjectError((Exception)val2);
				_ = val2;
				if (windowed)
				{
					GraphicsAdapterInfo adapterInfo = graphicsSettings.AdapterInfo;
					graphicsSettings.WindowedDisplayMode = Manager.get_Adapters().get_Item(adapterInfo.AdapterOrdinal).get_CurrentDisplayMode();
					presentParams.set_BackBufferFormat(((DisplayMode)(ref graphicsSettings.WindowedDisplayMode)).get_Format());
				}
				device.Reset(device.get_PresentationParameters());
				EnvironmentResized(device, new CancelEventArgs());
				ProjectData.ClearProjectError();
			}
			deviceLost = false;
		}
		float num = DXUtil.Timer(DirectXTimer.GetApplicationTime);
		float num2 = DXUtil.Timer(DirectXTimer.GetElapsedTime);
		if ((0f == num2) & frameMoving)
		{
			return;
		}
		if (frameMoving | isSingleStep)
		{
			if (constantFrameTime)
			{
				elapsedTime = 0.05f;
				appTime += elapsedTime;
			}
			else
			{
				appTime = num;
				elapsedTime = num2;
			}
			FrameMove();
			isSingleStep = false;
		}
		Render();
		UpdateStats();
		try
		{
			device.Present();
		}
		catch (DeviceLostException val3)
		{
			ProjectData.SetProjectError((Exception)val3);
			_ = val3;
			deviceLost = true;
			ProjectData.ClearProjectError();
		}
	}

	public void UpdateStats()
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected I4, but got Unknown
		float num = DXUtil.Timer(DirectXTimer.GetAbsoluteTime);
		frames++;
		if (num - lastTime > 1f)
		{
			framePerSecond = (float)frames / (num - lastTime);
			lastTime = num;
			frames = 0;
			DisplayMode displayMode = graphicsSettings.DisplayMode;
			Format format = ((DisplayMode)(ref displayMode)).get_Format();
			string text = ((format != device.get_PresentationParameters().get_BackBufferFormat()) ? $"backbuf {((Enum)device.get_PresentationParameters().get_BackBufferFormat()).ToString()}, adapter {((Enum)format).ToString()}" : ((Enum)format).ToString());
			string text2 = ((!enumerationSettings.AppUsesDepthBuffer) ? "" : $" ({((Enum)graphicsSettings.DepthStencilBufferFormat).ToString()})");
			string text3 = (graphicsSettings.MultisampleType - 1) switch
			{
				0 => " (NonMaskable Multisample)", 
				1 => " (2x Multisample)", 
				2 => " (3x Multisample)", 
				3 => " (4x Multisample)", 
				4 => " (5x Multisample)", 
				5 => " (6x Multisample)", 
				6 => " (7x Multisample)", 
				7 => " (8x Multisample)", 
				8 => " (9x Multisample)", 
				9 => " (10x Multisample)", 
				10 => " (11x Multisample)", 
				11 => " (12x Multisample)", 
				12 => " (13x Multisample)", 
				13 => " (14x Multisample)", 
				14 => " (15x Multisample)", 
				15 => " (16x Multisample)", 
				_ => string.Empty, 
			};
			frameStats = string.Format("{0} fps ({1}x{2}), {3}{4}{5}", framePerSecond.ToString("f2"), device.get_PresentationParameters().get_BackBufferWidth(), device.get_PresentationParameters().get_BackBufferHeight(), text, text2, text3);
		}
	}

	public void PauseSample(bool pause)
	{
		appPausedCount += IntegerType.FromObject(Interaction.IIf(pause, (object)1, (object)(-1)));
		ready = BooleanType.FromObject(Interaction.IIf(appPausedCount > 0, (object)false, (object)true));
		if ((pause & (1 == appPausedCount)) && frameMoving)
		{
			DXUtil.Timer(DirectXTimer.Stop);
		}
		if (0 == appPausedCount && frameMoving)
		{
			DXUtil.Timer(DirectXTimer.Start);
		}
	}

	public void CleanupEnvironment()
	{
		active = false;
		ready = false;
		if (device != null)
		{
			device.Dispose();
		}
		device = null;
	}

	public void UserSelectNewDevice(object sender, EventArgs e)
	{
		if (active & ready)
		{
			PauseSample(pause: true);
			DoSelectNewDevice();
			PauseSample(pause: false);
		}
	}

	private void DoSelectNewDevice()
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Invalid comparison between Unknown and I4
		isHandlingSizeChanges = false;
		if (!windowed)
		{
			try
			{
				ToggleFullscreen();
				isHandlingSizeChanges = false;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				HandleSampleException(new ResetFailedException(), ApplicationMessage.ApplicationMustExit);
				ProjectData.ClearProjectError();
				return;
			}
		}
		((Control)this).SendToBack();
		D3DSettingsForm d3DSettingsForm = new D3DSettingsForm(enumerationSettings, graphicsSettings);
		DialogResult val = ((Form)d3DSettingsForm).ShowDialog((IWin32Window)null);
		if ((int)val != 1)
		{
			isHandlingSizeChanges = true;
			return;
		}
		graphicsSettings = d3DSettingsForm.settings;
		windowed = graphicsSettings.IsWindowed;
		device.Dispose();
		device = null;
		try
		{
			InitializeEnvironment();
		}
		catch (SampleException ex)
		{
			ProjectData.SetProjectError((Exception)ex);
			SampleException e = ex;
			HandleSampleException(e, ApplicationMessage.ApplicationMustExit);
			ProjectData.ClearProjectError();
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			HandleSampleException(new SampleException(), ApplicationMessage.ApplicationMustExit);
			ProjectData.ClearProjectError();
		}
		if (!frameMoving)
		{
			isSingleStep = true;
			DXUtil.Timer(DirectXTimer.Start);
			DXUtil.Timer(DirectXTimer.Stop);
		}
		isHandlingSizeChanges = true;
	}

	private void ToggleStart(object sender, EventArgs e)
	{
		frameMoving = !frameMoving;
		DXUtil.Timer((DirectXTimer)IntegerType.FromObject(Interaction.IIf(frameMoving, (object)DirectXTimer.Start, (object)DirectXTimer.Stop)));
	}

	private void SingleStep(object sender, EventArgs e)
	{
		if (!frameMoving)
		{
			DXUtil.Timer(DirectXTimer.Advance);
		}
		else
		{
			DXUtil.Timer(DirectXTimer.Stop);
		}
		frameMoving = false;
		isSingleStep = true;
	}

	private void ExitSample(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	protected override void Dispose(bool disposing)
	{
		CleanupEnvironment();
		((Component)(object)mnuMain).Dispose();
		((Form)this).Dispose(disposing);
	}

	protected override void OnKeyPress(KeyPressEventArgs e)
	{
		if (isUsingMenus)
		{
			if (e.get_KeyChar() == ' ')
			{
				mnuSingle.PerformClick();
				e.set_Handled(true);
			}
			if (e.get_KeyChar() == '\r')
			{
				mnuGo.PerformClick();
				e.set_Handled(true);
			}
		}
		if (Strings.Asc(e.get_KeyChar()) == 27)
		{
			mnuExit.PerformClick();
			e.set_Handled(true);
		}
		((Control)this).OnKeyPress(e);
	}

	protected override void OnKeyDown(KeyEventArgs e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Invalid comparison between Unknown and I4
		if (isUsingMenus && (e.get_Alt() & ((int)e.get_KeyCode() == 13)) && (active & ready))
		{
			PauseSample(pause: true);
			try
			{
				ToggleFullscreen();
				PauseSample(pause: false);
				return;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				HandleSampleException(new ResetFailedException(), ApplicationMessage.ApplicationMustExit);
				ProjectData.ClearProjectError();
			}
			finally
			{
				e.set_Handled(true);
			}
		}
		((Control)this).OnKeyDown(e);
	}

	private void InitializeComponent()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		Size autoScaleBaseSize = new Size(5, 13);
		((Form)this).set_AutoScaleBaseSize(autoScaleBaseSize);
		autoScaleBaseSize = new Size(100, 100);
		((Form)this).set_MinimumSize(autoScaleBaseSize);
		mnuMain = new MainMenu();
		mnuFile = new MenuItem();
		mnuGo = new MenuItem();
		mnuSingle = new MenuItem();
		mnuBreak1 = new MenuItem();
		mnuChange = new MenuItem();
		mnuBreak2 = new MenuItem();
		mnuExit = new MenuItem();
		((Menu)mnuMain).get_MenuItems().AddRange((MenuItem[])(object)new MenuItem[1] { mnuFile });
		mnuFile.set_Index(0);
		((Menu)mnuFile).get_MenuItems().AddRange((MenuItem[])(object)new MenuItem[6] { mnuGo, mnuSingle, mnuBreak1, mnuChange, mnuBreak2, mnuExit });
		mnuFile.set_Text("&File");
		mnuGo.set_Index(0);
		mnuGo.set_Text("&Go/stop\tEnter");
		mnuSingle.set_Index(1);
		mnuSingle.set_Text("&Single step\tSpace");
		mnuBreak1.set_Index(2);
		mnuBreak1.set_Text("-");
		mnuChange.set_Index(3);
		mnuChange.set_Shortcut((Shortcut)113);
		mnuChange.set_ShowShortcut(true);
		mnuChange.set_Text("&Change Device...");
		mnuBreak2.set_Index(4);
		mnuBreak2.set_Text("-");
		mnuExit.set_Index(5);
		mnuExit.set_Text("E&xit\tESC");
	}

	protected override void OnMenuStart(EventArgs e)
	{
		PauseSample(pause: true);
	}

	protected override void OnMenuComplete(EventArgs e)
	{
		PauseSample(pause: false);
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		if (device != null)
		{
			device.SetCursorPosition(e.get_X(), e.get_Y(), false);
		}
		((Control)this).OnMouseMove(e);
	}

	protected override void OnSizeChanged(EventArgs e)
	{
		OnResize(e);
		((Control)this).OnSizeChanged(e);
	}

	protected override void OnResize(EventArgs e)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Invalid comparison between Unknown and I4
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Invalid comparison between Unknown and I4
		if (isHandlingSizeChanges)
		{
			isMaximized = (int)((Form)this).get_WindowState() == 2;
			if (!isMaximized)
			{
				storedSize = ((Form)this).get_ClientSize();
				storedLocation = ((Control)this).get_Location();
			}
		}
		active = !(((int)((Form)this).get_WindowState() == 1) | !((Control)this).get_Visible());
		((Form)this).OnResize(e);
	}

	protected override void OnGotFocus(EventArgs e)
	{
		isHandlingSizeChanges = true;
		isWindowActive = true;
		((Control)this).OnGotFocus(e);
	}

	protected override void OnMove(EventArgs e)
	{
		if (isHandlingSizeChanges)
		{
			storedLocation = ((Control)this).get_Location();
		}
		((Control)this).OnMove(e);
	}

	protected override void OnClosing(CancelEventArgs e)
	{
		((Form)this).OnClosing(e);
	}
}
