using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave;

internal sealed class WaveInterop
{
	[Flags]
	public enum WaveInOutOpenFlags
	{
		CallbackNull = 0,
		CallbackFunction = 0x30000,
		CallbackEvent = 0x50000,
		CallbackWindow = 0x10000,
		CallbackThread = 0x20000
	}

	public enum WaveMessage
	{
		WaveInOpen = 958,
		WaveInClose = 959,
		WaveInData = 960,
		WaveOutClose = 956,
		WaveOutDone = 957,
		WaveOutOpen = 955
	}

	public delegate void WaveCallback(IntPtr hWaveOut, WaveMessage message, IntPtr dwInstance, WaveHeader wavhdr, IntPtr dwReserved);

	[NonSerialized]
	internal static GetString _0090;

	[DllImport("winmm.dll")]
	public static extern int mmioStringToFOURCC([MarshalAs(UnmanagedType.LPStr)] string s, int flags);

	[DllImport("winmm.dll")]
	public static extern int waveOutGetNumDevs();

	[DllImport("winmm.dll")]
	public static extern MmResult waveOutPrepareHeader(IntPtr hWaveOut, WaveHeader lpWaveOutHdr, int uSize);

	[DllImport("winmm.dll")]
	public static extern MmResult waveOutUnprepareHeader(IntPtr hWaveOut, WaveHeader lpWaveOutHdr, int uSize);

	[DllImport("winmm.dll")]
	public static extern MmResult waveOutWrite(IntPtr hWaveOut, WaveHeader lpWaveOutHdr, int uSize);

	[DllImport("winmm.dll")]
	public static extern MmResult waveOutOpen(out IntPtr hWaveOut, IntPtr uDeviceID, WaveFormat lpFormat, WaveCallback dwCallback, IntPtr dwInstance, WaveInOutOpenFlags dwFlags);

	[DllImport("winmm.dll", EntryPoint = "waveOutOpen")]
	public static extern MmResult waveOutOpenWindow(out IntPtr hWaveOut, IntPtr uDeviceID, WaveFormat lpFormat, IntPtr callbackWindowHandle, IntPtr dwInstance, WaveInOutOpenFlags dwFlags);

	[DllImport("winmm.dll")]
	public static extern MmResult waveOutReset(IntPtr hWaveOut);

	[DllImport("winmm.dll")]
	public static extern MmResult waveOutClose(IntPtr hWaveOut);

	[DllImport("winmm.dll")]
	public static extern MmResult waveOutPause(IntPtr hWaveOut);

	[DllImport("winmm.dll")]
	public static extern MmResult waveOutRestart(IntPtr hWaveOut);

	[DllImport("winmm.dll")]
	public static extern MmResult waveOutGetPosition(IntPtr hWaveOut, out MmTime mmTime, int uSize);

	[DllImport("winmm.dll")]
	public static extern MmResult waveOutSetVolume(IntPtr hWaveOut, int dwVolume);

	[DllImport("winmm.dll")]
	public static extern MmResult waveOutGetVolume(IntPtr hWaveOut, out int dwVolume);

	[DllImport("winmm.dll", CharSet = CharSet.Auto)]
	public static extern MmResult waveOutGetDevCaps(IntPtr deviceID, out WaveOutCapabilities waveOutCaps, int waveOutCapsSize);

	[DllImport("winmm.dll")]
	public static extern int waveInGetNumDevs();

	[DllImport("winmm.dll", CharSet = CharSet.Auto)]
	public static extern MmResult waveInGetDevCaps(IntPtr deviceID, out WaveInCapabilities waveInCaps, int waveInCapsSize);

	[DllImport("winmm.dll")]
	public static extern MmResult waveInAddBuffer(IntPtr hWaveIn, WaveHeader pwh, int cbwh);

	[DllImport("winmm.dll")]
	public static extern MmResult waveInClose(IntPtr hWaveIn);

	[DllImport("winmm.dll")]
	public static extern MmResult waveInOpen(out IntPtr hWaveIn, IntPtr uDeviceID, WaveFormat lpFormat, WaveCallback dwCallback, IntPtr dwInstance, WaveInOutOpenFlags dwFlags);

	[DllImport("winmm.dll", EntryPoint = "waveInOpen")]
	public static extern MmResult waveInOpenWindow(out IntPtr hWaveIn, IntPtr uDeviceID, WaveFormat lpFormat, IntPtr callbackWindowHandle, IntPtr dwInstance, WaveInOutOpenFlags dwFlags);

	[DllImport("winmm.dll")]
	public static extern MmResult waveInPrepareHeader(IntPtr hWaveIn, WaveHeader lpWaveInHdr, int uSize);

	[DllImport("winmm.dll")]
	public static extern MmResult waveInUnprepareHeader(IntPtr hWaveIn, WaveHeader lpWaveInHdr, int uSize);

	[DllImport("winmm.dll")]
	public static extern MmResult waveInReset(IntPtr hWaveIn);

	[DllImport("winmm.dll")]
	public static extern MmResult waveInStart(IntPtr hWaveIn);

	[DllImport("winmm.dll")]
	public static extern MmResult waveInStop(IntPtr hWaveIn);

	static WaveInterop()
	{
		Strings.CreateGetStringDelegate(typeof(WaveInterop));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0090(107397830), _0090(107397793)), _0090(107397788), _0090(107397783)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0090(107397810)))
		{
			return;
		}
		throw new SecurityException(_0090(107397753));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
