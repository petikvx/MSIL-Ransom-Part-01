using System;
using System.Runtime.CompilerServices;
using System.Threading;
using NAudio.Wave.Asio;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave;

public sealed class AsioOut : IDisposable, IWavePlayer
{
	private AsioDriverExt driver;

	private IWaveProvider sourceStream;

	private PlaybackState playbackState;

	private int nbSamples;

	private byte[] waveBuffer;

	private AsioSampleConvertor.SampleConvertor convertor;

	private readonly string driverName;

	private readonly SynchronizationContext syncContext;

	private bool isInitialized;

	[NonSerialized]
	internal static GetString _008A;

	public int PlaybackLatency
	{
		get
		{
			driver.Driver.GetLatencies(out var _, out var outputLatency);
			return outputLatency;
		}
	}

	public PlaybackState PlaybackState => playbackState;

	public string DriverName => driverName;

	public int NumberOfOutputChannels { get; private set; }

	public int NumberOfInputChannels { get; private set; }

	public int DriverInputChannelCount => driver.Capabilities.NbInputChannels;

	public int DriverOutputChannelCount => driver.Capabilities.NbOutputChannels;

	public int ChannelOffset { get; set; }

	public int InputChannelOffset { get; set; }

	[Obsolete("this function will be removed in a future NAudio as ASIO does not support setting the volume on the device")]
	public float Volume
	{
		get
		{
			return 1f;
		}
		set
		{
			if (value != 1f)
			{
				throw new InvalidOperationException(_008A(107388991));
			}
		}
	}

	public event EventHandler<StoppedEventArgs> PlaybackStopped;

	public event EventHandler<AsioAudioAvailableEventArgs> AudioAvailable;

	public AsioOut()
		: this(0)
	{
	}

	public AsioOut(string driverName)
	{
		syncContext = SynchronizationContext.Current;
		InitFromName(driverName);
	}

	public AsioOut(int driverIndex)
	{
		syncContext = SynchronizationContext.Current;
		string[] driverNames = GetDriverNames();
		if (driverNames.Length == 0)
		{
			throw new ArgumentException(_008A(107389807));
		}
		if (driverIndex < 0 || driverIndex > driverNames.Length)
		{
			throw new ArgumentException(string.Format(_008A(107389742), driverNames.Length));
		}
		driverName = driverNames[driverIndex];
		InitFromName(driverName);
	}

	~AsioOut()
	{
		Dispose();
	}

	public void Dispose()
	{
		if (driver != null)
		{
			if (playbackState != 0)
			{
				driver.Stop();
			}
			driver.ReleaseDriver();
			driver = null;
		}
	}

	public static string[] GetDriverNames()
	{
		return AsioDriver.GetAsioDriverNames();
	}

	public static bool isSupported()
	{
		return GetDriverNames().Length != 0;
	}

	private void InitFromName(string driverName)
	{
		AsioDriver asioDriverByName = AsioDriver.GetAsioDriverByName(driverName);
		driver = new AsioDriverExt(asioDriverByName);
		ChannelOffset = 0;
	}

	public void ShowControlPanel()
	{
		driver.ShowControlPanel();
	}

	public void Play()
	{
		if (playbackState != PlaybackState.Playing)
		{
			playbackState = PlaybackState.Playing;
			driver.Start();
		}
	}

	public void Stop()
	{
		playbackState = PlaybackState.Stopped;
		driver.Stop();
		RaisePlaybackStopped(null);
	}

	public void Pause()
	{
		playbackState = PlaybackState.Paused;
		driver.Stop();
	}

	public void Init(IWaveProvider waveProvider)
	{
		InitRecordAndPlayback(waveProvider, 0, -1);
	}

	public void InitRecordAndPlayback(IWaveProvider waveProvider, int recordChannels, int recordOnlySampleRate)
	{
		if (isInitialized)
		{
			throw new InvalidOperationException(_008A(107389641));
		}
		isInitialized = true;
		int num = waveProvider?.WaveFormat.SampleRate ?? recordOnlySampleRate;
		if (waveProvider != null)
		{
			sourceStream = waveProvider;
			NumberOfOutputChannels = waveProvider.WaveFormat.Channels;
			convertor = AsioSampleConvertor.SelectSampleConvertor(waveProvider.WaveFormat, driver.Capabilities.OutputChannelInfos[0].type);
		}
		else
		{
			NumberOfOutputChannels = 0;
		}
		if (!driver.IsSampleRateSupported(num))
		{
			throw new ArgumentException(_008A(107389028));
		}
		if (driver.Capabilities.SampleRate != (double)num)
		{
			driver.SetSampleRate(num);
		}
		driver.FillBufferCallback = driver_BufferUpdate;
		NumberOfInputChannels = recordChannels;
		nbSamples = driver.CreateBuffers(NumberOfOutputChannels, NumberOfInputChannels, useMaxBufferSize: false);
		driver.SetChannelOffset(ChannelOffset, InputChannelOffset);
		if (waveProvider != null)
		{
			waveBuffer = new byte[nbSamples * NumberOfOutputChannels * waveProvider.WaveFormat.BitsPerSample / 8];
		}
	}

	private unsafe void driver_BufferUpdate(IntPtr[] inputChannels, IntPtr[] outputChannels)
	{
		if (NumberOfInputChannels > 0)
		{
			EventHandler<AsioAudioAvailableEventArgs> audioAvailable = this.AudioAvailable;
			if (audioAvailable != null)
			{
				AsioAudioAvailableEventArgs asioAudioAvailableEventArgs = new AsioAudioAvailableEventArgs(inputChannels, outputChannels, nbSamples, driver.Capabilities.InputChannelInfos[0].type);
				audioAvailable(this, asioAudioAvailableEventArgs);
				if (asioAudioAvailableEventArgs.WrittenToOutputBuffers)
				{
					return;
				}
			}
		}
		if (NumberOfOutputChannels > 0)
		{
			int num = sourceStream.Read(waveBuffer, 0, waveBuffer.Length);
			_ = waveBuffer.Length;
			fixed (IntPtr* value = &System.Runtime.CompilerServices.Unsafe.As<byte, IntPtr>(ref waveBuffer[0]))
			{
				convertor(new IntPtr(value), outputChannels, NumberOfOutputChannels, nbSamples);
			}
			if (num == 0)
			{
				Stop();
			}
		}
	}

	private void RaisePlaybackStopped(Exception e)
	{
		EventHandler<StoppedEventArgs> handler = this.PlaybackStopped;
		if (handler == null)
		{
			return;
		}
		if (syncContext == null)
		{
			handler(this, new StoppedEventArgs(e));
			return;
		}
		syncContext.Post(delegate
		{
			handler(this, new StoppedEventArgs(e));
		}, null);
	}

	public string AsioInputChannelName(int channel)
	{
		if (channel <= DriverInputChannelCount)
		{
			return driver.Capabilities.InputChannelInfos[channel].name;
		}
		return _008A(107398482);
	}

	public string AsioOutputChannelName(int channel)
	{
		if (channel <= DriverOutputChannelCount)
		{
			return driver.Capabilities.OutputChannelInfos[channel].name;
		}
		return _008A(107398482);
	}

	static AsioOut()
	{
		Strings.CreateGetStringDelegate(typeof(AsioOut));
	}
}
