using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave;

public sealed class DirectSoundOut : IDisposable, IWavePlayer
{
	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	internal sealed class BufferDescription
	{
		public int dwSize;

		[MarshalAs(UnmanagedType.U4)]
		public DirectSoundBufferCaps dwFlags;

		public uint dwBufferBytes;

		public int dwReserved;

		public IntPtr lpwfxFormat;

		public Guid guidAlgo;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	internal sealed class BufferCaps
	{
		public int dwSize;

		public int dwFlags;

		public int dwBufferBytes;

		public int dwUnlockTransferRate;

		public int dwPlayCpuOverhead;

		[NonSerialized]
		internal static GetString _0087;

		static BufferCaps()
		{
			Strings.CreateGetStringDelegate(typeof(BufferCaps));
			bool flag = false;
			Assembly assembly = global::_0005._001B();
			Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0087(107398189), _0087(107398152)), _0087(107398147), _0087(107398142)));
			if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0087(107398169)))
			{
				return;
			}
			throw new SecurityException(_0087(107398112));
		}

		[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
	}

	internal enum DirectSoundCooperativeLevel : uint
	{
		DSSCL_NORMAL = 1u,
		DSSCL_PRIORITY,
		DSSCL_EXCLUSIVE,
		DSSCL_WRITEPRIMARY
	}

	[Flags]
	internal enum DirectSoundPlayFlags : uint
	{
		DSBPLAY_LOOPING = 1u,
		DSBPLAY_LOCHARDWARE = 2u,
		DSBPLAY_LOCSOFTWARE = 4u,
		DSBPLAY_TERMINATEBY_TIME = 8u,
		DSBPLAY_TERMINATEBY_DISTANCE = 0x10u,
		DSBPLAY_TERMINATEBY_PRIORITY = 0x20u
	}

	internal enum DirectSoundBufferLockFlag : uint
	{
		None,
		FromWriteCursor,
		EntireBuffer
	}

	[Flags]
	internal enum DirectSoundBufferStatus : uint
	{
		DSBSTATUS_PLAYING = 1u,
		DSBSTATUS_BUFFERLOST = 2u,
		DSBSTATUS_LOOPING = 4u,
		DSBSTATUS_LOCHARDWARE = 8u,
		DSBSTATUS_LOCSOFTWARE = 0x10u,
		DSBSTATUS_TERMINATED = 0x20u
	}

	[Flags]
	internal enum DirectSoundBufferCaps : uint
	{
		DSBCAPS_PRIMARYBUFFER = 1u,
		DSBCAPS_STATIC = 2u,
		DSBCAPS_LOCHARDWARE = 4u,
		DSBCAPS_LOCSOFTWARE = 8u,
		DSBCAPS_CTRL3D = 0x10u,
		DSBCAPS_CTRLFREQUENCY = 0x20u,
		DSBCAPS_CTRLPAN = 0x40u,
		DSBCAPS_CTRLVOLUME = 0x80u,
		DSBCAPS_CTRLPOSITIONNOTIFY = 0x100u,
		DSBCAPS_CTRLFX = 0x200u,
		DSBCAPS_STICKYFOCUS = 0x4000u,
		DSBCAPS_GLOBALFOCUS = 0x8000u,
		DSBCAPS_GETCURRENTPOSITION2 = 0x10000u,
		DSBCAPS_MUTE3DATMAXDISTANCE = 0x20000u,
		DSBCAPS_LOCDEFER = 0x40000u
	}

	internal struct DirectSoundBufferPositionNotify
	{
		public uint dwOffset;

		public IntPtr hEventNotify;
	}

	[ComImport]
	[Guid("279AFA83-4981-11CE-A521-0020AF0BE560")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[SuppressUnmanagedCodeSecurity]
	internal interface IDirectSound
	{
		void CreateSoundBuffer([In] BufferDescription desc, [MarshalAs(UnmanagedType.Interface)] out object dsDSoundBuffer, IntPtr pUnkOuter);

		void GetCaps(IntPtr caps);

		void DuplicateSoundBuffer([In][MarshalAs(UnmanagedType.Interface)] IDirectSoundBuffer bufferOriginal, [In][MarshalAs(UnmanagedType.Interface)] IDirectSoundBuffer bufferDuplicate);

		void SetCooperativeLevel(IntPtr HWND, [In][MarshalAs(UnmanagedType.U4)] DirectSoundCooperativeLevel dwLevel);

		void Compact();

		void GetSpeakerConfig(IntPtr pdwSpeakerConfig);

		void SetSpeakerConfig(uint pdwSpeakerConfig);

		void Initialize([In][MarshalAs(UnmanagedType.LPStruct)] Guid guid);
	}

	[ComImport]
	[Guid("279AFA85-4981-11CE-A521-0020AF0BE560")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[SuppressUnmanagedCodeSecurity]
	internal interface IDirectSoundBuffer
	{
		void GetCaps([MarshalAs(UnmanagedType.LPStruct)] BufferCaps pBufferCaps);

		void GetCurrentPosition(out uint currentPlayCursor, out uint currentWriteCursor);

		void GetFormat();

		[return: MarshalAs(UnmanagedType.I4)]
		int GetVolume();

		void GetPan(out uint pan);

		[return: MarshalAs(UnmanagedType.I4)]
		int GetFrequency();

		[return: MarshalAs(UnmanagedType.U4)]
		DirectSoundBufferStatus GetStatus();

		void Initialize([In][MarshalAs(UnmanagedType.Interface)] IDirectSound directSound, [In] BufferDescription desc);

		void Lock(int dwOffset, uint dwBytes, out IntPtr audioPtr1, out int audioBytes1, out IntPtr audioPtr2, out int audioBytes2, [MarshalAs(UnmanagedType.U4)] DirectSoundBufferLockFlag dwFlags);

		void Play(uint dwReserved1, uint dwPriority, [In][MarshalAs(UnmanagedType.U4)] DirectSoundPlayFlags dwFlags);

		void SetCurrentPosition(uint dwNewPosition);

		void SetFormat([In] WaveFormat pcfxFormat);

		void SetVolume(int volume);

		void SetPan(uint pan);

		void SetFrequency(uint frequency);

		void Stop();

		void Unlock(IntPtr pvAudioPtr1, int dwAudioBytes1, IntPtr pvAudioPtr2, int dwAudioBytes2);

		void Restore();
	}

	[ComImport]
	[Guid("b0210783-89cd-11d0-af08-00a0c925cd16")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[SuppressUnmanagedCodeSecurity]
	internal interface IDirectSoundNotify
	{
		void SetNotificationPositions(uint dwPositionNotifies, [In][MarshalAs(UnmanagedType.LPArray)] DirectSoundBufferPositionNotify[] pcPositionNotifies);
	}

	private delegate bool DSEnumCallback(IntPtr lpGuid, IntPtr lpcstrDescription, IntPtr lpcstrModule, IntPtr lpContext);

	private PlaybackState playbackState;

	private WaveFormat waveFormat;

	private int samplesTotalSize;

	private int samplesFrameSize;

	private int nextSamplesWriteIndex;

	private int desiredLatency;

	private Guid device;

	private byte[] samples;

	private IWaveProvider waveStream;

	private IDirectSound directSound;

	private IDirectSoundBuffer primarySoundBuffer;

	private IDirectSoundBuffer secondaryBuffer;

	private EventWaitHandle frameEventWaitHandle1;

	private EventWaitHandle frameEventWaitHandle2;

	private EventWaitHandle endEventWaitHandle;

	private Thread notifyThread;

	private SynchronizationContext syncContext;

	private long bytesPlayed;

	private object m_LockObject = new object();

	private static List<DirectSoundDeviceInfo> devices;

	public static readonly Guid DSDEVID_DefaultPlayback;

	public static readonly Guid DSDEVID_DefaultCapture;

	public static readonly Guid DSDEVID_DefaultVoicePlayback;

	public static readonly Guid DSDEVID_DefaultVoiceCapture;

	[NonSerialized]
	internal static GetString _009D;

	public static IEnumerable<DirectSoundDeviceInfo> Devices
	{
		get
		{
			devices = new List<DirectSoundDeviceInfo>();
			DirectSoundEnumerate(EnumCallback, IntPtr.Zero);
			return devices;
		}
	}

	public TimeSpan PlaybackPosition => TimeSpan.FromMilliseconds((double)(GetPosition() / (waveFormat.Channels * waveFormat.BitsPerSample / 8)) * 1000.0 / (double)waveFormat.SampleRate);

	public PlaybackState PlaybackState => playbackState;

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
				throw new InvalidOperationException(_009D(107389178));
			}
		}
	}

	public event EventHandler<StoppedEventArgs> PlaybackStopped;

	private static bool EnumCallback(IntPtr lpGuid, IntPtr lpcstrDescription, IntPtr lpcstrModule, IntPtr lpContext)
	{
		DirectSoundDeviceInfo directSoundDeviceInfo = new DirectSoundDeviceInfo();
		if (lpGuid == IntPtr.Zero)
		{
			directSoundDeviceInfo.Guid = Guid.Empty;
		}
		else
		{
			byte[] array = new byte[16];
			Marshal.Copy(lpGuid, array, 0, 16);
			directSoundDeviceInfo.Guid = new Guid(array);
		}
		directSoundDeviceInfo.Description = Marshal.PtrToStringAnsi(lpcstrDescription);
		directSoundDeviceInfo.ModuleName = Marshal.PtrToStringAnsi(lpcstrModule);
		devices.Add(directSoundDeviceInfo);
		return true;
	}

	public DirectSoundOut()
		: this(DSDEVID_DefaultPlayback)
	{
	}

	public DirectSoundOut(Guid device)
		: this(device, 40)
	{
	}

	public DirectSoundOut(int latency)
		: this(DSDEVID_DefaultPlayback, latency)
	{
	}

	public DirectSoundOut(Guid device, int latency)
	{
		if (device == Guid.Empty)
		{
			device = DSDEVID_DefaultPlayback;
		}
		this.device = device;
		desiredLatency = latency;
		syncContext = SynchronizationContext.Current;
	}

	~DirectSoundOut()
	{
		Dispose();
	}

	public void Play()
	{
		if (playbackState == PlaybackState.Stopped)
		{
			notifyThread = new Thread(PlaybackThreadFunc);
			notifyThread.Priority = ThreadPriority.Normal;
			notifyThread.IsBackground = true;
			notifyThread.Start();
		}
		lock (m_LockObject)
		{
			playbackState = PlaybackState.Playing;
		}
	}

	public void Stop()
	{
		if (Monitor.TryEnter(m_LockObject, 50))
		{
			playbackState = PlaybackState.Stopped;
			Monitor.Exit(m_LockObject);
		}
		else if (notifyThread != null)
		{
			notifyThread.Abort();
			notifyThread = null;
		}
	}

	public void Pause()
	{
		lock (m_LockObject)
		{
			playbackState = PlaybackState.Paused;
		}
	}

	public long GetPosition()
	{
		if (playbackState != 0)
		{
			IDirectSoundBuffer directSoundBuffer = secondaryBuffer;
			if (directSoundBuffer != null)
			{
				directSoundBuffer.GetCurrentPosition(out var currentPlayCursor, out var _);
				return currentPlayCursor + bytesPlayed;
			}
		}
		return 0L;
	}

	public void Init(IWaveProvider waveProvider)
	{
		waveStream = waveProvider;
		waveFormat = waveProvider.WaveFormat;
	}

	private void InitializeDirectSound()
	{
		lock (m_LockObject)
		{
			directSound = null;
			DirectSoundCreate(ref device, out directSound, IntPtr.Zero);
			if (directSound != null)
			{
				directSound.SetCooperativeLevel(GetDesktopWindow(), DirectSoundCooperativeLevel.DSSCL_PRIORITY);
				BufferDescription bufferDescription = new BufferDescription();
				bufferDescription.dwSize = Marshal.SizeOf((object)bufferDescription);
				bufferDescription.dwBufferBytes = 0u;
				bufferDescription.dwFlags = DirectSoundBufferCaps.DSBCAPS_PRIMARYBUFFER;
				bufferDescription.dwReserved = 0;
				bufferDescription.lpwfxFormat = IntPtr.Zero;
				bufferDescription.guidAlgo = Guid.Empty;
				directSound.CreateSoundBuffer(bufferDescription, out var dsDSoundBuffer, IntPtr.Zero);
				primarySoundBuffer = (IDirectSoundBuffer)dsDSoundBuffer;
				primarySoundBuffer.Play(0u, 0u, DirectSoundPlayFlags.DSBPLAY_LOOPING);
				samplesFrameSize = MsToBytes(desiredLatency);
				BufferDescription bufferDescription2 = new BufferDescription();
				bufferDescription2.dwSize = Marshal.SizeOf((object)bufferDescription2);
				bufferDescription2.dwBufferBytes = (uint)(samplesFrameSize * 2);
				bufferDescription2.dwFlags = DirectSoundBufferCaps.DSBCAPS_CTRLVOLUME | DirectSoundBufferCaps.DSBCAPS_CTRLPOSITIONNOTIFY | DirectSoundBufferCaps.DSBCAPS_STICKYFOCUS | DirectSoundBufferCaps.DSBCAPS_GLOBALFOCUS | DirectSoundBufferCaps.DSBCAPS_GETCURRENTPOSITION2;
				bufferDescription2.dwReserved = 0;
				GCHandle gCHandle = GCHandle.Alloc(waveFormat, GCHandleType.Pinned);
				bufferDescription2.lpwfxFormat = gCHandle.AddrOfPinnedObject();
				bufferDescription2.guidAlgo = Guid.Empty;
				directSound.CreateSoundBuffer(bufferDescription2, out dsDSoundBuffer, IntPtr.Zero);
				secondaryBuffer = (IDirectSoundBuffer)dsDSoundBuffer;
				gCHandle.Free();
				BufferCaps bufferCaps = new BufferCaps();
				bufferCaps.dwSize = Marshal.SizeOf((object)bufferCaps);
				secondaryBuffer.GetCaps(bufferCaps);
				nextSamplesWriteIndex = 0;
				samplesTotalSize = bufferCaps.dwBufferBytes;
				samples = new byte[samplesTotalSize];
				IDirectSoundNotify obj = (IDirectSoundNotify)dsDSoundBuffer;
				frameEventWaitHandle1 = new EventWaitHandle(initialState: false, EventResetMode.AutoReset);
				frameEventWaitHandle2 = new EventWaitHandle(initialState: false, EventResetMode.AutoReset);
				endEventWaitHandle = new EventWaitHandle(initialState: false, EventResetMode.AutoReset);
				DirectSoundBufferPositionNotify[] array = new DirectSoundBufferPositionNotify[3]
				{
					default(DirectSoundBufferPositionNotify),
					default(DirectSoundBufferPositionNotify),
					default(DirectSoundBufferPositionNotify)
				};
				array[0].dwOffset = 0u;
				array[0].hEventNotify = frameEventWaitHandle1.SafeWaitHandle.DangerousGetHandle();
				array[1] = default(DirectSoundBufferPositionNotify);
				array[1].dwOffset = (uint)samplesFrameSize;
				array[1].hEventNotify = frameEventWaitHandle2.SafeWaitHandle.DangerousGetHandle();
				array[2] = default(DirectSoundBufferPositionNotify);
				array[2].dwOffset = uint.MaxValue;
				array[2].hEventNotify = endEventWaitHandle.SafeWaitHandle.DangerousGetHandle();
				obj.SetNotificationPositions(3u, array);
			}
		}
	}

	public void Dispose()
	{
		Stop();
		GC.SuppressFinalize(this);
	}

	private bool IsBufferLost()
	{
		if ((secondaryBuffer.GetStatus() & DirectSoundBufferStatus.DSBSTATUS_BUFFERLOST) == 0)
		{
			return false;
		}
		return true;
	}

	private int MsToBytes(int ms)
	{
		int num = ms * (waveFormat.AverageBytesPerSecond / 1000);
		return num - num % waveFormat.BlockAlign;
	}

	private void PlaybackThreadFunc()
	{
		bool flag = false;
		bool flag2 = false;
		bytesPlayed = 0L;
		Exception ex = null;
		try
		{
			InitializeDirectSound();
			int num = 1;
			if (PlaybackState == PlaybackState.Stopped)
			{
				secondaryBuffer.SetCurrentPosition(0u);
				nextSamplesWriteIndex = 0;
				num = Feed(samplesTotalSize);
			}
			if (num <= 0)
			{
				return;
			}
			lock (m_LockObject)
			{
				playbackState = PlaybackState.Playing;
			}
			secondaryBuffer.Play(0u, 0u, DirectSoundPlayFlags.DSBPLAY_LOOPING);
			WaitHandle[] waitHandles = new WaitHandle[3] { frameEventWaitHandle1, frameEventWaitHandle2, endEventWaitHandle };
			bool flag3 = true;
			while (PlaybackState != PlaybackState.Stopped && flag3)
			{
				int num2 = WaitHandle.WaitAny(waitHandles, 3 * desiredLatency, exitContext: false);
				if (num2 != 258)
				{
					switch (num2)
					{
					case 2:
						StopPlayback();
						flag = true;
						flag3 = false;
						continue;
					case 0:
						if (flag2)
						{
							bytesPlayed += samplesFrameSize * 2;
						}
						break;
					default:
						flag2 = true;
						break;
					}
					num2 = ((num2 == 0) ? 1 : 0);
					nextSamplesWriteIndex = num2 * samplesFrameSize;
					if (Feed(samplesFrameSize) == 0)
					{
						StopPlayback();
						flag = true;
						flag3 = false;
					}
					continue;
				}
				StopPlayback();
				flag = true;
				flag3 = false;
				throw new Exception(_009D(107388536));
			}
		}
		catch (Exception ex2)
		{
			ex = ex2;
		}
		finally
		{
			if (!flag)
			{
				try
				{
					StopPlayback();
				}
				catch (Exception ex3)
				{
					if (ex == null)
					{
						ex = ex3;
					}
				}
			}
			lock (m_LockObject)
			{
				playbackState = PlaybackState.Stopped;
			}
			bytesPlayed = 0L;
			RaisePlaybackStopped(ex);
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

	private void StopPlayback()
	{
		lock (m_LockObject)
		{
			if (secondaryBuffer != null)
			{
				secondaryBuffer.Stop();
				secondaryBuffer = null;
			}
			if (primarySoundBuffer != null)
			{
				primarySoundBuffer.Stop();
				primarySoundBuffer = null;
			}
		}
	}

	private int Feed(int bytesToCopy)
	{
		int num = bytesToCopy;
		if (IsBufferLost())
		{
			secondaryBuffer.Restore();
		}
		if (playbackState == PlaybackState.Paused)
		{
			Array.Clear(samples, 0, samples.Length);
		}
		else
		{
			num = waveStream.Read(samples, 0, bytesToCopy);
			if (num == 0)
			{
				Array.Clear(samples, 0, samples.Length);
				return 0;
			}
		}
		secondaryBuffer.Lock(nextSamplesWriteIndex, (uint)num, out var audioPtr, out var audioBytes, out var audioPtr2, out var audioBytes2, DirectSoundBufferLockFlag.None);
		if (audioPtr != IntPtr.Zero)
		{
			Marshal.Copy(samples, 0, audioPtr, audioBytes);
			if (audioPtr2 != IntPtr.Zero)
			{
				Marshal.Copy(samples, 0, audioPtr, audioBytes);
			}
		}
		secondaryBuffer.Unlock(audioPtr, audioBytes, audioPtr2, audioBytes2);
		return num;
	}

	[DllImport("dsound.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	private static extern void DirectSoundCreate(ref Guid GUID, [MarshalAs(UnmanagedType.Interface)] out IDirectSound directSound, IntPtr pUnkOuter);

	[DllImport("dsound.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, EntryPoint = "DirectSoundEnumerateA", ExactSpelling = true, SetLastError = true)]
	private static extern void DirectSoundEnumerate(DSEnumCallback lpDSEnumCallback, IntPtr lpContext);

	[DllImport("user32.dll")]
	private static extern IntPtr GetDesktopWindow();

	static DirectSoundOut()
	{
		Strings.CreateGetStringDelegate(typeof(DirectSoundOut));
		DSDEVID_DefaultPlayback = new Guid(_009D(107388499));
		DSDEVID_DefaultCapture = new Guid(_009D(107388482));
		DSDEVID_DefaultVoicePlayback = new Guid(_009D(107388401));
		DSDEVID_DefaultVoiceCapture = new Guid(_009D(107388384));
	}
}
