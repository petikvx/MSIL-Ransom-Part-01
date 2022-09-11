using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using NAudio.CoreAudioApi.Interfaces;
using NAudio.Utils;
using NAudio.Wave;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.CoreAudioApi;

public sealed class AudioClient : IDisposable
{
	private IAudioClient audioClientInterface;

	private WaveFormat mixFormat;

	private AudioRenderClient audioRenderClient;

	private AudioCaptureClient audioCaptureClient;

	private AudioClockClient audioClockClient;

	private AudioStreamVolume audioStreamVolume;

	private AudioClientShareMode shareMode;

	[NonSerialized]
	internal static GetString _0083;

	public WaveFormat MixFormat
	{
		get
		{
			if (mixFormat == null)
			{
				Marshal.ThrowExceptionForHR(audioClientInterface.GetMixFormat(out var deviceFormatPointer));
				WaveFormat waveFormat = WaveFormat.MarshalFromPtr(deviceFormatPointer);
				Marshal.FreeCoTaskMem(deviceFormatPointer);
				mixFormat = waveFormat;
			}
			return mixFormat;
		}
	}

	public int BufferSize
	{
		get
		{
			Marshal.ThrowExceptionForHR(audioClientInterface.GetBufferSize(out var bufferSize));
			return (int)bufferSize;
		}
	}

	public long StreamLatency => audioClientInterface.GetStreamLatency();

	public int CurrentPadding
	{
		get
		{
			Marshal.ThrowExceptionForHR(audioClientInterface.GetCurrentPadding(out var currentPadding));
			return currentPadding;
		}
	}

	public long DefaultDevicePeriod
	{
		get
		{
			Marshal.ThrowExceptionForHR(audioClientInterface.GetDevicePeriod(out var defaultDevicePeriod, out var _));
			return defaultDevicePeriod;
		}
	}

	public long MinimumDevicePeriod
	{
		get
		{
			Marshal.ThrowExceptionForHR(audioClientInterface.GetDevicePeriod(out var _, out var minimumDevicePeriod));
			return minimumDevicePeriod;
		}
	}

	public AudioStreamVolume AudioStreamVolume
	{
		get
		{
			if (shareMode == AudioClientShareMode.Exclusive)
			{
				throw new InvalidOperationException(_0083(107390555));
			}
			if (audioStreamVolume == null)
			{
				Guid interfaceId = new Guid(_0083(107404133));
				Marshal.ThrowExceptionForHR(audioClientInterface.GetService(interfaceId, out var interfacePointer));
				audioStreamVolume = new AudioStreamVolume((IAudioStreamVolume)interfacePointer);
			}
			return audioStreamVolume;
		}
	}

	public AudioClockClient AudioClockClient
	{
		get
		{
			if (audioClockClient == null)
			{
				Guid interfaceId = new Guid(_0083(107404116));
				Marshal.ThrowExceptionForHR(audioClientInterface.GetService(interfaceId, out var interfacePointer));
				audioClockClient = new AudioClockClient((IAudioClock)interfacePointer);
			}
			return audioClockClient;
		}
	}

	public AudioRenderClient AudioRenderClient
	{
		get
		{
			if (audioRenderClient == null)
			{
				Guid interfaceId = new Guid(_0083(107404035));
				Marshal.ThrowExceptionForHR(audioClientInterface.GetService(interfaceId, out var interfacePointer));
				audioRenderClient = new AudioRenderClient((IAudioRenderClient)interfacePointer);
			}
			return audioRenderClient;
		}
	}

	public AudioCaptureClient AudioCaptureClient
	{
		get
		{
			if (audioCaptureClient == null)
			{
				Guid interfaceId = new Guid(_0083(107404530));
				Marshal.ThrowExceptionForHR(audioClientInterface.GetService(interfaceId, out var interfacePointer));
				audioCaptureClient = new AudioCaptureClient((IAudioCaptureClient)interfacePointer);
			}
			return audioCaptureClient;
		}
	}

	internal AudioClient(IAudioClient audioClientInterface)
	{
		this.audioClientInterface = audioClientInterface;
	}

	public void Initialize(AudioClientShareMode shareMode, AudioClientStreamFlags streamFlags, long bufferDuration, long periodicity, WaveFormat waveFormat, Guid audioSessionGuid)
	{
		this.shareMode = shareMode;
		Marshal.ThrowExceptionForHR(audioClientInterface.Initialize(shareMode, streamFlags, bufferDuration, periodicity, waveFormat, ref audioSessionGuid));
		mixFormat = null;
	}

	public bool IsFormatSupported(AudioClientShareMode shareMode, WaveFormat desiredFormat)
	{
		WaveFormatExtensible closestMatchFormat;
		return IsFormatSupported(shareMode, desiredFormat, out closestMatchFormat);
	}

	private IntPtr GetPointerToPointer()
	{
		return Marshal.AllocHGlobal(MarshalHelpers.SizeOf<IntPtr>());
	}

	public bool IsFormatSupported(AudioClientShareMode shareMode, WaveFormat desiredFormat, out WaveFormatExtensible closestMatchFormat)
	{
		IntPtr pointerToPointer = GetPointerToPointer();
		closestMatchFormat = null;
		int num = audioClientInterface.IsFormatSupported(shareMode, desiredFormat, pointerToPointer);
		IntPtr intPtr = MarshalHelpers.PtrToStructure<IntPtr>(pointerToPointer);
		if (intPtr != IntPtr.Zero)
		{
			closestMatchFormat = MarshalHelpers.PtrToStructure<WaveFormatExtensible>(intPtr);
			Marshal.FreeCoTaskMem(intPtr);
		}
		Marshal.FreeHGlobal(pointerToPointer);
		switch (num)
		{
		case 0:
			return true;
		case 1:
			return false;
		case -2004287480:
			return shareMode != AudioClientShareMode.Exclusive;
		default:
			Marshal.ThrowExceptionForHR(num);
			throw new NotSupportedException(_0083(107404449) + num);
		}
	}

	public void Start()
	{
		audioClientInterface.Start();
	}

	public void Stop()
	{
		audioClientInterface.Stop();
	}

	public void SetEventHandle(IntPtr eventWaitHandle)
	{
		audioClientInterface.SetEventHandle(eventWaitHandle);
	}

	public void Reset()
	{
		audioClientInterface.Reset();
	}

	public void Dispose()
	{
		if (audioClientInterface != null)
		{
			if (audioClockClient != null)
			{
				audioClockClient.Dispose();
				audioClockClient = null;
			}
			if (audioRenderClient != null)
			{
				audioRenderClient.Dispose();
				audioRenderClient = null;
			}
			if (audioCaptureClient != null)
			{
				audioCaptureClient.Dispose();
				audioCaptureClient = null;
			}
			if (audioStreamVolume != null)
			{
				audioStreamVolume.Dispose();
				audioStreamVolume = null;
			}
			Marshal.ReleaseComObject(audioClientInterface);
			audioClientInterface = null;
			GC.SuppressFinalize(this);
		}
	}

	static AudioClient()
	{
		Strings.CreateGetStringDelegate(typeof(AudioClient));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0083(107400048), _0083(107400011)), _0083(107400006), _0083(107400001)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0083(107400028)))
		{
			return;
		}
		throw new SecurityException(_0083(107399971));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
