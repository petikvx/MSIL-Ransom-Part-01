using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;
using NAudio.Mixer;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave;

public sealed class WaveInEvent : IDisposable, IWaveIn
{
	private readonly AutoResetEvent callbackEvent;

	private readonly SynchronizationContext syncContext;

	private IntPtr waveInHandle;

	private volatile bool recording;

	private WaveInBuffer[] buffers;

	[NonSerialized]
	internal static GetString _0015;

	public static int DeviceCount => WaveInterop.waveInGetNumDevs();

	public int BufferMilliseconds { get; set; }

	public int NumberOfBuffers { get; set; }

	public int DeviceNumber { get; set; }

	public WaveFormat WaveFormat { get; set; }

	public event EventHandler<WaveInEventArgs> DataAvailable;

	public event EventHandler<StoppedEventArgs> RecordingStopped;

	public WaveInEvent()
	{
		callbackEvent = new AutoResetEvent(initialState: false);
		syncContext = SynchronizationContext.Current;
		DeviceNumber = 0;
		WaveFormat = new WaveFormat(8000, 16, 1);
		BufferMilliseconds = 100;
		NumberOfBuffers = 3;
	}

	public static WaveInCapabilities GetCapabilities(int devNumber)
	{
		WaveInCapabilities waveInCaps = default(WaveInCapabilities);
		int waveInCapsSize = Marshal.SizeOf((object)waveInCaps);
		MmException.Try(WaveInterop.waveInGetDevCaps((IntPtr)devNumber, out waveInCaps, waveInCapsSize), _0015(107390452));
		return waveInCaps;
	}

	private void CreateBuffers()
	{
		int num = BufferMilliseconds * WaveFormat.AverageBytesPerSecond / 1000;
		if (num % WaveFormat.BlockAlign != 0)
		{
			num -= num % WaveFormat.BlockAlign;
		}
		buffers = new WaveInBuffer[NumberOfBuffers];
		for (int i = 0; i < buffers.Length; i++)
		{
			buffers[i] = new WaveInBuffer(waveInHandle, num);
		}
	}

	private void OpenWaveInDevice()
	{
		CloseWaveInDevice();
		MmException.Try(WaveInterop.waveInOpenWindow(out waveInHandle, (IntPtr)DeviceNumber, WaveFormat, callbackEvent.SafeWaitHandle.DangerousGetHandle(), IntPtr.Zero, WaveInterop.WaveInOutOpenFlags.CallbackEvent), _0015(107390427));
		CreateBuffers();
	}

	public void StartRecording()
	{
		if (recording)
		{
			throw new InvalidOperationException(_0015(107390442));
		}
		OpenWaveInDevice();
		MmException.Try(WaveInterop.waveInStart(waveInHandle), _0015(107390385));
		recording = true;
		ThreadPool.QueueUserWorkItem(delegate
		{
			RecordThread();
		}, null);
	}

	private void RecordThread()
	{
		Exception e = null;
		try
		{
			DoRecording();
		}
		catch (Exception ex)
		{
			e = ex;
		}
		finally
		{
			recording = false;
			RaiseRecordingStoppedEvent(e);
		}
	}

	private void DoRecording()
	{
		WaveInBuffer[] array = buffers;
		foreach (WaveInBuffer waveInBuffer in array)
		{
			if (!waveInBuffer.InQueue)
			{
				waveInBuffer.Reuse();
			}
		}
		while (recording)
		{
			if (!callbackEvent.WaitOne() || !recording)
			{
				continue;
			}
			array = buffers;
			foreach (WaveInBuffer waveInBuffer2 in array)
			{
				if (waveInBuffer2.Done)
				{
					if (this.DataAvailable != null)
					{
						this.DataAvailable(this, new WaveInEventArgs(waveInBuffer2.Data, waveInBuffer2.BytesRecorded));
					}
					waveInBuffer2.Reuse();
				}
			}
		}
	}

	private void RaiseRecordingStoppedEvent(Exception e)
	{
		EventHandler<StoppedEventArgs> handler = this.RecordingStopped;
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

	public void StopRecording()
	{
		recording = false;
		callbackEvent.Set();
		MmException.Try(WaveInterop.waveInStop(waveInHandle), _0015(107390400));
	}

	protected virtual void Dispose(bool disposing)
	{
		if (disposing)
		{
			if (recording)
			{
				StopRecording();
			}
			CloseWaveInDevice();
		}
	}

	private void CloseWaveInDevice()
	{
		WaveInterop.waveInReset(waveInHandle);
		if (buffers != null)
		{
			for (int i = 0; i < buffers.Length; i++)
			{
				buffers[i].Dispose();
			}
			buffers = null;
		}
		WaveInterop.waveInClose(waveInHandle);
		waveInHandle = IntPtr.Zero;
	}

	public MixerLine GetMixerLine()
	{
		if (waveInHandle != IntPtr.Zero)
		{
			return new MixerLine(waveInHandle, 0, MixerFlags.WaveInHandle);
		}
		return new MixerLine((IntPtr)DeviceNumber, 0, MixerFlags.WaveIn);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	static WaveInEvent()
	{
		Strings.CreateGetStringDelegate(typeof(WaveInEvent));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0015(107397661), _0015(107397624)), _0015(107397619), _0015(107397614)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0015(107397641)))
		{
			return;
		}
		throw new SecurityException(_0015(107397584));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
