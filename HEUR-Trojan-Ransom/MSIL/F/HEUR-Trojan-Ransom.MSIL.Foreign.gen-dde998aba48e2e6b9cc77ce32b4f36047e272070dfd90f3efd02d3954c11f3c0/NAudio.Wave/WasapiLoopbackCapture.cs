using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using NAudio.CoreAudioApi;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave;

public sealed class WasapiLoopbackCapture : WasapiCapture
{
	[NonSerialized]
	internal static GetString _001B;

	public override WaveFormat WaveFormat
	{
		get
		{
			return base.WaveFormat;
		}
		set
		{
			throw new InvalidOperationException(_001B(107390084));
		}
	}

	public WasapiLoopbackCapture()
		: this(GetDefaultLoopbackCaptureDevice())
	{
	}

	public WasapiLoopbackCapture(MMDevice captureDevice)
		: base(captureDevice)
	{
	}

	public static MMDevice GetDefaultLoopbackCaptureDevice()
	{
		return new MMDeviceEnumerator().GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
	}

	protected override AudioClientStreamFlags GetAudioClientStreamFlags()
	{
		return AudioClientStreamFlags.Loopback;
	}

	static WasapiLoopbackCapture()
	{
		Strings.CreateGetStringDelegate(typeof(WasapiLoopbackCapture));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(global::_0007._007E_0087(global::_0007._007E_0087(_0006._007E_001C(assembly), _001B(107397775), _001B(107397738)), _001B(107397733), _001B(107397728)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _001B(107397755)))
		{
			return;
		}
		throw new SecurityException(_001B(107397698));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
