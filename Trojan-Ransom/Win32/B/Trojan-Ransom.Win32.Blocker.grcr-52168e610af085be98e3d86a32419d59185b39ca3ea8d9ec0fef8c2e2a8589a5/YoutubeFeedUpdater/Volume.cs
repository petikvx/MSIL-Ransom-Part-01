using System;
using System.Runtime.InteropServices;

namespace YoutubeFeedUpdater;

public static class Volume
{
	private const int int_0 = 21;

	private const int int_1 = 2;

	[DllImport("winmm.dll")]
	private static extern int waveOutGetVolume(IntPtr intptr_0, out uint uint_0);

	[DllImport("winmm.dll")]
	private static extern int waveOutSetVolume(IntPtr intptr_0, uint uint_0);

	[DllImport("urlmon.dll")]
	[return: MarshalAs(UnmanagedType.Error)]
	private static extern int CoInternetSetFeatureEnabled(int int_2, [MarshalAs(UnmanagedType.U4)] int int_3, bool bool_0);

	public static int GetVolume()
	{
		waveOutGetVolume(IntPtr.Zero, out var uint_);
		ushort num = (ushort)(uint_ & 0xFFFFu);
		return (int)num / 6553;
	}

	public static void SetVolume(int volume)
	{
		int num = 6553 * volume;
		uint uint_ = ((uint)num & 0xFFFFu) | (uint)(num << 16);
		waveOutSetVolume(IntPtr.Zero, uint_);
	}

	public static void Mute()
	{
		CoInternetSetFeatureEnabled(21, 2, bool_0: true);
		SetVolume(0);
	}
}
