using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave;

public sealed class WaveOutEvent : IDisposable, IWavePlayer, IWavePosition
{
	private readonly object waveOutLock;

	private readonly SynchronizationContext syncContext;

	private IntPtr hWaveOut;

	private WaveOutBuffer[] buffers;

	private IWaveProvider waveStream;

	private volatile PlaybackState playbackState;

	private AutoResetEvent callbackEvent;

	private float volume = 1f;

	[NonSerialized]
	internal static GetString _0002;

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
			WaveOut.SetWaveOutVolume(value, hWaveOut, waveOutLock);
			volume = value;
		}
	}

	public event EventHandler<StoppedEventArgs> PlaybackStopped;

	public WaveOutEvent()
	{
		syncContext = SynchronizationContext.Current;
		if (syncContext != null && (syncContext.GetType().Name == _0002(107387930) || syncContext.GetType().Name == _0002(107387913)))
		{
			syncContext = null;
		}
		DeviceNumber = 0;
		DesiredLatency = 300;
		NumberOfBuffers = 2;
		waveOutLock = new object();
	}

	public void Init(IWaveProvider waveProvider)
	{
		if (playbackState != 0)
		{
			throw new InvalidOperationException(_0002(107387840));
		}
		if (hWaveOut != IntPtr.Zero)
		{
			DisposeBuffers();
			CloseWaveOut();
		}
		callbackEvent = new AutoResetEvent(initialState: false);
		waveStream = waveProvider;
		int bufferSize = waveProvider.WaveFormat.ConvertLatencyToByteSize((DesiredLatency + NumberOfBuffers - 1) / NumberOfBuffers);
		MmResult result;
		lock (waveOutLock)
		{
			result = WaveInterop.waveOutOpenWindow(out hWaveOut, (IntPtr)DeviceNumber, waveStream.WaveFormat, callbackEvent.SafeWaitHandle.DangerousGetHandle(), IntPtr.Zero, WaveInterop.WaveInOutOpenFlags.CallbackEvent);
		}
		MmException.Try(result, _0002(107387617));
		buffers = new WaveOutBuffer[NumberOfBuffers];
		playbackState = PlaybackState.Stopped;
		for (int i = 0; i < NumberOfBuffers; i++)
		{
			buffers[i] = new WaveOutBuffer(hWaveOut, bufferSize, waveStream, waveOutLock);
		}
	}

	public void Play()
	{
		if (buffers == null || waveStream == null)
		{
			throw new InvalidOperationException(_0002(107387823));
		}
		if (playbackState == PlaybackState.Stopped)
		{
			playbackState = PlaybackState.Playing;
			callbackEvent.Set();
			ThreadPool.QueueUserWorkItem(delegate
			{
				PlaybackThread();
			}, null);
		}
		else if (playbackState == PlaybackState.Paused)
		{
			Resume();
			callbackEvent.Set();
		}
	}

	private void PlaybackThread()
	{
		Exception e = null;
		try
		{
			DoPlayback();
		}
		catch (Exception ex)
		{
			e = ex;
		}
		finally
		{
			playbackState = PlaybackState.Stopped;
			RaisePlaybackStoppedEvent(e);
		}
	}

	private void DoPlayback()
	{
		while (playbackState != 0)
		{
			if (!callbackEvent.WaitOne(DesiredLatency))
			{
				_ = playbackState;
				_ = 1;
			}
			if (playbackState != PlaybackState.Playing)
			{
				continue;
			}
			int num = 0;
			WaveOutBuffer[] array = buffers;
			foreach (WaveOutBuffer waveOutBuffer in array)
			{
				if (waveOutBuffer.InQueue || waveOutBuffer.OnDone())
				{
					num++;
				}
			}
			if (num == 0)
			{
				playbackState = PlaybackState.Stopped;
				callbackEvent.Set();
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
				throw new MmException(mmResult, _0002(107387632));
			}
		}
	}

	private void Resume()
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
				throw new MmException(mmResult, _0002(107387583));
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
				throw new MmException(mmResult, _0002(107387594));
			}
			callbackEvent.Set();
		}
	}

	public long GetPosition()
	{
		lock (waveOutLock)
		{
			MmTime mmTime = default(MmTime);
			mmTime.wType = 4u;
			MmException.Try(WaveInterop.waveOutGetPosition(hWaveOut, out mmTime, Marshal.SizeOf((object)mmTime)), _0002(107387545));
			if (mmTime.wType != 4)
			{
				throw new Exception(string.Format(_0002(107387520), 4, mmTime.wType));
			}
			return mmTime.cb;
		}
	}

	public void Dispose()
	{
		GC.SuppressFinalize(this);
		Dispose(disposing: true);
	}

	protected void Dispose(bool disposing)
	{
		Stop();
		if (disposing)
		{
			DisposeBuffers();
		}
		CloseWaveOut();
	}

	private void CloseWaveOut()
	{
		if (callbackEvent != null)
		{
			callbackEvent.Close();
			callbackEvent = null;
		}
		lock (waveOutLock)
		{
			if (hWaveOut != IntPtr.Zero)
			{
				WaveInterop.waveOutClose(hWaveOut);
				hWaveOut = IntPtr.Zero;
			}
		}
	}

	private void DisposeBuffers()
	{
		if (buffers != null)
		{
			WaveOutBuffer[] array = buffers;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Dispose();
			}
			buffers = null;
		}
	}

	~WaveOutEvent()
	{
		Dispose(disposing: false);
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

	static WaveOutEvent()
	{
		Strings.CreateGetStringDelegate(typeof(WaveOutEvent));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0002(107398309), _0002(107398272)), _0002(107398267), _0002(107398262)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0002(107398289)))
		{
			return;
		}
		throw new SecurityException(_0002(107398232));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
