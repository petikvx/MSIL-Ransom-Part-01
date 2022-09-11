using System;
using System.Runtime.InteropServices;
using System.Threading;
using NAudio.Wave;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.CoreAudioApi;

public class WasapiCapture : IDisposable, IWaveIn
{
	private const long ReftimesPerSec = 10000000L;

	private const long ReftimesPerMillisec = 10000L;

	private volatile CaptureState captureState;

	private byte[] recordBuffer;

	private Thread captureThread;

	private AudioClient audioClient;

	private int bytesPerFrame;

	private WaveFormat waveFormat;

	private bool initialized;

	private readonly SynchronizationContext syncContext;

	private readonly bool isUsingEventSync;

	private EventWaitHandle frameEventWaitHandle;

	private readonly int audioBufferMillisecondsLength;

	[NonSerialized]
	internal static GetString _0007;

	public AudioClientShareMode ShareMode { get; set; }

	public CaptureState CaptureState => captureState;

	public virtual WaveFormat WaveFormat
	{
		get
		{
			return waveFormat.AsStandardWaveFormat();
		}
		set
		{
			waveFormat = value;
		}
	}

	public event EventHandler<WaveInEventArgs> DataAvailable;

	public event EventHandler<StoppedEventArgs> RecordingStopped;

	public WasapiCapture()
		: this(GetDefaultCaptureDevice())
	{
	}

	public WasapiCapture(MMDevice captureDevice)
		: this(captureDevice, useEventSync: false)
	{
	}

	public WasapiCapture(MMDevice captureDevice, bool useEventSync)
		: this(captureDevice, useEventSync, 100)
	{
	}

	public WasapiCapture(MMDevice captureDevice, bool useEventSync, int audioBufferMillisecondsLength)
	{
		syncContext = SynchronizationContext.Current;
		audioClient = captureDevice.AudioClient;
		ShareMode = AudioClientShareMode.Shared;
		isUsingEventSync = useEventSync;
		this.audioBufferMillisecondsLength = audioBufferMillisecondsLength;
		waveFormat = audioClient.MixFormat;
	}

	public static MMDevice GetDefaultCaptureDevice()
	{
		return new MMDeviceEnumerator().GetDefaultAudioEndpoint(DataFlow.Capture, Role.Console);
	}

	private void InitializeCaptureDevice()
	{
		if (initialized)
		{
			return;
		}
		long num = 10000L * (long)audioBufferMillisecondsLength;
		if (!audioClient.IsFormatSupported(ShareMode, waveFormat))
		{
			throw new ArgumentException(_0007(107401686));
		}
		AudioClientStreamFlags audioClientStreamFlags = GetAudioClientStreamFlags();
		if (isUsingEventSync)
		{
			if (ShareMode == AudioClientShareMode.Shared)
			{
				audioClient.Initialize(ShareMode, AudioClientStreamFlags.EventCallback | audioClientStreamFlags, num, 0L, waveFormat, Guid.Empty);
			}
			else
			{
				audioClient.Initialize(ShareMode, AudioClientStreamFlags.EventCallback | audioClientStreamFlags, num, num, waveFormat, Guid.Empty);
			}
			frameEventWaitHandle = new EventWaitHandle(initialState: false, EventResetMode.AutoReset);
			audioClient.SetEventHandle(frameEventWaitHandle.SafeWaitHandle.DangerousGetHandle());
		}
		else
		{
			audioClient.Initialize(ShareMode, audioClientStreamFlags, num, 0L, waveFormat, Guid.Empty);
		}
		int bufferSize = audioClient.BufferSize;
		bytesPerFrame = waveFormat.Channels * waveFormat.BitsPerSample / 8;
		recordBuffer = new byte[bufferSize * bytesPerFrame];
		initialized = true;
	}

	protected virtual AudioClientStreamFlags GetAudioClientStreamFlags()
	{
		return AudioClientStreamFlags.None;
	}

	public void StartRecording()
	{
		if (captureState != 0)
		{
			throw new InvalidOperationException(_0007(107401653));
		}
		captureState = CaptureState.Starting;
		InitializeCaptureDevice();
		ThreadStart start = delegate
		{
			CaptureThread(audioClient);
		};
		captureThread = new Thread(start);
		captureThread.Start();
	}

	public void StopRecording()
	{
		if (captureState != 0)
		{
			captureState = CaptureState.Stopping;
		}
	}

	private void CaptureThread(AudioClient client)
	{
		Exception e = null;
		try
		{
			DoRecording(client);
		}
		catch (Exception ex)
		{
			e = ex;
		}
		finally
		{
			client.Stop();
		}
		captureThread = null;
		captureState = CaptureState.Stopped;
		RaiseRecordingStopped(e);
	}

	private void DoRecording(AudioClient client)
	{
		int bufferSize = client.BufferSize;
		long num = (long)(10000000.0 * (double)bufferSize / (double)waveFormat.SampleRate);
		int millisecondsTimeout = (int)(num / 10000 / 2);
		int millisecondsTimeout2 = (int)(3 * num / 10000);
		AudioCaptureClient audioCaptureClient = client.AudioCaptureClient;
		client.Start();
		captureState = CaptureState.Capturing;
		while (captureState == CaptureState.Capturing)
		{
			bool flag = true;
			if (isUsingEventSync)
			{
				flag = frameEventWaitHandle.WaitOne(millisecondsTimeout2, exitContext: false);
			}
			else
			{
				Thread.Sleep(millisecondsTimeout);
			}
			if (captureState == CaptureState.Capturing)
			{
				if (flag)
				{
					ReadNextPacket(audioCaptureClient);
				}
				continue;
			}
			break;
		}
	}

	private void RaiseRecordingStopped(Exception e)
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

	private void ReadNextPacket(AudioCaptureClient capture)
	{
		int nextPacketSize = capture.GetNextPacketSize();
		int num = 0;
		while (nextPacketSize != 0)
		{
			int numFramesToRead;
			AudioClientBufferFlags bufferFlags;
			IntPtr buffer = capture.GetBuffer(out numFramesToRead, out bufferFlags);
			int num2 = numFramesToRead * bytesPerFrame;
			if (Math.Max(0, recordBuffer.Length - num) < num2 && num > 0)
			{
				if (this.DataAvailable != null)
				{
					this.DataAvailable(this, new WaveInEventArgs(recordBuffer, num));
				}
				num = 0;
			}
			if ((bufferFlags & AudioClientBufferFlags.Silent) != AudioClientBufferFlags.Silent)
			{
				Marshal.Copy(buffer, recordBuffer, num, num2);
			}
			else
			{
				Array.Clear(recordBuffer, num, num2);
			}
			num += num2;
			capture.ReleaseBuffer(numFramesToRead);
			nextPacketSize = capture.GetNextPacketSize();
		}
		if (this.DataAvailable != null)
		{
			this.DataAvailable(this, new WaveInEventArgs(recordBuffer, num));
		}
	}

	public void Dispose()
	{
		StopRecording();
		if (captureThread != null)
		{
			captureThread.Join();
			captureThread = null;
		}
		if (audioClient != null)
		{
			audioClient.Dispose();
			audioClient = null;
		}
	}

	static WasapiCapture()
	{
		Strings.CreateGetStringDelegate(typeof(WasapiCapture));
	}
}
