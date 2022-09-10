using System;
using System.Collections;
using Microsoft.DirectX.Direct3D;
using Microsoft.VisualBasic.CompilerServices;

public class D3DEnumeration
{
	public delegate bool ConfirmDeviceCallbackType(Caps caps, VertexProcessingType vertexProcessingType, Format adapterFormat, Format backBufferFormat);

	public ConfirmDeviceCallbackType ConfirmDeviceCallback;

	public ArrayList AdapterInfoList;

	public int AppMinFullscreenWidth;

	public int AppMinFullscreenHeight;

	public int AppMinColorChannelBits;

	public int AppMinAlphaChannelBits;

	public int AppMinDepthBits;

	public int AppMinStencilBits;

	public bool AppUsesDepthBuffer;

	public bool AppUsesMixedVP;

	public bool AppRequiresWindowed;

	public bool AppRequiresFullscreen;

	public D3DEnumeration()
	{
		AdapterInfoList = new ArrayList();
		AppMinFullscreenWidth = 640;
		AppMinFullscreenHeight = 480;
		AppMinColorChannelBits = 5;
		AppMinAlphaChannelBits = 0;
		AppMinDepthBits = 15;
		AppMinStencilBits = 0;
		AppUsesDepthBuffer = true;
		AppUsesMixedVP = false;
		AppRequiresWindowed = false;
		AppRequiresFullscreen = false;
	}

	public void Enumerate()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = Manager.get_Adapters().GetEnumerator();
			IEnumerator enumerator2 = default(IEnumerator);
			while (enumerator.MoveNext())
			{
				AdapterInformation val = (AdapterInformation)enumerator.Current;
				ArrayList arrayList = new ArrayList();
				GraphicsAdapterInfo graphicsAdapterInfo = new GraphicsAdapterInfo();
				graphicsAdapterInfo.AdapterOrdinal = val.get_Adapter();
				graphicsAdapterInfo.AdapterDetails = val.get_Information();
				try
				{
					enumerator2 = val.get_SupportedDisplayModes().GetEnumerator();
					while (enumerator2.MoveNext())
					{
						DisplayMode val2 = (DisplayMode)(enumerator2.Current ?? Activator.CreateInstance(typeof(DisplayMode)));
						if (((DisplayMode)(ref val2)).get_Width() >= AppMinFullscreenWidth && ((DisplayMode)(ref val2)).get_Height() >= AppMinFullscreenHeight && GraphicsUtility.ColorChannelBits(((DisplayMode)(ref val2)).get_Format()) >= AppMinColorChannelBits)
						{
							graphicsAdapterInfo.DisplayModeList.Add(val2);
							if (!arrayList.Contains(((DisplayMode)(ref val2)).get_Format()))
							{
								arrayList.Add(((DisplayMode)(ref val2)).get_Format());
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
				DisplayModeComparer comparer = new DisplayModeComparer();
				graphicsAdapterInfo.DisplayModeList.Sort(comparer);
				EnumerateDevices(graphicsAdapterInfo, arrayList);
				if (graphicsAdapterInfo.DeviceInfoList.Count != 0)
				{
					AdapterInfoList.Add(graphicsAdapterInfo);
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

	protected void EnumerateDevices(GraphicsAdapterInfo adapterInfo, ArrayList adapterFormatList)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		DeviceType[] array = (DeviceType[])(object)new DeviceType[3]
		{
			(DeviceType)1,
			(DeviceType)3,
			(DeviceType)2
		};
		DeviceType[] array2 = array;
		foreach (DeviceType val in array2)
		{
			GraphicsDeviceInfo graphicsDeviceInfo = new GraphicsDeviceInfo();
			graphicsDeviceInfo.AdapterOrdinal = adapterInfo.AdapterOrdinal;
			graphicsDeviceInfo.DevType = val;
			try
			{
				graphicsDeviceInfo.Caps = Manager.GetDeviceCaps(adapterInfo.AdapterOrdinal, val);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				continue;
			}
			EnumerateDeviceCombos(graphicsDeviceInfo, adapterFormatList);
			if (graphicsDeviceInfo.DeviceComboList.Count != 0)
			{
				adapterInfo.DeviceInfoList.Add(graphicsDeviceInfo);
			}
		}
	}

	protected void EnumerateDeviceCombos(GraphicsDeviceInfo deviceInfo, ArrayList adapterFormatList)
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		Format[] array = (Format[])(object)new Format[6]
		{
			(Format)21,
			(Format)22,
			(Format)35,
			(Format)23,
			(Format)25,
			(Format)24
		};
		bool[] array2 = new bool[2] { false, true };
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = adapterFormatList.GetEnumerator();
			while (enumerator.MoveNext())
			{
				Format val = (Format)IntegerType.FromObject(enumerator.Current);
				Format[] array3 = array;
				foreach (Format val2 in array3)
				{
					if (GraphicsUtility.AlphaChannelBits(val2) < AppMinAlphaChannelBits)
					{
						continue;
					}
					bool[] array4 = array2;
					foreach (bool num in array4)
					{
						bool flag = num;
						if ((!num & AppRequiresWindowed) || (flag & AppRequiresFullscreen) || !Manager.CheckDeviceType(deviceInfo.AdapterOrdinal, deviceInfo.DevType, val, val2, flag))
						{
							continue;
						}
						DeviceCombo deviceCombo = new DeviceCombo();
						deviceCombo.AdapterOrdinal = deviceInfo.AdapterOrdinal;
						deviceCombo.DevType = deviceInfo.DevType;
						deviceCombo.AdapterFormat = val;
						deviceCombo.BackBufferFormat = val2;
						deviceCombo.IsWindowed = flag;
						if (AppUsesDepthBuffer)
						{
							BuildDepthStencilFormatList(deviceCombo);
							if (deviceCombo.DepthStencilFormatList.Count == 0)
							{
								continue;
							}
						}
						BuildMultiSampleTypeList(deviceCombo);
						if (deviceCombo.MultiSampleTypeList.Count == 0)
						{
							continue;
						}
						BuildDepthStencilMultiSampleConflictList(deviceCombo);
						BuildVertexProcessingTypeList(deviceInfo, deviceCombo);
						if (deviceCombo.VertexProcessingTypeList.Count != 0)
						{
							BuildPresentIntervalList(deviceInfo, deviceCombo);
							if (deviceCombo.PresentIntervalList.Count != 0)
							{
								deviceInfo.DeviceComboList.Add(deviceCombo);
							}
						}
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
	}

	public void BuildDepthStencilFormatList(DeviceCombo deviceCombo)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		DepthFormat[] array = (DepthFormat[])(object)new DepthFormat[6]
		{
			(DepthFormat)80,
			(DepthFormat)73,
			(DepthFormat)77,
			(DepthFormat)75,
			(DepthFormat)79,
			(DepthFormat)71
		};
		DepthFormat[] array2 = array;
		for (int i = 0; i < array2.Length; i++)
		{
			Format val = (Format)array2[i];
			if (GraphicsUtility.DepthBits((DepthFormat)val) >= AppMinDepthBits && GraphicsUtility.StencilBits((DepthFormat)val) >= AppMinStencilBits && Manager.CheckDeviceFormat(deviceCombo.AdapterOrdinal, deviceCombo.DevType, deviceCombo.AdapterFormat, (Usage)2, (ResourceType)1, val) && Manager.CheckDepthStencilMatch(deviceCombo.AdapterOrdinal, deviceCombo.DevType, deviceCombo.AdapterFormat, deviceCombo.BackBufferFormat, (DepthFormat)val))
			{
				deviceCombo.DepthStencilFormatList.Add(val);
			}
		}
	}

	public void BuildMultiSampleTypeList(DeviceCombo deviceCombo)
	{
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		MultiSampleType[] array = (MultiSampleType[])(object)new MultiSampleType[17]
		{
			(MultiSampleType)0,
			(MultiSampleType)1,
			(MultiSampleType)2,
			(MultiSampleType)3,
			(MultiSampleType)4,
			(MultiSampleType)5,
			(MultiSampleType)6,
			(MultiSampleType)7,
			(MultiSampleType)8,
			(MultiSampleType)9,
			(MultiSampleType)10,
			(MultiSampleType)11,
			(MultiSampleType)12,
			(MultiSampleType)13,
			(MultiSampleType)14,
			(MultiSampleType)15,
			(MultiSampleType)16
		};
		MultiSampleType[] array2 = array;
		int num2 = default(int);
		foreach (MultiSampleType val in array2)
		{
			int num = 0;
			if (Manager.CheckDeviceMultiSampleType(deviceCombo.AdapterOrdinal, deviceCombo.DevType, deviceCombo.BackBufferFormat, deviceCombo.IsWindowed, val, ref num2, ref num))
			{
				deviceCombo.MultiSampleTypeList.Add(val);
				deviceCombo.MultiSampleQualityList.Add(num);
			}
		}
	}

	public void BuildDepthStencilMultiSampleConflictList(DeviceCombo deviceCombo)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = deviceCombo.DepthStencilFormatList.GetEnumerator();
			IEnumerator enumerator2 = default(IEnumerator);
			while (enumerator.MoveNext())
			{
				DepthFormat val = (DepthFormat)IntegerType.FromObject(enumerator.Current);
				try
				{
					enumerator2 = deviceCombo.MultiSampleTypeList.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						MultiSampleType val2 = (MultiSampleType)IntegerType.FromObject(enumerator2.Current);
						if (!Manager.CheckDeviceMultiSampleType(deviceCombo.AdapterOrdinal, deviceCombo.DevType, (Format)val, deviceCombo.IsWindowed, val2))
						{
							DepthStencilMultiSampleConflict depthStencilMultiSampleConflict = new DepthStencilMultiSampleConflict();
							depthStencilMultiSampleConflict.DepthStencilFormat = val;
							depthStencilMultiSampleConflict.MultiSampleType = val2;
							deviceCombo.DepthStencilMultiSampleConflictList.Add(depthStencilMultiSampleConflict);
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
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				((IDisposable)enumerator).Dispose();
			}
		}
	}

	public void BuildVertexProcessingTypeList(GraphicsDeviceInfo deviceInfo, DeviceCombo deviceCombo)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		DeviceCaps deviceCaps = ((Caps)(ref deviceInfo.Caps)).get_DeviceCaps();
		if (((DeviceCaps)(ref deviceCaps)).get_SupportsHardwareTransformAndLight())
		{
			DeviceCaps deviceCaps2 = ((Caps)(ref deviceInfo.Caps)).get_DeviceCaps();
			if (((DeviceCaps)(ref deviceCaps2)).get_SupportsPureDevice() && ((ConfirmDeviceCallback == null) | ConfirmDeviceCallback(deviceInfo.Caps, VertexProcessingType.PureHardware, deviceCombo.AdapterFormat, deviceCombo.BackBufferFormat)))
			{
				deviceCombo.VertexProcessingTypeList.Add(VertexProcessingType.PureHardware);
			}
			if ((ConfirmDeviceCallback == null) | ConfirmDeviceCallback(deviceInfo.Caps, VertexProcessingType.Hardware, deviceCombo.AdapterFormat, deviceCombo.BackBufferFormat))
			{
				deviceCombo.VertexProcessingTypeList.Add(VertexProcessingType.Hardware);
			}
			if (AppUsesMixedVP & ((ConfirmDeviceCallback == null) | ConfirmDeviceCallback(deviceInfo.Caps, VertexProcessingType.Mixed, deviceCombo.AdapterFormat, deviceCombo.BackBufferFormat)))
			{
				deviceCombo.VertexProcessingTypeList.Add(VertexProcessingType.Mixed);
			}
		}
		if ((ConfirmDeviceCallback == null) | ConfirmDeviceCallback(deviceInfo.Caps, VertexProcessingType.Software, deviceCombo.AdapterFormat, deviceCombo.BackBufferFormat))
		{
			deviceCombo.VertexProcessingTypeList.Add(VertexProcessingType.Software);
		}
	}

	public void BuildPresentIntervalList(GraphicsDeviceInfo deviceInfo, DeviceCombo deviceCombo)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Invalid comparison between Unknown and I4
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Invalid comparison between Unknown and I4
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Invalid comparison between Unknown and I4
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Invalid comparison between Unknown and I4
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Invalid comparison between Unknown and I4
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		PresentInterval[] array = (PresentInterval[])(object)new PresentInterval[6]
		{
			(PresentInterval)int.MinValue,
			(PresentInterval)0,
			(PresentInterval)1,
			(PresentInterval)2,
			(PresentInterval)4,
			(PresentInterval)8
		};
		PresentInterval[] array2 = array;
		foreach (PresentInterval val in array2)
		{
			if ((!deviceCombo.IsWindowed || !((int)val == 2 || (int)val == 4 || (int)val == 8)) && (((int)val == 0) | ((((Caps)(ref deviceInfo.Caps)).get_PresentationIntervals() & val) != 0)))
			{
				deviceCombo.PresentIntervalList.Add(val);
			}
		}
	}
}
