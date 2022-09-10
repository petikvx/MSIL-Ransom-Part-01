using System;
using Microsoft.DirectX.Direct3D;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

public class D3DSettings
{
	public bool IsWindowed;

	public GraphicsAdapterInfo WindowedAdapterInfo;

	public GraphicsDeviceInfo WindowedDeviceInfo;

	public DeviceCombo WindowedDeviceCombo;

	public DisplayMode WindowedDisplayMode;

	public DepthFormat WindowedDepthStencilBufferFormat;

	public MultiSampleType WindowedMultisampleType;

	public int WindowedMultisampleQuality;

	public VertexProcessingType WindowedVertexProcessingType;

	public PresentInterval WindowedPresentInterval;

	public int WindowedWidth;

	public int WindowedHeight;

	public GraphicsAdapterInfo FullscreenAdapterInfo;

	public GraphicsDeviceInfo FullscreenDeviceInfo;

	public DeviceCombo FullscreenDeviceCombo;

	public DisplayMode FullscreenDisplayMode;

	public DepthFormat FullscreenDepthStencilBufferFormat;

	public MultiSampleType FullscreenMultisampleType;

	public int FullscreenMultisampleQuality;

	public VertexProcessingType FullscreenVertexProcessingType;

	public PresentInterval FullscreenPresentInterval;

	public DisplayMode DisplayMode
	{
		get
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			return (DisplayMode)(Interaction.IIf(IsWindowed, (object)WindowedDisplayMode, (object)FullscreenDisplayMode) ?? Activator.CreateInstance(typeof(DisplayMode)));
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			if (IsWindowed)
			{
				WindowedDisplayMode = value;
			}
			else
			{
				FullscreenDisplayMode = value;
			}
		}
	}

	public Format BackBufferFormat => DeviceCombo.BackBufferFormat;

	public MultiSampleType MultisampleType
	{
		get
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			return (MultiSampleType)IntegerType.FromObject(Interaction.IIf(IsWindowed, (object)WindowedMultisampleType, (object)FullscreenMultisampleType));
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			if (IsWindowed)
			{
				WindowedMultisampleType = value;
			}
			else
			{
				FullscreenMultisampleType = value;
			}
		}
	}

	public VertexProcessingType VertexProcessingType
	{
		get
		{
			return (VertexProcessingType)IntegerType.FromObject(Interaction.IIf(IsWindowed, (object)WindowedVertexProcessingType, (object)FullscreenVertexProcessingType));
		}
		set
		{
			if (IsWindowed)
			{
				WindowedVertexProcessingType = value;
			}
			else
			{
				FullscreenVertexProcessingType = value;
			}
		}
	}

	public int MultisampleQuality
	{
		get
		{
			return IntegerType.FromObject(Interaction.IIf(IsWindowed, (object)WindowedMultisampleQuality, (object)FullscreenMultisampleQuality));
		}
		set
		{
			if (IsWindowed)
			{
				WindowedMultisampleQuality = value;
			}
			else
			{
				FullscreenMultisampleQuality = value;
			}
		}
	}

	public DeviceCombo DeviceCombo
	{
		get
		{
			return (DeviceCombo)Interaction.IIf(IsWindowed, (object)WindowedDeviceCombo, (object)FullscreenDeviceCombo);
		}
		set
		{
			if (IsWindowed)
			{
				WindowedDeviceCombo = value;
			}
			else
			{
				FullscreenDeviceCombo = value;
			}
		}
	}

	public GraphicsAdapterInfo AdapterInfo
	{
		get
		{
			return (GraphicsAdapterInfo)Interaction.IIf(IsWindowed, (object)WindowedAdapterInfo, (object)FullscreenAdapterInfo);
		}
		set
		{
			if (IsWindowed)
			{
				WindowedAdapterInfo = value;
			}
			else
			{
				FullscreenAdapterInfo = value;
			}
		}
	}

	public DepthFormat DepthStencilBufferFormat
	{
		get
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			return (DepthFormat)IntegerType.FromObject(Interaction.IIf(IsWindowed, (object)WindowedDepthStencilBufferFormat, (object)FullscreenDepthStencilBufferFormat));
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			if (IsWindowed)
			{
				WindowedDepthStencilBufferFormat = value;
			}
			else
			{
				FullscreenDepthStencilBufferFormat = value;
			}
		}
	}

	public GraphicsDeviceInfo DeviceInfo
	{
		get
		{
			return (GraphicsDeviceInfo)Interaction.IIf(IsWindowed, (object)WindowedDeviceInfo, (object)FullscreenDeviceInfo);
		}
		set
		{
			if (IsWindowed)
			{
				WindowedDeviceInfo = value;
			}
			else
			{
				FullscreenDeviceInfo = value;
			}
		}
	}

	public DeviceType DevType => DeviceCombo.DevType;

	public int AdapterOrdinal => DeviceCombo.AdapterOrdinal;

	public PresentInterval PresentInterval
	{
		get
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			return (PresentInterval)IntegerType.FromObject(Interaction.IIf(IsWindowed, (object)WindowedPresentInterval, (object)FullscreenPresentInterval));
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			if (IsWindowed)
			{
				WindowedPresentInterval = value;
			}
			else
			{
				FullscreenPresentInterval = value;
			}
		}
	}

	public D3DSettings Clone()
	{
		return (D3DSettings)MemberwiseClone();
	}
}
