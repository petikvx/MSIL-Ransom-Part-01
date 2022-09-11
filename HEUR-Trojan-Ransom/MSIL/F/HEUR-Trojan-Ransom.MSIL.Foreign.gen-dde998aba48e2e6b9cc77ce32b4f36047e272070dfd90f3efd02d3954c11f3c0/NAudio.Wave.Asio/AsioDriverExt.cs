using System;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave.Asio;

public sealed class AsioDriverExt
{
	private readonly AsioDriver driver;

	private AsioCallbacks callbacks;

	private AsioDriverCapability capability;

	private AsioBufferInfo[] bufferInfos;

	private bool isOutputReadySupported;

	private IntPtr[] currentOutputBuffers;

	private IntPtr[] currentInputBuffers;

	private int numberOfOutputChannels;

	private int numberOfInputChannels;

	private AsioFillBufferCallback fillBufferCallback;

	private int bufferSize;

	private int outputChannelOffset;

	private int inputChannelOffset;

	[NonSerialized]
	internal static GetString _001A;

	public AsioDriver Driver => driver;

	public AsioFillBufferCallback FillBufferCallback
	{
		get
		{
			return fillBufferCallback;
		}
		set
		{
			fillBufferCallback = value;
		}
	}

	public AsioDriverCapability Capabilities => capability;

	public AsioDriverExt(AsioDriver driver)
	{
		this.driver = driver;
		if (!driver.Init(IntPtr.Zero))
		{
			throw new InvalidOperationException(driver.GetErrorMessage());
		}
		callbacks = default(AsioCallbacks);
		callbacks.pasioMessage = AsioMessageCallBack;
		callbacks.pbufferSwitch = BufferSwitchCallBack;
		callbacks.pbufferSwitchTimeInfo = BufferSwitchTimeInfoCallBack;
		callbacks.psampleRateDidChange = SampleRateDidChangeCallBack;
		BuildCapabilities();
	}

	public void SetChannelOffset(int outputChannelOffset, int inputChannelOffset)
	{
		if (outputChannelOffset + numberOfOutputChannels <= Capabilities.NbOutputChannels)
		{
			this.outputChannelOffset = outputChannelOffset;
			if (inputChannelOffset + numberOfInputChannels <= Capabilities.NbInputChannels)
			{
				this.inputChannelOffset = inputChannelOffset;
				return;
			}
			throw new ArgumentException(_001A(107414844));
		}
		throw new ArgumentException(_001A(107414844));
	}

	public void Start()
	{
		driver.Start();
	}

	public void Stop()
	{
		driver.Stop();
	}

	public void ShowControlPanel()
	{
		driver.ControlPanel();
	}

	public void ReleaseDriver()
	{
		try
		{
			driver.DisposeBuffers();
		}
		catch (Exception ex)
		{
			Console.Out.WriteLine(ex.ToString());
		}
		driver.ReleaseComAsioDriver();
	}

	public bool IsSampleRateSupported(double sampleRate)
	{
		return driver.CanSampleRate(sampleRate);
	}

	public void SetSampleRate(double sampleRate)
	{
		driver.SetSampleRate(sampleRate);
		BuildCapabilities();
	}

	public unsafe int CreateBuffers(int numberOfOutputChannels, int numberOfInputChannels, bool useMaxBufferSize)
	{
		if (numberOfOutputChannels < 0 || numberOfOutputChannels > capability.NbOutputChannels)
		{
			throw new ArgumentException(string.Format(_001A(107414811), numberOfOutputChannels, capability.NbOutputChannels));
		}
		if (numberOfInputChannels < 0 || numberOfInputChannels > capability.NbInputChannels)
		{
			throw new ArgumentException(_001A(107415274), string.Format(_001A(107415245), numberOfInputChannels, capability.NbInputChannels));
		}
		this.numberOfOutputChannels = numberOfOutputChannels;
		this.numberOfInputChannels = numberOfInputChannels;
		int num = capability.NbInputChannels + capability.NbOutputChannels;
		bufferInfos = new AsioBufferInfo[num];
		currentOutputBuffers = new IntPtr[numberOfOutputChannels];
		currentInputBuffers = new IntPtr[numberOfInputChannels];
		int num2 = 0;
		int num3 = 0;
		while (num3 < capability.NbInputChannels)
		{
			bufferInfos[num2].isInput = true;
			bufferInfos[num2].channelNum = num3;
			bufferInfos[num2].pBuffer0 = IntPtr.Zero;
			bufferInfos[num2].pBuffer1 = IntPtr.Zero;
			num3++;
			num2++;
		}
		int num4 = 0;
		while (num4 < capability.NbOutputChannels)
		{
			bufferInfos[num2].isInput = false;
			bufferInfos[num2].channelNum = num4;
			bufferInfos[num2].pBuffer0 = IntPtr.Zero;
			bufferInfos[num2].pBuffer1 = IntPtr.Zero;
			num4++;
			num2++;
		}
		if (useMaxBufferSize)
		{
			bufferSize = capability.BufferMaxSize;
		}
		else
		{
			bufferSize = capability.BufferPreferredSize;
		}
		fixed (AsioBufferInfo* value = &bufferInfos[0])
		{
			IntPtr intPtr = new IntPtr(value);
			driver.CreateBuffers(intPtr, num, bufferSize, ref callbacks);
		}
		isOutputReadySupported = driver.OutputReady() == AsioError.ASE_OK;
		return bufferSize;
	}

	private void BuildCapabilities()
	{
		capability = new AsioDriverCapability();
		capability.DriverName = driver.GetDriverName();
		driver.GetChannels(out capability.NbInputChannels, out capability.NbOutputChannels);
		capability.InputChannelInfos = new AsioChannelInfo[capability.NbInputChannels];
		capability.OutputChannelInfos = new AsioChannelInfo[capability.NbOutputChannels];
		for (int i = 0; i < capability.NbInputChannels; i++)
		{
			capability.InputChannelInfos[i] = driver.GetChannelInfo(i, trueForInputInfo: true);
		}
		for (int j = 0; j < capability.NbOutputChannels; j++)
		{
			capability.OutputChannelInfos[j] = driver.GetChannelInfo(j, trueForInputInfo: false);
		}
		capability.SampleRate = driver.GetSampleRate();
		AsioError latencies = driver.GetLatencies(out capability.InputLatency, out capability.OutputLatency);
		if (latencies != 0 && latencies != AsioError.ASE_NotPresent)
		{
			throw new AsioException(_001A(107415156))
			{
				Error = latencies
			};
		}
		driver.GetBufferSize(out capability.BufferMinSize, out capability.BufferMaxSize, out capability.BufferPreferredSize, out capability.BufferGranularity);
	}

	private void BufferSwitchCallBack(int doubleBufferIndex, bool directProcess)
	{
		for (int i = 0; i < numberOfInputChannels; i++)
		{
			currentInputBuffers[i] = bufferInfos[i + inputChannelOffset].Buffer(doubleBufferIndex);
		}
		for (int j = 0; j < numberOfOutputChannels; j++)
		{
			currentOutputBuffers[j] = bufferInfos[j + outputChannelOffset + capability.NbInputChannels].Buffer(doubleBufferIndex);
		}
		fillBufferCallback?.Invoke(currentInputBuffers, currentOutputBuffers);
		if (isOutputReadySupported)
		{
			driver.OutputReady();
		}
	}

	private void SampleRateDidChangeCallBack(double sRate)
	{
		capability.SampleRate = sRate;
	}

	private int AsioMessageCallBack(AsioMessageSelector selector, int value, IntPtr message, IntPtr opt)
	{
		switch (selector)
		{
		case AsioMessageSelector.kAsioSelectorSupported:
			switch ((AsioMessageSelector)Enum.ToObject(typeof(AsioMessageSelector), value))
			{
			case AsioMessageSelector.kAsioEngineVersion:
				return 1;
			case AsioMessageSelector.kAsioResetRequest:
				return 0;
			case AsioMessageSelector.kAsioBufferSizeChange:
				return 0;
			case AsioMessageSelector.kAsioResyncRequest:
				return 0;
			case AsioMessageSelector.kAsioLatenciesChanged:
				return 0;
			case AsioMessageSelector.kAsioSupportsTimeInfo:
				return 0;
			case AsioMessageSelector.kAsioSupportsTimeCode:
				return 0;
			}
			break;
		case AsioMessageSelector.kAsioEngineVersion:
			return 2;
		case AsioMessageSelector.kAsioResetRequest:
			return 1;
		case AsioMessageSelector.kAsioBufferSizeChange:
			return 0;
		case AsioMessageSelector.kAsioResyncRequest:
			return 0;
		case AsioMessageSelector.kAsioLatenciesChanged:
			return 0;
		case AsioMessageSelector.kAsioSupportsTimeInfo:
			return 0;
		case AsioMessageSelector.kAsioSupportsTimeCode:
			return 0;
		}
		return 0;
	}

	private IntPtr BufferSwitchTimeInfoCallBack(IntPtr asioTimeParam, int doubleBufferIndex, bool directProcess)
	{
		return IntPtr.Zero;
	}

	static AsioDriverExt()
	{
		Strings.CreateGetStringDelegate(typeof(AsioDriverExt));
	}
}
