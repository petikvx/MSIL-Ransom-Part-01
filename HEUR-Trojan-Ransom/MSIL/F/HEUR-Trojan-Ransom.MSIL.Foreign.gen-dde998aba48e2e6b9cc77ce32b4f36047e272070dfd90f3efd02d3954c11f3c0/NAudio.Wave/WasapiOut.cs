using System;
using System.Runtime.InteropServices;
using System.Threading;
using NAudio.CoreAudioApi;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave;

public sealed class WasapiOut : IDisposable, IWavePlayer, IWavePosition
{
	private AudioClient audioClient;

	private readonly MMDevice mmDevice;

	private readonly AudioClientShareMode shareMode;

	private AudioRenderClient renderClient;

	private IWaveProvider sourceProvider;

	private int latencyMilliseconds;

	private int bufferFrameCount;

	private int bytesPerFrame;

	private readonly bool isUsingEventSync;

	private EventWaitHandle frameEventWaitHandle;

	private byte[] readBuffer;

	private volatile PlaybackState playbackState;

	private Thread playThread;

	private WaveFormat outputFormat;

	private bool dmoResamplerNeeded;

	private readonly SynchronizationContext syncContext;

	[NonSerialized]
	internal static GetString _008C;

	public WaveFormat OutputWaveFormat => outputFormat;

	public PlaybackState PlaybackState => playbackState;

	public float Volume
	{
		get
		{
			return mmDevice.AudioEndpointVolume.MasterVolumeLevelScalar;
		}
		set
		{
			if (value < 0f)
			{
				throw new ArgumentOutOfRangeException(_008C(107391488), _008C(107388783));
			}
			if (value > 1f)
			{
				throw new ArgumentOutOfRangeException(_008C(107391488), _008C(107388783));
			}
			mmDevice.AudioEndpointVolume.MasterVolumeLevelScalar = value;
		}
	}

	public AudioStreamVolume AudioStreamVolume
	{
		get
		{
			if (shareMode == AudioClientShareMode.Exclusive)
			{
				throw new InvalidOperationException(_008C(107388766));
			}
			return audioClient.AudioStreamVolume;
		}
	}

	public event EventHandler<StoppedEventArgs> PlaybackStopped;

	public WasapiOut()
		: this(GetDefaultAudioEndpoint(), AudioClientShareMode.Shared, useEventSync: true, 200)
	{
	}

	public WasapiOut(AudioClientShareMode shareMode, int latency)
		: this(GetDefaultAudioEndpoint(), shareMode, useEventSync: true, latency)
	{
	}

	public WasapiOut(AudioClientShareMode shareMode, bool useEventSync, int latency)
		: this(GetDefaultAudioEndpoint(), shareMode, useEventSync, latency)
	{
	}

	public WasapiOut(MMDevice device, AudioClientShareMode shareMode, bool useEventSync, int latency)
	{
		audioClient = device.AudioClient;
		mmDevice = device;
		this.shareMode = shareMode;
		isUsingEventSync = useEventSync;
		latencyMilliseconds = latency;
		syncContext = SynchronizationContext.Current;
		outputFormat = audioClient.MixFormat;
	}

	private static MMDevice GetDefaultAudioEndpoint()
	{
		if (Environment.OSVersion.Version.Major < 6)
		{
			throw new NotSupportedException(_008C(107388929));
		}
		return new MMDeviceEnumerator().GetDefaultAudioEndpoint(DataFlow.Render, Role.Console);
	}

	private void PlayThread()
	{
		ResamplerDmoStream resamplerDmoStream = null;
		IWaveProvider playbackProvider = sourceProvider;
		Exception e = null;
		try
		{
			if (dmoResamplerNeeded)
			{
				resamplerDmoStream = new ResamplerDmoStream(sourceProvider, outputFormat);
				playbackProvider = resamplerDmoStream;
			}
			bufferFrameCount = audioClient.BufferSize;
			bytesPerFrame = outputFormat.Channels * outputFormat.BitsPerSample / 8;
			readBuffer = new byte[bufferFrameCount * bytesPerFrame];
			FillBuffer(playbackProvider, bufferFrameCount);
			WaitHandle[] waitHandles = new WaitHandle[1] { frameEventWaitHandle };
			audioClient.Start();
			while (playbackState != 0)
			{
				int num = 0;
				if (isUsingEventSync)
				{
					num = WaitHandle.WaitAny(waitHandles, 3 * latencyMilliseconds, exitContext: false);
				}
				else
				{
					Thread.Sleep(latencyMilliseconds / 2);
				}
				if (playbackState == PlaybackState.Playing && num != 258)
				{
					int num2 = ((!isUsingEventSync) ? audioClient.CurrentPadding : ((shareMode == AudioClientShareMode.Shared) ? audioClient.CurrentPadding : 0));
					int num3 = bufferFrameCount - num2;
					if (num3 > 10)
					{
						FillBuffer(playbackProvider, num3);
					}
				}
			}
			Thread.Sleep(latencyMilliseconds / 2);
			audioClient.Stop();
			if (playbackState == PlaybackState.Stopped)
			{
				audioClient.Reset();
			}
		}
		catch (Exception ex)
		{
			e = ex;
		}
		finally
		{
			resamplerDmoStream?.Dispose();
			RaisePlaybackStopped(e);
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

	private void FillBuffer(IWaveProvider playbackProvider, int frameCount)
	{
		IntPtr buffer = renderClient.GetBuffer(frameCount);
		int count = frameCount * bytesPerFrame;
		int num = playbackProvider.Read(readBuffer, 0, count);
		if (num == 0)
		{
			playbackState = PlaybackState.Stopped;
		}
		Marshal.Copy(readBuffer, 0, buffer, num);
		int numFramesWritten = num / bytesPerFrame;
		renderClient.ReleaseBuffer(numFramesWritten, AudioClientBufferFlags.None);
	}

	public long GetPosition()
	{
		if (playbackState == PlaybackState.Stopped)
		{
			return 0L;
		}
		return (long)audioClient.AudioClockClient.AdjustedPosition;
	}

	public void Play()
	{
		if (playbackState != PlaybackState.Playing)
		{
			if (playbackState == PlaybackState.Stopped)
			{
				playThread = new Thread(PlayThread);
				playbackState = PlaybackState.Playing;
				playThread.Start();
			}
			else
			{
				playbackState = PlaybackState.Playing;
			}
		}
	}

	public void Stop()
	{
		if (playbackState != 0)
		{
			playbackState = PlaybackState.Stopped;
			playThread.Join();
			playThread = null;
		}
	}

	public void Pause()
	{
		if (playbackState == PlaybackState.Playing)
		{
			playbackState = PlaybackState.Paused;
		}
	}

	public void Init(IWaveProvider waveProvider)
	{
		long num = latencyMilliseconds * 10000;
		outputFormat = waveProvider.WaveFormat;
		if (!audioClient.IsFormatSupported(shareMode, outputFormat, out var closestMatchFormat))
		{
			if (closestMatchFormat == null)
			{
				WaveFormat waveFormat = audioClient.MixFormat;
				if (!audioClient.IsFormatSupported(shareMode, waveFormat))
				{
					WaveFormatExtensible[] array = new WaveFormatExtensible[3]
					{
						new WaveFormatExtensible(outputFormat.SampleRate, 32, outputFormat.Channels),
						new WaveFormatExtensible(outputFormat.SampleRate, 24, outputFormat.Channels),
						new WaveFormatExtensible(outputFormat.SampleRate, 16, outputFormat.Channels)
					};
					for (int i = 0; i < array.Length; i++)
					{
						waveFormat = array[i];
						if (audioClient.IsFormatSupported(shareMode, waveFormat))
						{
							break;
						}
						waveFormat = null;
					}
					if (waveFormat == null)
					{
						waveFormat = new WaveFormatExtensible(outputFormat.SampleRate, 16, 2);
						if (!audioClient.IsFormatSupported(shareMode, waveFormat))
						{
							throw new NotSupportedException(_008C(107388864));
						}
					}
				}
				outputFormat = waveFormat;
			}
			else
			{
				outputFormat = closestMatchFormat;
			}
			using (new ResamplerDmoStream(waveProvider, outputFormat))
			{
			}
			dmoResamplerNeeded = true;
		}
		else
		{
			dmoResamplerNeeded = false;
		}
		sourceProvider = waveProvider;
		if (isUsingEventSync)
		{
			if (shareMode == AudioClientShareMode.Shared)
			{
				audioClient.Initialize(shareMode, AudioClientStreamFlags.EventCallback, num, 0L, outputFormat, Guid.Empty);
				long streamLatency = audioClient.StreamLatency;
				if (streamLatency != 0L)
				{
					latencyMilliseconds = (int)(streamLatency / 10000);
				}
			}
			else
			{
				audioClient.Initialize(shareMode, AudioClientStreamFlags.EventCallback, num, num, outputFormat, Guid.Empty);
			}
			frameEventWaitHandle = new EventWaitHandle(initialState: false, EventResetMode.AutoReset);
			audioClient.SetEventHandle(frameEventWaitHandle.SafeWaitHandle.DangerousGetHandle());
		}
		else
		{
			audioClient.Initialize(shareMode, AudioClientStreamFlags.None, num, 0L, outputFormat, Guid.Empty);
		}
		renderClient = audioClient.AudioRenderClient;
	}

	public void Dispose()
	{
		if (audioClient != null)
		{
			Stop();
			audioClient.Dispose();
			audioClient = null;
			renderClient = null;
		}
	}

	static WasapiOut()
	{
		Strings.CreateGetStringDelegate(typeof(WasapiOut));
	}
}
