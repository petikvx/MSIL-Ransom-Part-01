using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using NAudio.CoreAudioApi.Interfaces;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.CoreAudioApi;

public sealed class AudioRenderClient : IDisposable
{
	private IAudioRenderClient audioRenderClientInterface;

	[NonSerialized]
	internal static GetString _0015;

	internal AudioRenderClient(IAudioRenderClient audioRenderClientInterface)
	{
		this.audioRenderClientInterface = audioRenderClientInterface;
	}

	public IntPtr GetBuffer(int numFramesRequested)
	{
		Marshal.ThrowExceptionForHR(audioRenderClientInterface.GetBuffer(numFramesRequested, out var dataBufferPointer));
		return dataBufferPointer;
	}

	public void ReleaseBuffer(int numFramesWritten, AudioClientBufferFlags bufferFlags)
	{
		Marshal.ThrowExceptionForHR(audioRenderClientInterface.ReleaseBuffer(numFramesWritten, bufferFlags));
	}

	public void Dispose()
	{
		if (audioRenderClientInterface != null)
		{
			Marshal.ReleaseComObject(audioRenderClientInterface);
			audioRenderClientInterface = null;
			GC.SuppressFinalize(this);
		}
	}

	static AudioRenderClient()
	{
		Strings.CreateGetStringDelegate(typeof(AudioRenderClient));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0015(107400087), _0015(107400050)), _0015(107400045), _0015(107400040)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0015(107400067)))
		{
			return;
		}
		throw new SecurityException(_0015(107400010));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
