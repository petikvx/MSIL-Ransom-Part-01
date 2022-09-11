using System;
using System.Runtime.InteropServices;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave;

public sealed class WaveOut : IDisposable, IWavePlayer, IWavePosition
{
	private IntPtr hWaveOut;

	private WaveOutBuffer[] buffers;

	private IWaveProvider waveStream;

	private volatile PlaybackState playbackState;

	private WaveInterop.WaveCallback callback;

	private float volume = 1f;

	private WaveCallbackInfo callbackInfo;

	private object waveOutLock;

	private int queuedBuffers;

	private SynchronizationContext syncContext;

	[NonSerialized]
	internal static GetString _009C;

	public static int DeviceCount => WaveInterop.waveOutGetNumDevs();

	public int DesiredLatency { get; set; }

	public int NumberOfBuffers { get; set; }

	public int DeviceNumber { get; set; }

	public WaveFormat OutputWaveFormat => waveStream.WaveFormat;

	public PlaybackState PlaybackState => playbackState;

	public float Volume
	{
		get
		{
			return volume;
		}
		set
		{
			SetWaveOutVolume(value, hWaveOut, waveOutLock);
			volume = value;
		}
	}

	public event EventHandler<StoppedEventArgs> PlaybackStopped;

	public static WaveOutCapabilities GetCapabilities(int devNumber)
	{
		WaveOutCapabilities waveOutCaps = default(WaveOutCapabilities);
		int waveOutCapsSize = Marshal.SizeOf((object)waveOutCaps);
		MmException.Try(WaveInterop.waveOutGetDevCaps((IntPtr)devNumber, out waveOutCaps, waveOutCapsSize), _009C(107387626));
		return waveOutCaps;
	}

	public WaveOut()
		: this((SynchronizationContext.Current == null) ? WaveCallbackInfo.FunctionCallback() : WaveCallbackInfo.NewWindow())
	{
	}

	public WaveOut(IntPtr windowHandle)
		: this(WaveCallbackInfo.ExistingWindow(windowHandle))
	{
	}

	public WaveOut(WaveCallbackInfo callbackInfo)
	{
		syncContext = SynchronizationContext.Current;
		DeviceNumber = 0;
		DesiredLatency = 300;
		NumberOfBuffers = 2;
		callback = Callback;
		waveOutLock = new object();
		this.callbackInfo = callbackInfo;
		callbackInfo.Connect(callback);
	}

	public void Init(IWaveProvider waveProvider)
	{
		waveStream = waveProvider;
		int bufferSize = waveProvider.WaveFormat.ConvertLatencyToByteSize((DesiredLatency + NumberOfBuffers - 1) / NumberOfBuffers);
		MmResult result;
		lock (waveOutLock)
		{
			result = callbackInfo.WaveOutOpen(out hWaveOut, DeviceNumber, waveStream.WaveFormat, callback);
		}
		MmException.Try(result, _009C(107387601));
		buffers = new WaveOutBuffer[NumberOfBuffers];
		playbackState = PlaybackState.Stopped;
		for (int i = 0; i < NumberOfBuffers; i++)
		{
			buffers[i] = new WaveOutBuffer(hWaveOut, bufferSize, waveStream, waveOutLock);
		}
	}

	public void Play()
	{
		if (playbackState == PlaybackState.Stopped)
		{
			playbackState = PlaybackState.Playing;
			EnqueueBuffers();
		}
		else if (playbackState == PlaybackState.Paused)
		{
			EnqueueBuffers();
			Resume();
			playbackState = PlaybackState.Playing;
		}
	}

	private void EnqueueBuffers()
	{
		for (int i = 0; i < NumberOfBuffers; i++)
		{
			if (!buffers[i].InQueue)
			{
				if (!buffers[i].OnDone())
				{
					playbackState = PlaybackState.Stopped;
					break;
				}
				Interlocked.Increment(ref queuedBuffers);
			}
		}
	}

	public void Pause()
	{
		if (playbackState == PlaybackState.Playing)
		{
			playbackState = PlaybackState.Paused;
			MmResult mmResult;
			lock (waveOutLock)
			{
				mmResult = WaveInterop.waveOutPause(hWaveOut);
			}
			if (mmResult != 0)
			{
				throw new MmException(mmResult, _009C(107387616));
			}
		}
	}

	public void Resume()
	{
		if (playbackState == PlaybackState.Paused)
		{
			MmResult mmResult;
			lock (waveOutLock)
			{
				mmResult = WaveInterop.waveOutRestart(hWaveOut);
			}
			if (mmResult != 0)
			{
				throw new MmException(mmResult, _009C(107387567));
			}
			playbackState = PlaybackState.Playing;
		}
	}

	public void Stop()
	{
		if (playbackState != 0)
		{
			playbackState = PlaybackState.Stopped;
			MmResult mmResult;
			lock (waveOutLock)
			{
				mmResult = WaveInterop.waveOutReset(hWaveOut);
			}
			if (mmResult != 0)
			{
				throw new MmException(mmResult, _009C(107387578));
			}
			if (callbackInfo.Strategy == WaveCallbackStrategy.FunctionCallback)
			{
				RaisePlaybackStoppedEvent(null);
			}
		}
	}

	public long GetPosition()
	{
		lock (waveOutLock)
		{
			MmTime mmTime = default(MmTime);
			mmTime.wType = 4u;
			MmException.Try(WaveInterop.waveOutGetPosition(hWaveOut, out mmTime, Marshal.SizeOf((object)mmTime)), _009C(107387529));
			if (mmTime.wType != 4)
			{
				throw new Exception(string.Format(_009C(107387504), 4, mmTime.wType));
			}
			return mmTime.cb;
		}
	}

	internal static void SetWaveOutVolume(float value, IntPtr hWaveOut, object lockObject)
	{
		if (value < 0f)
		{
			throw new ArgumentOutOfRangeException(_009C(107391522), _009C(107388817));
		}
		if (value > 1f)
		{
			throw new ArgumentOutOfRangeException(_009C(107391522), _009C(107388817));
		}
		int dwVolume = (int)(value * 65535f) + ((int)(value * 65535f) << 16);
		MmResult result;
		lock (lockObject)
		{
			result = WaveInterop.waveOutSetVolume(hWaveOut, dwVolume);
		}
		MmException.Try(result, _009C(107387459));
	}

	public void Dispose()
	{
		GC.SuppressFinalize(this);
		Dispose(disposing: true);
	}

	protected void Dispose(bool disposing)
	{
		Stop();
		if (disposing && buffers != null)
		{
			for (int i = 0; i < buffers.Length; i++)
			{
				if (buffers[i] != null)
				{
					buffers[i].Dispose();
				}
			}
			buffers = null;
		}
		lock (waveOutLock)
		{
			WaveInterop.waveOutClose(hWaveOut);
		}
		if (disposing)
		{
			callbackInfo.Disconnect();
		}
	}

	~WaveOut()
	{
		Dispose(disposing: false);
	}

	private void Callback(IntPtr hWaveOut, WaveInterop.WaveMessage uMsg, IntPtr dwInstance, WaveHeader wavhdr, IntPtr dwReserved)
	{
		if (uMsg != WaveInterop.WaveMessage.WaveOutDone)
		{
			return;
		}
		WaveOutBuffer waveOutBuffer = (WaveOutBuffer)((GCHandle)wavhdr.userData).Target;
		Interlocked.Decrement(ref queuedBuffers);
		Exception e = null;
		if (PlaybackState == PlaybackState.Playing)
		{
			lock (waveOutLock)
			{
				try
				{
					if (waveOutBuffer.OnDone())
					{
						Interlocked.Increment(ref queuedBuffers);
					}
				}
				catch (Exception ex)
				{
					e = ex;
				}
			}
		}
		if (queuedBuffers == 0 && (callbackInfo.Strategy != 0 || playbackState != 0))
		{
			playbackState = PlaybackState.Stopped;
			RaisePlaybackStoppedEvent(e);
		}
	}

	private void RaisePlaybackStoppedEvent(Exception e)
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

	static WaveOut()
	{
		Strings.CreateGetStringDelegate(typeof(WaveOut));
	}
}
